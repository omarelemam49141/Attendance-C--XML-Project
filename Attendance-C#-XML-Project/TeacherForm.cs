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

namespace Attendance_C__XML_Project
{
    public partial class TeacherForm : Form
    {
        List<Student> studentsList;
        List<Teacher> teachersList;
        List<Class> classes;

        public TeacherForm()
        {
            InitializeComponent();

            // *** Static Data ***
            classes = new List<Class>();
            classes.Add(new Class("B1"));
            classes.Add(new Class("B2"));

            studentsList = new List<Student>();
            studentsList.Add(new Student("Ahmed Ali", "Oeams7476386#", "01074845994", "Teacher@yahoo.com", "Egypt Cairo", 3));
            studentsList.Add(new Student("Osame Ali", "Oeams7476386#", "01074845994", "Teacher@yahoo.com", "Egypt Cairo", 2));


            teachersList = new List<Teacher>();
            teachersList.Add(new Teacher("Ali", "Oeams7476386#", "01074845994", "Teacher@yahoo.com", "Egypt Cairo"));
            teachersList.Add(new Teacher("Omar", "Oeams7476386#", "01074845994", "Teacher@yahoo.com", "Egypt Cairo"));
            teachersList.Add(new Teacher("Ahmed", "Oeams7476386#", "01074845994", "Teacher@yahoo.com", "Egypt Cairo"));



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


        }

        private void btnShowReport_Click(object sender, EventArgs e)
        {
            panelShowStudents.Show();
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

            var role= LoggedInUser.userRole.ToString();

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
            List<string> classNames = classes.Select(c => c.Name).ToList();
            return classNames;
        }
        private void TeacherLogout()
        {
            throw new NotImplementedException();
        }
    }
}
