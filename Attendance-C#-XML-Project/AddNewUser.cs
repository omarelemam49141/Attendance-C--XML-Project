﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_C__XML_Project
{
    public partial class AddNewUser : Form
    {
        // Import the necessary Windows API methods
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;
        public AddNewUser()
        {
            InitializeComponent();
        }

        private void AddNewUser_Load(object sender, EventArgs e)
        {
            this.Controls.Remove(checkedListClass);
            GraphicsPath path = new GraphicsPath();
            Rectangle bounds = new Rectangle(0, 0, this.Width, this.Height);
            int radius = 10; // Change this value to adjust the roundness of the corners

            int diameter = radius * 2;
            Size size = new Size(diameter, diameter);
            Rectangle arc = new Rectangle(bounds.Location, size);

            // Add arcs to the path to create rounded corners
            path.AddArc(arc, 180, 90);
            arc.X = bounds.Right - diameter;
            path.AddArc(arc, 270, 90);
            arc.Y = bounds.Bottom - diameter;
            path.AddArc(arc, 0, 90);
            arc.X = bounds.Left;
            path.AddArc(arc, 90, 90);

            // Close the path
            path.CloseFigure();

            // Draw the form using the path
            this.Region = new Region(path);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            // Check if the left mouse button is pressed
            if (e.Button == MouseButtons.Left)
            {
                // Release capture to enable normal mouse operation like clicking on buttons
                ReleaseCapture();

                // Send the message to move the form
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void comboSelectRole_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboGender_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboClass_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboSelectRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblRole.Text = (sender as ComboBox)?.SelectedItem?.ToString();
            btnAddUser.Text = $"Add {(sender as ComboBox)?.SelectedItem?.ToString()}";
            if (lblRole.Text == "Teacher")
            {
                this.Controls.Remove(comboClass);
                this.Controls.Add(checkedListClass);
            }
            else
            {
                this.Controls.Add(comboClass);
                this.Controls.Remove(checkedListClass);
            }
        }
    }
}
