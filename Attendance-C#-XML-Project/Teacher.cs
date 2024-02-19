using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Attendance_C__XML_Project
{
    public class Teacher:User
    {
        //private fields
        List<Class> classes;
        //constructor
        public Teacher() { }
        public Teacher(string username, string password, string phone, string mail, string address)
            : base(username, password, phone, mail, address)
        {}
        //methods
        public void addClass(Class c) { classes.Add(c); }

        public void removeClass(int classID) 
        {  
            Class? _class = classes.Find(c => c.ID == classID);
            if (_class != null) { classes.Remove(_class); }
        }

        //properties
        //make a public property of the classes for xml requirments
        [XmlArray("classes")]
        [XmlArrayItem("class")]
        public List<Class> Classes
        { get { return classes; } set { classes = value; } }
    }
}
