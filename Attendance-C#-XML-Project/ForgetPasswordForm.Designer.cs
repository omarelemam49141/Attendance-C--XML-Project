namespace Attendance_C__XML_Project
{
    partial class ForgetPasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgetPasswordForm));
            txtEmail = new TextBox();
            btn_send_password = new Button();
            lblEmail = new Label();
            lblErr = new Label();
            SuspendLayout();
            // 
            // txtEmail
            // 
            resources.ApplyResources(txtEmail, "txtEmail");
            txtEmail.Name = "txtEmail";
            // 
            // btn_send_password
            // 
            resources.ApplyResources(btn_send_password, "btn_send_password");
            btn_send_password.BackColor = Color.Teal;
            btn_send_password.FlatAppearance.BorderSize = 0;
            btn_send_password.ForeColor = Color.Snow;
            btn_send_password.Name = "btn_send_password";
            btn_send_password.UseVisualStyleBackColor = false;
            btn_send_password.Click += btn_send_password_Click;
            // 
            // lblEmail
            // 
            resources.ApplyResources(lblEmail, "lblEmail");
            lblEmail.Name = "lblEmail";
            // 
            // lblErr
            // 
            resources.ApplyResources(lblErr, "lblErr");
            lblErr.ForeColor = Color.IndianRed;
            lblErr.Name = "lblErr";
            // 
            // ForgetPasswordForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblErr);
            Controls.Add(lblEmail);
            Controls.Add(btn_send_password);
            Controls.Add(txtEmail);
            Name = "ForgetPasswordForm";
            Tag = "myTheme";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmail;
        private Button btn_send_password;
        private Label lblEmail;
        private Label lblErr;
    }
}