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
    public partial class PreferencesForm : Form
    {
        public PreferencesForm()
        {
            InitializeComponent();

            // Loading UserName and User Role   

            try
            {
                lblUserName.Text = GetUserName();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                UserLogout();
                throw;
            }


            // Load Teacher Role
            try
            {
                lblRoleName.Text = GetUserRole();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                UserLogout();
                throw;
            }

            // Loading User Settings




        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private string GetUserName()
        {
            if (LoggedInUser.Name != "")
            {
                return LoggedInUser.Name;
            }
            throw new Exception("Can't Find UserName");
        }
        private string GetUserRole()
        {

            var role = LoggedInUser.userRole.ToString();

            if (role != null)
            {
                return role;
            }
            throw new Exception("Can't Find Teacher Role");
        }
        private void UserLogout()
        {
            throw new NotImplementedException();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
            this.Close();
        }

        private void comboColors_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected color from the combo box
            string selectedColor = comboColors.SelectedItem.ToString();

            // Set the default color to black in case of an invalid selection
            Color textColor = Color.Black;

            // Determine the selected color
            switch (selectedColor)
            {
                case "Black":
                    textColor = Color.Black;
                    break;
                case "Gray":
                    textColor = Color.Gray;
                    break;
                case "Blue":
                    textColor = Color.Blue;
                    break;
                default:
                    // If an invalid selection is made, set the color to black
                    MessageBox.Show("Invalid color selection. Defaulting to black.");
                    break;
            }

            // Iterate through all controls in the form
            foreach (Control control in Controls)
            {
                // Check if the control is a label or button (you can extend this to other types of controls as needed)
                if (control is Label || control is Button)
                {
                    // Set the text color of the control
                    control.ForeColor = textColor;
                }
            }
        }

    }
}
