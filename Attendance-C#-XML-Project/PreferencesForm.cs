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

        private void comboFontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected font size from the combo box
            string selectedFontSize = comboFontSize.SelectedItem.ToString();

            // Set the default font size
            float fontSize = 10; // Default font size

            // Determine the selected font size
            switch (selectedFontSize)
            {
                case "Small":
                    fontSize = 8; // Set to a small font size
                    break;
                case "Medium":
                    fontSize = 10; // Set to a medium font size
                    break;
                case "Large":
                    fontSize = 12; // Set to a large font size
                    break;
                default:
                    // If an invalid selection is made, set the font size to medium
                    MessageBox.Show("Invalid font size selection. Defaulting to medium.");
                    break;
            }

            // Iterate through all controls in the form
            foreach (Control control in Controls)
            {
                // Check if the control is a label or button (you can extend this to other types of controls as needed)
                if (control is Label || control is Button)
                {
                    // Set the font size of the control
                    control.Font = new Font(control.Font.FontFamily, fontSize);
                }
            }
        }

        private void comboDateFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected date format from the combo box
            string selectedFormat = comboDateFormat.SelectedItem.ToString();

            // Determine the format pattern based on the selection
            string formatPattern;
            switch (selectedFormat)
            {
                case "DD/MM/YYYY":
                    formatPattern = "dd/MM/yyyy";
                    break;
                case "MM/DD/YYYY":
                    formatPattern = "MM/dd/yyyy";
                    break;
                default:
                    // If an invalid selection is made, set the format to default ("DD/MM/YYYY")
                    MessageBox.Show("Invalid date format selection. Defaulting to DD/MM/YYYY.");
                    formatPattern = "dd/MM/yyyy";
                    break;
            }

            // Iterate through all controls in the form
            foreach (Control control in Controls)
            {
                // Check if the control is a DateTimePicker (you can extend this to other types of controls as needed)
                if (control is DateTimePicker)
                {
                    // Set the date format of the control
                    ((DateTimePicker)control).CustomFormat = formatPattern;
                    ((DateTimePicker)control).Format = DateTimePickerFormat.Custom;
                }
            }
        }

    }
}
