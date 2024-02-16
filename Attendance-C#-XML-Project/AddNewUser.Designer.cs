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
            comboSelectRole = new ComboBox();
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
            panel1.Controls.Add(comboSelectRole);
            panel1.Controls.Add(lblRole);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 37);
            panel1.Name = "panel1";
            panel1.Size = new Size(388, 464);
            panel1.TabIndex = 0;
            // 
            // comboSelectRole
            // 
            comboSelectRole.FlatStyle = FlatStyle.Flat;
            comboSelectRole.FormattingEnabled = true;
            comboSelectRole.Items.AddRange(new object[] { "Student", "Teacher" });
            comboSelectRole.Location = new Point(126, 389);
            comboSelectRole.Name = "comboSelectRole";
            comboSelectRole.Size = new Size(139, 23);
            comboSelectRole.TabIndex = 19;
            comboSelectRole.SelectedIndexChanged += comboSelectRole_SelectedIndexChanged;
            comboSelectRole.KeyPress += comboSelectRole_KeyPress;
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
            txtPassword.Location = new Point(449, 142);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(318, 23);
            txtPassword.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(449, 119);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(449, 205);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(318, 23);
            txtEmail.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(449, 182);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 6;
            label4.Text = "Email";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(449, 267);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(318, 23);
            txtPhone.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(449, 244);
            label5.Name = "label5";
            label5.Size = new Size(56, 20);
            label5.TabIndex = 8;
            label5.Text = "Phone";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(449, 328);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(318, 23);
            txtAddress.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(449, 305);
            label6.Name = "label6";
            label6.Size = new Size(67, 20);
            label6.TabIndex = 10;
            label6.Text = "Address";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(449, 365);
            label7.Name = "label7";
            label7.Size = new Size(66, 20);
            label7.TabIndex = 12;
            label7.Text = "Gender";
            // 
            // comboGender
            // 
            comboGender.FormattingEnabled = true;
            comboGender.Items.AddRange(new object[] { "Male", "Female" });
            comboGender.Location = new Point(449, 388);
            comboGender.Name = "comboGender";
            comboGender.Size = new Size(139, 23);
            comboGender.TabIndex = 14;
            comboGender.KeyPress += comboGender_KeyPress;
            // 
            // comboClass
            // 
            comboClass.FormattingEnabled = true;
            comboClass.Items.AddRange(new object[] { "Male", "Female" });
            comboClass.Location = new Point(634, 388);
            comboClass.Name = "comboClass";
            comboClass.Size = new Size(133, 23);
            comboClass.TabIndex = 16;
            comboClass.KeyPress += comboClass_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(634, 365);
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
            btnAddUser.Location = new Point(554, 441);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(115, 39);
            btnAddUser.TabIndex = 17;
            btnAddUser.Text = "Add Student";
            btnAddUser.UseVisualStyleBackColor = false;
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
            checkedListClass.Items.AddRange(new object[] { "Class A", "Class B", "Class C" });
            checkedListClass.Location = new Point(634, 388);
            checkedListClass.Name = "checkedListClass";
            checkedListClass.Size = new Size(133, 40);
            checkedListClass.TabIndex = 9;
            // 
            // AddNewUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 499);
            Controls.Add(checkedListClass);
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
        private ComboBox comboSelectRole;
        private Label lblRole;
        private PictureBox pictureBox2;
        private Label label9;
        private Button btnClose;
        private Panel panel3;
        private CheckedListBox checkedListClass;
    }
}