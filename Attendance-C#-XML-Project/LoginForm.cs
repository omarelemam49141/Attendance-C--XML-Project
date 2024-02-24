using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;



namespace Attendance_C__XML_Project
{
    public partial class LoginForm : Form
    {

        // Import the necessary Windows API methods
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
            this.Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            //Dummy data for testing
            Lists.teachersList = new List<Teacher>();
            //FileManagment.LoadClassesFromFile("teachers.xml", ref Lists.teachersList);

            //Lists.studentsList = new List<Student>();
            //FileManagment.LoadClassesFromFile("students.xml", ref Lists.studentsList);

            //Lists.classes = new List<Class>();
            //FileManagment.LoadClassesFromFile("classes.xml", ref Lists.classes);

            Lists.teachersList = [new Teacher("Ali", "Oeams7476386#", "01074845994", "Teacher@yahoo.com", "Egypt Cairo"),
            new Teacher("Omar", "Oeams7476386#", "01074845994", "Teacher@yahoo.com", "Egypt Cairo"),
            new Teacher("Ahmed", "Oeams7476386#", "01074845994", "Teacher@yahoo.com", "Egypt Cairo")];
            Lists.studentsList = [new Student("Ahmed Ali", "Oeams7476386#", "01074845994", "Teacher@yahoo.com", "Egypt Cairo", 1),
                                  new Student("Osame Ali", "Oeams7476386#", "01074845994", "Teacher@yahoo.com", "Egypt Cairo", 2),
                                  new Student("Hamada Ali", "Oeams7476386#", "01074845994", "Teacher@yahoo.com", "Egypt Cairo", 2),
                                  new Student("Mohamed Ali", "Oeams7476386#", "01074845994", "Teacher@yahoo.com", "Egypt Cairo", 2),
                                  new Student("Omar Sharkawi", "Oeams7476386#", "01074845994", "Teacher@yahoo.com", "Egypt Cairo", 2),
                                  new Student("Hamdy", "Oeams7476386#", "01074845994", "Teacher@yahoo.com", "Egypt Cairo", 2),
                                  new Student("Hmaed", "Oeams7476386#", "01074845994", "Teacher@yahoo.com", "Egypt Cairo", 2),
            ];

            Lists.admins = [new User("admin", "Oeams7476386#", "01074845994", "Teacher@yahoo.com", "Egypt Cairo")];
            Lists.classes = new List<Class>(){
                new Class() { ID=1,Name="A1"},
                new Class() { ID=2,Name="A2"},
            };

            GraphicsPath path = new GraphicsPath();
            Rectangle bounds = new Rectangle(0, 0, this.Width, this.Height);
            int radius = 10; // Change this value to adjust the roundness of the corners

            int diameter = radius * 2;
            Size size = new Size(diameter, diameter);
            Rectangle arc = new Rectangle(bounds.Location, size);

            // Add arcs to the path to create rounded corners
            path.AddArc(arc, 180, 90);
            arc.X = bounds.Right - diameter;
            path.AddArc(arc, 270, 90);
            arc.Y = bounds.Bottom - diameter;
            path.AddArc(arc, 0, 90);
            arc.X = bounds.Left;
            path.AddArc(arc, 90, 90);

            // Close the path
            path.CloseFigure();

            // Draw the form using the path
            this.Region = new Region(path);
        }

        //drag the form
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            // Check if the left mouse button is pressed
            if (e.Button == MouseButtons.Left)
            {
                // Release capture to enable normal mouse operation like clicking on buttons
                ReleaseCapture();

                // Send the message to move the form
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        //login process
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (IsAdmin())
            {
                LoggedInUser.Name = txtUsername.Text.ToLower();
                LoggedInUser.userRole = Role.Admin;
                AdminForm adminForm = new AdminForm(this);
                adminForm.Show();
                this.Hide();
            }
            else if (IsTeacher())
            {
                //loggedInUser = new LoggedInUser(txtUsername.Text.ToLower(), Role.Teacher);

                LoggedInUser.Name = txtUsername.Text.ToLower();
                LoggedInUser.userRole = Role.Teacher;
                TeacherForm teacherForm = new TeacherForm();
                teacherForm.Show();
                this.Hide();
            }
            else if (IsStudent())
            {
                //loggedInUser = new LoggedInUser(txtUsername.Text.ToLower(), Role.Student);

                LoggedInUser.Name = txtUsername.Text.ToLower();
                LoggedInUser.userRole = Role.Student;
                StudentForm studentForm = new StudentForm();
                studentForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }

        }

        //Check if the loggedin user is an admin then navigate him to the admin page (return true)
        private bool IsAdmin()
        {
            foreach (User admin in Lists.admins)
            {
                return (admin.Username.ToLower() == txtUsername.Text.ToLower() && admin.Password == txtPassword.Text);
            }
            return false;
        }

        //Check if the loggedin user is a teacher then navigate him to the teacher page (return true)
        private bool IsTeacher()
        {
            foreach (Teacher teacher in Lists.teachersList)
            {
                return (teacher.Username.ToLower() == txtUsername.Text.ToLower() && teacher.Password == txtPassword.Text);
            }
            return false;
        }

        //Check if the loggedin user is a student then navigate him to the student page (return true)
        private bool IsStudent()
        {
            foreach (Student student in Lists.studentsList)
            {
                return (student.Username.ToLower() == txtUsername.Text.ToLower() && student.Password == txtPassword.Text);
            }
            return false;
        }

        private void lnkForgetPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgetPasswordForm forgetPasswordFrom = new ForgetPasswordForm();
            forgetPasswordFrom.ShowDialog();
        }
    }
}
