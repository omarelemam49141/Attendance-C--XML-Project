using iTextSharp.text.pdf;
using iTextSharp.text;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Attendance_C__XML_Project
{
    public partial class TeacherForm : Form
    {
        List<AttendanceRecord> attendanceRecords;
        public TeacherForm()
        {
            InitializeComponent();
            // *** other dummy data ***
            attendanceRecords = new List<AttendanceRecord>
            {
                new AttendanceRecord(1,Lists.studentsList[0],AttendanceStatus.Absence){RecordDate = DateOnly.FromDateTime(DateTime.Now) },
                new AttendanceRecord(2,Lists.studentsList[0],AttendanceStatus.Absence){RecordDate = DateOnly.FromDateTime(DateTime.Now) },
                new AttendanceRecord(3,Lists.studentsList[0],AttendanceStatus.Presence){RecordDate = DateOnly.FromDateTime(DateTime.Now) },
                new AttendanceRecord(4,Lists.studentsList[1],AttendanceStatus.Presence){RecordDate = DateOnly.FromDateTime(DateTime.Now) },
                new AttendanceRecord(5,Lists.studentsList[0],AttendanceStatus.Absence){RecordDate = DateOnly.FromDateTime(DateTime.Now) },
            };

            //**************** GUI Init *************
            panelShowStudents.Hide();
            //**************** End Of GUI Init *************
            dateTimePicker.Value = DateTime.Now;
            comboClasses.SelectedIndex = 0;


            try
            {
                lblUserName.Text = GetTeacherName();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                TeacherLogout();
                throw;
            }


            // Load Teacher Role
            try
            {
                lblRoleName.Text = GetTeacherRole();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                TeacherLogout();
                throw;
            }

            // Get Class List into ComboBox
            List<string> myClasses = GetTeacherClasses();
            foreach (var cls in myClasses)
            {
                comboClasses.Items.Add(cls);
            }


        }

        private void btnShowReport_Click(object sender, EventArgs e)
        {
            panelShowStudents.Show();
            // load the students reports


            LoadStudentReports(dateTimePicker.Value, comboClasses.Text);


        }

        private void LoadStudentReports(DateTime mydate, string className)
        {
            //dgvViewStudents.Columns.Add("Column1", "Attendance Date");
            //dgvViewStudents.Columns.Add("Column2", "Status");

            //var classId = GetClassIdFromName(className);
            //if( classId != null )
            //{

            //    attendanceRecords.Where(record => (record.ClassID == classId&&record.RecordDate== mydate));

            //}
            //else
            //{
            //    throw new Exception("No Class with that name");
            //}

        }
        private string GetClassNameFromID(int id)
        {
            string? className = Lists.classes.Find(c => c.ID == id)?.Name;

            return className;
        }
        private int? GetClassIdFromName(string className)
        {
            int? classId = Lists.classes.Find(c => c.Name.ToLower() == className.ToLower())?.ID;
            return classId;
        }

        private string GetTeacherName()
        {
            if (LoggedInUser.Name != "")
            {
                return LoggedInUser.Name;
            }
            throw new Exception("Can't Find UserName");
        }
        private string GetTeacherRole()
        {

            var role = LoggedInUser.userRole.ToString();

            if (role != null)
            {
                return role;
            }
            throw new Exception("Can't Find Teacher Role");
        }
        private List<string> GetTeacherClasses()
        {
            //var teacher = teachersList.Find(t =>t.Username.ToLower()== MyLoggedInUser.Name.ToLower());

            // For Now i will display all classes
            List<string> classNames = Lists.classes.Select(c => c.Name).ToList();
            return classNames;
        }
        private void TeacherLogout()
        {
            LoggedInUser.Name = string.Empty;
            LoggedInUser.userRole = (Role)(-1);
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
            this.Close();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            PreferencesForm preferencesForm = new PreferencesForm();
            preferencesForm.Show();
            this.Hide();
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            ExportToExcel(dgvViewStudents);
        }
        private void ExportToExcel(DataGridView dataGridView)
        {
            using (ExcelPackage excelPackage = new ExcelPackage())
            {
                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Sheet1");

                // Export DataGridView headers to Excel
                for (int i = 0; i < dataGridView.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1].Value = dataGridView.Columns[i].HeaderText;
                }

                // Export DataGridView rows to Excel
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1].Value = dataGridView.Rows[i].Cells[j].Value?.ToString();
                    }
                }

                // Save the Excel file
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel Workbook (*.xlsx)|*.xlsx";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileInfo fileInfo = new FileInfo(saveFileDialog.FileName);
                    excelPackage.SaveAs(fileInfo);
                    MessageBox.Show("Exported to Excel successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnExportPDF(object sender, EventArgs e)
        {
            ExportPDF(dgvViewStudents);
        }
        private void ExportPDF(DataGridView dataGridView)
        {
            if (dataGridView.Rows.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (*.pdf)|*.pdf";
                save.FileName = "Result.pdf";
                bool ErrorMessage = false;
                if (save.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(save.FileName))
                    {
                        try
                        {
                            File.Delete(save.FileName);
                        }
                        catch (Exception ex)
                        {
                            ErrorMessage = true;
                            MessageBox.Show("Unable to wride data in disk" + ex.Message);
                        }
                    }
                    if (!ErrorMessage)
                    {
                        try
                        {
                            PdfPTable pTable = new PdfPTable(dataGridView.Columns.Count);
                            pTable.DefaultCell.Padding = 2;
                            pTable.WidthPercentage = 100;
                            pTable.HorizontalAlignment = Element.ALIGN_LEFT;
                            foreach (DataGridViewColumn col in dataGridView.Columns)
                            {
                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));
                                pTable.AddCell(pCell);
                            }
                            foreach (DataGridViewRow viewRow in dataGridView.Rows)
                            {
                                foreach (DataGridViewCell dcell in viewRow.Cells)
                                {
                                    if (dcell.Value != null) // Check if the cell value is not null
                                    {
                                        pTable.AddCell(dcell.Value.ToString());
                                    }
                                    else
                                    {
                                        pTable.AddCell(""); // Add an empty string or placeholder text for null values
                                    }
                                }
                            }
                            using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))
                            {
                                iTextSharp.text.Document document = new iTextSharp.text.Document(PageSize.A4, 8f, 16f, 16f, 8f);
                                PdfWriter.GetInstance(document, fileStream);
                                document.Open();
                                document.Add(pTable);
                                document.Close();
                                fileStream.Close();
                            }
                            MessageBox.Show("Data Export Successfully", "info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error while exporting Data" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record Found", "Info");
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            TeacherLogout();
        }
    }
}
