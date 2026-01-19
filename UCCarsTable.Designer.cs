using System.Windows.Forms;

namespace Admin
{
    partial class UCCarsTable
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
            tbAvailable = new TextBox();
            lblAvailable = new Label();
            tbPlateNumber = new TextBox();
            lblPlateNumber = new Label();
            tbCarID = new TextBox();
            lblCarID = new Label();
            btnClearAll = new Button();
            tbDescription = new TextBox();
            lblDescription = new Label();
            tbPrice = new TextBox();
            lblDoors = new Label();
            lblPrice = new Label();
            lblTransmission = new Label();
            tbDoors = new TextBox();
            lblSeatingCapacity = new Label();
            tbSeatingCapacity = new TextBox();
            tbTransmission = new TextBox();
            lblFuelType = new Label();
            tbFuelType = new TextBox();
            lblBodyType = new Label();
            tbBodyType = new TextBox();
            lblCarBrand = new Label();
            tbCarBrand = new TextBox();
            lblCarName = new Label();
            tbCarName = new TextBox();
            lblImgFilePath = new Label();
            tbImgFilePath = new TextBox();
            pictureBox1 = new PictureBox();
            pnlTable = new Panel();
            btnRefresh = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            dgvCarList = new DataGridView();
            pnlInputs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCarList).BeginInit();
            SuspendLayout();
            // 
            // pnlInputs
            // 
            pnlInputs.AutoScroll = true;
            pnlInputs.BackColor = Color.LightSkyBlue;
            pnlInputs.Controls.Add(tbAvailable);
            pnlInputs.Controls.Add(lblAvailable);
            pnlInputs.Controls.Add(tbPlateNumber);
            pnlInputs.Controls.Add(lblPlateNumber);
            pnlInputs.Controls.Add(tbCarID);
            pnlInputs.Controls.Add(lblCarID);
            pnlInputs.Controls.Add(btnClearAll);
            pnlInputs.Controls.Add(tbDescription);
            pnlInputs.Controls.Add(lblDescription);
            pnlInputs.Controls.Add(tbPrice);
            pnlInputs.Controls.Add(lblDoors);
            pnlInputs.Controls.Add(lblPrice);
            pnlInputs.Controls.Add(lblTransmission);
            pnlInputs.Controls.Add(tbDoors);
            pnlInputs.Controls.Add(lblSeatingCapacity);
            pnlInputs.Controls.Add(tbSeatingCapacity);
            pnlInputs.Controls.Add(tbTransmission);
            pnlInputs.Controls.Add(lblFuelType);
            pnlInputs.Controls.Add(tbFuelType);
            pnlInputs.Controls.Add(lblBodyType);
            pnlInputs.Controls.Add(tbBodyType);
            pnlInputs.Controls.Add(lblCarBrand);
            pnlInputs.Controls.Add(tbCarBrand);
            pnlInputs.Controls.Add(lblCarName);
            pnlInputs.Controls.Add(tbCarName);
            pnlInputs.Controls.Add(lblImgFilePath);
            pnlInputs.Controls.Add(tbImgFilePath);
            pnlInputs.Controls.Add(pictureBox1);
            pnlInputs.Dock = DockStyle.Left;
            pnlInputs.Location = new Point(0, 0);
            pnlInputs.Name = "pnlInputs";
            pnlInputs.Size = new Size(356, 1005);
            pnlInputs.TabIndex = 0;
            // 
            // tbAvailable
            // 
            tbAvailable.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbAvailable.Location = new Point(28, 885);
            tbAvailable.Margin = new Padding(40, 0, 0, 0);
            tbAvailable.Name = "tbAvailable";
            tbAvailable.Size = new Size(292, 25);
            tbAvailable.TabIndex = 27;
            // 
            // lblAvailable
            // 
            lblAvailable.AutoSize = true;
            lblAvailable.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAvailable.Location = new Point(10, 862);
            lblAvailable.Margin = new Padding(10, 0, 0, 6);
            lblAvailable.Name = "lblAvailable";
            lblAvailable.Size = new Size(63, 17);
            lblAvailable.TabIndex = 26;
            lblAvailable.Text = "Available:";
            // 
            // tbPlateNumber
            // 
            tbPlateNumber.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPlateNumber.Location = new Point(28, 830);
            tbPlateNumber.Margin = new Padding(40, 0, 0, 0);
            tbPlateNumber.Name = "tbPlateNumber";
            tbPlateNumber.Size = new Size(292, 25);
            tbPlateNumber.TabIndex = 25;
            // 
            // lblPlateNumber
            // 
            lblPlateNumber.AutoSize = true;
            lblPlateNumber.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPlateNumber.Location = new Point(10, 807);
            lblPlateNumber.Margin = new Padding(10, 0, 0, 6);
            lblPlateNumber.Name = "lblPlateNumber";
            lblPlateNumber.Size = new Size(91, 17);
            lblPlateNumber.TabIndex = 24;
            lblPlateNumber.Text = "Plate Number:";
            // 
            // tbCarID
            // 
            tbCarID.BackColor = Color.LightSkyBlue;
            tbCarID.BorderStyle = BorderStyle.None;
            tbCarID.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbCarID.Location = new Point(268, 292);
            tbCarID.Margin = new Padding(40, 0, 0, 0);
            tbCarID.Name = "tbCarID";
            tbCarID.ReadOnly = true;
            tbCarID.Size = new Size(52, 18);
            tbCarID.TabIndex = 23;
            // 
            // lblCarID
            // 
            lblCarID.AutoSize = true;
            lblCarID.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCarID.Location = new Point(209, 295);
            lblCarID.Margin = new Padding(10, 0, 0, 6);
            lblCarID.Name = "lblCarID";
            lblCarID.Size = new Size(43, 17);
            lblCarID.TabIndex = 22;
            lblCarID.Text = "CarID:";
            // 
            // btnClearAll
            // 
            btnClearAll.BackColor = Color.Yellow;
            btnClearAll.FlatStyle = FlatStyle.Flat;
            btnClearAll.Location = new Point(28, 18);
            btnClearAll.Name = "btnClearAll";
            btnClearAll.Size = new Size(104, 34);
            btnClearAll.TabIndex = 21;
            btnClearAll.Text = "Clear";
            btnClearAll.UseVisualStyleBackColor = false;
            btnClearAll.Click += btnClearAll_Click;
            // 
            // tbDescription
            // 
            tbDescription.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbDescription.Location = new Point(28, 718);
            tbDescription.Margin = new Padding(40, 0, 0, 0);
            tbDescription.Multiline = true;
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(292, 87);
            tbDescription.TabIndex = 20;
            tbDescription.KeyPress += tbDescription_KeyPress;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescription.Location = new Point(10, 695);
            lblDescription.Margin = new Padding(10, 0, 0, 6);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(77, 17);
            lblDescription.TabIndex = 19;
            lblDescription.Text = "Description:";
            // 
            // tbPrice
            // 
            tbPrice.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPrice.Location = new Point(28, 669);
            tbPrice.Margin = new Padding(40, 0, 0, 0);
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new Size(292, 25);
            tbPrice.TabIndex = 18;
            tbPrice.KeyPress += tbPrice_KeyPress;
            // 
            // lblDoors
            // 
            lblDoors.AutoSize = true;
            lblDoors.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDoors.Location = new Point(150, 550);
            lblDoors.Margin = new Padding(10, 0, 0, 6);
            lblDoors.Name = "lblDoors";
            lblDoors.Size = new Size(47, 17);
            lblDoors.TabIndex = 17;
            lblDoors.Text = "Doors:";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrice.Location = new Point(10, 646);
            lblPrice.Margin = new Padding(10, 0, 0, 6);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(39, 17);
            lblPrice.TabIndex = 16;
            lblPrice.Text = "Price:";
            // 
            // lblTransmission
            // 
            lblTransmission.AutoSize = true;
            lblTransmission.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTransmission.Location = new Point(10, 598);
            lblTransmission.Margin = new Padding(10, 0, 0, 6);
            lblTransmission.Name = "lblTransmission";
            lblTransmission.Size = new Size(86, 17);
            lblTransmission.TabIndex = 14;
            lblTransmission.Text = "Transmission:";
            // 
            // tbDoors
            // 
            tbDoors.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbDoors.Location = new Point(176, 573);
            tbDoors.Margin = new Padding(40, 0, 0, 0);
            tbDoors.Name = "tbDoors";
            tbDoors.Size = new Size(144, 25);
            tbDoors.TabIndex = 13;
            tbDoors.KeyPress += tbDoors_KeyPress;
            // 
            // lblSeatingCapacity
            // 
            lblSeatingCapacity.AutoSize = true;
            lblSeatingCapacity.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSeatingCapacity.Location = new Point(10, 550);
            lblSeatingCapacity.Margin = new Padding(10, 0, 0, 6);
            lblSeatingCapacity.Name = "lblSeatingCapacity";
            lblSeatingCapacity.Size = new Size(60, 17);
            lblSeatingCapacity.TabIndex = 12;
            lblSeatingCapacity.Text = "Capacity:";
            // 
            // tbSeatingCapacity
            // 
            tbSeatingCapacity.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbSeatingCapacity.Location = new Point(28, 573);
            tbSeatingCapacity.Margin = new Padding(40, 0, 0, 0);
            tbSeatingCapacity.Name = "tbSeatingCapacity";
            tbSeatingCapacity.Size = new Size(144, 25);
            tbSeatingCapacity.TabIndex = 11;
            tbSeatingCapacity.KeyPress += tbSeatingCapacity_KeyPress;
            // 
            // tbTransmission
            // 
            tbTransmission.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbTransmission.Location = new Point(28, 621);
            tbTransmission.Margin = new Padding(40, 0, 0, 0);
            tbTransmission.Name = "tbTransmission";
            tbTransmission.Size = new Size(292, 25);
            tbTransmission.TabIndex = 15;
            tbTransmission.KeyPress += tbTransmission_KeyPress;
            // 
            // lblFuelType
            // 
            lblFuelType.AutoSize = true;
            lblFuelType.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFuelType.Location = new Point(10, 500);
            lblFuelType.Margin = new Padding(10, 0, 0, 6);
            lblFuelType.Name = "lblFuelType";
            lblFuelType.Size = new Size(65, 17);
            lblFuelType.TabIndex = 10;
            lblFuelType.Text = "Fuel Type:";
            // 
            // tbFuelType
            // 
            tbFuelType.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbFuelType.Location = new Point(28, 523);
            tbFuelType.Margin = new Padding(40, 0, 0, 0);
            tbFuelType.Name = "tbFuelType";
            tbFuelType.Size = new Size(292, 25);
            tbFuelType.TabIndex = 9;
            tbFuelType.KeyPress += tbFuelType_KeyPress;
            // 
            // lblBodyType
            // 
            lblBodyType.AutoSize = true;
            lblBodyType.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBodyType.Location = new Point(10, 449);
            lblBodyType.Margin = new Padding(10, 0, 0, 6);
            lblBodyType.Name = "lblBodyType";
            lblBodyType.Size = new Size(71, 17);
            lblBodyType.TabIndex = 8;
            lblBodyType.Text = "Body Type:";
            // 
            // tbBodyType
            // 
            tbBodyType.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbBodyType.Location = new Point(28, 472);
            tbBodyType.Margin = new Padding(40, 0, 0, 0);
            tbBodyType.Name = "tbBodyType";
            tbBodyType.Size = new Size(292, 25);
            tbBodyType.TabIndex = 7;
            tbBodyType.KeyPress += tbBodyType_KeyPress;
            // 
            // lblCarBrand
            // 
            lblCarBrand.AutoSize = true;
            lblCarBrand.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCarBrand.Location = new Point(10, 401);
            lblCarBrand.Margin = new Padding(10, 0, 0, 6);
            lblCarBrand.Name = "lblCarBrand";
            lblCarBrand.Size = new Size(69, 17);
            lblCarBrand.TabIndex = 6;
            lblCarBrand.Text = "Car Brand:";
            // 
            // tbCarBrand
            // 
            tbCarBrand.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbCarBrand.Location = new Point(28, 424);
            tbCarBrand.Margin = new Padding(40, 0, 0, 0);
            tbCarBrand.Name = "tbCarBrand";
            tbCarBrand.Size = new Size(292, 25);
            tbCarBrand.TabIndex = 5;
            tbCarBrand.KeyPress += tbCarBrand_KeyPress;
            // 
            // lblCarName
            // 
            lblCarName.AutoSize = true;
            lblCarName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCarName.Location = new Point(10, 353);
            lblCarName.Margin = new Padding(10, 0, 0, 6);
            lblCarName.Name = "lblCarName";
            lblCarName.Size = new Size(70, 17);
            lblCarName.TabIndex = 4;
            lblCarName.Text = "Car Name:";
            // 
            // tbCarName
            // 
            tbCarName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbCarName.Location = new Point(28, 376);
            tbCarName.Margin = new Padding(40, 0, 0, 0);
            tbCarName.Name = "tbCarName";
            tbCarName.Size = new Size(292, 25);
            tbCarName.TabIndex = 3;
            tbCarName.KeyPress += tbCarName_KeyPress;
            // 
            // lblImgFilePath
            // 
            lblImgFilePath.AutoSize = true;
            lblImgFilePath.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblImgFilePath.Location = new Point(10, 303);
            lblImgFilePath.Margin = new Padding(10, 0, 0, 6);
            lblImgFilePath.Name = "lblImgFilePath";
            lblImgFilePath.Size = new Size(99, 17);
            lblImgFilePath.TabIndex = 2;
            lblImgFilePath.Text = "Image File Path:";
            // 
            // tbImgFilePath
            // 
            tbImgFilePath.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbImgFilePath.Location = new Point(28, 326);
            tbImgFilePath.Margin = new Padding(40, 0, 0, 0);
            tbImgFilePath.Name = "tbImgFilePath";
            tbImgFilePath.Size = new Size(292, 25);
            tbImgFilePath.TabIndex = 1;
            tbImgFilePath.KeyPress += tbImgFilePath_KeyPress;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonFace;
            pictureBox1.Location = new Point(41, 58);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(267, 228);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pnlTable
            // 
            pnlTable.BackColor = Color.SkyBlue;
            pnlTable.Controls.Add(btnRefresh);
            pnlTable.Controls.Add(btnDelete);
            pnlTable.Controls.Add(btnUpdate);
            pnlTable.Controls.Add(btnAdd);
            pnlTable.Controls.Add(dgvCarList);
            pnlTable.Dock = DockStyle.Right;
            pnlTable.Location = new Point(354, 0);
            pnlTable.Name = "pnlTable";
            pnlTable.Size = new Size(701, 1005);
            pnlTable.TabIndex = 1;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Blue;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(42, 18);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(88, 34);
            btnRefresh.TabIndex = 26;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Yellow;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.Red;
            btnDelete.Location = new Point(314, 401);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(104, 34);
            btnDelete.TabIndex = 25;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Yellow;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.ForeColor = Color.Blue;
            btnUpdate.Location = new Point(178, 401);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(104, 34);
            btnUpdate.TabIndex = 24;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Yellow;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = Color.Green;
            btnAdd.Location = new Point(42, 401);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(104, 34);
            btnAdd.TabIndex = 23;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvCarList
            // 
            dgvCarList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarList.Location = new Point(23, 75);
            dgvCarList.Name = "dgvCarList";
            dgvCarList.Size = new Size(650, 311);
            dgvCarList.TabIndex = 0;
            dgvCarList.RowHeaderMouseClick += dgvCarList_RowHeaderMouseClick;
            // 
            // UCCarsTable
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlInputs);
            Controls.Add(pnlTable);
            Name = "UCCarsTable";
            Size = new Size(1055, 1005);
            pnlInputs.ResumeLayout(false);
            pnlInputs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCarList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlInputs;
        private Panel pnlTable;
        private PictureBox pictureBox1;
        private Label lblBodyType;
        private TextBox tbBodyType;
        private Label lblCarBrand;
        private TextBox tbCarBrand;
        private Label lblCarName;
        private TextBox tbCarName;
        private Label lblImgFilePath;
        private TextBox tbImgFilePath;
        private TextBox tbDescription;
        private Label lblDescription;
        private TextBox tbPrice;
        private Label lblDoors;
        private Label lblPrice;
        private TextBox tbTransmission;
        private Label lblTransmission;
        private TextBox tbDoors;
        private Label lblSeatingCapacity;
        private TextBox tbSeatingCapacity;
        private Label lblFuelType;
        private TextBox tbFuelType;
        private DataGridView dgvCarList;
        private Button btnClearAll;
        private Label lblCarID;
        private Button btnAdd;
        private TextBox tbCarID;
        private TextBox tbAvailable;
        private Label lblAvailable;
        private TextBox tbPlateNumber;
        private Label lblPlateNumber;
        private Button btnRefresh;
        private Button btnDelete;
        private Button btnUpdate;
    }
}
