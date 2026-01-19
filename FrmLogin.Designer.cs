namespace Vehicle_Rental
{
    partial class FrmLogin
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
            lblUserName = new Label();
            tbUserName = new Payment.PaddedTextBox();
            tbPassword = new Payment.PaddedTextBox();
            lblPassword = new Label();
            btnLogin = new Button();
            lblLoginForm = new Label();
            SuspendLayout();
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserName.Location = new Point(53, 76);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(87, 21);
            lblUserName.TabIndex = 0;
            lblUserName.Text = "Username:";
            // 
            // tbUserName
            // 
            tbUserName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbUserName.Location = new Point(67, 100);
            tbUserName.Name = "tbUserName";
            tbUserName.PaddingBottom = 6;
            tbUserName.PaddingLeft = 10;
            tbUserName.PaddingRight = 0;
            tbUserName.PaddingTop = 6;
            tbUserName.Size = new Size(241, 29);
            tbUserName.TabIndex = 1;
            // 
            // tbPassword
            // 
            tbPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPassword.Location = new Point(67, 170);
            tbPassword.Name = "tbPassword";
            tbPassword.PaddingBottom = 6;
            tbPassword.PaddingLeft = 10;
            tbPassword.PaddingRight = 0;
            tbPassword.PaddingTop = 6;
            tbPassword.Size = new Size(241, 29);
            tbPassword.TabIndex = 3;
            tbPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(53, 146);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(83, 21);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password:";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Yellow;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(138, 225);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(102, 32);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblLoginForm
            // 
            lblLoginForm.AutoSize = true;
            lblLoginForm.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLoginForm.Location = new Point(117, 21);
            lblLoginForm.Name = "lblLoginForm";
            lblLoginForm.Size = new Size(150, 32);
            lblLoginForm.TabIndex = 5;
            lblLoginForm.Text = "Admin Login";
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(373, 269);
            Controls.Add(lblLoginForm);
            Controls.Add(btnLogin);
            Controls.Add(tbPassword);
            Controls.Add(lblPassword);
            Controls.Add(tbUserName);
            Controls.Add(lblUserName);
            Name = "FrmLogin";
            Text = "FrmLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUserName;
        private Payment.PaddedTextBox tbUserName;
        private Payment.PaddedTextBox tbPassword;
        private Label lblPassword;
        private Button btnLogin;
        private Label lblLoginForm;
    }
}