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
            panel3.BackColor = Color.FromArgb(73, 178, 202);
            panel3.Controls.Add(btnExit);
            panel3.Controls.Add(label9);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(896, 49);
            panel3.TabIndex = 21;
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
            label9.Size = new Size(184, 25);
            label9.TabIndex = 8;
            label9.Text = "DisplayReports Form";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gold;
            panel1.Controls.Add(lblRole);
            panel1.Controls.Add(lblRoleName);
            panel1.Controls.Add(lblWelcome);
            panel1.Controls.Add(picStudent);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(lblUserName);
            panel1.Controls.Add(lblRoleError);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 49);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(896, 100);
            panel1.TabIndex = 32;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Century Gothic", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRole.Location = new Point(111, 52);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(55, 23);
            lblRole.TabIndex = 36;
            lblRole.Text = "Role:";
            // 
            // lblRoleName
            // 
            lblRoleName.AutoSize = true;
            lblRoleName.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRoleName.Location = new Point(215, 53);
            lblRoleName.Name = "lblRoleName";
            lblRoleName.Size = new Size(102, 22);
            lblRoleName.TabIndex = 35;
            lblRoleName.Text = "role name";
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
            // picStudent
            // 
            picStudent.Image = (Image)resources.GetObject("picStudent.Image");
            picStudent.Location = new Point(12, 0);
            picStudent.Name = "picStudent";
            picStudent.Size = new Size(93, 96);
            picStudent.TabIndex = 28;
            picStudent.TabStop = false;
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
            // lblDatePicker
            // 
            lblDatePicker.AutoSize = true;
            lblDatePicker.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDatePicker.Location = new Point(47, 47);
            lblDatePicker.Name = "lblDatePicker";
            lblDatePicker.Size = new Size(103, 22);
            lblDatePicker.TabIndex = 39;
            lblDatePicker.Text = "Start Date";
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.Location = new Point(156, 43);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(250, 27);
            dateTimePickerStart.TabIndex = 38;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(450, 46);
            label1.Name = "label1";
            label1.Size = new Size(96, 22);
            label1.TabIndex = 41;
            label1.Text = "End Date";
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.Location = new Point(559, 42);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(250, 27);
            dateTimePickerEnd.TabIndex = 40;
            // 
            // panelShow
            // 
            panelShow.Controls.Add(label1);
            panelShow.Controls.Add(dateTimePickerEnd);
            panelShow.Controls.Add(btnSearchReports);
            panelShow.Controls.Add(lblDatePicker);
            panelShow.Controls.Add(dateTimePickerStart);
            panelShow.Dock = DockStyle.Top;
            panelShow.Location = new Point(0, 149);
            panelShow.Name = "panelShow";
            panelShow.Size = new Size(896, 161);
            panelShow.TabIndex = 42;
            // 
            // btnSearchReports
            // 
            btnSearchReports.BackColor = Color.Teal;
            btnSearchReports.FlatAppearance.BorderSize = 0;
            btnSearchReports.FlatStyle = FlatStyle.Flat;
            btnSearchReports.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearchReports.ForeColor = SystemColors.Control;
            btnSearchReports.Image = (Image)resources.GetObject("btnSearchReports.Image");
            btnSearchReports.Location = new Point(371, 92);
            btnSearchReports.Margin = new Padding(3, 4, 3, 4);
            btnSearchReports.Name = "btnSearchReports";
            btnSearchReports.Size = new Size(140, 53);
            btnSearchReports.TabIndex = 20;
            btnSearchReports.Text = "Search";
            btnSearchReports.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnSearchReports.UseVisualStyleBackColor = false;
            btnSearchReports.Click += btnSearchReports_Click;
            // 
            // panelShowReports
            // 
            panelShowReports.Controls.Add(toolStrip);
            panelShowReports.Controls.Add(dgvViewReports);
            panelShowReports.Controls.Add(btnExportPDF);
            panelShowReports.Controls.Add(btnExportExcel);
            panelShowReports.Controls.Add(button5);
            panelShowReports.Controls.Add(button1);
            panelShowReports.Controls.Add(button2);
            panelShowReports.Dock = DockStyle.Fill;
            panelShowReports.Location = new Point(0, 310);
            panelShowReports.Name = "panelShowReports";
            panelShowReports.Size = new Size(896, 480);
            panelShowReports.TabIndex = 43;
            panelShowReports.Paint += panelShowReports_Paint;
            // 
            // toolStrip
            // 
            toolStrip.Dock = DockStyle.None;
            toolStrip.ImageScalingSize = new Size(20, 20);
            toolStrip.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, toolStripPageLabel });
            toolStrip.Location = new Point(12, 322);
            toolStrip.Name = "toolStrip";
            toolStrip.Size = new Size(135, 27);
            toolStrip.TabIndex = 33;
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
            // dgvViewReports
            // 
            dgvViewReports.AllowUserToAddRows = false;
            dgvViewReports.AllowUserToDeleteRows = false;
            dgvViewReports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvViewReports.BackgroundColor = SystemColors.Control;
            dgvViewReports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvViewReports.Location = new Point(12, 9);
            dgvViewReports.Name = "dgvViewReports";
            dgvViewReports.RowHeadersWidth = 51;
            dgvViewReports.Size = new Size(872, 313);
            dgvViewReports.TabIndex = 32;
            // 
            // btnExportPDF
            // 
            btnExportPDF.BackColor = Color.Teal;
            btnExportPDF.FlatAppearance.BorderSize = 0;
            btnExportPDF.FlatStyle = FlatStyle.Flat;
            btnExportPDF.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExportPDF.ForeColor = SystemColors.Control;
            btnExportPDF.Image = (Image)resources.GetObject("btnExportPDF.Image");
            btnExportPDF.ImageAlign = ContentAlignment.MiddleLeft;
            btnExportPDF.Location = new Point(215, 358);
            btnExportPDF.Margin = new Padding(3, 4, 3, 4);
            btnExportPDF.Name = "btnExportPDF";
            btnExportPDF.Size = new Size(176, 80);
            btnExportPDF.TabIndex = 31;
            btnExportPDF.Text = "Export Pdf";
            btnExportPDF.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnExportPDF.UseVisualStyleBackColor = false;
            btnExportPDF.Click += btnExportPDF_Click;
            // 
            // btnExportExcel
            // 
            btnExportExcel.BackColor = Color.Teal;
            btnExportExcel.FlatAppearance.BorderSize = 0;
            btnExportExcel.FlatStyle = FlatStyle.Flat;
            btnExportExcel.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExportExcel.ForeColor = SystemColors.Control;
            btnExportExcel.Image = (Image)resources.GetObject("btnExportExcel.Image");
            btnExportExcel.Location = new Point(570, 358);
            btnExportExcel.Margin = new Padding(3, 4, 3, 4);
            btnExportExcel.Name = "btnExportExcel";
            btnExportExcel.Size = new Size(189, 80);
            btnExportExcel.TabIndex = 30;
            btnExportExcel.Text = "Export Excel";
            btnExportExcel.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnExportExcel.UseVisualStyleBackColor = false;
            btnExportExcel.Click += btnExportExcel_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Teal;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = SystemColors.Control;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.Location = new Point(685, 648);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(131, 80);
            button5.TabIndex = 29;
            button5.Text = "Save";
            button5.TextImageRelation = TextImageRelation.TextBeforeImage;
            button5.UseVisualStyleBackColor = false;
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
            // DisplayReportsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 790);
            Controls.Add(panelShowReports);
            Controls.Add(panelShow);
            Controls.Add(panel1);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DisplayReportsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DisplayReportsForm";
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