namespace Attendance_C__XML_Project
{
    partial class TeacherForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherForm));
            panelShow = new Panel();
            btnNewReport = new Button();
            checkBox1 = new CheckBox();
            lblDatePicker = new Label();
            dateTimePicker = new DateTimePicker();
            btnShowReport = new Button();
            lblClassPicker = new Label();
            comboClasses = new ComboBox();
            lblRole = new Label();
            lblWelcome = new Label();
            lblRoleName = new Label();
            btnSetting = new Button();
            button3 = new Button();
            lblUserName = new Label();
            lblRoleError = new Label();
            panel1 = new Panel();
            picStudent = new PictureBox();
            btnExit = new Button();
            label9 = new Label();
            panelAttendanceTable = new Panel();
            panelShowStudents = new Panel();
            btnsaveXml = new Button();
            toolStrip = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripPageLabel = new ToolStripLabel();
            dgvViewStudents = new DataGridView();
            btnSave = new Button();
            btnPrint = new Button();
            btnExcel = new Button();
            btnPDF = new Button();
            panel3 = new Panel();
            panelShow.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picStudent).BeginInit();
            panelAttendanceTable.SuspendLayout();
            panelShowStudents.SuspendLayout();
            toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvViewStudents).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panelShow
            // 
            resources.ApplyResources(panelShow, "panelShow");
            panelShow.Controls.Add(btnNewReport);
            panelShow.Controls.Add(checkBox1);
            panelShow.Controls.Add(lblDatePicker);
            panelShow.Controls.Add(dateTimePicker);
            panelShow.Controls.Add(btnShowReport);
            panelShow.Controls.Add(lblClassPicker);
            panelShow.Controls.Add(comboClasses);
            panelShow.Name = "panelShow";
            panelShow.Tag = "myTheme";
            panelShow.Paint += panelShow_Paint;
            // 
            // btnNewReport
            // 
            resources.ApplyResources(btnNewReport, "btnNewReport");
            btnNewReport.BackColor = Color.Blue;
            btnNewReport.FlatAppearance.BorderSize = 0;
            btnNewReport.ForeColor = SystemColors.Control;
            btnNewReport.Name = "btnNewReport";
            btnNewReport.UseVisualStyleBackColor = false;
            btnNewReport.Click += btnNewReport_Click;
            // 
            // checkBox1
            // 
            resources.ApplyResources(checkBox1, "checkBox1");
            checkBox1.Name = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += AttendAll_CheckedChanged;
            // 
            // lblDatePicker
            // 
            resources.ApplyResources(lblDatePicker, "lblDatePicker");
            lblDatePicker.Name = "lblDatePicker";
            // 
            // dateTimePicker
            // 
            resources.ApplyResources(dateTimePicker, "dateTimePicker");
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.ValueChanged += Date_ValueChanged;
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
            // lblClassPicker
            // 
            resources.ApplyResources(lblClassPicker, "lblClassPicker");
            lblClassPicker.Name = "lblClassPicker";
            // 
            // comboClasses
            // 
            resources.ApplyResources(comboClasses, "comboClasses");
            comboClasses.FormattingEnabled = true;
            comboClasses.Name = "comboClasses";
            // 
            // lblRole
            // 
            resources.ApplyResources(lblRole, "lblRole");
            lblRole.Name = "lblRole";
            // 
            // lblWelcome
            // 
            resources.ApplyResources(lblWelcome, "lblWelcome");
            lblWelcome.Name = "lblWelcome";
            // 
            // lblRoleName
            // 
            resources.ApplyResources(lblRoleName, "lblRoleName");
            lblRoleName.Name = "lblRoleName";
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
            // panel1
            // 
            resources.ApplyResources(panel1, "panel1");
            panel1.BackColor = Color.Gold;
            panel1.Controls.Add(lblRole);
            panel1.Controls.Add(lblWelcome);
            panel1.Controls.Add(lblRoleName);
            panel1.Controls.Add(btnSetting);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(lblUserName);
            panel1.Controls.Add(lblRoleError);
            panel1.Controls.Add(picStudent);
            panel1.Name = "panel1";
            // 
            // picStudent
            // 
            resources.ApplyResources(picStudent, "picStudent");
            picStudent.Name = "picStudent";
            picStudent.TabStop = false;
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
            // panelAttendanceTable
            // 
            resources.ApplyResources(panelAttendanceTable, "panelAttendanceTable");
            panelAttendanceTable.Controls.Add(panelShowStudents);
            panelAttendanceTable.Name = "panelAttendanceTable";
            // 
            // panelShowStudents
            // 
            resources.ApplyResources(panelShowStudents, "panelShowStudents");
            panelShowStudents.Controls.Add(btnsaveXml);
            panelShowStudents.Controls.Add(toolStrip);
            panelShowStudents.Controls.Add(dgvViewStudents);
            panelShowStudents.Controls.Add(btnSave);
            panelShowStudents.Controls.Add(btnPrint);
            panelShowStudents.Controls.Add(btnExcel);
            panelShowStudents.Controls.Add(btnPDF);
            panelShowStudents.Name = "panelShowStudents";
            panelShowStudents.Tag = "myTheme";
            // 
            // btnsaveXml
            // 
            resources.ApplyResources(btnsaveXml, "btnsaveXml");
            btnsaveXml.BackColor = Color.Teal;
            btnsaveXml.FlatAppearance.BorderSize = 0;
            btnsaveXml.ForeColor = SystemColors.Control;
            btnsaveXml.Name = "btnsaveXml";
            btnsaveXml.UseVisualStyleBackColor = false;
            btnsaveXml.Click += btnSave_Click;
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
            toolStripButton1.Click += prevPage_Click;
            // 
            // toolStripButton2
            // 
            resources.ApplyResources(toolStripButton2, "toolStripButton2");
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Click += nextPage_Click;
            // 
            // toolStripPageLabel
            // 
            resources.ApplyResources(toolStripPageLabel, "toolStripPageLabel");
            toolStripPageLabel.Name = "toolStripPageLabel";
            // 
            // dgvViewStudents
            // 
            resources.ApplyResources(dgvViewStudents, "dgvViewStudents");
            dgvViewStudents.AllowUserToAddRows = false;
            dgvViewStudents.AllowUserToDeleteRows = false;
            dgvViewStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvViewStudents.BackgroundColor = SystemColors.Control;
            dgvViewStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvViewStudents.Name = "dgvViewStudents";
            dgvViewStudents.CellContentClick += dgvViewStudents_CellContentClick;
            // 
            // btnSave
            // 
            resources.ApplyResources(btnSave, "btnSave");
            btnSave.BackColor = Color.Teal;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.ForeColor = SystemColors.Control;
            btnSave.Name = "btnSave";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnPrint
            // 
            resources.ApplyResources(btnPrint, "btnPrint");
            btnPrint.BackColor = Color.Teal;
            btnPrint.FlatAppearance.BorderSize = 0;
            btnPrint.ForeColor = SystemColors.Control;
            btnPrint.Name = "btnPrint";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnExportPDF;
            // 
            // btnExcel
            // 
            resources.ApplyResources(btnExcel, "btnExcel");
            btnExcel.BackColor = Color.Teal;
            btnExcel.FlatAppearance.BorderSize = 0;
            btnExcel.ForeColor = SystemColors.Control;
            btnExcel.Name = "btnExcel";
            btnExcel.UseVisualStyleBackColor = false;
            btnExcel.Click += btnExportExcel_Click;
            // 
            // btnPDF
            // 
            resources.ApplyResources(btnPDF, "btnPDF");
            btnPDF.BackColor = Color.Teal;
            btnPDF.FlatAppearance.BorderSize = 0;
            btnPDF.ForeColor = SystemColors.Control;
            btnPDF.Name = "btnPDF";
            btnPDF.UseVisualStyleBackColor = false;
            btnPDF.Click += btnExportPDF;
            // 
            // panel3
            // 
            resources.ApplyResources(panel3, "panel3");
            panel3.BackColor = Color.FromArgb(73, 178, 202);
            panel3.Controls.Add(btnExit);
            panel3.Controls.Add(label9);
            panel3.Name = "panel3";
            // 
            // TeacherForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelShow);
            Controls.Add(panel1);
            Controls.Add(panelAttendanceTable);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TeacherForm";
            panelShow.ResumeLayout(false);
            panelShow.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picStudent).EndInit();
            panelAttendanceTable.ResumeLayout(false);
            panelShowStudents.ResumeLayout(false);
            panelShowStudents.PerformLayout();
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvViewStudents).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelShow;
        private Button btnShowReport;
        private Label lblRole;
        private Label lblWelcome;
        private Label lblRoleName;
        private Button btnSetting;
        private Button button3;
        private Label lblUserName;
        private Label lblRoleError;
        private Panel panel1;
        private PictureBox picStudent;
        private Button btnExit;
        private Label label9;
        private Panel panelAttendanceTable;
        private Panel panel3;
        private Label lblClassPicker;
        private ComboBox comboClasses;
        private Label lblDatePicker;
        private DateTimePicker dateTimePicker;
        private CheckBox checkBox1;
        private Panel panelShowStudents;
        private DataGridView dgvViewStudents;
        private Button btnSave;
        private Button btnPrint;
        private Button btnExcel;
        private Button btnPDF;
        private ToolStrip toolStrip;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripLabel toolStripPageLabel;
        private Button btnNewReport;
        private Button btnsaveXml;
    }
}