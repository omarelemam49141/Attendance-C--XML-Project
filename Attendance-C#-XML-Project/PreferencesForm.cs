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
            // Change text color based on the selected color
            string selectedColor = comboColors.SelectedItem.ToString();
            Color textColor = Color.Black; // Default color
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
                    MessageBox.Show("Invalid color selection. Defaulting to black.");
                    break;
            }
            ApplyTextColor(textColor);
        }

        private void ApplyTextColor(Color color)
        {
            foreach (Control control in Controls)
            {
                if (control is Label || control is Button)
                {
                    control.ForeColor = color;
                }
            }
        }

        private void comboFontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Change font size based on the selected font size
            string selectedFontSize = comboFontSize.SelectedItem.ToString();
            float fontSize = 10; // Default font size
            switch (selectedFontSize)
            {
                case "Small":
                    fontSize = 8;
                    break;
                case "Medium":
                    fontSize = 10;
                    break;
                case "Large":
                    fontSize = 12;
                    break;
                default:
                    MessageBox.Show("Invalid font size selection. Defaulting to medium.");
                    break;
            }
            ApplyFontSize(fontSize);
        }

        private void ApplyFontSize(float size)
        {
            foreach (Control control in Controls)
            {
                if (control is Label || control is Button)
                {
                    control.Font = new Font(control.Font.FontFamily, size);
                }
            }
        }

        private void comboDateFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Change date format based on the selected format
            string selectedFormat = comboDateFormat.SelectedItem.ToString();
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
                    MessageBox.Show("Invalid date format selection. Defaulting to DD/MM/YYYY.");
                    formatPattern = "dd/MM/yyyy";
                    break;
            }
            ApplyDateFormat(formatPattern);
        }

        private void ApplyDateFormat(string format)
        {
            foreach (Control control in Controls)
            {
                if (control is DateTimePicker)
                {
                    ((DateTimePicker)control).CustomFormat = format;
                    ((DateTimePicker)control).Format = DateTimePickerFormat.Custom;
                }
            }
        }

        private void comboThemes_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Change theme based on the selected theme
            string selectedTheme = comboThemes.SelectedItem.ToString();
            switch (selectedTheme)
            {
                case "Light":
                    ApplyLightTheme();
                    break;
                case "Dark":
                    ApplyDarkTheme();
                    break;
                default:
                    MessageBox.Show("Invalid theme selection. Defaulting to Light theme.");
                    ApplyLightTheme();
                    break;
            }
        }

        private void ApplyLightTheme()
        {
            this.BackColor = SystemColors.Control;
            foreach (Control control in Controls)
            {
                control.BackColor = SystemColors.Control;
                if (control is Label || control is Button)
                {
                    control.ForeColor = SystemColors.ControlText;
                }
            }
        }

        private void ApplyDarkTheme()
        {
            this.BackColor = Color.FromArgb(45, 45, 48); // Dark gray background
            foreach (Control control in Controls)
            {
                control.BackColor = Color.FromArgb(45, 45, 48); // Dark gray background
                if (control is Label || control is Button)
                {
                    control.ForeColor = SystemColors.ControlLightLight; // Light gray text
                }
            }
        }

        private void comboLanguages_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedLanguage = comboLanguages.SelectedItem.ToString();
            switch (selectedLanguage)
            {
                case "English":
                    SetLanguage("en-US");
                    break;
                case "العربية":
                    SetLanguage("ar-SA");
                    break;
                default:
                    MessageBox.Show("Invalid language selection. Defaulting to English.");
                    SetLanguage("en-US");
                    break;
            }
        }

        private void SetLanguage(string cultureCode)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(cultureCode);
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(cultureCode);

            // Update UI elements here with translated text or resources
        }




        // PreferencesForm.cs
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Save user preferences
            SavePreferences();

            // Show confirmation message
            MessageBox.Show("Preferences saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SavePreferences()
        {
            // Save selected color
            string selectedColor = comboColors.SelectedItem.ToString();
            Properties.Settings.Default.SelectedColor = selectedColor;

            // Save selected font size
            string selectedFontSize = comboFontSize.SelectedItem.ToString();
            Properties.Settings.Default.SelectedFontSize = selectedFontSize;

            // Save selected date format
            string selectedDateFormat = comboDateFormat.SelectedItem.ToString();
            Properties.Settings.Default.SelectedDateFormat = selectedDateFormat;

            // Save selected theme
            string selectedTheme = comboThemes.SelectedItem.ToString();
            Properties.Settings.Default.SelectedTheme = selectedTheme;

            // Save selected language
            string selectedLanguage = comboLanguages.SelectedItem.ToString();
            Properties.Settings.Default.SelectedLanguage = selectedLanguage;

            // Apply changes immediately
            ApplyPreferences();

            // Save settings
            Properties.Settings.Default.Save();
        }

    }
}
