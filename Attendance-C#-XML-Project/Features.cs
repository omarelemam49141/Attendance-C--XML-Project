using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance_C__XML_Project
{
    enum Colors { Black, White }
    enum FontSize { Small, Normal, Large }
    enum Themes { Light, Dark}
    enum Language { English, Arabic }
    enum DateFormat { FullDate, MonthOnly, YearOnly}
    internal class Features
    {
        //properties
        public Colors Color { get; set; }
        public FontSize FontSize { get; set; }
        public Themes Themes { get; set; }
        public Language language { get; set; }
        public DateFormat dateFormat { get; set; }

        //constructor
        private Features(Colors color=Colors.Black, FontSize fontSize=FontSize.Normal, Themes theme = Themes.Light,
            Language lang = Language.English, DateFormat _dateFormat = DateFormat.FullDate) 
        {
            Color = color;
            FontSize = fontSize;
            Themes = theme;
            language = lang;
            dateFormat = _dateFormat;
        }

        //singleton design pattern (creating only one features object)
        //private fields
        static Features? features = null;
        public static Features createFeatures(Colors color = Colors.Black, FontSize fontSize = FontSize.Normal, Themes theme = Themes.Light,
            Language lang = Language.English, DateFormat _dateFormat = DateFormat.FullDate)
        {
            if (features == null)
            {
                return new Features(color, fontSize, theme, lang, _dateFormat);
            }
            return features;
        }

    }
}
