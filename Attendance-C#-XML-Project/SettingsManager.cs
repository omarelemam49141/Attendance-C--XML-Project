using System.Configuration;
using System.Drawing;
using Attendance_C__XML_Project.Properties;
namespace Attendance_C__XML_Project
{
    public static class SettingsManager
    {
      

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
        public static void ApplyTheme(Control.ControlCollection controls, Color theme)
        {
            foreach (Control control in controls)
            {
               
                if (control is Panel && control.Tag == "myTheme")
                {
                    control.BackColor = theme;
                    if (theme == Color.FromArgb(45, 45, 48))
                    {

                        control.ForeColor = Color.White;
                        if (control.HasChildren)
                        {
                            foreach (Control child in control.Controls)
                            {
                                if(child is Label)
                                    child.ForeColor = Color.White;
                            }
                        }
                    }
                    else
                    {
                        control.ForeColor = Color.Black;
                    }
                   
                }
               
            }
        }
        public static void ApplyDateFormat(Control.ControlCollection controls, string format)
        {
            foreach (Control control in controls)
            {
                if (control is DateTimePicker)
                {
                    var dateTimePicker = (DateTimePicker)control;
                    dateTimePicker.CustomFormat = format;  //"MM/dd/yyyy"
                    dateTimePicker.Format = DateTimePickerFormat.Custom;
                }
            }
        }

        public static void SettingsIntialization(Form form)
        {
            float defaultFontSize = Properties.Settings.Default.SelectedFontSize;
            string defaultFontColor = Properties.Settings.Default.SelectedColor;
            string defaultDateFormat = Properties.Settings.Default.SelectedDateFormat;
            Color Theme = Properties.Settings.Default.SelectedTheme;
            string language = Properties.Settings.Default.SelectedLanguage;

            Font newFont = new Font(form.Font.FontFamily, defaultFontSize);
            Color newColor = ColorTranslator.FromHtml(defaultFontColor);
            SettingsManager.ApplyFontStyleToControls(form.Controls, newFont, newColor);

            SettingsManager.ApplyTheme(form.Controls, Theme);
            SettingsManager.ApplyDateFormat(form.Controls, defaultDateFormat);

            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(language);

        }

    }
}
//