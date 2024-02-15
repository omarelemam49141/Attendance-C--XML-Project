using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance_C__XML_Project
{
    internal class Student : User
    {
        //private fields
        int absenceDays;
        int numberOfWarnings;
        int classID;

        //constructor
        public Student(int id, string username, string password, string phone, string mail, string address, int _classId, int _absenceDays=0, int _numberOfWarnings=0, bool _dismissal=false)
            : base(id, username, password, phone, mail, address)
        {
            ClassID = _classId;
            AbsenceDays = _absenceDays;
            NumberOfWarnings = _numberOfWarnings;
            Dismissal = _dismissal;
        }
        //properties
        public int AbsenceDays { 
            get=> absenceDays;
            set 
            {
                if (value < 0)
                {
                    Console.WriteLine("Absence days can't be less than zero");
                }
                else
                {
                    if (value >= 15)
                    {
                        numberOfWarnings = 3;
                        Dismissal = true;
                    }
                    else if (value >= 10)
                        numberOfWarnings = 2;
                    else
                        numberOfWarnings = 1;

                    absenceDays = value;
                };
            }
        }

        public int ClassID
        {
            get => classID;
            set
            {
                if (value < 1)
                {
                    Console.WriteLine("ID can't be less than 1");
                }
                else
                {
                    classID = value;
                }
            }
        }

        public int NumberOfWarnings
        {
            get => numberOfWarnings;
            set 
            {
                if (value < 0)
                {
                    Console.WriteLine("Absence days can't be less than zero");
                } 
                else
                {
                    if (value >= 3)
                    {
                        Dismissal = true;
                    }
                    numberOfWarnings = value;
                }
            }
        }

        public bool Dismissal { get; set; }
    }
}
