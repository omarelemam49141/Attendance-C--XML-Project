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
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(73, 178, 202);
            panel3.Controls.Add(btnExit);
            panel3.Controls.Add(label9);
            resources.ApplyResources(panel3, "panel3");
            panel3.Name = "panel3";
            // 
            // picStudent
            // 
            resources.ApplyResources(picStudent, "picStudent");
            picStudent.Name = "picStudent";
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
            resources.ApplyResources(panel1, "panel1");
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
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(button3, "button3");
            button3.ForeColor = Color.Black;
            button3.Name = "button3";
            button3.UseVisualStyleBackColor = false;
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
            resources.ApplyResources(panelShow, "panelShow");
            panelShow.Name = "panelShow";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // comboThemes
            // 
            resources.ApplyResources(comboThemes, "comboThemes");
            comboThemes.FormattingEnabled = true;
            comboThemes.Items.AddRange(new object[] { resources.GetString("comboThemes.Items"), resources.GetString("comboThemes.Items1") });
            comboThemes.Name = "comboThemes";
            comboThemes.SelectedIndexChanged += comboThemes_SelectedIndexChanged;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Teal;
            btnSave.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(btnSave, "btnSave");
            btnSave.ForeColor = SystemColors.Control;
            btnSave.Name = "btnSave";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // comboColors
            // 
            resources.ApplyResources(comboColors, "comboColors");
            comboColors.FormattingEnabled = true;
            comboColors.Items.AddRange(new object[] { resources.GetString("comboColors.Items"), resources.GetString("comboColors.Items1"), resources.GetString("comboColors.Items2") });
            comboColors.Name = "comboColors";
            comboColors.SelectedIndexChanged += comboColors_SelectedIndexChanged;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // comboFontSize
            // 
            resources.ApplyResources(comboFontSize, "comboFontSize");
            comboFontSize.FormattingEnabled = true;
            comboFontSize.Items.AddRange(new object[] { resources.GetString("comboFontSize.Items"), resources.GetString("comboFontSize.Items1"), resources.GetString("comboFontSize.Items2") });
            comboFontSize.Name = "comboFontSize";
            comboFontSize.SelectedIndexChanged += ComboFontSize_SelectedIndexChanged;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // comboDateFormat
            // 
            resources.ApplyResources(comboDateFormat, "comboDateFormat");
            comboDateFormat.FormattingEnabled = true;
            comboDateFormat.Items.AddRange(new object[] { resources.GetString("comboDateFormat.Items"), resources.GetString("comboDateFormat.Items1") });
            comboDateFormat.Name = "comboDateFormat";
            comboDateFormat.SelectedIndexChanged += comboDateFormat_SelectedIndexChanged;
            // 
            // lblClassPicker
            // 
            resources.ApplyResources(lblClassPicker, "lblClassPicker");
            lblClassPicker.Name = "lblClassPicker";
            // 
            // comboLanguages
            // 
            resources.ApplyResources(comboLanguages, "comboLanguages");
            comboLanguages.FormattingEnabled = true;
            comboLanguages.Items.AddRange(new object[] { resources.GetString("comboLanguages.Items"), resources.GetString("comboLanguages.Items1") });
            comboLanguages.Name = "comboLanguages";
            comboLanguages.SelectedIndexChanged += comboBoxLanguage_SelectedIndexChanged;
            // 
            // PreferencesForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelShow);
            Controls.Add(panel1);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PreferencesForm";
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