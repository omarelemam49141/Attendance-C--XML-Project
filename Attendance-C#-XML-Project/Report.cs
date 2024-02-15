using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance_C__XML_Project
{
    internal class GenerateReport
    {
        int id;
        List<AttendanceRecord> attendanceRecords;
        public GenerateReport(int _id) 
        {
            ID = _id;   
        }

        //methods
        public int getTotalAbsenceDays()
        {
            int absenceDays = 0;
            foreach (var attendanceRecord in attendanceRecords)
            {
                if (attendanceRecord.attendanceStatus == AttendanceStatus.Absence)
                {
                    absenceDays++;
                }
            }
            return absenceDays;
        }

        public int getTotalWarnings()
        {
            return getTotalAbsenceDays()/5;
        }

        public int getTotalDismissals()
        {
            return getTotalAbsenceDays() / 15;
        }

        public void addAttendanceRecord(AttendanceRecord attendanceRecord)
        {
            attendanceRecords.Add(attendanceRecord);
        }

        public void removeAttendanceRecord(AttendanceRecord attendanceRecord)
        {
            attendanceRecords.Remove(attendanceRecord);
        }

        //get all the attendance records for a specific student by his id
        public List<AttendanceRecord> getStudentReport(int studentID)
        {
            var studentReport = new List<AttendanceRecord>();
            foreach (var attendanceRecord in attendanceRecords)
            {
                if (attendanceRecord.student.ID == studentID)
                {
                    studentReport.Add(attendanceRecord);
                }
            }
            return studentReport;
        }

        //get all the attendance records between two dates
        public List<AttendanceRecord> getReportsBetween(DateOnly date1, DateOnly date2)
        {
            var dateReport = new List<AttendanceRecord>();
            foreach (var attendanceRecord in attendanceRecords)
            {
                if (attendanceRecord.RecordDate > date1 && attendanceRecord.RecordDate < date2)
                {
                    dateReport.Add(attendanceRecord);
                }
            }
            return dateReport;
        }

        //get all the attendance records before certain date
        public List<AttendanceRecord> getReportsBefore(DateOnly date)
        {
            var dateReport = new List<AttendanceRecord>();
            foreach (var attendanceRecord in attendanceRecords)
            {
                if (attendanceRecord.RecordDate < date)
                {
                    dateReport.Add(attendanceRecord);
                }
            }
            return dateReport;
        }

        //get all the attendance records after certain date
        public List<AttendanceRecord> getReportsAfter(DateOnly date)
        {
            var dateReport = new List<AttendanceRecord>();
            foreach (var attendanceRecord in attendanceRecords)
            {
                if (attendanceRecord.RecordDate > date)
                {
                    dateReport.Add(attendanceRecord);
                }
            }
            return dateReport;
        }

        //get reports for a certain Class
        public List<AttendanceRecord> getClassReports(int classID)
        {
            var classReport = new List<AttendanceRecord>();
            foreach (var attendanceRecord in attendanceRecords)
            {
                if (attendanceRecord.ClassID == classID)
                {
                    classReport.Add(attendanceRecord);
                }
            }
            return classReport;
        }

        //properties
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
