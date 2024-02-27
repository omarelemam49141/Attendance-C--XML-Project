﻿using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;

namespace Attendance_C__XML_Project
{
    public partial class DisplayReportsForm : Form
    {
        List<AttendanceRecord> attendanceRecords;
        GenerateReport myReports;

        List<AttendanceRecord> reports;
        private int pageSize = 3; // Number of rows per page
        private int currentPage = 1; // Current page index
        DateOnly start;
        DateOnly end;
        public DisplayReportsForm()
        {
            InitializeComponent();

            attendanceRecords = new List<AttendanceRecord>
            {
                new AttendanceRecord(1,Lists.studentsList[0],AttendanceStatus.Absence){RecordDate=new DateOnly(2024, 2, 11)},
                new AttendanceRecord(2,Lists.studentsList[0],AttendanceStatus.Absence){ RecordDate = new DateOnly(2024, 2, 12) },
                new AttendanceRecord(3,Lists.studentsList[index: 0],AttendanceStatus.Presence){ RecordDate = new DateOnly(2024, 2, 13) },
                new AttendanceRecord(4,Lists.studentsList[0],AttendanceStatus.Presence){ RecordDate = new DateOnly(2024, 2, 14) },
                new AttendanceRecord(5,Lists.studentsList[0],AttendanceStatus.Absence){ RecordDate = new DateOnly(2024, 2, 15) },
                new AttendanceRecord(5,Lists.studentsList[0],AttendanceStatus.Absence){ RecordDate = new DateOnly(2024, 2, 16) },
                new AttendanceRecord(6,Lists.studentsList[0],AttendanceStatus.Absence){ RecordDate = new DateOnly(2024, 2, 17) },
                new AttendanceRecord(7,Lists.studentsList[0],AttendanceStatus.Absence){ RecordDate = new DateOnly(2024, 2, 18) },
                new AttendanceRecord(8,Lists.studentsList[0],AttendanceStatus.Absence){ RecordDate = new DateOnly(2024, 2, 19) },
                new AttendanceRecord(9,Lists.studentsList[0],AttendanceStatus.Absence){ RecordDate = new DateOnly(2024, 2, 20) },
                new AttendanceRecord(10,Lists.studentsList[0],AttendanceStatus.Absence) { RecordDate = new DateOnly(2024, 2, 21) },
                new AttendanceRecord(11,Lists.studentsList[0],AttendanceStatus.Absence) { RecordDate = new DateOnly(2024, 2, 22) },
                new AttendanceRecord(12,Lists.studentsList[0],AttendanceStatus.Absence){RecordDate=new DateOnly(2024, 2, 24)},
                new AttendanceRecord(12,Lists.studentsList[0],AttendanceStatus.Absence){RecordDate=new DateOnly(2024, 2, 24)},
                new AttendanceRecord(12,Lists.studentsList[0],AttendanceStatus.Absence){RecordDate=new DateOnly(2024, 2, 24)},
                new AttendanceRecord(12,Lists.studentsList[0],AttendanceStatus.Absence){RecordDate=new DateOnly(2024, 2, 24)},
                new AttendanceRecord(12,Lists.studentsList[0],AttendanceStatus.Absence){RecordDate=new DateOnly(2024, 2, 24)},
                new AttendanceRecord(12,Lists.studentsList[0],AttendanceStatus.Absence){RecordDate=new DateOnly(2024, 2, 24)},
            };

            myReports = new GenerateReport();
            myReports.addAttendanceRecords(attendanceRecords);

            //try
            //{
            //    lblUserName.Text = GetUserName();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //    UserLogout();
            //    throw;
            //}


            //// Load Teacher Role
            //try
            //{
            //    lblRoleName.Text = GetUserRole();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //    UserLogout();
            //    throw;
            //}

        }

        private void btnSearchReports_Click(object sender, EventArgs e)
        {

            start = ConvertDatePickerToDateOnly(dateTimePickerStart);
            end = ConvertDatePickerToDateOnly(dateTimePickerEnd);

            DisplayReportsBetweenDates(start, end);

        }

