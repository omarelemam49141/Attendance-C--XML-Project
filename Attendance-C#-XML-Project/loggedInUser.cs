using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance_C__XML_Project
{
    enum Role {Admin, Student, Teacher}
    static internal class LoggedInUser
    {
        public static string Name { get; set; }
        public static Role userRole { get; set; }

    }
}
