namespace Vehicle_Rental
{
    partial class UCHomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCHomePage));
            webMaps = new Microsoft.Web.WebView2.WinForms.WebView2();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)webMaps).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // webMaps
            // 
            webMaps.AllowExternalDrop = true;
            webMaps.BackColor = Color.White;
            webMaps.CreationProperties = null;
            webMaps.DefaultBackgroundColor = Color.White;
            webMaps.Location = new Point(579, 40);
            webMaps.Name = "webMaps";
            webMaps.Size = new Size(633, 507);
            webMaps.TabIndex = 1;
            webMaps.ZoomFactor = 1D;
            webMaps.Click += webMaps_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(72, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(484, 399);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 564);
            panel1.Name = "panel1";
            panel1.Size = new Size(1264, 36);
            panel1.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.Yellow;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(1050, 3);
            button1.Name = "button1";
            button1.Size = new Size(211, 30);
            button1.TabIndex = 0;
            button1.Text = "Admin Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // UCHomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(56, 182, 255);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(webMaps);
            Name = "UCHomePage";
            Size = new Size(1264, 600);
            Load += UCHomePage_Load;
            ((System.ComponentModel.ISupportInitialize)webMaps).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webMaps;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button button1;
    }
}
