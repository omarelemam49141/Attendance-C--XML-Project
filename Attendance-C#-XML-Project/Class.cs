using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Attendance_C__XML_Project
{
    internal class Class
    {
        int id;
        string name;

        public Class(int _id, string _name) 
        {
            ID = _id;
            Name = _name;
        }

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

        public string Name
        {
            get => name;
            set
            {
                if (value.Trim().Length < 2)
                {
                    Console.WriteLine("Class name length can't be less than 2");
                }
                else { name = value; }
            }
        }
    }
}
