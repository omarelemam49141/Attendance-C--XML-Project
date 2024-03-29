﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Attendance_C__XML_Project
{
    public class Class
    {
        //private fields
        static int lastID = 0;

        int id;
        string name;

        //constructor
        public Class() 
        {
            
        }
        public Class(string _name) 
        {
            id = ++lastID;
            Name = _name;
        }

        //properties
        public int ID
        {
            get => id;
            set => id = value; //just for the xml to set the ID
        }

        public string Name
        {
            get => name;
            set
            {
                if (value.Trim().Length < 2)
                {
                    throw new Exception("Class name length can't be less than 2");
                }
                else { name = value; }
            }
        }

        //methods
        public override string ToString()
        {
            return $"{ID} - {Name}";
        }
    }
}
