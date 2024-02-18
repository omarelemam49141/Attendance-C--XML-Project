using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance_C__XML_Project
{
    public enum Role {Admin, Student, Teacher}
    internal class LoggedInUser
    {
        public LoggedInUser(string name, Role role)
        {
            Name = name;
            userRole = role;
        }
        public string Name { get; set; }
        public Role userRole { get; set; }

    }
    public static class MyLoggedInUser
    {
        public static string Name { get; set; }
        public static Role UserRole { get; set; }
    }

}
