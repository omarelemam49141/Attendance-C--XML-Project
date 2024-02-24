namespace Attendance_C__XML_Project.Properties
{

    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.8.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase
    {

        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));

        public static Settings Default
        {
            get
            {
                return defaultInstance;
            }
        }

        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Black")]
        public string SelectedColor
        {
            get
            {
                return (string)this["SelectedColor"];
            }
            set
            {
                this["SelectedColor"] = value;
            }
        }

        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Medium")]
        public string SelectedFontSize
        {
            get
            {
                return (string)this["SelectedFontSize"];
            }
            set
            {
                this["SelectedFontSize"] = value;
            }
        }

        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("dd/MM/yyyy")]
        public string SelectedDateFormat
        {
            get
            {
                return (string)this["SelectedDateFormat"];
            }
            set
            {
                this["SelectedDateFormat"] = value;
            }
        }

        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Light")]
        public string SelectedTheme
        {
            get
            {
                return (string)this["SelectedTheme"];
            }
            set
            {
                this["SelectedTheme"] = value;
            }
        }

        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("English")]
        public string SelectedLanguage
        {
            get
            {
                return (string)this["SelectedLanguage"];
            }
            set
            {
                this["SelectedLanguage"] = value;
            }
        }
    }
}
