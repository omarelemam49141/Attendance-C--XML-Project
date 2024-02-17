namespace Attendance_C__XML_Project
{
    partial class AddNewUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewUser));
            panel1 = new Panel();
            lblRoleError = new Label();
            comboRole = new ComboBox();
            lblRole = new Label();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            txtUsername = new MaskedTextBox();
            txtPassword = new MaskedTextBox();
            label3 = new Label();
            txtEmail = new MaskedTextBox();
            label4 = new Label();
            txtPhone = new MaskedTextBox();
            label5 = new Label();
            txtAddress = new MaskedTextBox();
            label6 = new Label();
            label7 = new Label();
            comboGender = new ComboBox();
            comboClass = new ComboBox();
            label8 = new Label();
            btnAddUser = new Button();
            label9 = new Label();
            btnClose = new Button();
            panel3 = new Panel();
            checkedListClass = new CheckedListBox();
            lblUsernameError = new Label();
            lblPasswordError = new Label();
            lblEmailError = new Label();
            lblPhoneError = new Label();
            lblAddressError = new Label();
            panel4 = new Panel();
            lblGenderError = new Label();
            lblClassError = new Label();
            lblClassesError = new Label();
            linkLogout = new LinkLabel();
            lblLoggedInRole = new Label();
            label17 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gold;
            panel1.Controls.Add(lblRoleError);
            panel1.Controls.Add(comboRole);
            panel1.Controls.Add(lblRole);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 37);
            panel1.Name = "panel1";
            panel1.Size = new Size(388, 592);
            panel1.TabIndex = 0;
            // 
            // lblRoleError
            // 
            lblRoleError.AutoSize = true;
            lblRoleError.ForeColor = Color.IndianRed;
            lblRoleError.Location = new Point(129, 422);
            lblRoleError.MaximumSize = new Size(139, 0);
            lblRoleError.Name = "lblRoleError";
            lblRoleError.Size = new Size(0, 15);
            lblRoleError.TabIndex = 27;
            // 
            // comboRole
            // 
            comboRole.FlatStyle = FlatStyle.Flat;
            comboRole.FormattingEnabled = true;
            comboRole.Items.AddRange(new object[] { "Student", "Teacher" });
            comboRole.Location = new Point(126, 389);
            comboRole.Name = "comboRole";
            comboRole.Size = new Size(139, 23);
            comboRole.TabIndex = 19;
            comboRole.SelectedIndexChanged += comboSelectRole_SelectedIndexChanged;
            comboRole.KeyPress += comboSelectRole_KeyPress;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Century Gothic", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRole.Location = new Point(158, 358);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(75, 22);
            lblRole.TabIndex = 18;
            lblRole.Text = "Student";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(25, 120);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(341, 227);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(388, 70);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Teal;
            label1.Font = new Font("Segoe UI", 30F);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(35, 3);
            label1.Name = "label1";
            label1.Size = new Size(278, 54);
            label1.TabIndex = 0;
            label1.Text = "Add New User";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(387, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(59, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(449, 61);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 2;
            label2.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(449, 84);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(318, 23);
            txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(449, 157);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(318, 23);
            txtPassword.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(449, 134);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(449, 269);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(318, 23);
            txtEmail.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(449, 246);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 6;
            label4.Text = "Email";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(449, 343);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(318, 23);
            txtPhone.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(449, 320);
            label5.Name = "label5";
            label5.Size = new Size(56, 20);
            label5.TabIndex = 8;
            label5.Text = "Phone";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(449, 413);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(318, 23);
            txtAddress.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(449, 390);
            label6.Name = "label6";
            label6.Size = new Size(67, 20);
            label6.TabIndex = 10;
            label6.Text = "Address";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(449, 460);
            label7.Name = "label7";
            label7.Size = new Size(66, 20);
            label7.TabIndex = 12;
            label7.Text = "Gender";
            // 
            // comboGender
            // 
            comboGender.FormattingEnabled = true;
            comboGender.Items.AddRange(new object[] { "Male", "Female" });
            comboGender.Location = new Point(449, 483);
            comboGender.Name = "comboGender";
            comboGender.Size = new Size(139, 23);
            comboGender.TabIndex = 14;
            comboGender.KeyPress += comboGender_KeyPress;
            // 
            // comboClass
            // 
            comboClass.FormattingEnabled = true;
            comboClass.Location = new Point(634, 483);
            comboClass.Name = "comboClass";
            comboClass.Size = new Size(133, 23);
            comboClass.TabIndex = 16;
            comboClass.KeyPress += comboClass_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(634, 460);
            label8.Name = "label8";
            label8.Size = new Size(46, 20);
            label8.TabIndex = 15;
            label8.Text = "Class";
            // 
            // btnAddUser
            // 
            btnAddUser.BackColor = Color.Teal;
            btnAddUser.FlatAppearance.BorderSize = 0;
            btnAddUser.FlatStyle = FlatStyle.Flat;
            btnAddUser.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddUser.ForeColor = SystemColors.Control;
            btnAddUser.Location = new Point(554, 571);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(115, 39);
            btnAddUser.TabIndex = 17;
            btnAddUser.Text = "Add Student";
            btnAddUser.UseVisualStyleBackColor = false;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(3, 7);
            label9.Name = "label9";
            label9.Size = new Size(123, 20);
            label9.TabIndex = 8;
            label9.Text = "Attendance Form";
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
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(73, 178, 202);
            panel3.Controls.Add(linkLogout);
            panel3.Controls.Add(lblLoggedInRole);
            panel3.Controls.Add(label17);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(btnClose);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 37);
            panel3.TabIndex = 18;
            panel3.MouseDown += panel3_MouseDown;
            // 
            // checkedListClass
            // 
            checkedListClass.FormattingEnabled = true;
            checkedListClass.Location = new Point(634, 483);
            checkedListClass.Name = "checkedListClass";
            checkedListClass.Size = new Size(133, 40);
            checkedListClass.TabIndex = 9;
            // 
            // lblUsernameError
            // 
            lblUsernameError.AutoSize = true;
            lblUsernameError.ForeColor = Color.IndianRed;
            lblUsernameError.Location = new Point(449, 110);
            lblUsernameError.Name = "lblUsernameError";
            lblUsernameError.Size = new Size(0, 15);
            lblUsernameError.TabIndex = 19;
            // 
            // lblPasswordError
            // 
            lblPasswordError.AutoSize = true;
            lblPasswordError.ForeColor = Color.IndianRed;
            lblPasswordError.Location = new Point(449, 182);
            lblPasswordError.MaximumSize = new Size(330, 0);
            lblPasswordError.Name = "lblPasswordError";
            lblPasswordError.Size = new Size(0, 15);
            lblPasswordError.TabIndex = 20;
            // 
            // lblEmailError
            // 
            lblEmailError.AutoSize = true;
            lblEmailError.ForeColor = Color.IndianRed;
            lblEmailError.Location = new Point(451, 298);
            lblEmailError.Name = "lblEmailError";
            lblEmailError.Size = new Size(0, 15);
            lblEmailError.TabIndex = 21;
            // 
            // lblPhoneError
            // 
            lblPhoneError.AutoSize = true;
            lblPhoneError.ForeColor = Color.IndianRed;
            lblPhoneError.Location = new Point(451, 372);
            lblPhoneError.Name = "lblPhoneError";
            lblPhoneError.Size = new Size(0, 15);
            lblPhoneError.TabIndex = 22;
            // 
            // lblAddressError
            // 
            lblAddressError.AutoSize = true;
            lblAddressError.ForeColor = Color.IndianRed;
            lblAddressError.Location = new Point(451, 442);
            lblAddressError.Name = "lblAddressError";
            lblAddressError.Size = new Size(0, 15);
            lblAddressError.TabIndex = 23;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveBorder;
            panel4.Location = new Point(449, 236);
            panel4.Name = "panel4";
            panel4.Size = new Size(318, 5);
            panel4.TabIndex = 24;
            // 
            // lblGenderError
            // 
            lblGenderError.AutoSize = true;
            lblGenderError.ForeColor = Color.IndianRed;
            lblGenderError.Location = new Point(454, 513);
            lblGenderError.MaximumSize = new Size(139, 0);
            lblGenderError.Name = "lblGenderError";
            lblGenderError.Size = new Size(0, 15);
            lblGenderError.TabIndex = 25;
            // 
            // lblClassError
            // 
            lblClassError.AutoSize = true;
            lblClassError.ForeColor = Color.IndianRed;
            lblClassError.Location = new Point(636, 513);
            lblClassError.MaximumSize = new Size(139, 0);
            lblClassError.Name = "lblClassError";
            lblClassError.Size = new Size(0, 15);
            lblClassError.TabIndex = 26;
            // 
            // lblClassesError
            // 
            lblClassesError.AutoSize = true;
            lblClassesError.ForeColor = Color.IndianRed;
            lblClassesError.Location = new Point(638, 528);
            lblClassesError.MaximumSize = new Size(139, 0);
            lblClassesError.Name = "lblClassesError";
            lblClassesError.Size = new Size(0, 15);
            lblClassesError.TabIndex = 27;
            // 
            // linkLogout
            // 
            linkLogout.AutoSize = true;
            linkLogout.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLogout.LinkColor = Color.Brown;
            linkLogout.Location = new Point(489, 7);
            linkLogout.Name = "linkLogout";
            linkLogout.Size = new Size(59, 21);
            linkLogout.TabIndex = 28;
            linkLogout.TabStop = true;
            linkLogout.Text = "Logout";
            linkLogout.LinkClicked += linkLogout_LinkClicked;
            // 
            // lblLoggedInRole
            // 
            lblLoggedInRole.AutoSize = true;
            lblLoggedInRole.BackColor = Color.Teal;
            lblLoggedInRole.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLoggedInRole.ForeColor = Color.WhiteSmoke;
            lblLoggedInRole.Location = new Point(421, 8);
            lblLoggedInRole.Name = "lblLoggedInRole";
            lblLoggedInRole.Size = new Size(60, 21);
            lblLoggedInRole.TabIndex = 29;
            lblLoggedInRole.Text = "admin";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.White;
            label17.Location = new Point(253, 7);
            label17.Name = "label17";
            label17.Size = new Size(169, 21);
            label17.TabIndex = 27;
            label17.Text = "You are logged in as";
            // 
            // AddNewUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 628);
            Controls.Add(lblClassesError);
            Controls.Add(lblClassError);
            Controls.Add(lblGenderError);
            Controls.Add(panel4);
            Controls.Add(lblAddressError);
            Controls.Add(lblPhoneError);
            Controls.Add(lblEmailError);
            Controls.Add(lblPasswordError);
            Controls.Add(lblUsernameError);
            Controls.Add(panel3);
            Controls.Add(btnAddUser);
            Controls.Add(comboClass);
            Controls.Add(label8);
            Controls.Add(comboGender);
            Controls.Add(label7);
            Controls.Add(txtAddress);
            Controls.Add(label6);
            Controls.Add(txtPhone);
            Controls.Add(label5);
            Controls.Add(txtEmail);
            Controls.Add(label4);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(checkedListClass);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddNewUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddNewUser";
            Load += AddNewUser_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label2;
        private MaskedTextBox txtUsername;
        private MaskedTextBox txtPassword;
        private Label label3;
        private MaskedTextBox txtEmail;
        private Label label4;
        private MaskedTextBox txtPhone;
        private Label label5;
        private MaskedTextBox txtAddress;
        private Label label6;
        private Label label7;
        private ComboBox comboGender;
        private ComboBox comboClass;
        private Label label8;
        private Button btnAddUser;
        private ComboBox comboRole;
        private Label lblRole;
        private PictureBox pictureBox2;
        private Label label9;
        private Button btnClose;
        private Panel panel3;
        private CheckedListBox checkedListClass;
        private Label lblUsernameError;
        private Label lblPasswordError;
        private Label lblEmailError;
        private Label lblPhoneError;
        private Label lblAddressError;
        private Panel panel4;
        private Label lblGenderError;
        private Label lblClassError;
        private Label lblRoleError;
        private Label lblClassesError;
        private LinkLabel linkLogout;
        private Label lblLoggedInRole;
        private Label label17;
    }
}