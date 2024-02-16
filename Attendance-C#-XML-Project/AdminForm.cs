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
    public partial class AdminForm : Form
    {
        List<Class> classes;
        List<Teacher> teachersList;
        List<Student> studentsList;
        // Import the necessary Windows API methods
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;
        public AdminForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
            this.Close();
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

        private void AdminForm_Load(object sender, EventArgs e)
        {
            //show the users panel and hide the others
            panelDisplayClass.Visible = false;

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
            //end dummy data

            //Load all the users in the list box
            foreach (var teacher in teachersList)
            {
                listUsers.Items.Add(teacher);
            }
            foreach (var student in studentsList)
            {
                listUsers.Items.Add(student);
            }
        }

        private void btnDisplayClasses_Click(object sender, EventArgs e)
        {
            (sender as Button).ForeColor = Color.White;
            btnDisplayUsers.ForeColor = Color.DarkGray;
            btnDisplayReports.ForeColor = Color.DarkGray;
            panelDisplayClass.Visible = true;
        }

        private void btnDisplayUsers_Click(object sender, EventArgs e)
        {
            panelDisplayClass.Visible = false;
            panelDisplayUser.Visible = true;
            (sender as Button).ForeColor = Color.White;
            btnDisplayClasses.ForeColor = Color.DarkGray;
            btnDisplayReports.ForeColor = Color.DarkGray;
        }

        private void btnDisplayReports_Click(object sender, EventArgs e)
        {
            (sender as Button).ForeColor = Color.White;
            btnDisplayClasses.ForeColor = Color.DarkGray;
            btnDisplayUsers.ForeColor = Color.DarkGray;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddNewUser addNewUser = new AddNewUser();
            addNewUser.ShowDialog();
        }

        private void listUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            User user =  (sender as ListBox)?.SelectedItem as User;
            if (user != null)
            {
                txtUsername.Text = user.Username;
                txtPassword.Text = user.Password;
                txtEmail.Text = user.Mail;
            }
        }
    }
}
