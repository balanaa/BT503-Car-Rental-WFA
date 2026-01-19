namespace Admin
{
    partial class UCUpdateLogTable
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
            dgvUpdateLogsTable = new DataGridView();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUpdateLogsTable).BeginInit();
            SuspendLayout();
            // 
            // dgvUpdateLogsTable
            // 
            dgvUpdateLogsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUpdateLogsTable.Location = new Point(55, 74);
            dgvUpdateLogsTable.Name = "dgvUpdateLogsTable";
            dgvUpdateLogsTable.Size = new Size(799, 371);
            dgvUpdateLogsTable.TabIndex = 0;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Blue;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(82, 34);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(88, 34);
            btnRefresh.TabIndex = 27;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // UCUpdateLogTable
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(btnRefresh);
            Controls.Add(dgvUpdateLogsTable);
            Name = "UCUpdateLogTable";
            Size = new Size(1055, 1005);
            ((System.ComponentModel.ISupportInitialize)dgvUpdateLogsTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvUpdateLogsTable;
        private Button btnRefresh;
    }
}
