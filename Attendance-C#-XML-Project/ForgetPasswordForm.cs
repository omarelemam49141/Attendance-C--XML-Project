using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static OfficeOpenXml.ExcelErrorValue;

namespace Attendance_C__XML_Project
{
    public partial class ForgetPasswordForm : Form
    {
        public ForgetPasswordForm()
        {
            InitializeComponent();
            SettingsManager.SettingsIntialization(this);
        }

        private void SendPasswordByEmail(string recipientEmail, string password)
        {
            try
            {
                // Sender's email address and credentials
                string senderEmail = "omar_elemam@outlook.com";
                string senderPassword = "_elemam1@123";

                // SMTP server details for Outlook.com
                string smtpServer = "smtp-mail.outlook.com";
                int smtpPort = 587;

                // Create a new MailMessage instance
                MailMessage mail = new MailMessage(senderEmail, recipientEmail);
                mail.From = new MailAddress(senderEmail);

                // Set the subject and body of the email
                mail.Subject = "recovery password";
                mail.Body = "[Your password is]: " + password;

                // Create a new SmtpClient instance
                SmtpClient smtpClient = new SmtpClient(smtpServer, smtpPort);

                // Enable SSL/TLS
                smtpClient.EnableSsl = true;

                // Set the credentials
                smtpClient.Credentials = new NetworkCredential(senderEmail, senderPassword);
                smtpClient.UseDefaultCredentials = false;

                // Send the email
                smtpClient.Send(mail);

                // Display success message
                MessageBox.Show("Email sent successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Display error message if sending fails
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

            private void btn_send_password_Click(object sender, EventArgs e)
        {
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            if (!Regex.IsMatch(txtEmail.Text, emailPattern))
            {
                //Validate the email
                lblErr.Text = "Invalid email format";
            }
            else
            {
                //Search for the email
                var teacher = Lists.teachersList.Find(teacher => teacher.Mail.ToLower() == txtEmail.Text.Trim().ToLower());
                if(teacher == null)
                {
                    var student = Lists.studentsList.Find(student => student.Mail.ToLower() == txtEmail.Text.Trim().ToLower());
                    if(student == null)
                    {
                        //email not found
                        lblErr.Text = "This email isn't registered within the system";
                    }
                    else
                    {
                        //get the student password and send it via mail
                        string studentPassword = student.Password, studentMail = student.Mail;
                        //empty the lblErr
                        lblErr.Text = "";
                        //send the password to the student mail
                        SendPasswordByEmail(studentMail, studentPassword);
                    }
                }
                else
                {
                    //get the teacher password and send it via mail
                    string teacherPassword = teacher.Password, teacherMail = teacher.Mail;
                    //empty the lblErr
                    lblErr.Text = "";
                    //send the password to the student mail
                    SendPasswordByEmail(teacherMail, teacherPassword);

                }
            }
        }

    }
}
