using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Attendance_C__XML_Project
{
    public partial class LoginForm : Form
    {
        List<Class> classes;
        List<Teacher> teachersList;
        List<Student> studentsList;
        List<User> admins;
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
            this.Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            //Dummy data for testing
            classes = new List<Class>();
            classes.Add(new Class("B1"));
            classes.Add(new Class("B2"));

            teachersList = new List<Teacher>();
            teachersList.Add(new Teacher("Ali", "Oeams7476386#", "01074845994", "Teacher@yahoo.com", "Egypt Cairo", classes));
            teachersList.Add(new Teacher("Omar", "Oeams7476386#", "01074845994", "Teacher@yahoo.com", "Egypt Cairo", classes));
            teachersList.Add(new Teacher("Ahmed", "Oeams7476386#", "01074845994", "Teacher@yahoo.com", "Egypt Cairo", classes));

            studentsList = new List<Student>();
            studentsList.Add(new Student("Ahmed Ali", "Oeams7476386#", "01074845994", "Teacher@yahoo.com", "Egypt Cairo", 1));
            studentsList.Add(new Student("Osame Ali", "Oeams7476386#", "01074845994", "Teacher@yahoo.com", "Egypt Cairo", 2));

            admins = new List<User>();
            admins.Add(new User("admin", "Oeams7476386#", "01074845994", "Teacher@yahoo.com", "Egypt Cairo"));
            //end dummy data

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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (IsAdmin())
            {
                AdminForm adminForm = new AdminForm();
                adminForm.Show();
                this.Hide();
            }
            else if (IsTeacher())
            {

            }
            else if (IsStudent())
            {

            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
            
        }

        //Check if the loggedin user is an admin then navigate him to the admin page (return true)
        private bool IsAdmin()
        {
            foreach (User admin in admins)
            {
                return (admin.Username.ToLower() == txtUsername.Text.ToLower() && admin.Password == txtPassword.Text);
            }
            return false;
        }

        //Check if the loggedin user is a teacher then navigate him to the teacher page (return true)
        private bool IsTeacher()
        {
            foreach (Teacher teacher in teachersList)
            {
                return (teacher.Username.ToLower() == txtUsername.Text.ToLower() && teacher.Password == txtPassword.Text);
            }
            return false;
        }

        //Check if the loggedin user is a student then navigate him to the student page (return true)
        private bool IsStudent()
        {
            foreach (Student student in studentsList)
            {
                return (student.Username.ToLower() == txtUsername.Text.ToLower() && student.Password == txtPassword.Text);
            }
            return false;
        }
    }
}
