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
            linkLogout = new LinkLabel();
            lblLoggedInRole = new Label();
            label17 = new Label();
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
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
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
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
            // 
            // lblRoleError
            // 
            resources.ApplyResources(lblRoleError, "lblRoleError");
            lblRoleError.ForeColor = Color.IndianRed;
            lblRoleError.Name = "lblRoleError";
            // 
            // comboRole
            // 
            resources.ApplyResources(comboRole, "comboRole");
            comboRole.FormattingEnabled = true;
            comboRole.Items.AddRange(new object[] { resources.GetString("comboRole.Items"), resources.GetString("comboRole.Items1") });
            comboRole.Name = "comboRole";
            comboRole.SelectedIndexChanged += comboSelectRole_SelectedIndexChanged;
            comboRole.KeyPress += comboSelectRole_KeyPress;
            // 
            // lblRole
            // 
            resources.ApplyResources(lblRole, "lblRole");
            lblRole.Name = "lblRole";
            // 
            // pictureBox2
            // 
            resources.ApplyResources(pictureBox2, "pictureBox2");
            pictureBox2.Name = "pictureBox2";
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Controls.Add(label1);
            resources.ApplyResources(panel2, "panel2");
            panel2.Name = "panel2";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.BackColor = Color.Teal;
            label1.ForeColor = SystemColors.Control;
            label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // txtUsername
            // 
            resources.ApplyResources(txtUsername, "txtUsername");
            txtUsername.Name = "txtUsername";
            // 
            // txtPassword
            // 
            resources.ApplyResources(txtPassword, "txtPassword");
            txtPassword.Name = "txtPassword";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // txtEmail
            // 
            resources.ApplyResources(txtEmail, "txtEmail");
            txtEmail.Name = "txtEmail";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // txtPhone
            // 
            resources.ApplyResources(txtPhone, "txtPhone");
            txtPhone.Name = "txtPhone";
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.Name = "label5";
            // 
            // txtAddress
            // 
            resources.ApplyResources(txtAddress, "txtAddress");
            txtAddress.Name = "txtAddress";
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(label7, "label7");
            label7.Name = "label7";
            // 
            // comboGender
            // 
            comboGender.FormattingEnabled = true;
            comboGender.Items.AddRange(new object[] { resources.GetString("comboGender.Items"), resources.GetString("comboGender.Items1") });
            resources.ApplyResources(comboGender, "comboGender");
            comboGender.Name = "comboGender";
            comboGender.KeyPress += comboGender_KeyPress;
            // 
            // comboClass
            // 
            comboClass.FormattingEnabled = true;
            resources.ApplyResources(comboClass, "comboClass");
            comboClass.Name = "comboClass";
            comboClass.KeyPress += comboClass_KeyPress;
            // 
            // label8
            // 
            resources.ApplyResources(label8, "label8");
            label8.Name = "label8";
            // 
            // btnAddUser
            // 
            btnAddUser.BackColor = Color.Teal;
            btnAddUser.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(btnAddUser, "btnAddUser");
            btnAddUser.ForeColor = SystemColors.Control;
            btnAddUser.Name = "btnAddUser";
            btnAddUser.UseVisualStyleBackColor = false;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // label9
            // 
            resources.ApplyResources(label9, "label9");
            label9.ForeColor = Color.White;
            label9.Name = "label9";
            // 
            // btnClose
            // 
            resources.ApplyResources(btnClose, "btnClose");
            btnClose.Cursor = Cursors.Hand;
            btnClose.Name = "btnClose";
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
            resources.ApplyResources(panel3, "panel3");
            panel3.Name = "panel3";
            panel3.MouseDown += panel3_MouseDown;
            // 
            // linkLogout
            // 
            resources.ApplyResources(linkLogout, "linkLogout");
            linkLogout.LinkColor = Color.Brown;
            linkLogout.Name = "linkLogout";
            linkLogout.TabStop = true;
            linkLogout.LinkClicked += linkLogout_LinkClicked;
            // 
            // lblLoggedInRole
            // 
            resources.ApplyResources(lblLoggedInRole, "lblLoggedInRole");
            lblLoggedInRole.BackColor = Color.Teal;
            lblLoggedInRole.ForeColor = Color.WhiteSmoke;
            lblLoggedInRole.Name = "lblLoggedInRole";
            // 
            // label17
            // 
            resources.ApplyResources(label17, "label17");
            label17.ForeColor = Color.White;
            label17.Name = "label17";
            // 
            // checkedListClass
            // 
            checkedListClass.FormattingEnabled = true;
            resources.ApplyResources(checkedListClass, "checkedListClass");
            checkedListClass.Name = "checkedListClass";
            // 
            // lblUsernameError
            // 
            resources.ApplyResources(lblUsernameError, "lblUsernameError");
            lblUsernameError.ForeColor = Color.IndianRed;
            lblUsernameError.Name = "lblUsernameError";
            // 
            // lblPasswordError
            // 
            resources.ApplyResources(lblPasswordError, "lblPasswordError");
            lblPasswordError.ForeColor = Color.IndianRed;
            lblPasswordError.Name = "lblPasswordError";
            // 
            // lblEmailError
            // 
            resources.ApplyResources(lblEmailError, "lblEmailError");
            lblEmailError.ForeColor = Color.IndianRed;
            lblEmailError.Name = "lblEmailError";
            // 
            // lblPhoneError
            // 
            resources.ApplyResources(lblPhoneError, "lblPhoneError");
            lblPhoneError.ForeColor = Color.IndianRed;
            lblPhoneError.Name = "lblPhoneError";
            // 
            // lblAddressError
            // 
            resources.ApplyResources(lblAddressError, "lblAddressError");
            lblAddressError.ForeColor = Color.IndianRed;
            lblAddressError.Name = "lblAddressError";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveBorder;
            resources.ApplyResources(panel4, "panel4");
            panel4.Name = "panel4";
            // 
            // lblGenderError
            // 
            resources.ApplyResources(lblGenderError, "lblGenderError");
            lblGenderError.ForeColor = Color.IndianRed;
            lblGenderError.Name = "lblGenderError";
            // 
            // lblClassError
            // 
            resources.ApplyResources(lblClassError, "lblClassError");
            lblClassError.ForeColor = Color.IndianRed;
            lblClassError.Name = "lblClassError";
            // 
            // lblClassesError
            // 
            resources.ApplyResources(lblClassesError, "lblClassesError");
            lblClassesError.ForeColor = Color.IndianRed;
            lblClassesError.Name = "lblClassesError";
            // 
            // AddNewUser
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
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
            Controls.Add(panel1);
            Controls.Add(checkedListClass);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddNewUser";
            Tag = "myTheme";
            Load += AddNewUser_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
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