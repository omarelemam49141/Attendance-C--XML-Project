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
    public partial class Backups : Form
    {
        public Backups()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DateOnly dateNow = DateOnly.FromDateTime(DateTime.Today);
            string stringedDate = dateNow.ToShortDateString().Replace("/", "-");
            try
            {
                string dir = @"backups/" + stringedDate;
                // If directory does not exist, create it
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }
                FileManagment.SerializeClassesToXml(Lists.teachersList, dir + @"/teachers.xml");
                FileManagment.SerializeClassesToXml(Lists.studentsList, dir + @"/students.xml");
                FileManagment.SerializeClassesToXml(Lists.classes, dir + @"/classes.xml");
                MessageBox.Show("Backup made successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving the backup");
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            DateOnly dateNow = DateOnly.FromDateTime(dateBackup.Value);
            string stringedDate = dateNow.ToString().Replace("/", "-");
            string dir = @"backups/" + stringedDate;
            try
            {
                FileManagment.LoadClassesFromFile(dir + @"/teachers.xml", ref Lists.teachersList);
                FileManagment.LoadClassesFromFile(dir + @"/students.xml", ref Lists.studentsList);
                FileManagment.LoadClassesFromFile(dir + @"/classes.xml", ref Lists.classes);
                MessageBox.Show(dir + " loaded successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading the backup");
            }
        }
    }
}
