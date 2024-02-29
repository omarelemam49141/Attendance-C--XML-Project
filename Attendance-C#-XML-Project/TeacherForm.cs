using iTextSharp.text.pdf;
using iTextSharp.text;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Attendance_C__XML_Project
{
    public partial class TeacherForm : Form
    {
       
        List<AttendanceRecord>? filteredAttendanceRecords;
        GenerateReport teacherReport;
        int studentId;
        private int pageSize = 3; // Number of rows per page
        private int currentPage = 1; // Current page index
        int classId = 1;
        DateTime dateOnlyValue;
        //Dictionary<int, bool> checkboxStates = new Dictionary<int, bool>();
        public TeacherForm()
        {
            InitializeComponent();
            // *** other dummy data ***
          
            teacherReport = new GenerateReport();
            teacherReport.addAttendanceRecords(Lists.attendanceRecords);

            // *** end of  dummy data ***

            //**************** GUI Init *************
            panelShowStudents.Hide();
            //**************** End Of GUI Init *************
            dateTimePicker.Value = DateTime.Now;



            try
            {
                lblUserName.Text = GetTeacherName();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                TeacherLogout();
                throw;
            }


            // Load Teacher Role
            try
            {
                lblRoleName.Text = GetTeacherRole();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                TeacherLogout();
                throw;
            }

            // Get Class List into ComboBox
            List<string> myClasses = GetTeacherClasses();
            foreach (var cls in myClasses)
            {
                comboClasses.Items.Add(cls);
            }
            comboClasses.SelectedIndex = 0;


            SettingsManager.SettingsIntialization(this);
        }

        private void btnShowReport_Click(object sender, EventArgs e)
        {
            panelShowStudents.Show();
            // load the students reports

            dateOnlyValue = new DateTime(dateTimePicker.Value.Year, dateTimePicker.Value.Month, dateTimePicker.Value.Day);
            classId = getClassIdFromComboBox();
            LoadStudentReports(dateOnlyValue, classId, null);


        }
        private int getClassIdFromComboBox()
        {
            var classId = Lists.classes.Find(c => c.Name.ToLower() == comboClasses.Text.ToLower()).ID;
            return classId;
        }
        private void LoadStudentReports(DateTime? mydate, int classId, bool? attendAll)
        {
            // Clear existing columns and rows
            dgvViewStudents.Columns.Clear();
            dgvViewStudents.Rows.Clear();

            // Add columns
            dgvViewStudents.Columns.Add("Column1", "RecordId");
            dgvViewStudents.Columns.Add("Column2", "Student Name");
            dgvViewStudents.Columns[0].ReadOnly = true;
            dgvViewStudents.Columns[1].ReadOnly = true;

            // Add checkbox column
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.HeaderText = "Attend";
            checkBoxColumn.Name = "checkBoxColumn";
            dgvViewStudents.Columns.Add(checkBoxColumn);


            // Set the readonly property based on the date
            checkBoxColumn.ReadOnly = !(mydate.HasValue && mydate.Value.Date == DateTime.Now.Date);

            if (classId != null)
            {
                // Assuming attendanceRecords is a list of records
                filteredAttendanceRecords = teacherReport.attendanceRecords.Where(record => (record.ClassID == classId && record.RecordDate.Date == mydate)).ToList();

                if (filteredAttendanceRecords != null)
                {
                    int startIndex = (currentPage - 1) * pageSize;
                    int endIndex = Math.Min(startIndex + pageSize - 1, teacherReport.attendanceRecords.Count - 1);

                    // Populate DataGridView with data for the current page

                    for (int i = startIndex; i <= endIndex && i < filteredAttendanceRecords.Count; i++)
                    {

                        AttendanceRecord? record = filteredAttendanceRecords[i];
                        if (record != null)
                        {
                            if (attendAll == true && mydate.Value.Date == DateTime.Now.Date)
                            {   
                                dgvViewStudents.Rows.Add(record.ID, record.student?.Username, attendAll);
                            }
                            else if (attendAll == false && mydate.Value.Date == DateTime.Now.Date)
                            {
                                dgvViewStudents.Rows.Add(record.ID, record.student?.Username, attendAll);
                            }
                            else
                            {
                                bool isAttended = (record.attendanceStatus == AttendanceStatus.Presence);
                                dgvViewStudents.Rows.Add(record.ID, record.student?.Username, isAttended);
                            }
                        }

                    }
                    // Update pagination information
                    toolStripPageLabel.Text = $"Page {currentPage}";
                }


            }
            else
            {
                throw new Exception("No Class with that name");
            }
        }
        private void dgvViewStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            // Check if the clicked cell is the checkbox cell
            if (e.ColumnIndex == dgvViewStudents.Columns["checkBoxColumn"].Index && e.RowIndex >= 0 && dateOnlyValue.Date == DateTime.Now.Date)
            {
                // Toggle the checkbox state and update the dictionary
                int recordId = (int)dgvViewStudents.Rows[e.RowIndex].Cells["Column1"].Value;

                teacherReport.ChangeStudentAttendanceStatus(recordId, DateTime.Now);
            }
        }

        private string GetClassNameFromID(int id)
        {
            string? className = Lists.classes.Find(c => c.ID == id)?.Name;

            return className;
        }
        private int? GetClassIdFromName(string className)
        {
            int? classId = Lists.classes.Find(c => c.Name.ToLower() == className.ToLower())?.ID;
            return classId;
        }

        private string GetTeacherName()
        {
            if (LoggedInUser.Name != "")
            {
                return LoggedInUser.Name;
            }
            throw new Exception("Can't Find UserName");
        }
        private string GetTeacherRole()
        {

            var role = LoggedInUser.userRole.ToString();

            if (role != null)
            {
                return role;
            }
            throw new Exception("Can't Find Teacher Role");
        }
        private List<string> GetTeacherClasses()
        {
            var teacher = Lists.teachersList.Find(t =>t.Username.ToLower()== LoggedInUser.Name.ToLower());

            var classes = teacher.Classes.Select(c=>c.Name).ToList();

            return classes;
        }
        private void TeacherLogout()
        {
            LoggedInUser.Name = string.Empty;
            LoggedInUser.userRole = (Role)(-1);
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
            this.Close();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            PreferencesForm preferencesForm = new PreferencesForm();
            preferencesForm.Show();
            this.Hide();
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            ExportToExcel(dgvViewStudents);
        }
        private void ExportToExcel(DataGridView dataGridView)
        {
            using (ExcelPackage excelPackage = new ExcelPackage())
            {
                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Sheet1");

                // Export DataGridView headers to Excel
                for (int i = 0; i < dataGridView.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1].Value = dataGridView.Columns[i].HeaderText;
                }

                // Export DataGridView rows to Excel
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1].Value = dataGridView.Rows[i].Cells[j].Value?.ToString();
                    }
                }

                // Save the Excel file
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel Workbook (*.xlsx)|*.xlsx";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileInfo fileInfo = new FileInfo(saveFileDialog.FileName);
                    excelPackage.SaveAs(fileInfo);
                    MessageBox.Show("Exported to Excel successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnExportPDF(object sender, EventArgs e)
        {
            ExportPDF(dgvViewStudents);
        }
        private void ExportPDF(DataGridView dataGridView)
        {
            if (dataGridView.Rows.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (*.pdf)|*.pdf";
                save.FileName = "Result.pdf";
                bool ErrorMessage = false;
                if (save.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(save.FileName))
                    {
                        try
                        {
                            File.Delete(save.FileName);
                        }
                        catch (Exception ex)
                        {
                            ErrorMessage = true;
                            MessageBox.Show("Unable to wride data in disk" + ex.Message);
                        }
                    }
                    if (!ErrorMessage)
                    {
                        try
                        {
                            PdfPTable pTable = new PdfPTable(dataGridView.Columns.Count);
                            pTable.DefaultCell.Padding = 2;
                            pTable.WidthPercentage = 100;
                            pTable.HorizontalAlignment = Element.ALIGN_LEFT;
                            foreach (DataGridViewColumn col in dataGridView.Columns)
                            {
                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));
                                pTable.AddCell(pCell);
                            }
                            foreach (DataGridViewRow viewRow in dataGridView.Rows)
                            {
                                foreach (DataGridViewCell dcell in viewRow.Cells)
                                {
                                    if (dcell.Value != null) // Check if the cell value is not null
                                    {
                                        pTable.AddCell(dcell.Value.ToString());
                                    }
                                    else
                                    {
                                        pTable.AddCell(""); // Add an empty string or placeholder text for null values
                                    }
                                }
                            }
                            using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))
                            {
                                iTextSharp.text.Document document = new iTextSharp.text.Document(PageSize.A4, 8f, 16f, 16f, 8f);
                                PdfWriter.GetInstance(document, fileStream);
                                document.Open();
                                document.Add(pTable);
                                document.Close();
                                fileStream.Close();
                            }
                            MessageBox.Show("Data Export Successfully", "info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error while exporting Data" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record Found", "Info");
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            TeacherLogout();
        }

        private void AttendAll_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            panelShowStudents.Show();
            // load the students reports
            DateTime dateOnlyValue = new DateTime(dateTimePicker.Value.Year, dateTimePicker.Value.Month, dateTimePicker.Value.Day);
            int classId = getClassIdFromComboBox();
            if (dateOnlyValue.Date == DateTime.Now.Date)
            {
                if (checkBox.Checked)
                {

                    LoadStudentReports(dateOnlyValue, classId, true);
                }
                else
                {
                    LoadStudentReports(dateOnlyValue, classId, attendAll: false);
                }
            }

        }


        private int TotalPages
        {
            get { return (int)Math.Ceiling((double)filteredAttendanceRecords.Count / pageSize); }
        }

        private void prevPage_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                toolStripPageLabel.Text = currentPage.ToString();
                LoadStudentReports(dateOnlyValue, classId, null);
            }
        }

        private void nextPage_Click(object sender, EventArgs e)
        {
            if (currentPage < TotalPages)
            {
                currentPage++;
                toolStripPageLabel.Text = currentPage.ToString();
                LoadStudentReports(dateOnlyValue, classId, null);
            }
        }


        private void Date_ValueChanged(object sender, EventArgs e)
        {

            if (dateTimePicker.Value.Day == DateTime.Now.Day && dateTimePicker.Value.Month == DateTime.Now.Month && dateTimePicker.Value.Year == DateTime.Now.Year)
            {
                btnSave.Enabled = true;
                btnSave.BackColor = Color.Teal;
                btnNewReport.Show();
            }
            else
            {
                btnSave.Enabled = false;
                btnSave.BackColor = Color.DarkGray;
                btnNewReport.Hide();
            }
        }



        private void panelShow_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Save Data To Xml
            
            Lists.attendanceRecords = teacherReport.attendanceRecords;
            bool isValidFile =  FileManagment.ValidateAgainstXsd(Lists.attendanceRecords, "attendances.xsd");
            if(isValidFile)
            {
                FileManagment.SerializeClassesToXml(Lists.attendanceRecords, "attendances.xml");
                MessageBox.Show("Saved Successfully");
            }
            else
            {
                MessageBox.Show("something went wrong!");
            }

            //FileManagment.ValidateAgainstXsd(attendanceRecords);

        }
        private void btnNewReport_Click(object sender, EventArgs e)
        {
            //dgvViewStudents.Show()
            var TodayReports = teacherReport.getReportsAt(DateTime.Now);
            var currentClassId = getClassIdFromComboBox();
            var students = Lists.studentsList.Where(s => s.ClassID == currentClassId).ToList();
            int newId = 0;
            if (TodayReports.Count == 0)
            {
                foreach (var student in students)
                {
                    newId = GetLastAttendanceId(Lists.attendanceRecords);
                    AttendanceRecord attendanceRecord = new AttendanceRecord(_id: newId, student, AttendanceStatus.Absence);
                    attendanceRecord.RecordDate = DateTime.Now;

                    teacherReport.attendanceRecords.Add(attendanceRecord);
                    Lists.attendanceRecords = teacherReport.attendanceRecords;
                }
            }
            LoadStudentReports(dateOnlyValue, classId, false);
        }

        private int GetLastAttendanceId(List<AttendanceRecord> attendanceRecords)
        {
            if (attendanceRecords == null || attendanceRecords.Count == 0)
            {
                throw new ArgumentException("Attendance records list is null or empty.");
            }

            // Assuming the IDs are sequential integers and the list is ordered by ID
            return attendanceRecords.Last().ID+1;
        }
    }
}
