namespace Attendance_C__XML_Project
{
    partial class StudentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
            panel3 = new Panel();
            btnExit = new Button();
            label9 = new Label();
            btnShowReport = new Button();
            lblAttended = new Label();
            lblAbsent = new Label();
            lblAbsentNum = new Label();
            lblAttendedNum = new Label();
            btnExportExcel = new Button();
            btnPrintReport = new Button();
            picStudent = new PictureBox();
            panel1 = new Panel();
            lblClass = new Label();
            lblWelcome = new Label();
            lblClassName = new Label();
            btnSetting = new Button();
            button3 = new Button();
            lblUserName = new Label();
            lblRoleError = new Label();
            panelShow = new Panel();
            panelAttendanceTable = new Panel();
            toolStrip = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripPageLabel = new ToolStripLabel();
            dgvStudentReports = new DataGridView();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picStudent).BeginInit();
            panel1.SuspendLayout();
            panelShow.SuspendLayout();
            panelAttendanceTable.SuspendLayout();
            toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudentReports).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            resources.ApplyResources(panel3, "panel3");
            panel3.BackColor = Color.FromArgb(73, 178, 202);
            panel3.Controls.Add(btnExit);
            panel3.Controls.Add(label9);
            panel3.Name = "panel3";
            // 
            // btnExit
            // 
            resources.ApplyResources(btnExit, "btnExit");
            btnExit.Cursor = Cursors.Hand;
            btnExit.Name = "btnExit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label9
            // 
            resources.ApplyResources(label9, "label9");
            label9.ForeColor = Color.White;
            label9.Name = "label9";
            // 
            // btnShowReport
            // 
            resources.ApplyResources(btnShowReport, "btnShowReport");
            btnShowReport.BackColor = Color.Teal;
            btnShowReport.FlatAppearance.BorderSize = 0;
            btnShowReport.ForeColor = SystemColors.Control;
            btnShowReport.Name = "btnShowReport";
            btnShowReport.UseVisualStyleBackColor = false;
            btnShowReport.Click += btnShowReport_Click;
            // 
            // lblAttended
            // 
            resources.ApplyResources(lblAttended, "lblAttended");
            lblAttended.Name = "lblAttended";
            // 
            // lblAbsent
            // 
            resources.ApplyResources(lblAbsent, "lblAbsent");
            lblAbsent.Name = "lblAbsent";
            // 
            // lblAbsentNum
            // 
            resources.ApplyResources(lblAbsentNum, "lblAbsentNum");
            lblAbsentNum.BackColor = Color.Transparent;
            lblAbsentNum.ForeColor = Color.Black;
            lblAbsentNum.Name = "lblAbsentNum";
            // 
            // lblAttendedNum
            // 
            resources.ApplyResources(lblAttendedNum, "lblAttendedNum");
            lblAttendedNum.BackColor = Color.Transparent;
            lblAttendedNum.ForeColor = Color.Black;
            lblAttendedNum.Name = "lblAttendedNum";
            // 
            // btnExportExcel
            // 
            resources.ApplyResources(btnExportExcel, "btnExportExcel");
            btnExportExcel.BackColor = Color.Teal;
            btnExportExcel.FlatAppearance.BorderSize = 0;
            btnExportExcel.ForeColor = SystemColors.Control;
            btnExportExcel.Name = "btnExportExcel";
            btnExportExcel.UseVisualStyleBackColor = false;
            btnExportExcel.Click += btnExportExcel_Click;
            // 
            // btnPrintReport
            // 
            resources.ApplyResources(btnPrintReport, "btnPrintReport");
            btnPrintReport.BackColor = Color.Teal;
            btnPrintReport.FlatAppearance.BorderSize = 0;
            btnPrintReport.ForeColor = SystemColors.Control;
            btnPrintReport.Name = "btnPrintReport";
            btnPrintReport.UseVisualStyleBackColor = false;
            btnPrintReport.Click += btnPrintReport_Click;
            // 
            // picStudent
            // 
            resources.ApplyResources(picStudent, "picStudent");
            picStudent.Name = "picStudent";
            picStudent.TabStop = false;
            // 
            // panel1
            // 
            resources.ApplyResources(panel1, "panel1");
            panel1.BackColor = Color.Gold;
            panel1.Controls.Add(lblClass);
            panel1.Controls.Add(lblWelcome);
            panel1.Controls.Add(lblClassName);
            panel1.Controls.Add(btnSetting);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(lblUserName);
            panel1.Controls.Add(lblRoleError);
            panel1.Controls.Add(picStudent);
            panel1.Controls.Add(lblAttended);
            panel1.Controls.Add(lblAbsent);
            panel1.Controls.Add(lblAttendedNum);
            panel1.Controls.Add(lblAbsentNum);
            panel1.Name = "panel1";
            // 
            // lblClass
            // 
            resources.ApplyResources(lblClass, "lblClass");
            lblClass.Name = "lblClass";
            // 
            // lblWelcome
            // 
            resources.ApplyResources(lblWelcome, "lblWelcome");
            lblWelcome.Name = "lblWelcome";
            // 
            // lblClassName
            // 
            resources.ApplyResources(lblClassName, "lblClassName");
            lblClassName.Name = "lblClassName";
            // 
            // btnSetting
            // 
            resources.ApplyResources(btnSetting, "btnSetting");
            btnSetting.BackColor = Color.Transparent;
            btnSetting.FlatAppearance.BorderSize = 0;
            btnSetting.ForeColor = Color.Black;
            btnSetting.Name = "btnSetting";
            btnSetting.UseVisualStyleBackColor = false;
            btnSetting.Click += btnSetting_Click;
            // 
            // button3
            // 
            resources.ApplyResources(button3, "button3");
            button3.BackColor = Color.Transparent;
            button3.FlatAppearance.BorderSize = 0;
            button3.ForeColor = Color.Black;
            button3.Name = "button3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += btnLogout_Click;
            // 
            // lblUserName
            // 
            resources.ApplyResources(lblUserName, "lblUserName");
            lblUserName.Name = "lblUserName";
            // 
            // lblRoleError
            // 
            resources.ApplyResources(lblRoleError, "lblRoleError");
            lblRoleError.ForeColor = Color.IndianRed;
            lblRoleError.Name = "lblRoleError";
            // 
            // panelShow
            // 
            resources.ApplyResources(panelShow, "panelShow");
            panelShow.Controls.Add(btnShowReport);
            panelShow.Name = "panelShow";
            panelShow.Tag = "myTheme";
            panelShow.Paint += panelShow_Paint;
            // 
            // panelAttendanceTable
            // 
            resources.ApplyResources(panelAttendanceTable, "panelAttendanceTable");
            panelAttendanceTable.Controls.Add(toolStrip);
            panelAttendanceTable.Controls.Add(dgvStudentReports);
            panelAttendanceTable.Controls.Add(btnPrintReport);
            panelAttendanceTable.Controls.Add(btnExportExcel);
            panelAttendanceTable.Name = "panelAttendanceTable";
            panelAttendanceTable.Tag = "";
            // 
            // toolStrip
            // 
            resources.ApplyResources(toolStrip, "toolStrip");
            toolStrip.ImageScalingSize = new Size(20, 20);
            toolStrip.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, toolStripPageLabel });
            toolStrip.Name = "toolStrip";
            // 
            // toolStripButton1
            // 
            resources.ApplyResources(toolStripButton1, "toolStripButton1");
            toolStripButton1.BackColor = SystemColors.Control;
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripButton2
            // 
            resources.ApplyResources(toolStripButton2, "toolStripButton2");
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // toolStripPageLabel
            // 
            resources.ApplyResources(toolStripPageLabel, "toolStripPageLabel");
            toolStripPageLabel.Name = "toolStripPageLabel";
            // 
            // dgvStudentReports
            // 
            resources.ApplyResources(dgvStudentReports, "dgvStudentReports");
            dgvStudentReports.AllowUserToAddRows = false;
            dgvStudentReports.AllowUserToDeleteRows = false;
            dgvStudentReports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStudentReports.BackgroundColor = SystemColors.Control;
            dgvStudentReports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudentReports.Name = "dgvStudentReports";
            dgvStudentReports.ReadOnly = true;
            dgvStudentReports.Tag = "";
            // 
            // StudentForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelAttendanceTable);
            Controls.Add(panelShow);
            Controls.Add(panel1);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StudentForm";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picStudent).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelShow.ResumeLayout(false);
            panelAttendanceTable.ResumeLayout(false);
            panelAttendanceTable.PerformLayout();
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudentReports).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Label label9;
        private Button btnShowReport;
        private Label lblAttended;
        private Label lblAbsent;
        private Label lblAbsentNum;
        private Label lblAttendedNum;
        private Button btnExportExcel;
        private Button btnPrintReport;
        private PictureBox picStudent;
        private Panel panel1;
        private Label lblRoleError;
        private Button button3;
        private Label lblUserName;
        private Button btnSetting;
        private Panel panelShow;
        private Panel panelAttendanceTable;
        private Label lblClassName;
        private Label lblClass;
        private Label lblWelcome;
        private Button btnExit;
        private DataGridView dgvStudentReports;
        private ToolStrip toolStrip;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripLabel toolStripPageLabel;
    }
}