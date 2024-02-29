namespace Attendance_C__XML_Project
{
    partial class Backups
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
            btnSave = new Button();
            btnLoad = new Button();
            dateBackup = new DateTimePicker();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Teal;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 12F);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(39, 90);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(130, 41);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save a backup";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnLoad
            // 
            btnLoad.BackColor = Color.IndianRed;
            btnLoad.FlatAppearance.BorderSize = 0;
            btnLoad.FlatStyle = FlatStyle.Flat;
            btnLoad.Font = new Font("Segoe UI", 12F);
            btnLoad.ForeColor = Color.White;
            btnLoad.Location = new Point(280, 90);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(130, 41);
            btnLoad.TabIndex = 1;
            btnLoad.Text = "Load a backup";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // dateBackup
            // 
            dateBackup.Location = new Point(242, 50);
            dateBackup.Name = "dateBackup";
            dateBackup.Size = new Size(200, 23);
            dateBackup.TabIndex = 2;
            // 
            // Backups
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 224);
            Controls.Add(dateBackup);
            Controls.Add(btnLoad);
            Controls.Add(btnSave);
            Name = "Backups";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Backups";
            ResumeLayout(false);
        }

        #endregion

        private Button btnSave;
        private Button btnLoad;
        private DateTimePicker dateBackup;
    }
}