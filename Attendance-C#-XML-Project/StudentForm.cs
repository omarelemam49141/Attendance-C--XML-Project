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
    public partial class StudentForm : Form
    {
        
        public StudentForm()
        {
            InitializeComponent();

        
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

            // Load Number Of Absence

        }

        private void btnShowReport_Click(object sender, EventArgs e)
        {

            panelAttendanceTable.Show();

            // Load The Current Student's Attendance Report

        }

        private string GetStudentName()
        {
            if (LoggedInUser.Name != "")
            {
                return  LoggedInUser.Name;
            }
            throw new Exception("Can't Find UserName");
        }
        private string GetStudentClassName()
        {

            var studentName = LoggedInUser.Name;
            var classID = Lists.studentsList.Find(s =>s.Username.ToLower() == studentName.ToLower())?.ClassID;

            if(classID != null)
            {
                var className = Lists.classes.Find(c =>c.ID == classID)?.Name;
                if(className != null)
                {
                    return className;
                }
            }
            throw new Exception("Can't Find Student Class");
        }
        private string GetNumOfStudentAttendance()
        {
            throw new NotImplementedException();
        }
        private string GetNumOfStudentAbsence()
        {
            throw new NotImplementedException();
        }
        private List<AttendanceRecord> GetStudentAttendanceReport()
        {
            throw new NotImplementedException();
        }
        private void StudentLogout()
        {
            throw new NotImplementedException();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
            this.Close();
        }
    }
}