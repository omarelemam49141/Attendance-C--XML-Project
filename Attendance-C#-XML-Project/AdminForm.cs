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
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Attendance_C__XML_Project
{
    public partial class AdminForm : Form
    {
        //The parent form
        LoginForm loginForm;
        public XmlSerializer serializer;

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
            //SettingsManager.SettingsIntialization(this);
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
            //read the data from the xml files
            //read the classes data
            Lists.classes = new List<Class>();
            FileManagment.LoadClassesFromFile("classes.xml", ref Lists.classes);

            //read the teachers data
            Lists.teachersList = new List<Teacher>();
            FileManagment.LoadClassesFromFile("teachers.xml", ref Lists.teachersList);

            //read the students data
            Lists.studentsList = new List<Student>();
            FileManagment.LoadClassesFromFile("students.xml", ref Lists.studentsList);

            //show the users panel and hide the others
            panelShowClasses.Visible = false;


            lblRole.Text = LoggedInUser.userRole.ToString();
            lblUsername.Text = $"Welcome {LoggedInUser.Name}";

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

            //Load all the users in the list box
            foreach (var teacher in Lists.teachersList)
            {
                listUsers.Items.Add(teacher);
            }
            foreach (var student in Lists.studentsList)
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
            قائمة_الفصول_المعروضة.Items.Clear();
            //display all classes in the list classes
            foreach (var classItem in Lists.classes)
            {
                قائمة_الفصول_المعروضة.Items.Add(classItem);
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

            DisplayReportsForm fr = new DisplayReportsForm();
            fr.ShowDialog();
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
                var teacher = Lists.teachersList.Find(teacher => teacher.Username.ToLower() == txtSearch.Text.Trim().ToLower());
                if (teacher != null)
                {
                    listUsers.SelectedItem = teacher;
                    return;
                }
                //Search for a student with the search box text
                var student = Lists.studentsList.Find(student => student.Username.ToLower() == txtSearch.Text.Trim().ToLower());
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
                        int index = Lists.teachersList.FindIndex(teacher => teacher.ID == selectedUser.ID);
                        //get the old teacher object
                        Teacher oldTeacher = Lists.teachersList[index];
                        Teacher updatedTeacher = (Teacher)oldTeacher.Clone();
                        //update the old teacher from the list
                        updatedTeacher.Username = txtUsername.Text;
                        updatedTeacher.Mail = txtEmail.Text;
                        updatedTeacher.Password = txtPassword.Text;
                        //remove the old teacher
                        Lists.teachersList.RemoveAt(index);
                        //update the teacher in the xml file
                        // Validate the teachersList against the XSD schema

                        //add it to the teacher list at the old index
                        Lists.teachersList.Insert(index, updatedTeacher);

                        bool isValid = FileManagment.ValidateAgainstXsd(Lists.teachersList, "teachers.xsd");


                        // If the classes are valid, serialize them to an XML file
                        if (isValid)
                        {
                            FileManagment.SerializeClassesToXml(Lists.teachersList, "teachers.xml");
                        }
                        else
                        {
                            throw new Exception("TeacherLists is not valid against XSD schema. Unable to save.");
                        }

                        //update the teacher in the list box
                        listUsers.Items[listUsers.SelectedIndex] = updatedTeacher;

                        MessageBox.Show("Teacher updated successfully");
                    }
                    else if (selectedUser is Student)
                    {
                        //find the index of the student to remove
                        int index = Lists.studentsList.FindIndex(student => student.ID == selectedUser.ID);
                        //get the old student object
                        Student oldStudent = Lists.studentsList[index];
                        Student updatedStudent = (Student)oldStudent.Clone();
                        //remove the student from the list
                        Lists.studentsList.RemoveAt(index);
                        //add it to the student list at the old index
                        //update the old student and 
                        updatedStudent.Username = txtUsername.Text;
                        updatedStudent.Mail = txtEmail.Text;
                        updatedStudent.Password = txtPassword.Text;
                        Lists.studentsList.Insert(index, updatedStudent);
                        //update the student in the xml file
                        // Validate the studendsList against the XSD schema
                        bool isValid = FileManagment.ValidateAgainstXsd(Lists.studentsList, "students.xsd");

                        // If the classes are valid, serialize them to an XML file
                        if (true)
                        {
                            FileManagment.SerializeClassesToXml(Lists.studentsList, "students.xml");
                        }
                        else
                        {
                            throw new Exception("StudentLists is not valid against XSD schema. Unable to save.");
                        }


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
                        int index = Lists.teachersList.FindIndex(teacher => teacher.ID == selectedUser.ID);
                        //remove the teacher from teachers list
                        Lists.teachersList.RemoveAt(index);

                        //remove the teacher from the xml file
                        // Validate the teachersList against the XSD schema
                        bool isValid = FileManagment.ValidateAgainstXsd(Lists.teachersList, "teachers.xsd");

                        // If the classes are valid, serialize them to an XML file
                        if (isValid)
                        {
                            FileManagment.SerializeClassesToXml(Lists.teachersList, "teachers.xml");
                        }
                        else
                        {
                            throw new Exception("TeacherLists is not valid against XSD schema. Unable to save.");
                        }

                        //remove the teacher from the list box
                        listUsers.Items.RemoveAt(listUsers.SelectedIndex);
                        //Removing the selection from the list box
                        قائمة_الفصول_المعروضة.SelectedItem = null;

                        MessageBox.Show("Teacher deleted successfully");
                    }
                    else if (selectedUser is Student)
                    {
                        //find the index of the student to remove
                        int index = Lists.studentsList.FindIndex(student => student.ID == selectedUser.ID);
                        //remove the student from the students list
                        Lists.studentsList.RemoveAt(index);

                        //remove the student from the xml file
                        // Validate the studendsList against the XSD schema
                        bool isValid = FileManagment.ValidateAgainstXsd(Lists.studentsList, "students.xsd");

                        // If the classes are valid, serialize them to an XML file
                        if (isValid)
                        {
                            FileManagment.SerializeClassesToXml(Lists.studentsList, "students.xml");
                        }
                        else
                        {
                            throw new Exception("TeacherLists is not valid against XSD schema. Unable to save.");
                        }

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
            selectedClass = قائمة_الفصول_المعروضة.SelectedItem as Class;
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
                Class selectedClass = Lists.classes.Find(classItem => classItem.Name.ToLower() == txtSearchClass.Text.Trim().ToLower());
                قائمة_الفصول_المعروضة.SelectedItem = selectedClass;
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
                    Class? updatedClass = Lists.classes.Find(classItem => classItem.ID == selectedClass.ID);
                    //update the class name
                    updatedClass.Name = txtNameOfClass.Text.Trim();

                    //update the class in the xml file
                    // Validate the classes against the XSD schema
                    bool isValid = FileManagment.ValidateAgainstXsd(Lists.classes, "classes.xsd");

                    // If the classes are valid, serialize them to an XML file
                    if (isValid)
                    {
                        FileManagment.SerializeClassesToXml(Lists.classes, "classes.xml");
                    }
                    else
                    {
                        throw new Exception("Classes are not valid against XSD schema. Unable to save.");
                    }

                    //update the class in the listDisplayClasses with the new info
                    قائمة_الفصول_المعروضة.Items[قائمة_الفصول_المعروضة.SelectedIndex] = updatedClass;
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
                    int deletedClassIndex = Lists.classes.IndexOf(selectedClass);
                    //set students' class to null if they were enroll in the deleted class
                    List<Student> students = Lists.studentsList.FindAll(student => student.ClassID == selectedClass.ID);
                    if (students.Count > 0)
                    {
                        students.ForEach(student => { student.ClassID = -1; });
                    }
                    //set teachers' class to null if they were enroll in the deleted class
                    List<Teacher> teachers = Lists.teachersList.FindAll(teacher => teacher.Classes.Contains(selectedClass));
                    if (teachers.Count > 0)
                    {
                        teachers.ForEach(teacher => teacher.Classes.Remove(selectedClass));
                    }

                    //Remove the class itself
                    Lists.classes.RemoveAt(deletedClassIndex);

                    //delete the class from the xml file
                    // Validate the classes against the XSD schema
                    bool isValid = FileManagment.ValidateAgainstXsd(Lists.classes, "classes.xsd");

                    // If the classes are valid, serialize them to an XML file
                    if (isValid)
                    {
                        FileManagment.SerializeClassesToXml(Lists.classes, "classes.xml");
                    }
                    else
                    {
                        throw new Exception("Classes are not valid against XSD schema. Unable to save.");
                    }


                    //Delete the class from the listDisplayClass 
                    قائمة_الفصول_المعروضة.Items.Remove(selectedClass);
                    //Removing the selection from the list box
                    قائمة_الفصول_المعروضة.SelectedItem = null;
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

        //add new class
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (txtNameOfClass.Text.Trim() == "")
            {
                MessageBox.Show("The class name can't be empty");
                return;
            }
            try
            {
                Class newClass = new Class(txtNameOfClass.Text.Trim());
                Lists.classes.Add(newClass);
                //Save the classes into an xml file
                // Validate the classes against the XSD schema
                bool isValid = FileManagment.ValidateAgainstXsd(Lists.classes, "classes.xsd");

                // If the classes are valid, serialize them to an XML file
                if (isValid)
                {
                    FileManagment.SerializeClassesToXml(Lists.classes, "classes.xml");
                }
                else
                {
                    throw new Exception("Classes are not valid against XSD schema. Unable to save.");
                }

                قائمة_الفصول_المعروضة.Items.Add(newClass);
                MessageBox.Show("Class added successfully");
                if (lblAddError.Visible)
                {
                    lblAddError.Visible = false;
                }
            }
            catch (Exception ex)
            {
                lblAddError.Visible = true;
                lblAddError.Text = ex.Message;
            }

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            PreferencesForm preferencesForm = new PreferencesForm();
            preferencesForm.ShowDialog();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
