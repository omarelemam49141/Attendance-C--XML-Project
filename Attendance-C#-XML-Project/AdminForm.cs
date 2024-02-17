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
        internal List<Class> classes;
        internal List<Teacher> teachersList;
        internal List<Student> studentsList;

        //the reference that will refer to the loggedIn information
        internal LoggedInUser loggedInUser;

        //The parent form
        LoginForm loginForm;

        public ListBox ListDisplayUsers { get => listUsers; }

        User selectedUser = null; //The user object that the user selects to edit or delete it
        Class selectedClass = null; //The class object that the user selects to edit or delete it
        // Import the necessary Windows API methods
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;
        public AdminForm(LoginForm _loginForm)
        {
            //get the parent form
            loginForm = _loginForm;
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
            panelShowClasses.Visible = false;

            //Show the role and the user name of the logged in user
            loggedInUser = loginForm.loggedInUser;

            lblRole.Text = loggedInUser.userRole.ToString();
            lblUsername.Text = $"Welcome {loggedInUser.Name}";

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
            teachersList.Add(new Teacher("Ali", "Oeams7476386#", "01074845994", "Teacher@yahoo.com", "Egypt Cairo"));
            teachersList.Add(new Teacher("Omar", "Oeams7476386#", "01074845994", "Teacher@yahoo.com", "Egypt Cairo"));
            teachersList.Add(new Teacher("Ahmed", "Oeams7476386#", "01074845994", "Teacher@yahoo.com", "Egypt Cairo"));

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

        //display classes
        private void btnDisplayClasses_Click(object sender, EventArgs e)
        {
            (sender as Button).ForeColor = Color.White;
            btnDisplayUsers.ForeColor = Color.DarkGray;
            btnDisplayReports.ForeColor = Color.DarkGray;
            panelShowClasses.Visible = true;

            //Clear the list box of classes
            listDisplayClasses.Items.Clear();
            //display all classes in the list classes
            foreach (var classItem in classes)
            {
                listDisplayClasses.Items.Add(classItem);
            }
        }

        //display users
        private void btnDisplayUsers_Click(object sender, EventArgs e)
        {
            panelShowClasses.Visible = false;
            (sender as Button).ForeColor = Color.White;
            btnDisplayClasses.ForeColor = Color.DarkGray;
            btnDisplayReports.ForeColor = Color.DarkGray;
        }

        //open display reports
        private void btnDisplayReports_Click(object sender, EventArgs e)
        {
            (sender as Button).ForeColor = Color.White;
            btnDisplayClasses.ForeColor = Color.DarkGray;
            btnDisplayUsers.ForeColor = Color.DarkGray;
        }

        //Open Add new user form
        private void button3_Click(object sender, EventArgs e)
        {
            AddNewUser addNewUser = new AddNewUser(this);
            addNewUser.ShowDialog();
        }

        //Display a user details
        private void listUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            User user = (sender as ListBox)?.SelectedItem as User;
            if (user != null)
            {
                selectedUser = user;
                lblID.Text = user.ID.ToString();
                txtUsername.Text = user.Username;
                txtPassword.Text = user.Password;
                txtEmail.Text = user.Mail;
            }
        }

        //Search for a user by username
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.Trim() != "")
            {
                //Search for a teacher with the search box text
                var teacher = teachersList.Find(teacher => teacher.Username.ToLower() == txtSearch.Text.Trim().ToLower());
                if (teacher != null)
                {
                    listUsers.SelectedItem = teacher;
                    return;
                }
                //Search for a student with the search box text
                var student = studentsList.Find(student => student.Username.ToLower() == txtSearch.Text.Trim().ToLower());
                if (student != null)
                {
                    listUsers.SelectedItem = student;
                    return;
                }
                //Not found
                MessageBox.Show("user not found!");
            }
        }

        //update the user information
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (selectedUser != null)
            {
                //check if the data is changed
                if (userDataChanged())
                {////////////////////////-------------------------------Needs refactoring
                    if (selectedUser is Teacher)
                    {
                        //find the index of the teacher to remove
                        int index = teachersList.FindIndex(teacher => teacher.ID == selectedUser.ID);
                        //get the old teacher object
                        Teacher updatedTeacher = teachersList[index];
                        //remove the teacher
                        teachersList.RemoveAt(index);
                        //update the old teacher from the list
                        updatedTeacher.Username = txtUsername.Text;
                        updatedTeacher.Mail = txtEmail.Text;
                        updatedTeacher.Password = txtPassword.Text;
                        //add it to the teacher list at the old index
                        teachersList.Insert(index, updatedTeacher);
                        //update the teacher in the list box
                        listUsers.Items[listUsers.SelectedIndex] = updatedTeacher;

                        MessageBox.Show("Teacher updated successfully");
                    }
                    else if (selectedUser is Student)
                    {
                        //find the index of the student to remove
                        int index = studentsList.FindIndex(student => student.ID == selectedUser.ID);
                        //get the old student object
                        Student updatedStudent = studentsList[index];
                        //remove the student from the list
                        studentsList.RemoveAt(index);
                        //update the old student and 
                        updatedStudent.Username = txtUsername.Text;
                        updatedStudent.Mail = txtEmail.Text;
                        updatedStudent.Password = txtPassword.Text;
                        //add it to the student list at the old index
                        studentsList.Insert(index, updatedStudent);
                        //update the student in the list box
                        listUsers.Items[listUsers.SelectedIndex] = updatedStudent;

                        MessageBox.Show("Student updated successfully");
                    }
                }
            }
        }

        //return true if the user data has been changed
        private bool userDataChanged()
        {
            return (selectedUser.Username.ToLower() != txtUsername.Text.ToLower()
                || selectedUser.Password.ToLower() != txtPassword.Text.ToLower()
                || selectedUser.Mail.ToLower() != txtEmail.Text.ToLower());
        }

        //Delete the selected user
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //Check if a user is selected
            if (selectedUser != null)
            {
                //confirm the deleting process
                if (MessageBox.Show($"Are you sure you want to delete {selectedUser.Username}?", "Deleting confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (selectedUser is Teacher)
                    {
                        //find the index of the teacher to remove
                        int index = teachersList.FindIndex(teacher => teacher.ID == selectedUser.ID);
                        //remove the teacher from teachers list
                        teachersList.RemoveAt(index);
                        //remove the teacher from the list box
                        listUsers.Items.RemoveAt(listUsers.SelectedIndex);
                        //Removing the selection from the list box
                        listDisplayClasses.SelectedItem = null;

                        MessageBox.Show("Teacher deleted successfully");
                    }
                    else if (selectedUser is Student)
                    {
                        //find the index of the student to remove
                        int index = studentsList.FindIndex(student => student.ID == selectedUser.ID);
                        //remove the student from the students list
                        studentsList.RemoveAt(index);
                        //remove the student from the list box
                        listUsers.Items.RemoveAt(listUsers.SelectedIndex);

                        MessageBox.Show("Student deleted successfully");
                    }

                    //Removing the selection from the list box
                    selectedUser = null;
                    ResetUserFields();
                }
            }
        }

        private void ResetUserFields()
        {
            lblID.Text = "-1";
            txtPassword.Text = "";
            txtEmail.Text = "";
            txtUsername.Text = "";
        }

        //Display the class information when selecting it
        private void liatDisplayClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedClass = listDisplayClasses.SelectedItem as Class;
            if (selectedClass != null)
            {
                txtClassID.Text = selectedClass.ID.ToString();
                txtNameOfClass.Text = selectedClass.Name;
            }
        }

        //Search for a class by its name
        private void btnSearchClasses_Click(object sender, EventArgs e)
        {
            if (txtSearchClass.Text.Trim().Length > 0)
            {
                Class selectedClass = classes.Find(classItem => classItem.Name.ToLower() == txtSearchClass.Text.Trim().ToLower());
                listDisplayClasses.SelectedItem = selectedClass;
            }
        }

        //Edit the selected class information
        private void btnUpdateClass_Click(object sender, EventArgs e)
        {
            if (selectedClass != null)
            {
                if (classInfoChanged())
                {
                    //Get the updated class from the class list
                    Class? updatedClass = classes.Find(classItem => classItem.ID == selectedClass.ID);
                    //update the class name
                    updatedClass.Name = txtNameOfClass.Text.Trim();
                    //update the class in the listDisplayClasses with the new info
                    listDisplayClasses.Items[listDisplayClasses.SelectedIndex] = updatedClass;
                    //Show success message
                    MessageBox.Show("Class updated successfully");
                }
            }
        }

        //Check if the class information has been changed (return true)
        private bool classInfoChanged()
        {
            return (selectedClass.Name.ToLower() != txtNameOfClass.Text.Trim().ToLower());
        }

        //Delete the selected class
        private void btnRemoveClass_Click(object sender, EventArgs e)
        {
            if (selectedClass != null)
            {
                //Show confirmation message
                if (MessageBox.Show($"Are you sure you want to delete {selectedClass}?", "Confirm Deleting", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //Get the index of the class to delete
                    int deletedClassIndex = classes.IndexOf(selectedClass);
                    //Delete the class from the listDisplayClass 
                    listDisplayClasses.Items.Remove(selectedClass);
                    //Removing the selection from the list box
                    listDisplayClasses.SelectedItem = null;
                    //Delete the class from the classes list
                    //Removing the selection from the list box
                    selectedClass = null;
                    ResetClassFields();
                }
            }
        }

        private void ResetClassFields()
        {
            txtNameOfClass.Text = "";
            txtClassID.Text = "-1";
        }

        private void linkLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}
