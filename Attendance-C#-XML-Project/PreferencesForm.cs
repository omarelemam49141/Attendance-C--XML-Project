﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Attendance_C__XML_Project;

namespace Attendance_C__XML_Project
{
    public partial class PreferencesForm : Form
    {
        public PreferencesForm()
        {
            InitializeComponent();
            btnSave.Hide();

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
            SettingsManager.SettingsIntialization(this);



            LoadSettings();


        }
        private void LoadSettings()
        {

            comboColors.Text = Properties.Settings.Default.SelectedColor;

            comboDateFormat.Text = Properties.Settings.Default.SelectedDateFormat;

            switch (Properties.Settings.Default.SelectedFontSize)
            {
                case 10:
                    comboFontSize.Text = "Small";
                    break;
                case 11:
                    comboFontSize.Text = "Medium";
                    break;
                case 13:
                    comboFontSize.Text = "Large";
                    break;
                default:
                    comboFontSize.Text = "Medium";
                    break;
            }


            if (Properties.Settings.Default.SelectedLanguage.ToString() == "ar")
            {
                comboLanguages.Text = "العربية";
            }
            else
            {
                comboLanguages.Text = "English";
            }

            // comboThemes.Text = Properties.Settings.Default.SelectedTheme.Name;
            if (Properties.Settings.Default.SelectedTheme.Name.ToString() == "Control")
            {
                comboThemes.Text = "Light";
            }
            else
            {
                comboThemes.Text = "Dark";
            }
        }


        #region User Management

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

        #endregion


        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
            this.Close();
        }

        private void comboColors_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedColor = comboColors.SelectedItem.ToString();
            ApplyTextColor(GetColorFromName(selectedColor));
        }
        private void ApplyTextColor(Color color)
        {

            var s = color.ToString();

            Properties.Settings.Default.SelectedColor = color.Name.ToString();
            Properties.Settings.Default.Save();

            float defaultFontSize = Properties.Settings.Default.SelectedFontSize;
            Font newFont = new Font(Font.FontFamily, defaultFontSize);
            SettingsManager.ApplyFontStyleToControls(this.Controls, newFont, color);
        }

        private void comboFontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedFontSize = comboFontSize.SelectedItem.ToString();
            ApplyFontSize(GetFontSizeFromName(selectedFontSize));
        }
        private float GetFontSizeFromName(string fontSizeName)
        {
            switch (fontSizeName)
            {
                case "Small":
                    return 10;
                case "Medium":
                    return 11;
                case "Large":
                    return 13;
                default:
                    MessageBox.Show("Invalid font size selection. Defaulting to medium.");
                    return 10;
            }
        }
        private void ApplyFontSize(float size)
        {
            Properties.Settings.Default.SelectedFontSize = size;
            Properties.Settings.Default.Save();

            Font newFont = new Font(this.Font.FontFamily, size);
            string defaultFontColor = Properties.Settings.Default.SelectedColor;
            Color newColor = ColorTranslator.FromHtml(defaultFontColor);
            SettingsManager.ApplyFontStyleToControls(this.Controls, newFont, newColor);
        }

        private void comboDateFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedFormat = comboDateFormat.SelectedItem.ToString();
            string formatPattern;
            switch (selectedFormat)
            {
                case "DD/MM/YYYY":
                    formatPattern = "dd/MM/yyyy";
                    Properties.Settings.Default.SelectedDateFormat = formatPattern;
                    break;
                case "MM/DD/YYYY":
                    formatPattern = "MM/dd/yyyy";
                    Properties.Settings.Default.SelectedDateFormat = formatPattern;
                    break;
                default:
                    MessageBox.Show("Invalid date format selection. Defaulting to DD/MM/YYYY.");
                    formatPattern = "dd/MM/yyyy";
                    Properties.Settings.Default.SelectedDateFormat = formatPattern;
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

            Properties.Settings.Default.SelectedTheme = SystemColors.Control;

            SettingsManager.SettingsIntialization(this);
        }
        private void ApplyDarkTheme()
        {
            Properties.Settings.Default.SelectedTheme = Color.FromArgb(45, 45, 48);
            SettingsManager.SettingsIntialization(this);
        }
        private void comboBoxLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboLanguages.SelectedItem != null)
            {
                if (comboLanguages.SelectedItem.ToString() == "English")
                {
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
                    SetLanguage("en-US"); // Set language to English
                    Properties.Settings.Default.SelectedLanguage ="en-US";
                }
                else if (comboLanguages.SelectedItem.ToString() == "العربية")
                {
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ar");
                    SetLanguage("ar"); // Set language to Arabic
                    Properties.Settings.Default.SelectedLanguage = "ar";

                }
            }


        }
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

            if (control.Controls.Count > 0)
            {
                foreach (Control childControl in control.Controls)
                {
                    ApplyResources(childControl, cultureCode);
                }
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            SavePreferences();
            MessageBox.Show("Preferences saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SavePreferences()
        {
            

        }



        private Color GetColorFromName(string colorName)
        {
            switch (colorName)
            {
                case "Black":
                    return Color.Black;
                case "Grey":
                    return Color.Gray;
                case "Blue":
                    return Color.Blue;
                default:
                    MessageBox.Show("Invalid color selection. Defaulting to black.");
                    return Color.Black;
            }
        }

     


        private void SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UserLogout_click(object sender, EventArgs e)
        {
            LoggedInUser.Name = string.Empty;
            LoggedInUser.userRole = (Role)(-1);
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}
