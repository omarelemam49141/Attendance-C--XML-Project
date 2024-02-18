namespace Attendance_C__XML_Project
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            label4 = new Label();
            btnClose = new Button();
            panel1 = new Panel();
            linkLogout = new LinkLabel();
            lblRole = new Label();
            label17 = new Label();
            panelDisplayClass = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            label22 = new Label();
            label24 = new Label();
            label19 = new Label();
            label18 = new Label();
            txtClassName = new MaskedTextBox();
            lblClassID = new Label();
            btnEditClass = new PictureBox();
            btnDeleteClass = new PictureBox();
            pictureBox10 = new PictureBox();
            lstClass = new ListBox();
            button2 = new Button();
            btnSearchClass = new MaskedTextBox();
            panel6 = new Panel();
            label25 = new Label();
            panel2 = new Panel();
            lblUsername = new Label();
            button3 = new Button();
            btnDisplayReports = new Button();
            btnDisplayClasses = new Button();
            btnDisplayUsers = new Button();
            pictureBox1 = new PictureBox();
            maskedTextBox8 = new MaskedTextBox();
            panel4 = new Panel();
            tableLayoutPanel4 = new TableLayoutPanel();
            label20 = new Label();
            label21 = new Label();
            panelDisplayUser = new Panel();
            panelShowClasses = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            label14 = new Label();
            pictureBox5 = new PictureBox();
            txtNameOfClass = new MaskedTextBox();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            txtClassID = new Label();
            label15 = new Label();
            btnUpdateClass = new PictureBox();
            btnRemoveClass = new PictureBox();
            pictureBox7 = new PictureBox();
            listDisplayClasses = new ListBox();
            btnSearchClasses = new Button();
            txtSearchClass = new MaskedTextBox();
            panel7 = new Panel();
            label16 = new Label();
            lblAddError = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            txtPassword = new MaskedTextBox();
            txtUsername = new MaskedTextBox();
            label2 = new Label();
            txtEmail = new MaskedTextBox();
            lblID = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            listUsers = new ListBox();
            btnSearch = new Button();
            txtSearch = new MaskedTextBox();
            panel3 = new Panel();
            label9 = new Label();
            panel1.SuspendLayout();
            panelDisplayClass.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnEditClass).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnDeleteClass).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            panel6.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            panelDisplayUser.SuspendLayout();
            panelShowClasses.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnUpdateClass).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnRemoveClass).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            panel7.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(3, 7);
            label4.Name = "label4";
            label4.Size = new Size(151, 21);
            label4.TabIndex = 8;
            label4.Text = "Attendance Form";
            // 
            // btnClose
            // 
            btnClose.BackgroundImage = (Image)resources.GetObject("btnClose.BackgroundImage");
            btnClose.BackgroundImageLayout = ImageLayout.Zoom;
            btnClose.Cursor = Cursors.Hand;
            btnClose.Dock = DockStyle.Right;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Location = new Point(761, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(39, 37);
            btnClose.TabIndex = 0;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 7, 95);
            panel1.Controls.Add(linkLogout);
            panel1.Controls.Add(lblRole);
            panel1.Controls.Add(label17);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnClose);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 37);
            panel1.TabIndex = 1;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // linkLogout
            // 
            linkLogout.AutoSize = true;
            linkLogout.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLogout.LinkColor = Color.IndianRed;
            linkLogout.Location = new Point(434, 6);
            linkLogout.Name = "linkLogout";
            linkLogout.Size = new Size(59, 21);
            linkLogout.TabIndex = 24;
            linkLogout.TabStop = true;
            linkLogout.Text = "Logout";
            linkLogout.LinkClicked += linkLogout_LinkClicked;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.BackColor = Color.Teal;
            lblRole.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRole.ForeColor = Color.WhiteSmoke;
            lblRole.Location = new Point(366, 7);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(60, 21);
            lblRole.TabIndex = 26;
            lblRole.Text = "admin";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.White;
            label17.Location = new Point(198, 6);
            label17.Name = "label17";
            label17.Size = new Size(169, 21);
            label17.TabIndex = 9;
            label17.Text = "You are logged in as";
            // 
            // panelDisplayClass
            // 
            panelDisplayClass.Controls.Add(tableLayoutPanel3);
            panelDisplayClass.Controls.Add(pictureBox10);
            panelDisplayClass.Controls.Add(lstClass);
            panelDisplayClass.Controls.Add(button2);
            panelDisplayClass.Controls.Add(btnSearchClass);
            panelDisplayClass.Controls.Add(panel6);
            panelDisplayClass.Location = new Point(198, 0);
            panelDisplayClass.Name = "panelDisplayClass";
            panelDisplayClass.Size = new Size(602, 463);
            panelDisplayClass.TabIndex = 25;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.0001965F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.0002F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.0002F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.0002F));
            tableLayoutPanel3.Controls.Add(label22, 1, 0);
            tableLayoutPanel3.Controls.Add(label24, 0, 0);
            tableLayoutPanel3.Controls.Add(label19, 2, 0);
            tableLayoutPanel3.Controls.Add(label18, 3, 0);
            tableLayoutPanel3.Controls.Add(txtClassName, 1, 1);
            tableLayoutPanel3.Controls.Add(lblClassID, 0, 1);
            tableLayoutPanel3.Controls.Add(btnEditClass, 2, 1);
            tableLayoutPanel3.Controls.Add(btnDeleteClass, 3, 1);
            tableLayoutPanel3.Location = new Point(6, 338);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 49.99936F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0006371F));
            tableLayoutPanel3.Size = new Size(582, 94);
            tableLayoutPanel3.TabIndex = 10;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.BackColor = Color.Teal;
            label22.Dock = DockStyle.Fill;
            label22.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label22.ForeColor = Color.White;
            label22.Location = new Point(148, 0);
            label22.Name = "label22";
            label22.Size = new Size(139, 46);
            label22.TabIndex = 1;
            label22.Text = "Class name";
            label22.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.BackColor = Color.Teal;
            label24.Dock = DockStyle.Fill;
            label24.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label24.ForeColor = Color.White;
            label24.Location = new Point(3, 0);
            label24.Name = "label24";
            label24.Size = new Size(139, 46);
            label24.TabIndex = 0;
            label24.Text = "ID";
            label24.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BackColor = Color.Teal;
            label19.Dock = DockStyle.Fill;
            label19.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label19.ForeColor = Color.White;
            label19.Location = new Point(293, 0);
            label19.Name = "label19";
            label19.Size = new Size(139, 46);
            label19.TabIndex = 28;
            label19.Text = "Edit";
            label19.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.Teal;
            label18.Dock = DockStyle.Fill;
            label18.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label18.ForeColor = Color.White;
            label18.Location = new Point(438, 0);
            label18.Name = "label18";
            label18.Size = new Size(141, 46);
            label18.TabIndex = 29;
            label18.Text = "Delete";
            label18.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtClassName
            // 
            txtClassName.Dock = DockStyle.Bottom;
            txtClassName.Location = new Point(148, 68);
            txtClassName.Name = "txtClassName";
            txtClassName.Size = new Size(139, 23);
            txtClassName.TabIndex = 22;
            // 
            // lblClassID
            // 
            lblClassID.AutoSize = true;
            lblClassID.BackColor = Color.Transparent;
            lblClassID.Dock = DockStyle.Fill;
            lblClassID.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblClassID.ForeColor = Color.Black;
            lblClassID.Location = new Point(3, 46);
            lblClassID.Name = "lblClassID";
            lblClassID.Size = new Size(139, 48);
            lblClassID.TabIndex = 12;
            lblClassID.Text = "123456";
            lblClassID.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnEditClass
            // 
            btnEditClass.Dock = DockStyle.Fill;
            btnEditClass.Image = (Image)resources.GetObject("btnEditClass.Image");
            btnEditClass.Location = new Point(293, 49);
            btnEditClass.Name = "btnEditClass";
            btnEditClass.Size = new Size(139, 42);
            btnEditClass.SizeMode = PictureBoxSizeMode.Zoom;
            btnEditClass.TabIndex = 24;
            btnEditClass.TabStop = false;
            // 
            // btnDeleteClass
            // 
            btnDeleteClass.Dock = DockStyle.Fill;
            btnDeleteClass.Image = (Image)resources.GetObject("btnDeleteClass.Image");
            btnDeleteClass.Location = new Point(438, 49);
            btnDeleteClass.Name = "btnDeleteClass";
            btnDeleteClass.Size = new Size(141, 42);
            btnDeleteClass.SizeMode = PictureBoxSizeMode.Zoom;
            btnDeleteClass.TabIndex = 25;
            btnDeleteClass.TabStop = false;
            // 
            // pictureBox10
            // 
            pictureBox10.Image = (Image)resources.GetObject("pictureBox10.Image");
            pictureBox10.Location = new Point(352, 24);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(59, 70);
            pictureBox10.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox10.TabIndex = 22;
            pictureBox10.TabStop = false;
            // 
            // lstClass
            // 
            lstClass.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstClass.FormattingEnabled = true;
            lstClass.ItemHeight = 21;
            lstClass.Location = new Point(8, 8);
            lstClass.Name = "lstClass";
            lstClass.Size = new Size(226, 319);
            lstClass.TabIndex = 18;
            // 
            // button2
            // 
            button2.BackColor = Color.Teal;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 11F);
            button2.ForeColor = Color.White;
            button2.Location = new Point(375, 215);
            button2.Name = "button2";
            button2.Size = new Size(112, 36);
            button2.TabIndex = 20;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = false;
            // 
            // btnSearchClass
            // 
            btnSearchClass.Location = new Point(291, 179);
            btnSearchClass.Name = "btnSearchClass";
            btnSearchClass.Size = new Size(281, 23);
            btnSearchClass.TabIndex = 19;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Teal;
            panel6.Controls.Add(label25);
            panel6.Location = new Point(410, 23);
            panel6.Name = "panel6";
            panel6.Size = new Size(192, 70);
            panel6.TabIndex = 23;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI", 30F);
            label25.ForeColor = Color.White;
            label25.Location = new Point(25, 6);
            label25.Name = "label25";
            label25.Size = new Size(150, 54);
            label25.TabIndex = 21;
            label25.Text = "Classes";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 7, 95);
            panel2.Controls.Add(lblUsername);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(btnDisplayReports);
            panel2.Controls.Add(btnDisplayClasses);
            panel2.Controls.Add(btnDisplayUsers);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(panelDisplayClass);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 37);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 463);
            panel2.TabIndex = 9;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.BackColor = Color.Teal;
            lblUsername.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.WhiteSmoke;
            lblUsername.Location = new Point(23, 10);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(160, 22);
            lblUsername.TabIndex = 25;
            lblUsername.Text = "Welcome Admin";
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 11F);
            button3.ForeColor = Color.DarkGray;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(-110, 382);
            button3.Name = "button3";
            button3.Size = new Size(324, 36);
            button3.TabIndex = 13;
            button3.Text = "                                       Add New User";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // btnDisplayReports
            // 
            btnDisplayReports.BackgroundImage = (Image)resources.GetObject("btnDisplayReports.BackgroundImage");
            btnDisplayReports.BackgroundImageLayout = ImageLayout.Zoom;
            btnDisplayReports.FlatAppearance.BorderSize = 0;
            btnDisplayReports.FlatStyle = FlatStyle.Flat;
            btnDisplayReports.Font = new Font("Segoe UI", 11F);
            btnDisplayReports.ForeColor = Color.DarkGray;
            btnDisplayReports.ImageAlign = ContentAlignment.MiddleLeft;
            btnDisplayReports.Location = new Point(-110, 318);
            btnDisplayReports.Name = "btnDisplayReports";
            btnDisplayReports.Size = new Size(324, 36);
            btnDisplayReports.TabIndex = 12;
            btnDisplayReports.Text = "                                       Display Reports";
            btnDisplayReports.UseVisualStyleBackColor = true;
            btnDisplayReports.Click += btnDisplayReports_Click;
            // 
            // btnDisplayClasses
            // 
            btnDisplayClasses.BackgroundImage = (Image)resources.GetObject("btnDisplayClasses.BackgroundImage");
            btnDisplayClasses.BackgroundImageLayout = ImageLayout.Zoom;
            btnDisplayClasses.FlatAppearance.BorderSize = 0;
            btnDisplayClasses.FlatStyle = FlatStyle.Flat;
            btnDisplayClasses.Font = new Font("Segoe UI", 11F);
            btnDisplayClasses.ForeColor = Color.DarkGray;
            btnDisplayClasses.ImageAlign = ContentAlignment.MiddleLeft;
            btnDisplayClasses.Location = new Point(-110, 254);
            btnDisplayClasses.Name = "btnDisplayClasses";
            btnDisplayClasses.Size = new Size(324, 36);
            btnDisplayClasses.TabIndex = 11;
            btnDisplayClasses.Text = "                                       Display Classes";
            btnDisplayClasses.UseVisualStyleBackColor = true;
            btnDisplayClasses.Click += btnDisplayClasses_Click;
            // 
            // btnDisplayUsers
            // 
            btnDisplayUsers.BackgroundImage = (Image)resources.GetObject("btnDisplayUsers.BackgroundImage");
            btnDisplayUsers.BackgroundImageLayout = ImageLayout.Zoom;
            btnDisplayUsers.FlatAppearance.BorderSize = 0;
            btnDisplayUsers.FlatStyle = FlatStyle.Flat;
            btnDisplayUsers.Font = new Font("Segoe UI", 11F);
            btnDisplayUsers.ForeColor = Color.White;
            btnDisplayUsers.ImageAlign = ContentAlignment.MiddleLeft;
            btnDisplayUsers.Location = new Point(-110, 190);
            btnDisplayUsers.Name = "btnDisplayUsers";
            btnDisplayUsers.Size = new Size(324, 36);
            btnDisplayUsers.TabIndex = 10;
            btnDisplayUsers.Text = "                                       Display Users";
            btnDisplayUsers.UseVisualStyleBackColor = true;
            btnDisplayUsers.Click += btnDisplayUsers_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(27, 43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 141);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // maskedTextBox8
            // 
            maskedTextBox8.Dock = DockStyle.Bottom;
            maskedTextBox8.Location = new Point(351, 47);
            maskedTextBox8.Name = "maskedTextBox8";
            maskedTextBox8.Size = new Size(110, 23);
            maskedTextBox8.TabIndex = 21;
            // 
            // panel4
            // 
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 100);
            panel4.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 4;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.0001965F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.0002F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.0002F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.0002F));
            tableLayoutPanel4.Controls.Add(label20, 1, 0);
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.Size = new Size(200, 100);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.BackColor = Color.Teal;
            label20.Dock = DockStyle.Fill;
            label20.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label20.ForeColor = Color.White;
            label20.Location = new Point(52, 0);
            label20.Name = "label20";
            label20.Size = new Size(44, 100);
            label20.TabIndex = 1;
            label20.Text = "Class name";
            label20.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.BackColor = Color.Teal;
            label21.Dock = DockStyle.Fill;
            label21.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label21.ForeColor = Color.White;
            label21.Location = new Point(3, 0);
            label21.Name = "label21";
            label21.Size = new Size(43, 100);
            label21.TabIndex = 0;
            label21.Text = "ID";
            label21.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelDisplayUser
            // 
            panelDisplayUser.Controls.Add(panelShowClasses);
            panelDisplayUser.Controls.Add(tableLayoutPanel1);
            panelDisplayUser.Controls.Add(pictureBox4);
            panelDisplayUser.Controls.Add(listUsers);
            panelDisplayUser.Controls.Add(btnSearch);
            panelDisplayUser.Controls.Add(txtSearch);
            panelDisplayUser.Controls.Add(panel3);
            panelDisplayUser.Location = new Point(201, 37);
            panelDisplayUser.Name = "panelDisplayUser";
            panelDisplayUser.Size = new Size(599, 463);
            panelDisplayUser.TabIndex = 24;
            // 
            // panelShowClasses
            // 
            panelShowClasses.Controls.Add(tableLayoutPanel2);
            panelShowClasses.Controls.Add(pictureBox7);
            panelShowClasses.Controls.Add(listDisplayClasses);
            panelShowClasses.Controls.Add(btnSearchClasses);
            panelShowClasses.Controls.Add(txtSearchClass);
            panelShowClasses.Controls.Add(panel7);
            panelShowClasses.Controls.Add(lblAddError);
            panelShowClasses.Location = new Point(0, 0);
            panelShowClasses.Name = "panelShowClasses";
            panelShowClasses.Size = new Size(599, 463);
            panelShowClasses.TabIndex = 25;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 5;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.572258F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.5722523F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2846947F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2846947F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2860975F));
            tableLayoutPanel2.Controls.Add(label14, 4, 0);
            tableLayoutPanel2.Controls.Add(pictureBox5, 4, 1);
            tableLayoutPanel2.Controls.Add(txtNameOfClass, 1, 1);
            tableLayoutPanel2.Controls.Add(label11, 3, 0);
            tableLayoutPanel2.Controls.Add(label12, 2, 0);
            tableLayoutPanel2.Controls.Add(label13, 1, 0);
            tableLayoutPanel2.Controls.Add(txtClassID, 0, 1);
            tableLayoutPanel2.Controls.Add(label15, 0, 0);
            tableLayoutPanel2.Controls.Add(btnUpdateClass, 2, 1);
            tableLayoutPanel2.Controls.Add(btnRemoveClass, 3, 1);
            tableLayoutPanel2.Location = new Point(6, 338);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 49.99936F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0006371F));
            tableLayoutPanel2.Size = new Size(582, 94);
            tableLayoutPanel2.TabIndex = 10;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Teal;
            label14.Dock = DockStyle.Fill;
            label14.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label14.ForeColor = Color.White;
            label14.Location = new Point(501, 0);
            label14.Name = "label14";
            label14.Size = new Size(78, 46);
            label14.TabIndex = 28;
            label14.Text = "Add";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(501, 49);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(78, 42);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 25;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // txtNameOfClass
            // 
            txtNameOfClass.Dock = DockStyle.Bottom;
            txtNameOfClass.Location = new Point(169, 68);
            txtNameOfClass.Name = "txtNameOfClass";
            txtNameOfClass.Size = new Size(160, 23);
            txtNameOfClass.TabIndex = 24;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Teal;
            label11.Dock = DockStyle.Fill;
            label11.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label11.ForeColor = Color.White;
            label11.Location = new Point(418, 0);
            label11.Name = "label11";
            label11.Size = new Size(77, 46);
            label11.TabIndex = 27;
            label11.Text = "Delete";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Teal;
            label12.Dock = DockStyle.Fill;
            label12.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label12.ForeColor = Color.White;
            label12.Location = new Point(335, 0);
            label12.Name = "label12";
            label12.Size = new Size(77, 46);
            label12.TabIndex = 26;
            label12.Text = "Edit";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Teal;
            label13.Dock = DockStyle.Fill;
            label13.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label13.ForeColor = Color.White;
            label13.Location = new Point(169, 0);
            label13.Name = "label13";
            label13.Size = new Size(160, 46);
            label13.TabIndex = 1;
            label13.Text = "Class name";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtClassID
            // 
            txtClassID.AutoSize = true;
            txtClassID.BackColor = Color.Transparent;
            txtClassID.Dock = DockStyle.Fill;
            txtClassID.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            txtClassID.ForeColor = Color.Black;
            txtClassID.Location = new Point(3, 46);
            txtClassID.Name = "txtClassID";
            txtClassID.Size = new Size(160, 48);
            txtClassID.TabIndex = 12;
            txtClassID.Text = "-1";
            txtClassID.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Teal;
            label15.Dock = DockStyle.Fill;
            label15.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label15.ForeColor = Color.White;
            label15.Location = new Point(3, 0);
            label15.Name = "label15";
            label15.Size = new Size(160, 46);
            label15.TabIndex = 0;
            label15.Text = "Class ID";
            label15.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnUpdateClass
            // 
            btnUpdateClass.Dock = DockStyle.Fill;
            btnUpdateClass.Image = (Image)resources.GetObject("btnUpdateClass.Image");
            btnUpdateClass.Location = new Point(335, 49);
            btnUpdateClass.Name = "btnUpdateClass";
            btnUpdateClass.Size = new Size(77, 42);
            btnUpdateClass.SizeMode = PictureBoxSizeMode.Zoom;
            btnUpdateClass.TabIndex = 24;
            btnUpdateClass.TabStop = false;
            btnUpdateClass.Click += btnUpdateClass_Click;
            // 
            // btnRemoveClass
            // 
            btnRemoveClass.Dock = DockStyle.Fill;
            btnRemoveClass.Image = (Image)resources.GetObject("btnRemoveClass.Image");
            btnRemoveClass.Location = new Point(418, 49);
            btnRemoveClass.Name = "btnRemoveClass";
            btnRemoveClass.Size = new Size(77, 42);
            btnRemoveClass.SizeMode = PictureBoxSizeMode.Zoom;
            btnRemoveClass.TabIndex = 25;
            btnRemoveClass.TabStop = false;
            btnRemoveClass.Click += btnRemoveClass_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(352, 24);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(59, 70);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 22;
            pictureBox7.TabStop = false;
            // 
            // listDisplayClasses
            // 
            listDisplayClasses.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listDisplayClasses.FormattingEnabled = true;
            listDisplayClasses.ItemHeight = 21;
            listDisplayClasses.Location = new Point(8, 8);
            listDisplayClasses.Name = "listDisplayClasses";
            listDisplayClasses.Size = new Size(226, 319);
            listDisplayClasses.TabIndex = 18;
            listDisplayClasses.SelectedIndexChanged += liatDisplayClasses_SelectedIndexChanged;
            // 
            // btnSearchClasses
            // 
            btnSearchClasses.BackColor = Color.Teal;
            btnSearchClasses.FlatAppearance.BorderSize = 0;
            btnSearchClasses.FlatStyle = FlatStyle.Flat;
            btnSearchClasses.Font = new Font("Segoe UI", 11F);
            btnSearchClasses.ForeColor = Color.White;
            btnSearchClasses.Location = new Point(375, 215);
            btnSearchClasses.Name = "btnSearchClasses";
            btnSearchClasses.Size = new Size(112, 36);
            btnSearchClasses.TabIndex = 20;
            btnSearchClasses.Text = "Search";
            btnSearchClasses.UseVisualStyleBackColor = false;
            btnSearchClasses.Click += btnSearchClasses_Click;
            // 
            // txtSearchClass
            // 
            txtSearchClass.Location = new Point(291, 179);
            txtSearchClass.Name = "txtSearchClass";
            txtSearchClass.Size = new Size(281, 23);
            txtSearchClass.TabIndex = 19;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Teal;
            panel7.Controls.Add(label16);
            panel7.Location = new Point(410, 23);
            panel7.Name = "panel7";
            panel7.Size = new Size(192, 70);
            panel7.TabIndex = 23;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 30F);
            label16.ForeColor = Color.White;
            label16.Location = new Point(29, 6);
            label16.Name = "label16";
            label16.Size = new Size(150, 54);
            label16.TabIndex = 21;
            label16.Text = "Classes";
            // 
            // lblAddError
            // 
            lblAddError.AutoSize = true;
            lblAddError.BackColor = Color.IndianRed;
            lblAddError.ForeColor = Color.White;
            lblAddError.Location = new Point(173, 435);
            lblAddError.Name = "lblAddError";
            lblAddError.Padding = new Padding(10, 5, 10, 5);
            lblAddError.Size = new Size(20, 25);
            lblAddError.TabIndex = 29;
            lblAddError.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.0001965F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.0002F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.0002F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.0002F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.0001F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.9991F));
            tableLayoutPanel1.Controls.Add(label7, 5, 0);
            tableLayoutPanel1.Controls.Add(label6, 4, 0);
            tableLayoutPanel1.Controls.Add(label5, 3, 0);
            tableLayoutPanel1.Controls.Add(label3, 2, 0);
            tableLayoutPanel1.Controls.Add(txtPassword, 0, 1);
            tableLayoutPanel1.Controls.Add(txtUsername, 0, 1);
            tableLayoutPanel1.Controls.Add(label2, 1, 0);
            tableLayoutPanel1.Controls.Add(txtEmail, 1, 1);
            tableLayoutPanel1.Controls.Add(lblID, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(pictureBox2, 4, 1);
            tableLayoutPanel1.Controls.Add(pictureBox3, 5, 1);
            tableLayoutPanel1.Location = new Point(6, 338);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 49.99936F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0006371F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(582, 94);
            tableLayoutPanel1.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Teal;
            label7.Dock = DockStyle.Fill;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(525, 0);
            label7.Name = "label7";
            label7.Size = new Size(54, 46);
            label7.TabIndex = 29;
            label7.Text = "Delete";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Teal;
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(467, 0);
            label6.Name = "label6";
            label6.Size = new Size(52, 46);
            label6.TabIndex = 28;
            label6.Text = "Edit";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Teal;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(351, 0);
            label5.Name = "label5";
            label5.Size = new Size(110, 46);
            label5.TabIndex = 27;
            label5.Text = "Email";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Teal;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(235, 0);
            label3.Name = "label3";
            label3.Size = new Size(110, 46);
            label3.TabIndex = 26;
            label3.Text = "Password";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPassword
            // 
            txtPassword.Dock = DockStyle.Bottom;
            txtPassword.Location = new Point(235, 68);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(110, 23);
            txtPassword.TabIndex = 23;
            // 
            // txtUsername
            // 
            txtUsername.Dock = DockStyle.Bottom;
            txtUsername.Location = new Point(119, 68);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(110, 23);
            txtUsername.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Teal;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(119, 0);
            label2.Name = "label2";
            label2.Size = new Size(110, 46);
            label2.TabIndex = 1;
            label2.Text = "Username";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtEmail
            // 
            txtEmail.Dock = DockStyle.Bottom;
            txtEmail.Location = new Point(351, 68);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(110, 23);
            txtEmail.TabIndex = 21;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.BackColor = Color.Transparent;
            lblID.Dock = DockStyle.Fill;
            lblID.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblID.ForeColor = Color.Black;
            lblID.Location = new Point(3, 46);
            lblID.Name = "lblID";
            lblID.Size = new Size(110, 48);
            lblID.TabIndex = 12;
            lblID.Text = "-1";
            lblID.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Teal;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(110, 46);
            label1.TabIndex = 0;
            label1.Text = "ID";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(467, 49);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 42);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 24;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(525, 49);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(52, 42);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 25;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(352, 24);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(59, 70);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 22;
            pictureBox4.TabStop = false;
            // 
            // listUsers
            // 
            listUsers.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listUsers.FormattingEnabled = true;
            listUsers.ItemHeight = 21;
            listUsers.Location = new Point(8, 8);
            listUsers.Name = "listUsers";
            listUsers.Size = new Size(226, 319);
            listUsers.TabIndex = 18;
            listUsers.SelectedIndexChanged += listUsers_SelectedIndexChanged;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Teal;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 11F);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(375, 215);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(112, 36);
            btnSearch.TabIndex = 20;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(291, 179);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(281, 23);
            txtSearch.TabIndex = 19;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Teal;
            panel3.Controls.Add(label9);
            panel3.Location = new Point(410, 23);
            panel3.Name = "panel3";
            panel3.Size = new Size(192, 70);
            panel3.TabIndex = 23;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 30F);
            label9.ForeColor = Color.White;
            label9.Location = new Point(43, 6);
            label9.Name = "label9";
            label9.Size = new Size(119, 54);
            label9.TabIndex = 21;
            label9.Text = "Users";
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 500);
            Controls.Add(panelDisplayUser);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminForm";
            Load += AdminForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelDisplayClass.ResumeLayout(false);
            panelDisplayClass.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnEditClass).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnDeleteClass).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            panelDisplayUser.ResumeLayout(false);
            panelDisplayUser.PerformLayout();
            panelShowClasses.ResumeLayout(false);
            panelShowClasses.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnUpdateClass).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnRemoveClass).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label4;
        private Button btnClose;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button btnDisplayUsers;
        private Button button3;
        private Button btnDisplayReports;
        private Button btnDisplayClasses;
        private Panel panelDisplayClass;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label22;
        private Label label24;
        private Label label19;
        private Label label18;
        private MaskedTextBox txtClassName;
        private Label lblClassID;
        private PictureBox btnEditClass;
        private PictureBox btnDeleteClass;
        private PictureBox pictureBox10;
        private ListBox lstClass;
        private Button button2;
        private MaskedTextBox btnSearchClass;
        private Panel panel6;
        private Label label25;
        private MaskedTextBox maskedTextBox8;
        private Panel panel4;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label20;
        private Label label21;
        private Panel panelDisplayUser;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label3;
        private MaskedTextBox txtPassword;
        private MaskedTextBox txtUsername;
        private Label label2;
        private MaskedTextBox txtEmail;
        private Label lblID;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private ListBox listUsers;
        private Button btnSearch;
        private MaskedTextBox txtSearch;
        private Panel panel3;
        private Label label9;
        private Panel panelShowClasses;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label8;
        private Label label10;
        private Label label11;
        private Label label12;
        private MaskedTextBox maskedTextBox1;
        private MaskedTextBox maskedTextBox2;
        private Label label13;
        private MaskedTextBox maskedTextBox3;
        private Label txtClassID;
        private Label label15;
        private PictureBox btnUpdateClass;
        private PictureBox btnRemoveClass;
        private PictureBox pictureBox7;
        private ListBox listDisplayClasses;
        private Button btnSearchClasses;
        private MaskedTextBox txtSearchClass;
        private Panel panel7;
        private Label label16;
        private MaskedTextBox txtNameOfClass;
        private Label lblRole;
        private Label label17;
        private Label lblUsername;
        private LinkLabel linkLogout;
        private PictureBox pictureBox5;
        private Label label14;
        private Label lblAddError;
    }
}