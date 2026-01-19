namespace progressbar
{
    partial class frmPopUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPopUp));
            tbPopUpDescription = new TextBox();
            pbPopUpImg = new PictureBox();
            lblPopUpRate = new Label();
            panel1 = new Panel();
            lblPopUpPrice = new Label();
            btnSelectCar = new Button();
            ((System.ComponentModel.ISupportInitialize)pbPopUpImg).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tbPopUpDescription
            // 
            tbPopUpDescription.BackColor = Color.FromArgb(56, 182, 255);
            tbPopUpDescription.BorderStyle = BorderStyle.None;
            tbPopUpDescription.Location = new Point(26, 311);
            tbPopUpDescription.Multiline = true;
            tbPopUpDescription.Name = "tbPopUpDescription";
            tbPopUpDescription.ReadOnly = true;
            tbPopUpDescription.Size = new Size(357, 53);
            tbPopUpDescription.TabIndex = 5;
            tbPopUpDescription.Text = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy typesetting, remaining essentially unchanged";
            // 
            // pbPopUpImg
            // 
            pbPopUpImg.Image = (Image)resources.GetObject("pbPopUpImg.Image");
            pbPopUpImg.Location = new Point(26, 12);
            pbPopUpImg.Name = "pbPopUpImg";
            pbPopUpImg.Size = new Size(357, 291);
            pbPopUpImg.SizeMode = PictureBoxSizeMode.Zoom;
            pbPopUpImg.TabIndex = 3;
            pbPopUpImg.TabStop = false;
            // 
            // lblPopUpRate
            // 
            lblPopUpRate.AutoSize = true;
            lblPopUpRate.BackColor = Color.FromArgb(56, 182, 255);
            lblPopUpRate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPopUpRate.ForeColor = SystemColors.ControlText;
            lblPopUpRate.Location = new Point(23, 364);
            lblPopUpRate.Name = "lblPopUpRate";
            lblPopUpRate.Size = new Size(109, 21);
            lblPopUpRate.TabIndex = 6;
            lblPopUpRate.Text = "Rate per day:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(56, 182, 255);
            panel1.Controls.Add(btnSelectCar);
            panel1.Controls.Add(lblPopUpPrice);
            panel1.Controls.Add(lblPopUpRate);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(406, 435);
            panel1.TabIndex = 9;
            // 
            // lblPopUpPrice
            // 
            lblPopUpPrice.AutoSize = true;
            lblPopUpPrice.BackColor = Color.FromArgb(56, 182, 255);
            lblPopUpPrice.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPopUpPrice.ForeColor = Color.Red;
            lblPopUpPrice.Location = new Point(138, 364);
            lblPopUpPrice.Name = "lblPopUpPrice";
            lblPopUpPrice.Size = new Size(109, 21);
            lblPopUpPrice.TabIndex = 9;
            lblPopUpPrice.Text = "Rate per day:";
            // 
            // btnSelectCar
            // 
            btnSelectCar.BackColor = Color.FromArgb(255, 222, 89);
            btnSelectCar.FlatStyle = FlatStyle.Flat;
            btnSelectCar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSelectCar.Location = new Point(237, 396);
            btnSelectCar.Name = "btnSelectCar";
            btnSelectCar.Size = new Size(143, 30);
            btnSelectCar.TabIndex = 10;
            btnSelectCar.Text = "Select This Car";
            btnSelectCar.UseVisualStyleBackColor = false;
            btnSelectCar.Click += btnSelectCar_Click;
            // 
            // frmPopUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 222, 89);
            ClientSize = new Size(413, 441);
            Controls.Add(tbPopUpDescription);
            Controls.Add(pbPopUpImg);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmPopUp";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pbPopUpImg).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbPopUpDescription;
        private PictureBox pbPopUpImg;
        private Label lblPopUpRate;
        private Panel panel1;
        private Label lblPopUpPrice;
        private Button btnSelectCar;
    }
}