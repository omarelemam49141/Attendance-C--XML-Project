using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance_C__XML_Project
{
    enum AttendanceStatus { Absence, Presence }
    internal class AttendanceRecord
    {
        int id;
        
        public AttendanceRecord(int _id, Student _student, AttendanceStatus _attendanceStatus) 
        {
            ID = _id;
            student = _student;
            ClassID = student.ClassID;
            RecordDate = DateOnly.FromDateTime(DateTime.Now);
            attendanceStatus = _attendanceStatus;
        }

        public AttendanceStatus attendanceStatus { get; set; }
        public DateOnly RecordDate { get; set; }
        public int ClassID {  get; set; }
        public Student student { get; set; }
        public int ID
        {
            get => id;
            set
            {
                if (value < 1)
                {
                    Console.WriteLine("ID can't be less than 1");
                }
                else
                {
                    id = value;
                }
            }
        }
    }
}
