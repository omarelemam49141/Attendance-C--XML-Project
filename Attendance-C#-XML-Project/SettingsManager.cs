using System.Configuration;
using Attendance_C__XML_Project.Properties;
namespace Attendance_C__XML_Project
{
    public static class SettingsManager
    {
        public static string GetSelectedColor()
        {
            return Properties.Settings.Default.SelectedColor;
        }

        public static void SetSelectedColor(string color)
        {
            Properties.Settings.Default.SelectedColor = color;
        }

        public static float GetSelectedFontSize()
        {
            return Properties.Settings.Default.SelectedFontSize;
        }

        public static void SetSelectedFontSize(float fontSize)
        {
            Properties.Settings.Default.SelectedFontSize = fontSize;
        }

        public static string GetSelectedDateFormat()
        {
            return Properties.Settings.Default.SelectedDateFormat;
        }

        public static void SetSelectedDateFormat(string dateFormat)
        {
            Properties.Settings.Default.SelectedDateFormat = dateFormat;
        }

        public static string GetSelectedTheme()
        {
            return Properties.Settings.Default.SelectedTheme;
        }

        public static void SetSelectedTheme(string theme)
        {
            Properties.Settings.Default.SelectedTheme = theme;
        }

        public static string GetSelectedLanguage()
        {
            return Properties.Settings.Default.SelectedLanguage;
        }

        public static void SetSelectedLanguage(string language)
        {
            Properties.Settings.Default.SelectedLanguage = language;
        }


        public static void ApplyFontStyleToControls(Control.ControlCollection controls, Font font, Color color)
        {
            foreach (Control control in controls)
            {
                control.Font = font;
                if (control is Label)
                    control.ForeColor = color;
                if (control.HasChildren)
                {
                    
                    ApplyFontStyleToControls(control.Controls, font, color);
                }
            }
        }

        public static void SettingsIntialization(Form form)
        {
            float defaultFontSize = Properties.Settings.Default.SelectedFontSize;
            string defaultFontColor = Properties.Settings.Default.SelectedColor;

            Font newFont = new Font(form.Font.FontFamily, defaultFontSize);
            Color newColor = ColorTranslator.FromHtml(defaultFontColor);
            SettingsManager.ApplyFontStyleToControls(form.Controls, newFont, newColor);
        }
    }
}
//