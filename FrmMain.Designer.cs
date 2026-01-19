namespace Vehicle_Rental
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            pnlHeading = new Panel();
            pnlHeadingDropOffDate = new Panel();
            lblHeadingDropOffDateTime = new Label();
            lblDD = new Label();
            pnlHeadingPickUpDate = new Panel();
            lblHeadingPickUpDateTime = new Label();
            lblDT = new Label();
            pnlExitContainer = new Panel();
            exitIcon = new PictureBox();
            pnlHeadingPickUpLoc = new Panel();
            lblHeadingPickUpLoc = new Label();
            lblPL = new Label();
            pnlHeadingDropOffLoc = new Panel();
            lblHeadingDropOffLoc = new Label();
            lblDL = new Label();
            pbLogo = new PictureBox();
            pnlNavigation = new Panel();
            pnlHighlightCurrentPnl = new Panel();
            pnlHeaderBottom = new Panel();
            pbArrow3 = new PictureBox();
            pbArrow2 = new PictureBox();
            pbArrow1 = new PictureBox();
            btnDriverInfo = new Button();
            btnCheckout = new Button();
            btnSchedule = new Button();
            btnChooseCar = new Button();
            pnlMain = new Panel();
            pnlHeading.SuspendLayout();
            pnlHeadingDropOffDate.SuspendLayout();
            pnlHeadingPickUpDate.SuspendLayout();
            pnlExitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)exitIcon).BeginInit();
            pnlHeadingPickUpLoc.SuspendLayout();
            pnlHeadingDropOffLoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            pnlNavigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbArrow3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbArrow2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbArrow1).BeginInit();
            SuspendLayout();
            // 
            // pnlHeading
            // 
            pnlHeading.BackColor = Color.FromArgb(56, 182, 255);
            pnlHeading.Controls.Add(pnlHeadingDropOffDate);
            pnlHeading.Controls.Add(pnlHeadingPickUpDate);
            pnlHeading.Controls.Add(pnlExitContainer);
            pnlHeading.Controls.Add(pnlHeadingPickUpLoc);
            pnlHeading.Controls.Add(pnlHeadingDropOffLoc);
            pnlHeading.Controls.Add(pbLogo);
            pnlHeading.Dock = DockStyle.Top;
            pnlHeading.Location = new Point(0, 0);
            pnlHeading.Name = "pnlHeading";
            pnlHeading.Size = new Size(1264, 47);
            pnlHeading.TabIndex = 0;
            // 
            // pnlHeadingDropOffDate
            // 
            pnlHeadingDropOffDate.BorderStyle = BorderStyle.FixedSingle;
            pnlHeadingDropOffDate.Controls.Add(lblHeadingDropOffDateTime);
            pnlHeadingDropOffDate.Controls.Add(lblDD);
            pnlHeadingDropOffDate.Location = new Point(940, 0);
            pnlHeadingDropOffDate.Name = "pnlHeadingDropOffDate";
            pnlHeadingDropOffDate.Size = new Size(247, 47);
            pnlHeadingDropOffDate.TabIndex = 3;
            // 
            // lblHeadingDropOffDateTime
            // 
            lblHeadingDropOffDateTime.AutoSize = true;
            lblHeadingDropOffDateTime.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHeadingDropOffDateTime.Location = new Point(4, 18);
            lblHeadingDropOffDateTime.Name = "lblHeadingDropOffDateTime";
            lblHeadingDropOffDateTime.Size = new Size(0, 20);
            lblHeadingDropOffDateTime.TabIndex = 3;
            // 
            // lblDD
            // 
            lblDD.AutoSize = true;
            lblDD.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDD.Location = new Point(3, 0);
            lblDD.Name = "lblDD";
            lblDD.Size = new Size(125, 20);
            lblDD.TabIndex = 2;
            lblDD.Text = "Drop-off Date/Time";
            // 
            // pnlHeadingPickUpDate
            // 
            pnlHeadingPickUpDate.BorderStyle = BorderStyle.FixedSingle;
            pnlHeadingPickUpDate.Controls.Add(lblHeadingPickUpDateTime);
            pnlHeadingPickUpDate.Controls.Add(lblDT);
            pnlHeadingPickUpDate.Location = new Point(450, 0);
            pnlHeadingPickUpDate.Name = "pnlHeadingPickUpDate";
            pnlHeadingPickUpDate.Size = new Size(239, 47);
            pnlHeadingPickUpDate.TabIndex = 1;
            // 
            // lblHeadingPickUpDateTime
            // 
            lblHeadingPickUpDateTime.AutoSize = true;
            lblHeadingPickUpDateTime.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHeadingPickUpDateTime.Location = new Point(3, 20);
            lblHeadingPickUpDateTime.Name = "lblHeadingPickUpDateTime";
            lblHeadingPickUpDateTime.Size = new Size(0, 20);
            lblHeadingPickUpDateTime.TabIndex = 2;
            // 
            // lblDT
            // 
            lblDT.AutoSize = true;
            lblDT.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDT.Location = new Point(3, 0);
            lblDT.Name = "lblDT";
            lblDT.Size = new Size(122, 20);
            lblDT.TabIndex = 1;
            lblDT.Text = "Pick-up Date/Time";
            // 
            // pnlExitContainer
            // 
            pnlExitContainer.Controls.Add(exitIcon);
            pnlExitContainer.Location = new Point(1210, 0);
            pnlExitContainer.Name = "pnlExitContainer";
            pnlExitContainer.Size = new Size(54, 47);
            pnlExitContainer.TabIndex = 1;
            // 
            // exitIcon
            // 
            exitIcon.Image = (Image)resources.GetObject("exitIcon.Image");
            exitIcon.Location = new Point(12, 9);
            exitIcon.Name = "exitIcon";
            exitIcon.Size = new Size(30, 30);
            exitIcon.SizeMode = PictureBoxSizeMode.CenterImage;
            exitIcon.TabIndex = 0;
            exitIcon.TabStop = false;
            exitIcon.Click += exitIcon_Click;
            // 
            // pnlHeadingPickUpLoc
            // 
            pnlHeadingPickUpLoc.BorderStyle = BorderStyle.FixedSingle;
            pnlHeadingPickUpLoc.Controls.Add(lblHeadingPickUpLoc);
            pnlHeadingPickUpLoc.Controls.Add(lblPL);
            pnlHeadingPickUpLoc.Location = new Point(209, 0);
            pnlHeadingPickUpLoc.Name = "pnlHeadingPickUpLoc";
            pnlHeadingPickUpLoc.Size = new Size(239, 47);
            pnlHeadingPickUpLoc.TabIndex = 2;
            // 
            // lblHeadingPickUpLoc
            // 
            lblHeadingPickUpLoc.AutoSize = true;
            lblHeadingPickUpLoc.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHeadingPickUpLoc.Location = new Point(3, 20);
            lblHeadingPickUpLoc.Name = "lblHeadingPickUpLoc";
            lblHeadingPickUpLoc.Size = new Size(0, 20);
            lblHeadingPickUpLoc.TabIndex = 1;
            // 
            // lblPL
            // 
            lblPL.AutoSize = true;
            lblPL.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPL.Location = new Point(3, 0);
            lblPL.Name = "lblPL";
            lblPL.Size = new Size(114, 20);
            lblPL.TabIndex = 0;
            lblPL.Text = "Pick-up Location";
            // 
            // pnlHeadingDropOffLoc
            // 
            pnlHeadingDropOffLoc.BorderStyle = BorderStyle.FixedSingle;
            pnlHeadingDropOffLoc.Controls.Add(lblHeadingDropOffLoc);
            pnlHeadingDropOffLoc.Controls.Add(lblDL);
            pnlHeadingDropOffLoc.Location = new Point(691, 0);
            pnlHeadingDropOffLoc.Name = "pnlHeadingDropOffLoc";
            pnlHeadingDropOffLoc.Size = new Size(248, 47);
            pnlHeadingDropOffLoc.TabIndex = 0;
            // 
            // lblHeadingDropOffLoc
            // 
            lblHeadingDropOffLoc.AutoSize = true;
            lblHeadingDropOffLoc.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHeadingDropOffLoc.Location = new Point(3, 20);
            lblHeadingDropOffLoc.Name = "lblHeadingDropOffLoc";
            lblHeadingDropOffLoc.Size = new Size(0, 20);
            lblHeadingDropOffLoc.TabIndex = 3;
            // 
            // lblDL
            // 
            lblDL.AutoSize = true;
            lblDL.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDL.Location = new Point(3, 0);
            lblDL.Name = "lblDL";
            lblDL.Size = new Size(117, 20);
            lblDL.TabIndex = 2;
            lblDL.Text = "Drop-off Location";
            // 
            // pbLogo
            // 
            pbLogo.BackgroundImage = (Image)resources.GetObject("pbLogo.BackgroundImage");
            pbLogo.Cursor = Cursors.Hand;
            pbLogo.Location = new Point(12, 0);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(176, 47);
            pbLogo.TabIndex = 0;
            pbLogo.TabStop = false;
            pbLogo.Click += pictureBox4_Click;
            // 
            // pnlNavigation
            // 
            pnlNavigation.BackColor = Color.FromArgb(255, 222, 89);
            pnlNavigation.Controls.Add(pnlHighlightCurrentPnl);
            pnlNavigation.Controls.Add(pnlHeaderBottom);
            pnlNavigation.Controls.Add(pbArrow3);
            pnlNavigation.Controls.Add(pbArrow2);
            pnlNavigation.Controls.Add(pbArrow1);
            pnlNavigation.Controls.Add(btnDriverInfo);
            pnlNavigation.Controls.Add(btnCheckout);
            pnlNavigation.Controls.Add(btnSchedule);
            pnlNavigation.Controls.Add(btnChooseCar);
            pnlNavigation.Dock = DockStyle.Top;
            pnlNavigation.Location = new Point(0, 47);
            pnlNavigation.Margin = new Padding(0);
            pnlNavigation.Name = "pnlNavigation";
            pnlNavigation.Size = new Size(1264, 53);
            pnlNavigation.TabIndex = 1;
            // 
            // pnlHighlightCurrentPnl
            // 
            pnlHighlightCurrentPnl.BackColor = Color.Red;
            pnlHighlightCurrentPnl.Location = new Point(116, 50);
            pnlHighlightCurrentPnl.Name = "pnlHighlightCurrentPnl";
            pnlHighlightCurrentPnl.Size = new Size(227, 3);
            pnlHighlightCurrentPnl.TabIndex = 0;
            // 
            // pnlHeaderBottom
            // 
            pnlHeaderBottom.BackColor = Color.Red;
            pnlHeaderBottom.Dock = DockStyle.Bottom;
            pnlHeaderBottom.Location = new Point(0, 50);
            pnlHeaderBottom.Name = "pnlHeaderBottom";
            pnlHeaderBottom.Size = new Size(1264, 3);
            pnlHeaderBottom.TabIndex = 8;
            // 
            // pbArrow3
            // 
            pbArrow3.Image = Properties.Resources.play_arrow_16dp_000000_FILL1_wght700_GRAD0_opsz20;
            pbArrow3.Location = new Point(886, 11);
            pbArrow3.Name = "pbArrow3";
            pbArrow3.Size = new Size(30, 30);
            pbArrow3.SizeMode = PictureBoxSizeMode.Zoom;
            pbArrow3.TabIndex = 6;
            pbArrow3.TabStop = false;
            // 
            // pbArrow2
            // 
            pbArrow2.Image = Properties.Resources.play_arrow_16dp_000000_FILL1_wght700_GRAD0_opsz20;
            pbArrow2.Location = new Point(617, 11);
            pbArrow2.Name = "pbArrow2";
            pbArrow2.Size = new Size(30, 30);
            pbArrow2.SizeMode = PictureBoxSizeMode.Zoom;
            pbArrow2.TabIndex = 5;
            pbArrow2.TabStop = false;
            // 
            // pbArrow1
            // 
            pbArrow1.Image = (Image)resources.GetObject("pbArrow1.Image");
            pbArrow1.Location = new Point(349, 12);
            pbArrow1.Name = "pbArrow1";
            pbArrow1.Size = new Size(30, 30);
            pbArrow1.SizeMode = PictureBoxSizeMode.Zoom;
            pbArrow1.TabIndex = 4;
            pbArrow1.TabStop = false;
            // 
            // btnDriverInfo
            // 
            btnDriverInfo.BackColor = Color.FromArgb(255, 222, 89);
            btnDriverInfo.FlatAppearance.BorderSize = 0;
            btnDriverInfo.FlatStyle = FlatStyle.Flat;
            btnDriverInfo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDriverInfo.Image = (Image)resources.GetObject("btnDriverInfo.Image");
            btnDriverInfo.Location = new Point(653, 0);
            btnDriverInfo.Name = "btnDriverInfo";
            btnDriverInfo.Padding = new Padding(20, 0, 0, 0);
            btnDriverInfo.Size = new Size(227, 55);
            btnDriverInfo.TabIndex = 2;
            btnDriverInfo.Text = "Driver Info";
            btnDriverInfo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDriverInfo.UseVisualStyleBackColor = false;
            btnDriverInfo.Click += btnDriverInfo_Click;
            // 
            // btnCheckout
            // 
            btnCheckout.BackColor = Color.FromArgb(255, 222, 89);
            btnCheckout.FlatAppearance.BorderSize = 0;
            btnCheckout.FlatStyle = FlatStyle.Flat;
            btnCheckout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCheckout.Image = (Image)resources.GetObject("btnCheckout.Image");
            btnCheckout.Location = new Point(923, 0);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Padding = new Padding(20, 0, 0, 0);
            btnCheckout.Size = new Size(227, 55);
            btnCheckout.TabIndex = 3;
            btnCheckout.Text = "Checkout";
            btnCheckout.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCheckout.UseVisualStyleBackColor = false;
            btnCheckout.Click += btnCheckout_Click;
            // 
            // btnSchedule
            // 
            btnSchedule.BackColor = Color.FromArgb(255, 222, 89);
            btnSchedule.FlatAppearance.BorderColor = Color.Red;
            btnSchedule.FlatAppearance.BorderSize = 0;
            btnSchedule.FlatStyle = FlatStyle.Flat;
            btnSchedule.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSchedule.ForeColor = Color.Black;
            btnSchedule.Image = (Image)resources.GetObject("btnSchedule.Image");
            btnSchedule.Location = new Point(116, 0);
            btnSchedule.Name = "btnSchedule";
            btnSchedule.Padding = new Padding(25, 0, 0, 0);
            btnSchedule.Size = new Size(227, 55);
            btnSchedule.TabIndex = 0;
            btnSchedule.Text = "Schedule";
            btnSchedule.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSchedule.UseVisualStyleBackColor = false;
            btnSchedule.Click += btnSchedule_Click;
            // 
            // btnChooseCar
            // 
            btnChooseCar.BackColor = Color.FromArgb(255, 222, 89);
            btnChooseCar.FlatAppearance.BorderSize = 0;
            btnChooseCar.FlatStyle = FlatStyle.Flat;
            btnChooseCar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChooseCar.Image = (Image)resources.GetObject("btnChooseCar.Image");
            btnChooseCar.Location = new Point(385, 0);
            btnChooseCar.Name = "btnChooseCar";
            btnChooseCar.Padding = new Padding(15, 0, 0, 0);
            btnChooseCar.Size = new Size(227, 55);
            btnChooseCar.TabIndex = 1;
            btnChooseCar.Text = "Choose a Car";
            btnChooseCar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnChooseCar.UseVisualStyleBackColor = false;
            btnChooseCar.Click += btnChooseCar_Click;
            // 
            // pnlMain
            // 
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 100);
            pnlMain.Margin = new Padding(0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1264, 581);
            pnlMain.TabIndex = 3;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1264, 681);
            Controls.Add(pnlMain);
            Controls.Add(pnlNavigation);
            Controls.Add(pnlHeading);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            pnlHeading.ResumeLayout(false);
            pnlHeadingDropOffDate.ResumeLayout(false);
            pnlHeadingDropOffDate.PerformLayout();
            pnlHeadingPickUpDate.ResumeLayout(false);
            pnlHeadingPickUpDate.PerformLayout();
            pnlExitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)exitIcon).EndInit();
            pnlHeadingPickUpLoc.ResumeLayout(false);
            pnlHeadingPickUpLoc.PerformLayout();
            pnlHeadingDropOffLoc.ResumeLayout(false);
            pnlHeadingDropOffLoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            pnlNavigation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbArrow3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbArrow2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbArrow1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeading;
        private Panel pnlNavigation;
        private Button btnSchedule;
        private Button btnCheckout;
        private Button btnDriverInfo;
        private Button btnChooseCar;
        private Panel pnlMain;
        private PictureBox exitIcon;
        private PictureBox pbArrow3;
        private PictureBox pbArrow2;
        private PictureBox pbArrow1;
        private Panel pnlExitContainer;
        private PictureBox pbLogo;
        private Panel pnlHeadingDropOffLoc;
        private Panel pnlHeadingPickUpLoc;
        private Panel pnlHeadingPickUpDate;
        private Label lblDT;
        private Label lblPL;
        private Label lblDL;
        private Panel pnlHeadingDropOffDate;
        private Label lblHeadingDropOffDateTime;
        private Label lblDD;
        private Label lblHeadingPickUpDateTime;
        private Label lblHeadingPickUpLoc;
        private Label lblHeadingDropOffLoc;
        private Panel pnlHeaderBottom;
        private Panel pnlHighlightCurrentPnl;
    }
}
