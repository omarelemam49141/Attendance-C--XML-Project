namespace Attendance_C__XML_Project
{
    partial class PreferencesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreferencesForm));
            btnExit = new Button();
            label9 = new Label();
            panel3 = new Panel();
            picStudent = new PictureBox();
            panel1 = new Panel();
            lblRole = new Label();
            lblRoleName = new Label();
            lblWelcome = new Label();
            button3 = new Button();
            lblUserName = new Label();
            lblRoleError = new Label();
            panelShow = new Panel();
            label4 = new Label();
            comboThemes = new ComboBox();
            btnSave = new Button();
            label3 = new Label();
            comboColors = new ComboBox();
            label2 = new Label();
            comboFontSize = new ComboBox();
            label1 = new Label();
            comboDateFormat = new ComboBox();
            lblClassPicker = new Label();
            comboLanguages = new ComboBox();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picStudent).BeginInit();
            panel1.SuspendLayout();
            panelShow.SuspendLayout();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.BackgroundImage = (Image)resources.GetObject("btnExit.BackgroundImage");
            btnExit.BackgroundImageLayout = ImageLayout.Zoom;
            btnExit.Cursor = Cursors.Hand;
            btnExit.Dock = DockStyle.Right;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Location = new Point(745, 0);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(39, 37);
            btnExit.TabIndex = 9;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
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
            label9.Text = "Preferences Form";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(73, 178, 202);
            panel3.Controls.Add(btnExit);
            panel3.Controls.Add(label9);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(784, 37);
            panel3.TabIndex = 20;
            // 
            // picStudent
            // 
            picStudent.Image = (Image)resources.GetObject("picStudent.Image");
            picStudent.Location = new Point(10, 0);
            picStudent.Margin = new Padding(3, 2, 3, 2);
            picStudent.Name = "picStudent";
            picStudent.Size = new Size(81, 72);
            picStudent.TabIndex = 28;
            picStudent.TabStop = false;
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
            panel1.Location = new Point(0, 37);
            panel1.Name = "panel1";
            panel1.Size = new Size(784, 75);
            panel1.TabIndex = 31;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRole.Location = new Point(97, 39);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(48, 18);
            lblRole.TabIndex = 36;
            lblRole.Text = "Role:";
            // 
            // lblRoleName
            // 
            lblRoleName.AutoSize = true;
            lblRoleName.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRoleName.Location = new Point(188, 40);
            lblRoleName.Name = "lblRoleName";
            lblRoleName.Size = new Size(74, 18);
            lblRoleName.TabIndex = 35;
            lblRoleName.Text = "role name";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(97, 9);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(89, 18);
            lblWelcome.TabIndex = 33;
            lblWelcome.Text = "Welcome: ";
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Black;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(745, 6);
            button3.Name = "button3";
            button3.Size = new Size(34, 28);
            button3.TabIndex = 30;
            button3.UseVisualStyleBackColor = false;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserName.Location = new Point(188, 9);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(78, 18);
            lblUserName.TabIndex = 29;
            lblUserName.Text = "user name";
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
            // panelShow
            // 
            panelShow.Controls.Add(label4);
            panelShow.Controls.Add(comboThemes);
            panelShow.Controls.Add(btnSave);
            panelShow.Controls.Add(label3);
            panelShow.Controls.Add(comboColors);
            panelShow.Controls.Add(label2);
            panelShow.Controls.Add(comboFontSize);
            panelShow.Controls.Add(label1);
            panelShow.Controls.Add(comboDateFormat);
            panelShow.Controls.Add(lblClassPicker);
            panelShow.Controls.Add(comboLanguages);
            panelShow.Dock = DockStyle.Fill;
            panelShow.Location = new Point(0, 112);
            panelShow.Margin = new Padding(3, 2, 3, 2);
            panelShow.Name = "panelShow";
            panelShow.Size = new Size(784, 479);
            panelShow.TabIndex = 36;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(56, 283);
            label4.Name = "label4";
            label4.Size = new Size(62, 18);
            label4.TabIndex = 46;
            label4.Text = "Themes";
            // 
            // comboThemes
            // 
            comboThemes.FlatStyle = FlatStyle.Flat;
            comboThemes.FormattingEnabled = true;
            comboThemes.Items.AddRange(new object[] { "Light", "Dark" });
            comboThemes.Location = new Point(143, 281);
            comboThemes.Name = "comboThemes";
            comboThemes.Size = new Size(139, 23);
            comboThemes.TabIndex = 45;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Teal;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = SystemColors.Control;
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.Location = new Point(598, 391);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(115, 46);
            btnSave.TabIndex = 44;
            btnSave.Text = "Save";
            btnSave.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(56, 225);
            label3.Name = "label3";
            label3.Size = new Size(53, 18);
            label3.TabIndex = 43;
            label3.Text = "Colors";
            // 
            // comboColors
            // 
            comboColors.FlatStyle = FlatStyle.Flat;
            comboColors.FormattingEnabled = true;
            comboColors.Items.AddRange(new object[] { "Black", "Blue", "Grey" });
            comboColors.Location = new Point(143, 224);
            comboColors.Name = "comboColors";
            comboColors.Size = new Size(139, 23);
            comboColors.TabIndex = 42;
            comboColors.SelectedIndexChanged += comboColors_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(56, 171);
            label2.Name = "label2";
            label2.Size = new Size(71, 18);
            label2.TabIndex = 41;
            label2.Text = "Font Size";
            // 
            // comboFontSize
            // 
            comboFontSize.FlatStyle = FlatStyle.Flat;
            comboFontSize.FormattingEnabled = true;
            comboFontSize.Items.AddRange(new object[] { "Small", "Medium", "Large" });
            comboFontSize.Location = new Point(158, 170);
            comboFontSize.Name = "comboFontSize";
            comboFontSize.Size = new Size(139, 23);
            comboFontSize.TabIndex = 40;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(56, 116);
            label1.Name = "label1";
            label1.Size = new Size(91, 18);
            label1.TabIndex = 39;
            label1.Text = "Date Format";
            // 
            // comboDateFormat
            // 
            comboDateFormat.FlatStyle = FlatStyle.Flat;
            comboDateFormat.FormattingEnabled = true;
            comboDateFormat.Items.AddRange(new object[] { "DD/MM/YYYY", "MM/DD/YYYY" });
            comboDateFormat.Location = new Point(171, 114);
            comboDateFormat.Name = "comboDateFormat";
            comboDateFormat.Size = new Size(139, 23);
            comboDateFormat.TabIndex = 38;
            // 
            // lblClassPicker
            // 
            lblClassPicker.AutoSize = true;
            lblClassPicker.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblClassPicker.Location = new Point(56, 65);
            lblClassPicker.Name = "lblClassPicker";
            lblClassPicker.Size = new Size(72, 18);
            lblClassPicker.TabIndex = 37;
            lblClassPicker.Text = "Language";
            // 
            // comboLanguages
            // 
            comboLanguages.FlatStyle = FlatStyle.Flat;
            comboLanguages.FormattingEnabled = true;
            comboLanguages.Items.AddRange(new object[] { "English", "العربية" });
            comboLanguages.Location = new Point(158, 64);
            comboLanguages.Name = "comboLanguages";
            comboLanguages.Size = new Size(139, 23);
            comboLanguages.TabIndex = 36;
            // 
            // PreferencesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 591);
            Controls.Add(panelShow);
            Controls.Add(panel1);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "PreferencesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PreferencesForm";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picStudent).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelShow.ResumeLayout(false);
            panelShow.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnExit;
        private Label label9;
        private Panel panel3;
        private PictureBox picStudent;
        private Panel panel1;
        private Label lblWelcome;
        private Button button3;
        private Label lblUserName;
        private Label lblRoleError;
        private Panel panelShow;
        private Label label3;
        private ComboBox comboColors;
        private Label label2;
        private ComboBox comboFontSize;
        private Label label1;
        private ComboBox comboDateFormat;
        private Label lblClassPicker;
        private ComboBox comboLanguages;
        private Button btnSave;
        private Label lblRole;
        private Label lblRoleName;
        private Label label4;
        private ComboBox comboThemes;
    }
}