using System.Windows.Forms;

namespace Vehicle_Rental
{
    partial class UCCheckoutGcash
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCCheckoutGcash));
            lblShowGcash = new Label();
            btnGcashPay = new Button();
            lblErrEmail = new Label();
            pnlErrEmail = new Panel();
            tbEmail = new Payment.PaddedTextBox();
            lblEmail = new Label();
            pictureBox1 = new PictureBox();
            lblreference = new Label();
            panel1 = new Panel();
            ReferenceNo = new Payment.PaddedTextBox();
            lblErrReference = new Label();
            pnlErrEmail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblShowGcash
            // 
            lblShowGcash.AutoSize = true;
            lblShowGcash.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblShowGcash.ForeColor = Color.White;
            lblShowGcash.Location = new Point(150, 42);
            lblShowGcash.Margin = new Padding(130, 0, 0, 0);
            lblShowGcash.Name = "lblShowGcash";
            lblShowGcash.Size = new Size(185, 27);
            lblShowGcash.TabIndex = 12;
            lblShowGcash.Text = "Pay with GCash";
            // 
            // btnGcashPay
            // 
            btnGcashPay.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGcashPay.Location = new Point(61, 508);
            btnGcashPay.Name = "btnGcashPay";
            btnGcashPay.Size = new Size(367, 46);
            btnGcashPay.TabIndex = 14;
            btnGcashPay.Text = "Click After Payment";
            btnGcashPay.UseVisualStyleBackColor = true;
            btnGcashPay.Click += button1_Click;
            // 
            // lblErrEmail
            // 
            lblErrEmail.AutoSize = true;
            lblErrEmail.ForeColor = Color.LightSkyBlue;
            lblErrEmail.Location = new Point(90, 72);
            lblErrEmail.Name = "lblErrEmail";
            lblErrEmail.Size = new Size(32, 15);
            lblErrEmail.TabIndex = 40;
            lblErrEmail.Text = "Error";
            // 
            // pnlErrEmail
            // 
            pnlErrEmail.BackColor = Color.LightSkyBlue;
            pnlErrEmail.Controls.Add(tbEmail);
            pnlErrEmail.Location = new Point(34, 95);
            pnlErrEmail.Name = "pnlErrEmail";
            pnlErrEmail.Size = new Size(422, 45);
            pnlErrEmail.TabIndex = 39;
            // 
            // tbEmail
            // 
            tbEmail.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbEmail.Location = new Point(2, 2);
            tbEmail.Margin = new Padding(4, 3, 4, 3);
            tbEmail.Multiline = true;
            tbEmail.Name = "tbEmail";
            tbEmail.PaddingBottom = 6;
            tbEmail.PaddingLeft = 10;
            tbEmail.PaddingRight = 0;
            tbEmail.PaddingTop = 6;
            tbEmail.Size = new Size(418, 41);
            tbEmail.TabIndex = 16;
            tbEmail.TextChanged += tbEmail_TextChanged;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = Color.White;
            lblEmail.Location = new Point(30, 66);
            lblEmail.Margin = new Padding(0, 0, 0, 4);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(57, 22);
            lblEmail.TabIndex = 38;
            lblEmail.Text = "Email";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(108, 227);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(271, 267);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 41;
            pictureBox1.TabStop = false;
            // 
            // lblreference
            // 
            lblreference.AutoSize = true;
            lblreference.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblreference.ForeColor = Color.White;
            lblreference.Location = new Point(30, 147);
            lblreference.Margin = new Padding(0, 0, 0, 4);
            lblreference.Name = "lblreference";
            lblreference.Size = new Size(134, 22);
            lblreference.TabIndex = 42;
            lblreference.Text = "Reference No.";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSkyBlue;
            panel1.Controls.Add(ReferenceNo);
            panel1.Location = new Point(34, 176);
            panel1.Name = "panel1";
            panel1.Size = new Size(422, 45);
            panel1.TabIndex = 40;
            // 
            // ReferenceNo
            // 
            ReferenceNo.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ReferenceNo.Location = new Point(2, 2);
            ReferenceNo.Margin = new Padding(4, 3, 4, 3);
            ReferenceNo.Multiline = true;
            ReferenceNo.Name = "ReferenceNo";
            ReferenceNo.PaddingBottom = 6;
            ReferenceNo.PaddingLeft = 10;
            ReferenceNo.PaddingRight = 0;
            ReferenceNo.PaddingTop = 6;
            ReferenceNo.Size = new Size(418, 41);
            ReferenceNo.TabIndex = 16;
            ReferenceNo.TextChanged += paddedTextBox1_TextChanged;
            ReferenceNo.KeyPress += ReferenceNo_KeyPress;
            // 
            // lblErrReference
            // 
            lblErrReference.AutoSize = true;
            lblErrReference.ForeColor = Color.LightSkyBlue;
            lblErrReference.Location = new Point(167, 153);
            lblErrReference.Name = "lblErrReference";
            lblErrReference.Size = new Size(32, 15);
            lblErrReference.TabIndex = 43;
            lblErrReference.Text = "Error";
            // 
            // UCCheckoutGcash
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            Controls.Add(lblErrReference);
            Controls.Add(panel1);
            Controls.Add(lblreference);
            Controls.Add(lblErrEmail);
            Controls.Add(pictureBox1);
            Controls.Add(pnlErrEmail);
            Controls.Add(lblEmail);
            Controls.Add(btnGcashPay);
            Controls.Add(lblShowGcash);
            Name = "UCCheckoutGcash";
            Size = new Size(490, 581);
            pnlErrEmail.ResumeLayout(false);
            pnlErrEmail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblShowGcash;
        private Button btnGcashPay;
        private Label lblErrEmail;
        private Panel pnlErrEmail;
        private Payment.PaddedTextBox tbEmail;
        private Label lblEmail;
        private PictureBox pictureBox1;
        private Label lblreference;
        private Panel panel1;
        private Payment.PaddedTextBox ReferenceNo;
        private Label lblErrReference;
    }
}