        private void DisplayReportsBetweenDates(DateOnly start, DateOnly end)
        {
            reports = myReports.getReportsBetween(start, end);
            if (reports != null)
            {
                dgvViewReports.Columns.Clear();
                dgvViewReports.Columns.Add("Column1", "Id");
                dgvViewReports.Columns.Add("Column2", "Class Name");
                dgvViewReports.Columns.Add("Column3", "Student Id");
                dgvViewReports.Columns.Add("Column4", "Student Name");
                dgvViewReports.Columns.Add("Column5", "Total Attendances");
                dgvViewReports.Columns.Add("Column6", "Total Absences");
                dgvViewReports.Columns.Add("Column7", "Total Warnings");

                dgvViewReports.Rows.Clear();


                // Calculate indexes of the items to display on the current page
                int startIndex = (currentPage - 1) * pageSize;
                int endIndex = Math.Min(startIndex + pageSize - 1, attendanceRecords.Count - 1);

                // Populate DataGridView with data for the current page

                for (int i = startIndex; i <= endIndex && i < reports.Count; i++)
                {

                    AttendanceRecord? record = reports[i];
                    if (record != null)
                    {
                        string classname= GetClassNameFromID(record.ClassID);
                        string numOfAttendance = LoadStudentAttendanceNumber(reports, record.student.Username);
                        string numOfAbsence = LoadStudentAbsenceNumber(reports,record.student.Username);
                        int numOfWarnings = int.Parse(numOfAbsence) / 5;

                        dgvViewReports.Rows.Add(record.ID, classname, record.student?.ID ,record.student?.Username, numOfAttendance,numOfAbsence, numOfWarnings);
                    }

                }
                // Update pagination information
                toolStripPageLabel.Text = $"Page {currentPage}";

            }
        }

        private string LoadStudentAttendanceNumber(List<AttendanceRecord> _attendanceRecords,string studentName)
        {
            int counter = 0;
            foreach (var record in _attendanceRecords)
            {
                if (record.student.Username.ToLower() == studentName.ToLower() && record.attendanceStatus == AttendanceStatus.Presence)
                {
                    counter++;
                }
            }
            return counter.ToString();
        }
        private string LoadStudentAbsenceNumber(List<AttendanceRecord> _attendanceRecords, string studentName)
        {
            int counter = 0;
            foreach (var record in _attendanceRecords)
            {
                if (record.student.Username.ToLower() == studentName.ToLower() && record.attendanceStatus == AttendanceStatus.Absence)
                {
                    counter++;
                }
            }
            return counter.ToString();
        }
        private string GetClassNameFromID(int id)
        {
            string? className = Lists.classes.Find(c => c.ID == id)?.Name;

            return className;
        }
        private DateOnly ConvertDatePickerToDateOnly(DateTimePicker dateTimePicker)
        {
            return new DateOnly(dateTimePicker.Value.Year, dateTimePicker.Value.Month, dateTimePicker.Value.Day);

        }

        private string GetUserName()
        {
            if (LoggedInUser.Name != "")
            {
                return LoggedInUser.Name;
            }
            throw new Exception("Can't Find UserName");
        }
        private string GetUserRole()
        {

            var role = LoggedInUser.userRole.ToString();

            if (role != null)
            {
                return role;
            }
            throw new Exception("Can't Find Teacher Role");
        }
        private void UserLogout()
        {
            LoggedInUser.Name = string.Empty;
            LoggedInUser.userRole = (Role)(-1);
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }


        private void btnExportPDF_Click(object sender, EventArgs e)
        {
            if (dgvViewReports.Rows.Count > 0)
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
                            PdfPTable pTable = new PdfPTable(dgvViewReports.Columns.Count);
                            pTable.DefaultCell.Padding = 2;
                            pTable.WidthPercentage = 100;
                            pTable.HorizontalAlignment = Element.ALIGN_LEFT;
                            foreach (DataGridViewColumn col in dgvViewReports.Columns)
                            {
                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));
                                pTable.AddCell(pCell);
                            }
                            foreach (DataGridViewRow viewRow in dgvViewReports.Rows)
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
        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            ExportToExcel(dgvViewReports);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
            this.Close();
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
            UserLogout();
        }

        private void panelShowReports_Paint(object sender, PaintEventArgs e)
        {

        }

        private void prevPage_Click(object sender, EventArgs e)
        {


            if (currentPage > 1)
            {
                currentPage--;
                toolStripPageLabel.Text = currentPage.ToString();
                DisplayReportsBetweenDates(start, end);
            }
        }

        private void nextPage_Click(object sender, EventArgs e)
        {

            if (currentPage < TotalPages)
            {
                currentPage++;
                toolStripPageLabel.Text = currentPage.ToString();
                DisplayReportsBetweenDates(start, end);
            }
        }

        private void startdate_ValueChange(object sender, EventArgs e)
        {
            if (dateTimePickerEnd.Value < dateTimePickerStart.Value)
            {
                dateTimePickerEnd.Value = dateTimePickerStart.Value;
            }


        }

        private void enddate_ValueChange(object sender, EventArgs e)
        {
            if (dateTimePickerEnd.Value < dateTimePickerStart.Value)
            {
                dateTimePickerStart.Value = dateTimePickerEnd.Value;
            }
        }

        private int TotalPages
        {
            get { return (int)Math.Ceiling((double)reports.Count / pageSize); }
        }
    }
}
