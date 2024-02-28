using System.Configuration;
using Attendance_C__XML_Project.Properties;
namespace Attendance_C__XML_Project
{
    internal class SettingsManager
    {
        public static string GetSelectedColor()
        {
            return Properties.Settings.Default.SelectedColor;
        }

        public static void SetSelectedColor(string color)
        {
            Properties.Settings.Default.SelectedColor = color;
        }

        public static string GetSelectedFontSize()
        {
            return Properties.Settings.Default.SelectedFontSize;
        }

        public static void SetSelectedFontSize(string fontSize)
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
    }
}
//