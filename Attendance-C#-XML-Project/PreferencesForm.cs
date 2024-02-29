using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace Attendance_C__XML_Project
{
    public partial class PreferencesForm : Form
    {
        // Constructor
        public PreferencesForm()
        {
            InitializeComponent();

            // Load UserName and UserRole
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


            
        }

        // Helper method to get UserName
        private string GetUserName()
        {
            if (LoggedInUser.Name != "")
            {
                return LoggedInUser.Name;
            }
            throw new Exception("Can't Find UserName");
        }

        // Helper method to get UserRole
        private string GetUserRole()
        {
            var role = LoggedInUser.userRole.ToString();

            if (role != null)
            {
                return role;
            }
            throw new Exception("Can't Find Teacher Role");
        }

        // Helper method to handle user logout
        private void UserLogout()
        {
            
        }

        // Event handler for language selection change
        private void comboBoxLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboLanguages.SelectedItem != null)
            {
                if (comboLanguages.SelectedItem.ToString() == "English")
                {
                    SetLanguage("en-US"); // Set language to English
                }
                else if (comboLanguages.SelectedItem.ToString() == "العربية")
                {
                    SetLanguage("ar"); // Set language to Arabic (Saudi Arabia)
                }
            }
        }
        // Helper method to set language
        private void SetLanguage(string cultureCode)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(cultureCode);
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(cultureCode);

            foreach (Control control in this.Controls)
            {
                ApplyResources(control, cultureCode);
            }
        }

        private void ApplyResources(Control control, string cultureCode)
        {

            var resources = new System.ComponentModel.ComponentResourceManager(this.GetType());
            resources.ApplyResources(control, control.Name, new CultureInfo(cultureCode));
            this.Close();

            if (control.Controls.Count > 0)
            {
                foreach (Control childControl in control.Controls)
                {
                    ApplyResources(childControl, cultureCode);
                }
            }
        }// Event handlers for combo box selection changes
        private void comboColors_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedColor = comboColors.SelectedItem.ToString();
            Color color = GetColorFromName(selectedColor);
            ApplyTextColor(color);
            ApplyComboBoxColor(color);
        }

        private void ComboFontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedFontSize = comboFontSize.SelectedItem.ToString();
            float fontSize = GetFontSizeFromName(selectedFontSize);
            ApplyFontSize(fontSize);
        }

        private void comboDateFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
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

        private void comboThemes_SelectedIndexChanged(object sender, EventArgs e)
        {
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


        // Helper method to apply text color to controls
        private void ApplyTextColor(Color color)
        {
            foreach (Control control in GetAllControls(this))
            {
                if (control is Label || control is Button || control is ComboBox)
                {
                    control.ForeColor = color;
                }
            }
        }

        // Helper method to apply font size to controls
        private void ApplyFontSize(float size)
        {
            foreach (Control control in GetAllControls(this))
            {
                control.Font = new Font(control.Font.FontFamily, size);
            }
        }

        // Helper method to apply date format to DateTimePicker controls
        private void ApplyDateFormat(string format)
        {
            foreach (Control control in GetAllControls(this))
            {
                if (control is DateTimePicker)
                {
                    ((DateTimePicker)control).CustomFormat = format;
                    ((DateTimePicker)control).Format = DateTimePickerFormat.Custom;
                }
            }
        }

        // Helper method to apply light theme
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

        // Helper method to apply dark theme
        private void ApplyDarkTheme()
        {
            this.BackColor = Color.FromArgb(45, 45, 48);
            foreach (Control control in Controls)
            {
                control.BackColor = Color.FromArgb(45, 45, 48);
                if (control is Label || control is Button)
                {
                    control.ForeColor = SystemColors.ControlLightLight;
                }
            }
        }

        // Helper method to get all controls within a form recursively
        private IEnumerable<Control> GetAllControls(Control container)
        {
            var controls = container.Controls.Cast<Control>();
            return controls.SelectMany(ctrl => GetAllControls(ctrl)).Concat(controls);
        }

        // Helper method to apply combo box background color
        private void ApplyComboBoxColor(Color color)
        {
            foreach (Control control in Controls)
            {
                if (control is ComboBox)
                {
                    (control as ComboBox).BackColor = color;
                }
            }
        }

        // Helper method to get color from color name
        private Color GetColorFromName(string colorName)
        {
            switch (colorName)
            {
                case "Black":
                    return Color.Black;
                case "Gray":
                    return Color.Gray;
                case "Blue":
                    return Color.Blue;
                default:
                    MessageBox.Show("Invalid color selection. Defaulting to black.");
                    return Color.Black;
            }
        }

        // Helper method to get font size from font size name
        private float GetFontSizeFromName(string fontSizeName)
        {
            switch (fontSizeName)
            {
                case "Small":
                    return 8;
                case "Medium":
                    return 10;
                case "Large":
                    return 12;
                default:
                    MessageBox.Show("Invalid font size selection. Defaulting to medium.");
                    return 10;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
            this.Close();
        }
        // Save button click event handler
        private void btnSave_Click(object sender, EventArgs e)
        {
            SavePreferences();
            MessageBox.Show("Preferences saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        // Method to save preferences
        private void SavePreferences()
        {
            if (comboColors.SelectedItem != null && comboFontSize.SelectedItem != null && comboDateFormat.SelectedItem != null && comboThemes.SelectedItem != null && comboLanguages.SelectedItem != null)
            {
                string selectedLanguage = comboLanguages.SelectedItem.ToString();
                SetLanguage(selectedLanguage); // Apply language setting first

                string selectedColor = comboColors.SelectedItem.ToString();
                string selectedFontSize = comboFontSize.SelectedItem.ToString();
                string selectedDateFormat = comboDateFormat.SelectedItem.ToString();
                string selectedTheme = comboThemes.SelectedItem.ToString();

                // Save other preferences
                SettingsManager.SetSelectedColor(selectedColor);
                SettingsManager.SetSelectedFontSize(selectedFontSize);
                SettingsManager.SetSelectedDateFormat(selectedDateFormat);
                SettingsManager.SetSelectedTheme(selectedTheme);
                SettingsManager.SetSelectedLanguage(selectedLanguage); // This is redundant but to make sure

                ApplyPreferences();
            }
        }

        // Method to apply saved preferences
        private void ApplyPreferences()
        {
            string selectedColor = SettingsManager.GetSelectedColor();
            ApplyTextColor(GetColorFromName(selectedColor));

            string selectedFontSize = SettingsManager.GetSelectedFontSize();
            float fontSize = GetFontSizeFromName(selectedFontSize);
            ApplyFontSize(fontSize);

            string selectedDateFormat = SettingsManager.GetSelectedDateFormat();
            ApplyDateFormat(selectedDateFormat);

            string selectedTheme = SettingsManager.GetSelectedTheme();
            if (selectedTheme == "Light")
            {
                ApplyLightTheme();
            }
            else if (selectedTheme == "Dark")
            {
                ApplyDarkTheme();
            }
            else
            {
                MessageBox.Show("Invalid theme selection. Defaulting to Light theme.");
                ApplyLightTheme();
            }

            string selectedLanguage = SettingsManager.GetSelectedLanguage();
            SetLanguage(selectedLanguage);
        }
    }
}
