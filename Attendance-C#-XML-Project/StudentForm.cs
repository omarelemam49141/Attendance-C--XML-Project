using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;
using System.Drawing.Printing;


namespace Attendance_C__XML_Project
{
    public partial class StudentForm : Form
    {
        //List<AttendanceRecord> attendanceRecords;
        GenerateReport studentReport;
        int studentId;
        private int pageSize = 5; // Number of rows per page
        private int currentPage = 1; // Current page index
        public StudentForm()
        {
            InitializeComponent();


            // *** other dummy data ***
            studentReport = new GenerateReport();
            studentReport.addAttendanceRecords(Lists.attendanceRecords);


            //**************** GUI Init *************
            panelAttendanceTable.Hide();
            toolStripPageLabel.Text = currentPage.ToString();
            //**************** End Of GUI Init *************

            // Load Student Name
            try
            {
                lblUserName.Text = GetStudentName();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                StudentLogout();
                throw;
            }


            // Load Student Class
            try
            {
                lblClassName.Text = GetStudentClassName();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                StudentLogout();
                throw;
            }

            //Load Student Id
            studentId = GetStudentIdByName(LoggedInUser.Name);

            // Load Number Of Attendance
            lblAttendedNum.Text = LoadStudentAttendanceNumber();

            // Load Number Of Absence
            lblAbsentNum.Text = LoadStudentAbsenceNumber();


        }

        private void btnShowReport_Click(object sender, EventArgs e)
        {

            panelAttendanceTable.Show();

            // Load The Current Student's Attendance Report
            LoadStudentAttendanceReports();

        }
        private string LoadStudentAttendanceNumber()
        {
            int counter = 0;
            if (studentReport.attendanceRecords != null)
            {
                foreach (var record in studentReport.attendanceRecords)
                {
                    if (record.student.Username.ToLower() == LoggedInUser.Name.ToLower() && record.attendanceStatus == AttendanceStatus.Presence)
                    {
                        counter++;
                    }
                }

            }
            return counter.ToString();

        }
        private string LoadStudentAbsenceNumber()
        {
            int counter = 0;
            if (studentReport.attendanceRecords != null)
            {
                foreach (var record in studentReport.attendanceRecords)
                {
                    if (record.student.Username.ToLower() == LoggedInUser.Name.ToLower() && record.attendanceStatus == AttendanceStatus.Absence)
                    {
                        counter++;
                    }
                }
            }
            return counter.ToString();
        }
        private void LoadStudentAttendanceReports()
        {
            dgvStudentReports.Columns.Clear();
            dgvStudentReports.Columns.Add("Column1", "Id");
            dgvStudentReports.Columns.Add("Column1", "Attendance Date");
            dgvStudentReports.Columns.Add("Column3", "Status");
            var _attendanceRecords = studentReport.getStudentReport(studentId);


            dgvStudentReports.Rows.Clear();

            // Calculate indexes of the items to display on the current page
            int startIndex = (currentPage - 1) * pageSize;
            int endIndex = Math.Min(startIndex + pageSize - 1, studentReport.attendanceRecords.Count - 1);

            // Populate DataGridView with data for the current page

            for (int i = startIndex; i <= endIndex && i < _attendanceRecords.Count; i++)
            {

                AttendanceRecord? record = _attendanceRecords[i];
                if (record != null)
                {
                    if (record.student.Username.ToLower() == LoggedInUser.Name.ToLower())
                    {
                        dgvStudentReports.Rows.Add(record.ID, record.RecordDate + ", " + record.RecordDate.DayOfWeek, record.attendanceStatus);

                    }
                }

            }
            // Update pagination information
            toolStripPageLabel.Text = $"Page {currentPage}";
            //FileManagment.SerializeClassesToXml<AttendanceRecord>(attendanceRecords, "data/attendance.xml");
        }
        // next button clicked
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (currentPage < TotalPages)
            {
                currentPage++;
                toolStripPageLabel.Text = currentPage.ToString();
                LoadStudentAttendanceReports();
            }
        }


        // previous button clicked
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                toolStripPageLabel.Text = currentPage.ToString();
                LoadStudentAttendanceReports();
            }
        }
        private void LoadData(DataGridView dataGridView)
        {
            // Clear existing rows
            dataGridView.Rows.Clear();

            // Calculate indexes of the items to display on the current page
            int startIndex = (currentPage - 1) * pageSize;
            int endIndex = Math.Min(startIndex + pageSize - 1, studentReport.attendanceRecords.Count - 1);

            // Populate DataGridView with data for the current page
            for (int i = startIndex; i <= endIndex; i++)
            {
                dataGridView.Rows.Add(studentReport.attendanceRecords[i]);
            }

            // Update pagination information
            toolStripPageLabel.Text = $"Page {currentPage}";
        }


        private int TotalPages
        {
            get { return (int)Math.Ceiling((double)studentReport.attendanceRecords.Count / pageSize); }
        }



        private string GetStudentName()
        {
            if (LoggedInUser.Name != "")
            {
                return LoggedInUser.Name;
            }
            throw new Exception("Can't Find UserName");
        }

        private int GetStudentIdByName(string userName)
        {
            int studentId = Lists.studentsList.Find(s => s.Username.ToLower() == userName.ToLower()).ID;
            return studentId;
        }
        private string GetStudentClassName()
        {

            var studentName = LoggedInUser.Name;
            var classID = Lists.studentsList.Find(s => s.Username.ToLower() == studentName.ToLower())?.ClassID;

            if (classID != null)
            {
                var className = Lists.classes.Find(c => c.ID == classID)?.Name;
                if (className != null)
                {
                    return className;
                }
            }
            throw new Exception("Can't Find Student Class");
        }

        private void StudentLogout()
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

        private void ExportPDF()
        {
            if (dgvStudentReports.Rows.Count > 0)
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
                            PdfPTable pTable = new PdfPTable(dgvStudentReports.Columns.Count);
                            pTable.DefaultCell.Padding = 2;
                            pTable.WidthPercentage = 100;
                            pTable.HorizontalAlignment = Element.ALIGN_LEFT;
                            foreach (DataGridViewColumn col in dgvStudentReports.Columns)
                            {
                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));
                                pTable.AddCell(pCell);
                            }
                            foreach (DataGridViewRow viewRow in dgvStudentReports.Rows)
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
        private void btnPrintReport_Click(object sender, EventArgs e)
        {
            ExportPDF();
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            ExportToExcel(dgvStudentReports);
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

        private void btnLogout_Click(object sender, EventArgs e)
        {
            StudentLogout();
        }

        private void panelShow_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}