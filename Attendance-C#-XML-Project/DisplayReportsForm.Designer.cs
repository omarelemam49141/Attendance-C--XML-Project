namespace Attendance_C__XML_Project
{
    partial class DisplayReportsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayReportsForm));
            panel3 = new Panel();
            btnExit = new Button();
            label9 = new Label();
            panel1 = new Panel();
            lblRole = new Label();
            lblRoleName = new Label();
            lblWelcome = new Label();
            picStudent = new PictureBox();
            button3 = new Button();
            lblUserName = new Label();
            lblRoleError = new Label();
            lblDatePicker = new Label();
            dateTimePickerStart = new DateTimePicker();
            label1 = new Label();
            dateTimePickerEnd = new DateTimePicker();
            panelShow = new Panel();
            btnSearchReports = new Button();
            panelShowReports = new Panel();
            toolStrip = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripPageLabel = new ToolStripLabel();
            dgvViewReports = new DataGridView();
            btnExportPDF = new Button();
            btnExportExcel = new Button();
            button5 = new Button();
            button1 = new Button();
            button2 = new Button();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picStudent).BeginInit();
            panelShow.SuspendLayout();
            panelShowReports.SuspendLayout();
            toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvViewReports).BeginInit();
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
            // panel1
            // 
            resources.ApplyResources(panel1, "panel1");
            panel1.BackColor = Color.Gold;
            panel1.Controls.Add(lblRole);
            panel1.Controls.Add(lblRoleName);
            panel1.Controls.Add(lblWelcome);
            panel1.Controls.Add(picStudent);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(lblUserName);
            panel1.Controls.Add(lblRoleError);
            panel1.Name = "panel1";
            // 
            // lblRole
            // 
            resources.ApplyResources(lblRole, "lblRole");
            lblRole.Name = "lblRole";
            // 
            // lblRoleName
            // 
            resources.ApplyResources(lblRoleName, "lblRoleName");
            lblRoleName.Name = "lblRoleName";
            // 
            // lblWelcome
            // 
            resources.ApplyResources(lblWelcome, "lblWelcome");
            lblWelcome.Name = "lblWelcome";
            // 
            // picStudent
            // 
            resources.ApplyResources(picStudent, "picStudent");
            picStudent.Name = "picStudent";
            picStudent.TabStop = false;
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
            // lblDatePicker
            // 
            resources.ApplyResources(lblDatePicker, "lblDatePicker");
            lblDatePicker.Name = "lblDatePicker";
            // 
            // dateTimePickerStart
            // 
            resources.ApplyResources(dateTimePickerStart, "dateTimePickerStart");
            dateTimePickerStart.Name = "dateTimePickerStart";

            dateTimePickerStart.Size = new Size(250, 27);
            dateTimePickerStart.TabIndex = 38;
            dateTimePickerStart.ValueChanged += startdate_ValueChange;

            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // dateTimePickerEnd
            // 
            resources.ApplyResources(dateTimePickerEnd, "dateTimePickerEnd");
            dateTimePickerEnd.Name = "dateTimePickerEnd";

            dateTimePickerEnd.Size = new Size(250, 27);
            dateTimePickerEnd.TabIndex = 40;
            dateTimePickerEnd.ValueChanged += enddate_ValueChange;

            // 
            // panelShow
            // 
            resources.ApplyResources(panelShow, "panelShow");
            panelShow.Controls.Add(label1);
            panelShow.Controls.Add(dateTimePickerEnd);
            panelShow.Controls.Add(btnSearchReports);
            panelShow.Controls.Add(lblDatePicker);
            panelShow.Controls.Add(dateTimePickerStart);
            panelShow.Name = "panelShow";
            // 
            // btnSearchReports
            // 
            resources.ApplyResources(btnSearchReports, "btnSearchReports");
            btnSearchReports.BackColor = Color.Teal;
            btnSearchReports.FlatAppearance.BorderSize = 0;
            btnSearchReports.ForeColor = SystemColors.Control;
            btnSearchReports.Name = "btnSearchReports";
            btnSearchReports.UseVisualStyleBackColor = false;
            btnSearchReports.Click += btnSearchReports_Click;
            // 
            // panelShowReports
            // 
            resources.ApplyResources(panelShowReports, "panelShowReports");
            panelShowReports.Controls.Add(toolStrip);
            panelShowReports.Controls.Add(dgvViewReports);
            panelShowReports.Controls.Add(btnExportPDF);
            panelShowReports.Controls.Add(btnExportExcel);
            panelShowReports.Controls.Add(button5);
            panelShowReports.Controls.Add(button1);
            panelShowReports.Controls.Add(button2);
            panelShowReports.Name = "panelShowReports";
            panelShowReports.Paint += panelShowReports_Paint;
            // 
            // toolStrip
            // 
            resources.ApplyResources(toolStrip, "toolStrip");
            toolStrip.ImageScalingSize = new Size(20, 20);
            toolStrip.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, toolStripPageLabel });
            toolStrip.Name = "toolStrip";

            toolStrip.Size = new Size(96, 27);
            toolStrip.TabIndex = 33;
            toolStrip.Text = "toolStrip1";

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
            // dgvViewReports
            // 
            resources.ApplyResources(dgvViewReports, "dgvViewReports");
            dgvViewReports.AllowUserToAddRows = false;
            dgvViewReports.AllowUserToDeleteRows = false;
            dgvViewReports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvViewReports.BackgroundColor = SystemColors.Control;
            dgvViewReports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvViewReports.Name = "dgvViewReports";

            dgvViewReports.ReadOnly = true;
            dgvViewReports.RowHeadersWidth = 51;
            dgvViewReports.Size = new Size(872, 313);
            dgvViewReports.TabIndex = 32;

            // 
            // btnExportPDF
            // 
            resources.ApplyResources(btnExportPDF, "btnExportPDF");
            btnExportPDF.BackColor = Color.Teal;
            btnExportPDF.FlatAppearance.BorderSize = 0;
            btnExportPDF.ForeColor = SystemColors.Control;
            btnExportPDF.Name = "btnExportPDF";
            btnExportPDF.UseVisualStyleBackColor = false;
            btnExportPDF.Click += btnExportPDF_Click;
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
            // button5
            // 
            resources.ApplyResources(button5, "button5");
            button5.BackColor = Color.Teal;
            button5.FlatAppearance.BorderSize = 0;
            button5.ForeColor = SystemColors.Control;
            button5.Name = "button5";
            button5.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            button1.BackColor = Color.Teal;
            button1.FlatAppearance.BorderSize = 0;
            button1.ForeColor = SystemColors.Control;
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            resources.ApplyResources(button2, "button2");
            button2.BackColor = Color.Teal;
            button2.FlatAppearance.BorderSize = 0;
            button2.ForeColor = SystemColors.Control;
            button2.Name = "button2";
            button2.UseVisualStyleBackColor = false;
            // 
            // DisplayReportsForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelShowReports);
            Controls.Add(panelShow);
            Controls.Add(panel1);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DisplayReportsForm";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picStudent).EndInit();
            panelShow.ResumeLayout(false);
            panelShow.PerformLayout();
            panelShowReports.ResumeLayout(false);
            panelShowReports.PerformLayout();
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvViewReports).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Button btnExit;
        private Label label9;
        private Panel panel1;
        private Label lblRole;
        private Label lblRoleName;
        private Label lblWelcome;
        private PictureBox picStudent;
        private Button button3;
        private Label lblUserName;
        private Label lblRoleError;
        private Label lblDatePicker;
        private DateTimePicker dateTimePickerStart;
        private Label label1;
        private DateTimePicker dateTimePickerEnd;
        private Panel panelShow;
        private Button btnSearchReports;
        private Panel panelShowReports;
        private Button button5;
        private ListBox listBox2;
        private Button button1;
        private Button button2;
        private Button btnExportPDF;
        private Button btnExportExcel;
        private DataGridView dgvViewReports;
        private ToolStrip toolStrip;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripLabel toolStripPageLabel;
    }
}