using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance_C__XML_Project
{
    static internal class Lists
    {
        //private fields
        static internal List<Class> classes;
        static internal List<Teacher> teachersList;
        static internal List<Student> studentsList;
        static internal List<User> admins;
        static internal List<AttendanceRecord> attendanceRecords;

        #region Data_Population
        static void PopulateData()
        {

            Lists.classes = new List<Class>(){
                new Class() { ID=1,Name="A1"},
                new Class() { ID=2,Name="A2"},
                new Class() { ID=3,Name="B1"},
                new Class() { ID=4,Name="B2"},
            };

            var teacher1classes = new List<Class>(){
                new Class() { ID=1,Name="A1"},
                new Class() { ID=2,Name="A2"}
            };
            var teacher2classes = new List<Class>(){
                new Class() { ID=3,Name="B1"},
                new Class() { ID=4,Name="B2"}
            };
            FileManagment.SerializeClassesToXml(Lists.classes, "classes.xml");

            Lists.teachersList = [new Teacher("teacher1", "Oeams7476386#", "01074845994", "Teacher1@yahoo.com", "Egypt Mansoura"){Classes=teacher1classes},
            new Teacher("teacher2", "Oeams7476386#", "01074845994", "Teacher2@yahoo.com", "Egypt Cairo"){Classes=teacher2classes}];

            FileManagment.SerializeClassesToXml(Lists.teachersList, "teachers.xml");

            Lists.studentsList = [new Student("Ali", "Oeams7476386#", "01074845994", "Student1@yahoo.com", "Egypt Manoura", 1),
                                  new Student("Hamada", "Oeams7476386#", "01074845994", "Student3@yahoo.com", "Egypt Alex", 1),
                                  new Student("Omar", "Oeams7476386#", "01074845994", "Student5@yahoo.com", "Egypt Mansoura", 2),
                                  new Student("Hamdy", "Oeams7476386#", "01074845994", "Student6@yahoo.com", "Egypt Kafer ELsheikh", 3),
                                  new Student("Hamed", "Oeams7476386#", "01074845994", "Student7@yahoo.com", "Egypt Cairo", 4),
            ];

            FileManagment.SerializeClassesToXml(Lists.studentsList, "students.xml");

            attendanceRecords = new List<AttendanceRecord>
            {
                new AttendanceRecord(1,Lists.studentsList[0],AttendanceStatus.Presence){RecordDate=new DateTime(2024, 2, 23)},
                new AttendanceRecord(2,Lists.studentsList[0],AttendanceStatus.Presence){RecordDate=new DateTime(2024, 2, 24)},
                new AttendanceRecord(3,Lists.studentsList[0],AttendanceStatus.Absence){RecordDate=new DateTime(2024, 2, 25)},
                new AttendanceRecord(4,Lists.studentsList[0],AttendanceStatus.Absence){RecordDate=new DateTime(2024, 2, 26)},
                new AttendanceRecord(5,Lists.studentsList[0],AttendanceStatus.Presence){RecordDate=new DateTime(2024, 2, 27)},
                new AttendanceRecord(6,Lists.studentsList[0],AttendanceStatus.Presence){RecordDate=new DateTime(2024, 2, 28)},

                new AttendanceRecord(7,Lists.studentsList[1],AttendanceStatus.Absence){RecordDate=new DateTime(2024, 2, 23)},
                new AttendanceRecord(8,Lists.studentsList[1],AttendanceStatus.Absence){RecordDate=new DateTime(2024, 2, 24)},
                new AttendanceRecord(9,Lists.studentsList[1],AttendanceStatus.Absence){RecordDate=new DateTime(2024, 2, 25)},
                new AttendanceRecord(10,Lists.studentsList[1],AttendanceStatus.Absence){RecordDate=new DateTime(2024, 2, 26)},
                new AttendanceRecord(11,Lists.studentsList[1],AttendanceStatus.Presence){RecordDate=new DateTime(2024, 2, 27)},
                new AttendanceRecord(12,Lists.studentsList[1],AttendanceStatus.Presence){RecordDate=new DateTime(2024, 2, 28)},

                 new AttendanceRecord(13,Lists.studentsList[2],AttendanceStatus.Absence){RecordDate=new DateTime(2024, 2, 23)},
                new AttendanceRecord(14,Lists.studentsList[2],AttendanceStatus.Absence){RecordDate=new DateTime(2024, 2, 24)},
                new AttendanceRecord(15,Lists.studentsList[2],AttendanceStatus.Absence){RecordDate=new DateTime(2024, 2, 25)},
                new AttendanceRecord(16,Lists.studentsList[2],AttendanceStatus.Absence){RecordDate=new DateTime(2024, 2, 26)},
                new AttendanceRecord(17,Lists.studentsList[2],AttendanceStatus.Presence){RecordDate=new DateTime(2024, 2, 27)},
                new AttendanceRecord(18,Lists.studentsList[2],AttendanceStatus.Presence){RecordDate=new DateTime(2024, 2, 28)},

                new AttendanceRecord(19,Lists.studentsList[3],AttendanceStatus.Absence){RecordDate=new DateTime(2024, 2, 23)},
                new AttendanceRecord(20,Lists.studentsList[3],AttendanceStatus.Absence){RecordDate=new DateTime(2024, 2, 24)},
                new AttendanceRecord(21,Lists.studentsList[3],AttendanceStatus.Absence){RecordDate=new DateTime(2024, 2, 25)},
                new AttendanceRecord(22,Lists.studentsList[3],AttendanceStatus.Absence){RecordDate=new DateTime(2024, 2, 26)},
                new AttendanceRecord(23,Lists.studentsList[3],AttendanceStatus.Presence){RecordDate=new DateTime(2024, 2, 27)},
                new AttendanceRecord(24,Lists.studentsList[3],AttendanceStatus.Presence){RecordDate=new DateTime(2024, 2, 28)},

                new AttendanceRecord(25,Lists.studentsList[4],AttendanceStatus.Absence){RecordDate=new DateTime(2024, 2, 23)},
                new AttendanceRecord(26,Lists.studentsList[4],AttendanceStatus.Absence){RecordDate=new DateTime(2024, 2, 24)},
                new AttendanceRecord(27,Lists.studentsList[4],AttendanceStatus.Absence){RecordDate=new DateTime(2024, 2, 25)},
                new AttendanceRecord(28,Lists.studentsList[4],AttendanceStatus.Absence){RecordDate=new DateTime(2024, 2, 26)},
                new AttendanceRecord(29,Lists.studentsList[4],AttendanceStatus.Presence){RecordDate=new DateTime(2024, 2, 27)},
                new AttendanceRecord(30,Lists.studentsList[4],AttendanceStatus.Presence){RecordDate=new DateTime(2024, 2, 28)},
            };
            FileManagment.SerializeClassesToXml(attendanceRecords, "attendances.xml");
        }
        #endregion
    }
}
