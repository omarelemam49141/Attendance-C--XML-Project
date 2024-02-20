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


namespace Attendance_C__XML_Project
{
    public partial class StudentForm : Form
    {
        List<AttendanceRecord> attendanceRecords;
        public StudentForm()
        {
            InitializeComponent();


            // *** other dummy data ***
            attendanceRecords = new List<AttendanceRecord>
            {
                new AttendanceRecord(1,Lists.studentsList[0],AttendanceStatus.Absence){RecordDate = DateOnly.FromDateTime(DateTime.Now) },
                new AttendanceRecord(2,Lists.studentsList[0],AttendanceStatus.Absence){RecordDate = DateOnly.FromDateTime(DateTime.Now) },
                new AttendanceRecord(3,Lists.studentsList[0],AttendanceStatus.Presence){RecordDate = DateOnly.FromDateTime(DateTime.Now) },
                new AttendanceRecord(4,Lists.studentsList[1],AttendanceStatus.Presence){RecordDate = DateOnly.FromDateTime(DateTime.Now) },
                new AttendanceRecord(5,Lists.studentsList[0],AttendanceStatus.Absence){RecordDate = DateOnly.FromDateTime(DateTime.Now) },
            };


            //**************** GUI Init *************
            panelAttendanceTable.Hide();

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
            foreach (var record in attendanceRecords)
            {
                if (record.student.Username.ToLower() == LoggedInUser.Name.ToLower() && record.attendanceStatus == AttendanceStatus.Presence)
                {
                    counter++;
                }
            }
            return counter.ToString();
        }
        private string LoadStudentAbsenceNumber()
        {
            int counter = 0;
            foreach (var record in attendanceRecords)
            {
                if (record.student.Username.ToLower() == LoggedInUser.Name.ToLower() && record.attendanceStatus == AttendanceStatus.Absence)
                {
                    counter++;
                }
            }
            return counter.ToString();
        }
        private void LoadStudentAttendanceReports()
        {
            dgvStudentReports.Columns.Add("Column1", "Attendance Date");
            dgvStudentReports.Columns.Add("Column2", "Status");

            foreach (var record in attendanceRecords)
            {
                if (record.student.Username.ToLower() == LoggedInUser.Name.ToLower())
                {
                    dgvStudentReports.Rows.Add(record.RecordDate, record.attendanceStatus);
                }
            }

        }

        private string GetStudentName()
        {
            if (LoggedInUser.Name != "")
            {
                return LoggedInUser.Name;
            }
            throw new Exception("Can't Find UserName");
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


        private void ExportToExcel()
        {
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
    }
}