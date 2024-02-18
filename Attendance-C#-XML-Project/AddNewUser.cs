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
    public partial class AddNewUser : Form
    {
        // Import the necessary Windows API methods
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        //the parent form
        private AdminForm adminForm;

        public AddNewUser(AdminForm? _adminForm)
        {
            InitializeComponent();
            adminForm = _adminForm;
        }

        private void AddNewUser_Load(object sender, EventArgs e)
        {
            if (LoggedInUser.userRole != null)
            {
                lblLoggedInRole.Text = LoggedInUser.userRole.ToString();
            }

            this.Controls.Remove(checkedListClass);
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

            //Dummy classes data
            Lists.classes = [new Class("B1"), new Class("B2"), new Class("B3")
                ,new Class("B4"), new Class("B5"), new Class("B6")];

            //provide the classes for the comboClass students and teacher
            foreach (var classItem in Lists.classes)
            {
                comboClass.Items.Add(classItem.Name);
                checkedListClass.Items.Add(classItem.Name);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
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

        private void comboSelectRole_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboGender_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboClass_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboSelectRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblRole.Text = (sender as ComboBox)?.SelectedItem?.ToString();
            btnAddUser.Text = $"Add {(sender as ComboBox)?.SelectedItem?.ToString()}";
            if (lblRole.Text == "Teacher")
            {
                this.Controls.Remove(comboClass);
                this.Controls.Add(checkedListClass);
            }
            else
            {
                this.Controls.Add(comboClass);
                this.Controls.Remove(checkedListClass);
            }
        }

        //Add new user
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            int errors = 0;

            //validate the user data and add them if they are valid
            User newUser = new User();
            if (comboRole.SelectedItem == "Student" || comboRole.SelectedItem == "Teacher") //check if the role is slected
            {
                //Validate the username
                try
                {
                    //check the uniquness of the username
                    foreach (var student in Lists.studentsList)
                    {
                        if (student.Username.ToLower() == txtUsername.Text.Trim().ToLower())
                        {
                            throw new Exception("This username is taken");
                        }
                    }
                    foreach (var teacher in Lists.teachersList)
                    {
                        if (teacher.Username.ToLower() == txtUsername.Text.Trim().ToLower())
                        {
                            throw new Exception("This username is taken");
                        }
                    }

                    newUser.Username = txtUsername.Text.Trim();
                    lblUsernameError.Text = "";
                }
                catch (Exception ex)
                {
                    lblUsernameError.Text = ex.Message;
                    errors++;
                }

                //Validate the password
                try
                {
                    newUser.Password = txtPassword.Text.Trim();
                    lblPasswordError.Text = "";
                }
                catch (Exception ex)
                {
                    lblPasswordError.Text = ex.Message;
                    errors++;
                }

                //Validate the email
                try
                {
                    newUser.Mail = txtEmail.Text.Trim();
                    lblEmailError.Text = "";
                }
                catch (Exception ex)
                {
                    lblEmailError.Text = ex.Message;
                    errors++;
                }

                //Validate the phone
                try
                {
                    newUser.Phone = txtPhone.Text.Trim();
                    lblPhoneError.Text = "";
                }
                catch (Exception ex)
                {
                    lblPhoneError.Text = ex.Message;
                    errors++;
                }

                //Validate the address
                try
                {
                    newUser.Address = txtAddress.Text.Trim();
                    lblAddressError.Text = "";
                }
                catch (Exception ex)
                {
                    lblAddressError.Text = ex.Message;
                    errors++;
                }

                //Validate the gender
                try
                {
                    newUser.gender = (Gender)Enum.Parse(typeof(Gender), comboGender.SelectedItem.ToString());
                    lblGenderError.Text = "";
                }
                catch (Exception ex)
                {
                    lblGenderError.Text = "You must select a gender from the list";
                    errors++;
                }

                lblRoleError.Text = "";
            }
            else
            {
                lblRoleError.Text = "You must select a role";
                return;
            }

            //Check if the role is student then try to add his class
            if (comboRole.SelectedItem == "Student")
            {
                Student newStudent = null;
                //Validate the class
                try
                {
                    newStudent = new Student(newUser.Username, newUser.Password, newUser.Phone, newUser.Mail, newUser.Address, 1);
                    newStudent.gender = newUser.gender;
                }
                catch
                {
                    MessageBox.Show("Invalid form info");
                    return;
                }

                try { 
                    //Get the class from the classes list
                    Class selectedClass = Lists.classes.Find(classItem => classItem.Name.ToLower() == comboClass.SelectedItem.ToString().Trim().ToLower());
                    //add the class id to the new student
                    newStudent.ClassID = selectedClass.ID;
                    lblClassError.Text = "";
                }
                catch (Exception ex)
                {
                    lblClassError.Text = "You must select a class from the list";
                    errors++;
                }

                //add the new student if no errors
                if (errors == 0)
                {
                    //add the student to the parent students list
                    Lists.studentsList.Add(newStudent);
                    //add the student to the parent list box
                    adminForm.ListDisplayUsers.Items.Add(newStudent);
                    MessageBox.Show("Student Added Successfully");
                }
            }
            //If the role is teacher then try to add his list of classes
            else if (comboRole.SelectedItem == "Teacher")
            {
                Teacher newTeacher = null;
                //Try to Make a new object of teacher
                try
                {
                    newTeacher = new Teacher(newUser.Username, newUser.Password, newUser.Phone, newUser.Mail, newUser.Address);
                    newTeacher.gender = newUser.gender;
                }
                catch 
                {
                    MessageBox.Show("Invalid form info");
                    return;
                }
               
                //Validate the class
                try
                {
                    foreach (string className in checkedListClass.Items)
                    {
                        //Get the class from the classes list
                        Class selectedClass = Lists.classes.Find(classItem => classItem.Name.ToLower() == className.Trim().ToLower());
                        //add the class id to the new student
                        newTeacher.addClass(selectedClass);
                    }
                    //newStudent.ClassID = comboClass.slec.Trim();
                    lblClassesError.Text = "";
                }
                catch (Exception ex)
                {
                    lblClassesError.Text = "You must select at least one class from the list";
                    errors++;
                }

                //add the new teacher if no errors
                if (errors == 0)
                {
                    //add the teacher to the student list
                    Lists.teachersList.Add(newTeacher);
                    //add the teacher to the parent list box
                    adminForm.ListDisplayUsers.Items.Add(newTeacher);
                    MessageBox.Show("Teacher Added Successfully");
                }
            }
        }

        private void linkLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
            adminForm.Hide();
        }
    }
}
