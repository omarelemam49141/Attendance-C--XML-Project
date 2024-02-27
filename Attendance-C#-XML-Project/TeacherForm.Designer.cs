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
            toolStrip = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripPageLabel = new ToolStripLabel();
            dgvViewStudents = new DataGridView();
            btnSave = new Button();
            button1 = new Button();
            button2 = new Button();
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
            panelShow.Controls.Add(checkBox1);
            panelShow.Controls.Add(lblDatePicker);
            panelShow.Controls.Add(dateTimePicker);
            panelShow.Controls.Add(btnShowReport);
            panelShow.Controls.Add(lblClassPicker);
            panelShow.Controls.Add(comboClasses);
            panelShow.Dock = DockStyle.Top;
            panelShow.Location = new Point(0, 151);
            panelShow.Name = "panelShow";
            panelShow.Size = new Size(896, 125);
            panelShow.TabIndex = 34;
            panelShow.Paint += panelShow_Paint;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 11F);
            checkBox1.Location = new Point(734, 81);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(117, 29);
            checkBox1.TabIndex = 39;
            checkBox1.Text = "Attend All";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += AttendAll_CheckedChanged;
            // 
            // lblDatePicker
            // 
            lblDatePicker.AutoSize = true;
            lblDatePicker.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDatePicker.Location = new Point(78, 23);
            lblDatePicker.Name = "lblDatePicker";
            lblDatePicker.Size = new Size(56, 22);
            lblDatePicker.TabIndex = 37;
            lblDatePicker.Text = "Date";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(150, 18);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(250, 27);
            dateTimePicker.TabIndex = 36;
            dateTimePicker.ValueChanged += Date_ValueChanged;
            // 
            // btnShowReport
            // 
            btnShowReport.BackColor = Color.Teal;
            btnShowReport.FlatAppearance.BorderSize = 0;
            btnShowReport.FlatStyle = FlatStyle.Flat;
            btnShowReport.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShowReport.ForeColor = SystemColors.Control;
            btnShowReport.Image = (Image)resources.GetObject("btnShowReport.Image");
            btnShowReport.Location = new Point(644, 5);
            btnShowReport.Margin = new Padding(3, 4, 3, 4);
            btnShowReport.Name = "btnShowReport";
            btnShowReport.Size = new Size(140, 53);
            btnShowReport.TabIndex = 20;
            btnShowReport.Text = "Search";
            btnShowReport.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnShowReport.UseVisualStyleBackColor = false;
            btnShowReport.Click += btnShowReport_Click;
            // 
            // lblClassPicker
            // 
            lblClassPicker.AutoSize = true;
            lblClassPicker.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblClassPicker.Location = new Point(78, 72);
            lblClassPicker.Name = "lblClassPicker";
            lblClassPicker.Size = new Size(111, 22);
            lblClassPicker.TabIndex = 35;
            lblClassPicker.Text = "class name";
            // 
            // comboClasses
            // 
            comboClasses.FlatStyle = FlatStyle.Flat;
            comboClasses.FormattingEnabled = true;
            comboClasses.Location = new Point(195, 70);
            comboClasses.Margin = new Padding(3, 4, 3, 4);
            comboClasses.Name = "comboClasses";
            comboClasses.Size = new Size(158, 28);
            comboClasses.TabIndex = 21;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Century Gothic", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRole.Location = new Point(111, 49);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(55, 23);
            lblRole.TabIndex = 34;
            lblRole.Text = "Role:";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Century Gothic", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(111, 12);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(108, 23);
            lblWelcome.TabIndex = 33;
            lblWelcome.Text = "Welcome: ";
            // 
            // lblRoleName
            // 
            lblRoleName.AutoSize = true;
            lblRoleName.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRoleName.Location = new Point(215, 50);
            lblRoleName.Name = "lblRoleName";
            lblRoleName.Size = new Size(102, 22);
            lblRoleName.TabIndex = 32;
            lblRoleName.Text = "role name";
            // 
            // btnSetting
            // 
            btnSetting.BackColor = Color.Transparent;
            btnSetting.FlatAppearance.BorderSize = 0;
            btnSetting.FlatStyle = FlatStyle.Flat;
            btnSetting.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSetting.ForeColor = Color.Black;
            btnSetting.Image = (Image)resources.GetObject("btnSetting.Image");
            btnSetting.ImageAlign = ContentAlignment.MiddleLeft;
            btnSetting.Location = new Point(851, 49);
            btnSetting.Margin = new Padding(3, 4, 3, 4);
            btnSetting.Name = "btnSetting";
            btnSetting.Size = new Size(42, 36);
            btnSetting.TabIndex = 31;
            btnSetting.UseVisualStyleBackColor = false;
            btnSetting.Click += btnSetting_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Black;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(851, 8);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(39, 37);
            button3.TabIndex = 30;
            button3.UseVisualStyleBackColor = false;
            button3.Click += btnLogout_Click;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserName.Location = new Point(215, 12);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(106, 22);
            lblUserName.TabIndex = 29;
            lblUserName.Text = "user name";
            // 
            // lblRoleError
            // 
            lblRoleError.AutoSize = true;
            lblRoleError.ForeColor = Color.IndianRed;
            lblRoleError.Location = new Point(147, 563);
            lblRoleError.MaximumSize = new Size(159, 0);
            lblRoleError.Name = "lblRoleError";
            lblRoleError.Size = new Size(0, 20);
            lblRoleError.TabIndex = 27;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gold;
            panel1.Controls.Add(lblRole);
            panel1.Controls.Add(lblWelcome);
            panel1.Controls.Add(lblRoleName);
            panel1.Controls.Add(btnSetting);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(lblUserName);
            panel1.Controls.Add(lblRoleError);
            panel1.Controls.Add(picStudent);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 49);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(896, 102);
            panel1.TabIndex = 33;
            // 
            // picStudent
            // 
            picStudent.BackgroundImageLayout = ImageLayout.Center;
            picStudent.Image = (Image)resources.GetObject("picStudent.Image");
            picStudent.Location = new Point(3, 3);
            picStudent.Name = "picStudent";
            picStudent.Size = new Size(107, 111);
            picStudent.TabIndex = 28;
            picStudent.TabStop = false;
            // 
            // btnExit
            // 
            btnExit.BackgroundImage = (Image)resources.GetObject("btnExit.BackgroundImage");
            btnExit.BackgroundImageLayout = ImageLayout.Zoom;
            btnExit.Cursor = Cursors.Hand;
            btnExit.Dock = DockStyle.Right;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Location = new Point(851, 0);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(45, 49);
            btnExit.TabIndex = 9;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(3, 9);
            label9.Name = "label9";
            label9.Size = new Size(125, 25);
            label9.TabIndex = 8;
            label9.Text = "Teacher Form";
            // 
            // panelAttendanceTable
            // 
            panelAttendanceTable.Controls.Add(panelShowStudents);
            panelAttendanceTable.Dock = DockStyle.Fill;
            panelAttendanceTable.Location = new Point(0, 49);
            panelAttendanceTable.Name = "panelAttendanceTable";
            panelAttendanceTable.Size = new Size(896, 741);
            panelAttendanceTable.TabIndex = 35;
            // 
            // panelShowStudents
            // 
            panelShowStudents.Controls.Add(toolStrip);
            panelShowStudents.Controls.Add(dgvViewStudents);
            panelShowStudents.Controls.Add(btnSave);
            panelShowStudents.Controls.Add(button1);
            panelShowStudents.Controls.Add(button2);
            panelShowStudents.Dock = DockStyle.Fill;
            panelShowStudents.Location = new Point(0, 0);
            panelShowStudents.Name = "panelShowStudents";
            panelShowStudents.Size = new Size(896, 741);
            panelShowStudents.TabIndex = 33;
            // 
            // toolStrip
            // 
            toolStrip.Dock = DockStyle.None;
            toolStrip.ImageScalingSize = new Size(20, 20);
            toolStrip.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, toolStripPageLabel });
            toolStrip.Location = new Point(12, 549);
            toolStrip.Name = "toolStrip";
            toolStrip.Size = new Size(96, 27);
            toolStrip.TabIndex = 31;
            toolStrip.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.BackColor = SystemColors.Control;
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(29, 24);
            toolStripButton1.Text = "previous";
            toolStripButton1.Click += prevPage_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(29, 24);
            toolStripButton2.Text = "next";
            toolStripButton2.Click += nextPage_Click;
            // 
            // toolStripPageLabel
            // 
            toolStripPageLabel.Name = "toolStripPageLabel";
            toolStripPageLabel.Size = new Size(25, 24);
            toolStripPageLabel.Text = "00";
            // 
            // dgvViewStudents
            // 
            dgvViewStudents.AllowUserToAddRows = false;
            dgvViewStudents.AllowUserToDeleteRows = false;
            dgvViewStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvViewStudents.BackgroundColor = SystemColors.Control;
            dgvViewStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvViewStudents.Location = new Point(12, 233);
            dgvViewStudents.Name = "dgvViewStudents";
            dgvViewStudents.RowHeadersWidth = 51;
            dgvViewStudents.Size = new Size(872, 313);
            dgvViewStudents.TabIndex = 30;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Teal;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = SystemColors.Control;
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.Location = new Point(685, 648);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(131, 80);
            btnSave.TabIndex = 29;
            btnSave.Text = "Save";
            btnSave.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Teal;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Control;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(91, 648);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(176, 80);
            button1.TabIndex = 27;
            button1.Text = "Print Pdf";
            button1.TextImageRelation = TextImageRelation.TextBeforeImage;
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Teal;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.Control;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(371, 648);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(189, 80);
            button2.TabIndex = 26;
            button2.Text = "Export Excel";
            button2.TextImageRelation = TextImageRelation.TextBeforeImage;
            button2.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(73, 178, 202);
            panel3.Controls.Add(btnExit);
            panel3.Controls.Add(label9);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(896, 49);
            panel3.TabIndex = 32;
            // 
            // TeacherForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 790);
            Controls.Add(panelShow);
            Controls.Add(panel1);
            Controls.Add(panelAttendanceTable);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TeacherForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TeacherForm";
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
        private Button button1;
        private Button button2;
        private ToolStrip toolStrip;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripLabel toolStripPageLabel;
    }
}