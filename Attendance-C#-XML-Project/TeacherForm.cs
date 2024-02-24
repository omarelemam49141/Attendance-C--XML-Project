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
        List<AttendanceRecord> attendanceRecords;
        List<AttendanceRecord>? filteredAttendanceRecords;
        GenerateReport teacherReport;
        int studentId;
        private int pageSize = 3; // Number of rows per page
        private int currentPage = 1; // Current page index
        int classId = 1;
        DateOnly dateOnlyValue;
        public TeacherForm()
        {
            InitializeComponent();
            // *** other dummy data ***
            attendanceRecords = new List<AttendanceRecord>
            {
                new AttendanceRecord(1,Lists.studentsList[0],AttendanceStatus.Absence){RecordDate=new DateOnly(2024, 2, 11)},
                new AttendanceRecord(2,Lists.studentsList[0],AttendanceStatus.Absence){ RecordDate = new DateOnly(2024, 2, 12) },
                new AttendanceRecord(3,Lists.studentsList[0],AttendanceStatus.Presence){ RecordDate = new DateOnly(2024, 2, 13) },
                new AttendanceRecord(4,Lists.studentsList[1],AttendanceStatus.Presence){ RecordDate = new DateOnly(2024, 2, 14) },
                new AttendanceRecord(5,Lists.studentsList[0],AttendanceStatus.Absence){ RecordDate = new DateOnly(2024, 2, 15) },
                new AttendanceRecord(5,Lists.studentsList[0],AttendanceStatus.Absence){ RecordDate = new DateOnly(2024, 2, 16) },
                new AttendanceRecord(6,Lists.studentsList[0],AttendanceStatus.Absence){ RecordDate = new DateOnly(2024, 2, 17) },
                new AttendanceRecord(7,Lists.studentsList[0],AttendanceStatus.Absence){ RecordDate = new DateOnly(2024, 2, 18) },
                new AttendanceRecord(8,Lists.studentsList[0],AttendanceStatus.Absence){ RecordDate = new DateOnly(2024, 2, 19) },
                new AttendanceRecord(9,Lists.studentsList[0],AttendanceStatus.Absence){ RecordDate = new DateOnly(2024, 2, 20) },
                new AttendanceRecord(10,Lists.studentsList[0],AttendanceStatus.Absence) { RecordDate = new DateOnly(2024, 2, 21) },
                new AttendanceRecord(11,Lists.studentsList[0],AttendanceStatus.Absence) { RecordDate = new DateOnly(2024, 2, 22) },
                new AttendanceRecord(12,Lists.studentsList[0],AttendanceStatus.Absence){RecordDate=new DateOnly(2024, 2, 24)},
                new AttendanceRecord(12,Lists.studentsList[1],AttendanceStatus.Absence){RecordDate=new DateOnly(2024, 2, 24)},
                new AttendanceRecord(12,Lists.studentsList[2],AttendanceStatus.Absence){RecordDate=new DateOnly(2024, 2, 24)},
                new AttendanceRecord(12,Lists.studentsList[3],AttendanceStatus.Absence){RecordDate=new DateOnly(2024, 2, 24)},
                new AttendanceRecord(12,Lists.studentsList[4],AttendanceStatus.Absence){RecordDate=new DateOnly(2024, 2, 24)},
                new AttendanceRecord(12,Lists.studentsList[5],AttendanceStatus.Absence){RecordDate=new DateOnly(2024, 2, 24)},
            };

            teacherReport = new GenerateReport();
            teacherReport.addAttendanceRecords(attendanceRecords);

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

        }

        private void btnShowReport_Click(object sender, EventArgs e)
        {
            panelShowStudents.Show();
            // load the students reports

            dateOnlyValue = new DateOnly(dateTimePicker.Value.Year, dateTimePicker.Value.Month, dateTimePicker.Value.Day);
            classId = getClassIdFromComboBox();
            LoadStudentReports(dateOnlyValue, classId, null);


        }
        private int getClassIdFromComboBox()
        {
            var classId = Lists.classes.Find(c => c.Name.ToLower() == comboClasses.Text.ToLower()).ID;
            return classId;
        }
        private void LoadStudentReports(DateOnly? mydate, int classId, bool? attendAll)
        {
            // Clear existing columns and rows
            dgvViewStudents.Columns.Clear();
            dgvViewStudents.Rows.Clear();

            // Add columns
            dgvViewStudents.Columns.Add("Column1", "StudentId");
            dgvViewStudents.Columns.Add("Column2", "Student Name");
            dgvViewStudents.Columns[0].ReadOnly = true;
            dgvViewStudents.Columns[1].ReadOnly = true;

            // Add checkbox column
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.HeaderText = "Attend";
            checkBoxColumn.Name = "checkBoxColumn";
            dgvViewStudents.Columns.Add(checkBoxColumn);


            // Set the readonly property based on the date
            checkBoxColumn.ReadOnly = !(mydate.HasValue && mydate.Value.Equals(DateOnly.FromDateTime(DateTime.Now)));

            if (classId != null)
            {
                // Assuming attendanceRecords is a list of records
                filteredAttendanceRecords = attendanceRecords.Where(record => (record.ClassID == classId && record.RecordDate == mydate)).ToList();

                if (filteredAttendanceRecords != null)
                {
                    int startIndex = (currentPage - 1) * pageSize;
                    int endIndex = Math.Min(startIndex + pageSize - 1, attendanceRecords.Count - 1);

                    // Populate DataGridView with data for the current page

                    for (int i = startIndex; i <= endIndex && i < filteredAttendanceRecords.Count; i++)
                    {

                        AttendanceRecord? record = filteredAttendanceRecords[i];
                        if (record != null)
                        {
                            if (attendAll == true && mydate.Value.Equals(DateOnly.FromDateTime(DateTime.Now)))
                            {
                                dgvViewStudents.Rows.Add(record.ID, record.student?.Username, attendAll);
                            }
                            else if (attendAll == false && mydate.Value.Equals(DateOnly.FromDateTime(DateTime.Now)))
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
            //var teacher = teachersList.Find(t =>t.Username.ToLower()== MyLoggedInUser.Name.ToLower());

            // For Now i will display all classes
            List<string> classNames = Lists.classes.Select(c => c.Name).ToList();
            return classNames;
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

            DateOnly dateOnlyValue = new DateOnly(dateTimePicker.Value.Year, dateTimePicker.Value.Month, dateTimePicker.Value.Day);
            int classId = getClassIdFromComboBox();
            if (checkBox.Checked)
            {

                LoadStudentReports(dateOnlyValue, classId, true);
            }
            else
            {
                LoadStudentReports(dateOnlyValue, classId, attendAll: false);
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
                LoadStudentReports(dateOnlyValue, classId,null);
            }
        }

        private void nextPage_Click(object sender, EventArgs e)
        {
            if (currentPage < TotalPages)
            {
                currentPage++;
                toolStripPageLabel.Text = currentPage.ToString();
                LoadStudentReports(dateOnlyValue,classId,null);
            }
        }


        private void Date_ValueChanged(object sender, EventArgs e)
        {

            if (dateTimePicker.Value.Day == DateTime.Now.Day && dateTimePicker.Value.Month == DateTime.Now.Month && dateTimePicker.Value.Year == DateTime.Now.Year)
            {
                btnSave.Enabled = true;
                btnSave.BackColor = Color.Teal;
            }
            else
            {
                btnSave.Enabled = false;
                btnSave.BackColor = Color.DarkGray;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Save Data To Xml
        }
    }
}
