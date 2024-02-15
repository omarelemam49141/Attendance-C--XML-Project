using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance_C__XML_Project
{
    internal class Teacher:User
    {
        //private fields
        List<Class> classes;
        //constructor
        public Teacher(int id, string username, string password, string phone, string mail, string address, List<Class> _classes)
            : base(id, username, password, phone, mail, address)
        {
            classes = _classes;
        }
        //methods
        public void addClass(Class c) { classes.Add(c); }

        public void removeClass(Class c) {  classes.Remove(c); }
    }
}
