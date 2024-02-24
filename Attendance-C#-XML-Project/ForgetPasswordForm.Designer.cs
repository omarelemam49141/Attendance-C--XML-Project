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
            txtEmail = new TextBox();
            btn_send_password = new Button();
            lblEmail = new Label();
            lblErr = new Label();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 11F);
            txtEmail.Location = new Point(79, 59);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(261, 27);
            txtEmail.TabIndex = 0;
            // 
            // btn_send_password
            // 
            btn_send_password.BackColor = Color.Teal;
            btn_send_password.FlatAppearance.BorderSize = 0;
            btn_send_password.FlatStyle = FlatStyle.Flat;
            btn_send_password.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_send_password.ForeColor = Color.Snow;
            btn_send_password.Location = new Point(126, 100);
            btn_send_password.Name = "btn_send_password";
            btn_send_password.Size = new Size(163, 35);
            btn_send_password.TabIndex = 1;
            btn_send_password.Text = "Send password";
            btn_send_password.UseVisualStyleBackColor = false;
            btn_send_password.Click += btn_send_password_Click;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 12F);
            lblEmail.Location = new Point(149, 24);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(120, 21);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Type your email";
            // 
            // lblErr
            // 
            lblErr.AutoSize = true;
            lblErr.Font = new Font("Segoe UI", 11F);
            lblErr.ForeColor = Color.IndianRed;
            lblErr.Location = new Point(8, 145);
            lblErr.MaximumSize = new Size(400, 0);
            lblErr.MinimumSize = new Size(400, 0);
            lblErr.Name = "lblErr";
            lblErr.Size = new Size(400, 20);
            lblErr.TabIndex = 3;
            lblErr.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ForgetPasswordForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(416, 197);
            Controls.Add(lblErr);
            Controls.Add(lblEmail);
            Controls.Add(btn_send_password);
            Controls.Add(txtEmail);
            Name = "ForgetPasswordForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ForgetPasswordForm";
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