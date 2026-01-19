namespace Admin
{
    partial class UCScheduleTable
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
            pnlInputs = new Panel();
            comboBox1 = new ComboBox();
            lblStatus = new Label();
            lblSchedule = new Label();
            tbScheduleID = new TextBox();
            btnApprove = new Button();
            pnlTable = new Panel();
            dgvScheduleList = new DataGridView();
            pnlInputs.SuspendLayout();
            pnlTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvScheduleList).BeginInit();
            SuspendLayout();
            // 
            // pnlInputs
            // 
            pnlInputs.AutoScroll = true;
            pnlInputs.BackColor = SystemColors.ActiveCaption;
            pnlInputs.Controls.Add(comboBox1);
            pnlInputs.Controls.Add(lblStatus);
            pnlInputs.Controls.Add(lblSchedule);
            pnlInputs.Controls.Add(tbScheduleID);
            pnlInputs.Controls.Add(btnApprove);
            pnlInputs.Dock = DockStyle.Left;
            pnlInputs.Location = new Point(0, 0);
            pnlInputs.Name = "pnlInputs";
            pnlInputs.Size = new Size(356, 609);
            pnlInputs.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "To Be Approved", "Active", "Completed", "Cancelled" });
            comboBox1.Location = new Point(102, 297);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 28;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(60, 279);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(42, 15);
            lblStatus.TabIndex = 27;
            lblStatus.Text = "Status:";
            // 
            // lblSchedule
            // 
            lblSchedule.AutoSize = true;
            lblSchedule.Location = new Point(60, 180);
            lblSchedule.Name = "lblSchedule";
            lblSchedule.Size = new Size(66, 15);
            lblSchedule.TabIndex = 25;
            lblSchedule.Text = "ScheduleID";
            // 
            // tbScheduleID
            // 
            tbScheduleID.Location = new Point(102, 207);
            tbScheduleID.Name = "tbScheduleID";
            tbScheduleID.Size = new Size(121, 23);
            tbScheduleID.TabIndex = 24;
            // 
            // btnApprove
            // 
            btnApprove.BackColor = Color.Yellow;
            btnApprove.FlatStyle = FlatStyle.Flat;
            btnApprove.Location = new Point(102, 380);
            btnApprove.Name = "btnApprove";
            btnApprove.Size = new Size(104, 34);
            btnApprove.TabIndex = 23;
            btnApprove.Text = "Approve";
            btnApprove.UseVisualStyleBackColor = false;
            btnApprove.Click += btnChangeStatus_Click;
            // 
            // pnlTable
            // 
            pnlTable.BackColor = Color.LightSkyBlue;
            pnlTable.Controls.Add(dgvScheduleList);
            pnlTable.Dock = DockStyle.Right;
            pnlTable.Location = new Point(354, 0);
            pnlTable.Name = "pnlTable";
            pnlTable.Size = new Size(701, 609);
            pnlTable.TabIndex = 2;
            // 
            // dgvScheduleList
            // 
            dgvScheduleList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvScheduleList.Location = new Point(23, 75);
            dgvScheduleList.Name = "dgvScheduleList";
            dgvScheduleList.Size = new Size(650, 311);
            dgvScheduleList.TabIndex = 0;
            dgvScheduleList.RowHeaderMouseClick += dgvScheduleList_RowHeaderMouseClick;
            // 
            // UCScheduleTable
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlTable);
            Controls.Add(pnlInputs);
            Name = "UCScheduleTable";
            Size = new Size(1055, 609);
            pnlInputs.ResumeLayout(false);
            pnlInputs.PerformLayout();
            pnlTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvScheduleList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlInputs;
        private Panel pnlTable;
        private Button btnApprove;
        private DataGridView dgvScheduleList;
        private Label lblStatus;
        private Label lblSchedule;
        private TextBox tbScheduleID;
        private ComboBox comboBox1;
    }
}
