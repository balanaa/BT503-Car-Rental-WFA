using Vehicle_Rental;

namespace Payment
{
    partial class UCCheckout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCCheckout));
            lblPaymentCNTitle = new Label();
            lblPaymentTitles = new Label();
            btnCreditCard = new Button();
            btnGCash = new Button();
            btnDebitCard = new Button();
            SConCheckOut = new SplitContainer();
            panel2 = new Panel();
            label1 = new Label();
            roundedPanel1 = new RoundedPanel();
            lblTotalCost = new Label();
            lblRate = new Label();
            lblShowDaysandPrice = new Label();
            pbCarPicCheckout = new PictureBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)SConCheckOut).BeginInit();
            SConCheckOut.Panel1.SuspendLayout();
            SConCheckOut.Panel2.SuspendLayout();
            SConCheckOut.SuspendLayout();
            panel2.SuspendLayout();
            roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbCarPicCheckout).BeginInit();
            SuspendLayout();
            // 
            // lblPaymentCNTitle
            // 
            lblPaymentCNTitle.AutoSize = true;
            lblPaymentCNTitle.Font = new Font("Arial", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPaymentCNTitle.Location = new Point(19, 18);
            lblPaymentCNTitle.Margin = new Padding(4, 0, 4, 0);
            lblPaymentCNTitle.Name = "lblPaymentCNTitle";
            lblPaymentCNTitle.Size = new Size(663, 41);
            lblPaymentCNTitle.TabIndex = 0;
            lblPaymentCNTitle.Text = "Secure Payment with Manila Car Rental";
            // 
            // lblPaymentTitles
            // 
            lblPaymentTitles.AutoSize = true;
            lblPaymentTitles.BackColor = Color.Transparent;
            lblPaymentTitles.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPaymentTitles.ForeColor = Color.White;
            lblPaymentTitles.Location = new Point(27, 165);
            lblPaymentTitles.Margin = new Padding(4, 0, 4, 0);
            lblPaymentTitles.Name = "lblPaymentTitles";
            lblPaymentTitles.Size = new Size(185, 25);
            lblPaymentTitles.TabIndex = 8;
            lblPaymentTitles.Text = "Select payment type:";
            // 
            // btnCreditCard
            // 
            btnCreditCard.BackColor = Color.FromArgb(255, 222, 89);
            btnCreditCard.FlatAppearance.BorderColor = Color.Black;
            btnCreditCard.Font = new Font("Segoe UI", 9.75F);
            btnCreditCard.Location = new Point(56, 219);
            btnCreditCard.Margin = new Padding(0, 0, 0, 16);
            btnCreditCard.Name = "btnCreditCard";
            btnCreditCard.Padding = new Padding(0, 0, 20, 0);
            btnCreditCard.Size = new Size(386, 54);
            btnCreditCard.TabIndex = 9;
            btnCreditCard.Text = "Credit Card";
            btnCreditCard.TextAlign = ContentAlignment.MiddleRight;
            btnCreditCard.UseVisualStyleBackColor = false;
            btnCreditCard.Click += btnCreditCard_Click;
            // 
            // btnGCash
            // 
            btnGCash.BackColor = Color.FromArgb(255, 222, 89);
            btnGCash.Font = new Font("Segoe UI", 9.75F);
            btnGCash.Location = new Point(56, 359);
            btnGCash.Margin = new Padding(0, 0, 0, 16);
            btnGCash.Name = "btnGCash";
            btnGCash.Padding = new Padding(0, 0, 20, 0);
            btnGCash.Size = new Size(386, 54);
            btnGCash.TabIndex = 11;
            btnGCash.Text = "GCash";
            btnGCash.TextAlign = ContentAlignment.MiddleRight;
            btnGCash.UseVisualStyleBackColor = false;
            btnGCash.Click += btnGcash_Click;
            // 
            // btnDebitCard
            // 
            btnDebitCard.BackColor = Color.FromArgb(255, 222, 89);
            btnDebitCard.Font = new Font("Segoe UI", 9.75F);
            btnDebitCard.Location = new Point(56, 289);
            btnDebitCard.Margin = new Padding(0, 0, 0, 16);
            btnDebitCard.Name = "btnDebitCard";
            btnDebitCard.Padding = new Padding(0, 0, 20, 0);
            btnDebitCard.Size = new Size(386, 54);
            btnDebitCard.TabIndex = 12;
            btnDebitCard.Text = "Debit Card";
            btnDebitCard.TextAlign = ContentAlignment.MiddleRight;
            btnDebitCard.UseVisualStyleBackColor = false;
            btnDebitCard.Click += btnDebitCard_Click;
            // 
            // SConCheckOut
            // 
            SConCheckOut.BackColor = Color.Red;
            SConCheckOut.Dock = DockStyle.Fill;
            SConCheckOut.Location = new Point(0, 0);
            SConCheckOut.Name = "SConCheckOut";
            // 
            // SConCheckOut.Panel1
            // 
            SConCheckOut.Panel1.BackColor = Color.DeepSkyBlue;
            SConCheckOut.Panel1.Controls.Add(panel2);
            SConCheckOut.Panel1.Controls.Add(roundedPanel1);
            // 
            // SConCheckOut.Panel2
            // 
            SConCheckOut.Panel2.BackColor = Color.FromArgb(56, 182, 255);
            SConCheckOut.Panel2.Controls.Add(label2);
            SConCheckOut.Panel2.Controls.Add(btnCreditCard);
            SConCheckOut.Panel2.Controls.Add(btnDebitCard);
            SConCheckOut.Panel2.Controls.Add(btnGCash);
            SConCheckOut.Panel2.Controls.Add(lblPaymentTitles);
            SConCheckOut.Size = new Size(1264, 581);
            SConCheckOut.SplitterDistance = 772;
            SConCheckOut.SplitterWidth = 1;
            SConCheckOut.TabIndex = 13;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(lblPaymentCNTitle);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(772, 60);
            panel2.TabIndex = 2;
            // 
            // label1
            // 
            label1.BackColor = Color.Red;
            label1.Dock = DockStyle.Right;
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(712, 0);
            label1.Name = "label1";
            label1.Size = new Size(60, 60);
            label1.TabIndex = 3;
            label1.Click += label1_Click;
            // 
            // roundedPanel1
            // 
            roundedPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            roundedPanel1.BackColor = Color.LightSkyBlue;
            roundedPanel1.Controls.Add(lblTotalCost);
            roundedPanel1.Controls.Add(lblRate);
            roundedPanel1.Controls.Add(lblShowDaysandPrice);
            roundedPanel1.Controls.Add(pbCarPicCheckout);
            roundedPanel1.Location = new Point(104, 81);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(569, 407);
            roundedPanel1.TabIndex = 0;
            // 
            // lblTotalCost
            // 
            lblTotalCost.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblTotalCost.AutoSize = true;
            lblTotalCost.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalCost.Location = new Point(45, 16);
            lblTotalCost.Margin = new Padding(0, 0, 0, 10);
            lblTotalCost.Name = "lblTotalCost";
            lblTotalCost.Size = new Size(229, 25);
            lblTotalCost.TabIndex = 3;
            lblTotalCost.Text = "Total Cost: PHP 9,465.00";
            // 
            // lblRate
            // 
            lblRate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblRate.AutoSize = true;
            lblRate.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRate.Location = new Point(45, 328);
            lblRate.Name = "lblRate";
            lblRate.Size = new Size(61, 25);
            lblRate.TabIndex = 2;
            lblRate.Text = "Rate :";
            // 
            // lblShowDaysandPrice
            // 
            lblShowDaysandPrice.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblShowDaysandPrice.AutoSize = true;
            lblShowDaysandPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblShowDaysandPrice.Location = new Point(45, 360);
            lblShowDaysandPrice.Margin = new Padding(0, 7, 0, 0);
            lblShowDaysandPrice.Name = "lblShowDaysandPrice";
            lblShowDaysandPrice.Size = new Size(173, 21);
            lblShowDaysandPrice.TabIndex = 1;
            lblShowDaysandPrice.Text = " 3 days at PHP 2,655.00";
            // 
            // pbCarPicCheckout
            // 
            pbCarPicCheckout.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pbCarPicCheckout.Location = new Point(68, 54);
            pbCarPicCheckout.Name = "pbCarPicCheckout";
            pbCarPicCheckout.Size = new Size(434, 265);
            pbCarPicCheckout.SizeMode = PictureBoxSizeMode.Zoom;
            pbCarPicCheckout.TabIndex = 0;
            pbCarPicCheckout.TabStop = false;
            // 
            // label2
            // 
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.Location = new Point(56, 18);
            label2.Name = "label2";
            label2.Size = new Size(386, 132);
            label2.TabIndex = 13;
            // 
            // UCCheckout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            BackgroundImageLayout = ImageLayout.Zoom;
            Controls.Add(SConCheckOut);
            Margin = new Padding(4, 3, 4, 3);
            Name = "UCCheckout";
            Size = new Size(1264, 581);
            SConCheckOut.Panel1.ResumeLayout(false);
            SConCheckOut.Panel2.ResumeLayout(false);
            SConCheckOut.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SConCheckOut).EndInit();
            SConCheckOut.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbCarPicCheckout).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblPaymentCNTitle;
        private System.Windows.Forms.Label lblPaymentTitles;
        private System.Windows.Forms.Button btnCreditCard;
        private System.Windows.Forms.Button btnGCash;
        private System.Windows.Forms.Button btnDebitCard;
        public SplitContainer SConCheckOut;
        private Vehicle_Rental.RoundedPanel roundedPanel1;
        private Label lblTotalCost;
        private Label lblRate;
        private Label lblShowDaysandPrice;
        private PictureBox pbCarPicCheckout;
        private Panel panel2;
        private Label label1;
        private Label label2;
    }
}
