using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Attendance_C__XML_Project
{
    enum Gender { Male, Female}
    internal class User
    {
        //private fields
        static int lastID = 0;

        int id;
        string username;
        string password;
        string phone;
        string mail;
        string address;

        //constructors
        public User( string _username, string _password, string _phone, string _mail, string _address) 
        {
            id = ++lastID;
            Username = _username;
            Password = _password;
            Phone = _phone;
            Mail = _mail;
            Address = _address;
        }

        //properties with validation
        public int ID //readonly
        { 
            get=>id;
        }

        public string Username
        {
            get => username; 
            set 
            { 
                if(value.Trim().Length < 3)
                {
                    throw new Exception("Name length can't be less than 3");
                }
                else { username=value; }
            }
        }

        public string Password
        {
            get => password;
            set
            {
                string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[!@#$%^&*()-_=+{}|;:',.<>?]).{8,}$";

                if (Regex.IsMatch(value, pattern))
                {
                    password = value;
                }
                else
                {
                    throw new Exception("Password must be at least 8 characters long and contain at least one uppercase letter, one lowercase letter, one digit, and one special character.");
                }
            }
        }

        public Gender gender { get; set; }

        public string Phone { get => phone; 
            set 
            {
                string pattern = @"^01[0-2]{1}[0-9]{8}$"; // Egyptian phone number pattern

                if (Regex.IsMatch(value.Trim(), pattern))
                {
                    phone = value;
                }
                else
                {
                    throw new Exception("Invalid Egyptian phone number.");
                }
            } 
        }

        public string Mail
        {
            get => mail;
            set
            {
                // Regular expression for email validation
                string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

                if (Regex.IsMatch(value, emailPattern))
                {
                    mail = value;
                }
                else
                {
                    throw new Exception("Invalid email format");
                }
            }
        }

        public string Address { get=>address; 
            set 
            {
                if (value.Trim().Length < 5)
                {
                    throw new Exception("Address can't be less than 5 characters");
                }
                else { address=value; }
            } 
        }

        //methods
        public override string ToString()
        {
            return $"ID: {ID} - Username: {username}";
        }
    }
}
