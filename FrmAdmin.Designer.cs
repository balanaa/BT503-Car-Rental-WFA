namespace Admin
{
    partial class FrmAdmin
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
            btnSchedule = new Button();
            btnDriverInformation = new Button();
            btnCarsTable = new Button();
            pnlMain = new Panel();
            pnlHeadingMargin = new Panel();
            button1 = new Button();
            pnlHeading = new Panel();
            btnUpdateLogsTable = new Button();
            pnlHeadingMargin.SuspendLayout();
            pnlHeading.SuspendLayout();
            SuspendLayout();
            // 
            // btnSchedule
            // 
            btnSchedule.BackColor = Color.Yellow;
            btnSchedule.Dock = DockStyle.Right;
            btnSchedule.FlatAppearance.BorderSize = 0;
            btnSchedule.FlatStyle = FlatStyle.Flat;
            btnSchedule.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSchedule.Location = new Point(639, 0);
            btnSchedule.Margin = new Padding(4, 0, 4, 0);
            btnSchedule.Name = "btnSchedule";
            btnSchedule.Size = new Size(152, 48);
            btnSchedule.TabIndex = 1;
            btnSchedule.Text = "Schedule";
            btnSchedule.UseVisualStyleBackColor = false;
            btnSchedule.Click += btnSchedule_Click;
            // 
            // btnDriverInformation
            // 
            btnDriverInformation.BackColor = Color.Yellow;
            btnDriverInformation.Dock = DockStyle.Right;
            btnDriverInformation.FlatAppearance.BorderSize = 0;
            btnDriverInformation.FlatStyle = FlatStyle.Flat;
            btnDriverInformation.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDriverInformation.Location = new Point(791, 0);
            btnDriverInformation.Margin = new Padding(4, 0, 4, 0);
            btnDriverInformation.Name = "btnDriverInformation";
            btnDriverInformation.Size = new Size(152, 48);
            btnDriverInformation.TabIndex = 2;
            btnDriverInformation.Text = "Driver Information";
            btnDriverInformation.UseVisualStyleBackColor = false;
            btnDriverInformation.Click += btnDriverInformation_Click;
            // 
            // btnCarsTable
            // 
            btnCarsTable.BackColor = Color.Yellow;
            btnCarsTable.Dock = DockStyle.Right;
            btnCarsTable.FlatAppearance.BorderSize = 0;
            btnCarsTable.FlatStyle = FlatStyle.Flat;
            btnCarsTable.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCarsTable.Location = new Point(487, 0);
            btnCarsTable.Margin = new Padding(4, 0, 4, 0);
            btnCarsTable.Name = "btnCarsTable";
            btnCarsTable.Size = new Size(152, 48);
            btnCarsTable.TabIndex = 3;
            btnCarsTable.Text = "Cars";
            btnCarsTable.UseVisualStyleBackColor = false;
            btnCarsTable.Click += btnCarsTable_Click;
            // 
            // pnlMain
            // 
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 48);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1039, 469);
            pnlMain.TabIndex = 0;
            // 
            // pnlHeadingMargin
            // 
            pnlHeadingMargin.Controls.Add(button1);
            pnlHeadingMargin.Dock = DockStyle.Right;
            pnlHeadingMargin.Location = new Point(943, 0);
            pnlHeadingMargin.Margin = new Padding(0);
            pnlHeadingMargin.Name = "pnlHeadingMargin";
            pnlHeadingMargin.Size = new Size(96, 48);
            pnlHeadingMargin.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.Yellow;
            button1.Location = new Point(9, 8);
            button1.Name = "button1";
            button1.Size = new Size(75, 33);
            button1.TabIndex = 5;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pnlHeading
            // 
            pnlHeading.BackColor = Color.DeepSkyBlue;
            pnlHeading.Controls.Add(btnUpdateLogsTable);
            pnlHeading.Controls.Add(btnCarsTable);
            pnlHeading.Controls.Add(btnSchedule);
            pnlHeading.Controls.Add(btnDriverInformation);
            pnlHeading.Controls.Add(pnlHeadingMargin);
            pnlHeading.Dock = DockStyle.Top;
            pnlHeading.ForeColor = SystemColors.ActiveCaptionText;
            pnlHeading.Location = new Point(0, 0);
            pnlHeading.Name = "pnlHeading";
            pnlHeading.Size = new Size(1039, 48);
            pnlHeading.TabIndex = 0;
            // 
            // btnUpdateLogsTable
            // 
            btnUpdateLogsTable.BackColor = Color.Yellow;
            btnUpdateLogsTable.Dock = DockStyle.Left;
            btnUpdateLogsTable.FlatAppearance.BorderSize = 0;
            btnUpdateLogsTable.FlatStyle = FlatStyle.Flat;
            btnUpdateLogsTable.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateLogsTable.ForeColor = Color.DeepSkyBlue;
            btnUpdateLogsTable.Location = new Point(0, 0);
            btnUpdateLogsTable.Margin = new Padding(4, 0, 4, 0);
            btnUpdateLogsTable.Name = "btnUpdateLogsTable";
            btnUpdateLogsTable.Size = new Size(152, 48);
            btnUpdateLogsTable.TabIndex = 4;
            btnUpdateLogsTable.Text = "UpdateLogs";
            btnUpdateLogsTable.UseVisualStyleBackColor = false;
            btnUpdateLogsTable.Click += btnUpdateLogsTable_Click;
            // 
            // FrmAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1039, 517);
            Controls.Add(pnlMain);
            Controls.Add(pnlHeading);
            Name = "FrmAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            pnlHeadingMargin.ResumeLayout(false);
            pnlHeading.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnCarsTable;
        private Button btnSchedule;
        private Button btnDriverInformation;
        private Panel pnlMain;
        private Panel pnlHeadingMargin;
        private Panel pnlHeading;
        private Button btnUpdateLogsTable;
        private Button button1;
    }
}
