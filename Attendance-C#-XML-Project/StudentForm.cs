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

            // Load Student Class

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
            throw new NotImplementedException();
        }
        private string GetStudentClassName()
        {
            throw new NotImplementedException();
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


    }
}