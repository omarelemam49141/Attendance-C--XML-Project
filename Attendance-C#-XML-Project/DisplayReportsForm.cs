using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                dgvViewReports.Columns.Add("Column1", "Attendance Date");
                dgvViewReports.Columns.Add("Column3", "Status");

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

                        dgvViewReports.Rows.Add(record.ID, record.RecordDate + ", " + record.RecordDate.DayOfWeek, record.ClassID);
                    }

                }
                // Update pagination information
                toolStripPageLabel.Text = $"Page {currentPage}";

            }
        }
        private DateOnly ConvertDatePickerToDateOnly(DateTimePicker dateTimePicker)
        {
            return new DateOnly(dateTimePickerStart.Value.Year, dateTimePickerStart.Value.Month, dateTimePickerStart.Value.Day);

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

        }
        private void btnExportExcel_Click(object sender, EventArgs e)
        {

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
            this.Close();
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
                DisplayReportsBetweenDates(start,end);
            }
        }

        private void nextPage_Click(object sender, EventArgs e)
        {

            if (currentPage < TotalPages)
            {
                currentPage++;
                toolStripPageLabel.Text = currentPage.ToString();
                DisplayReportsBetweenDates(start,end);
            }
        }
        private int TotalPages
        {
            get { return (int)Math.Ceiling((double)reports.Count / pageSize); }
        }
    }
}
