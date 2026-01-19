using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using static Vehicle_Rental.SQLQueries;

namespace Vehicle_Rental
{
    public partial class UCCarSelection : UserControl
    {
        SQLQueries sql = new SQLQueries();
        private Panel currentPanel = null;
        private bool isCurrentExpanded = false;
        private int animationStep = 10;

        public bool isBrandExpanded = false;
        public bool isBodyTypeExpanded = false;
        public bool isFuelTypeExpanded = false;

        public bool isBrandSelected = false;
        public bool isFuelTypeSelected = false;
        public bool isBodyTypeSelected = false;
        public bool isSeatingCapacitySelected = false;
        public bool isTransmissionSelected = false;


        public static string ImgPath = "";
        public static string CarName = "";
        public static string Brand = "";
        public static string BodyType = "";
        public static string Transmission = "";
        public static string FuelType = "";
        public static byte SeatingCapacity = 0;
        public static byte Doors = 0;

        public static string Description = "";
        public static string Price = "";

        private string currentCarID = null;
        private string currentBrand = null;
        private string currentBodyType = null;
        private string currentFuelType = null;
        private string currentTransmission = null;
        private byte currentSeatingCapacity = 0;

        private static Color unselectedColor = Color.FromArgb(131, 209, 255);
        private static Color highlightedColor = Color.White;

        public bool carChosen = false;

        public UCCarSelection()
        {
            InitializeComponent();
        }
        public void UpdateExpandedState(bool expanded) //gamit ung panel malalaman anong flag ang babaguhin
        {
            isCurrentExpanded = expanded;//connecting ng global at local

            if (currentPanel == pnlBrandDropdown)
                isBrandExpanded = expanded;
            else if (currentPanel == pnlBodyTypeDropdown)
                isBodyTypeExpanded = expanded;

        }
        public void StartDropdownAnimation(Panel panel, ref bool isExpanded)
        {
            currentPanel = panel;
            isCurrentExpanded = isExpanded;

            //flipping
            isExpanded = !isExpanded;

            dropDownTimer.Start();
        }

        private void dropDownTimer_Tick(object sender, EventArgs e)
        {
            if (currentPanel == null) return;
            if (!isCurrentExpanded)
            {
                currentPanel.Height += animationStep;
                if (currentPanel.Height >= currentPanel.MaximumSize.Height)
                {
                    currentPanel.Height = currentPanel.MaximumSize.Height; // Snap to max height
                    dropDownTimer.Stop();
                    UpdateExpandedState(true);
                }
            }
            else
            {
                currentPanel.Height -= animationStep;
                if (currentPanel.Height <= currentPanel.MinimumSize.Height)
                {
                    currentPanel.Height = currentPanel.MinimumSize.Height; // Snap to min height
                    dropDownTimer.Stop();
                    UpdateExpandedState(false);
                }
            }
        }

        private void btnBrandDropdown_Click(object sender, EventArgs e)
        {
            StartDropdownAnimation(pnlBrandDropdown, ref isBrandExpanded);
        }

        private void btnBodyTypeDropdown_Click(object sender, EventArgs e)
        {
            StartDropdownAnimation(pnlBodyTypeDropdown, ref isBodyTypeExpanded);
        }

        private void btnFuelTypeDropdown_Click(object sender, EventArgs e)
        {
            StartDropdownAnimation(pnlFuelTypeDropdown, ref isFuelTypeExpanded);
        }

        private void btnHonda_Click(object sender, EventArgs e)
        {

            UpdateBrand("Honda");
            PopulateFlowLayout(false);
        }

        private void btnToyota_Click(object sender, EventArgs e)
        {

            UpdateBrand("Toyota");
            PopulateFlowLayout(false);
        }

        private void btnSuzuki_Click(object sender, EventArgs e)
        {

            UpdateBrand("Suzuki");
            PopulateFlowLayout(false);
        }

        private void btnNissan_Click(object sender, EventArgs e)
        {

            UpdateBrand("Nissan");
            PopulateFlowLayout(false);
        }

        private void btnSedan_Click(object sender, EventArgs e)
        {

            UpdateBodyType("Sedan");
            PopulateFlowLayout(false);
        }

        private void btnVan_Click(object sender, EventArgs e)
        {

            UpdateBodyType("Van");
            PopulateFlowLayout(false);
        }

        private void btnSUV_Click(object sender, EventArgs e)
        {

            UpdateBodyType("SUV");
            PopulateFlowLayout(false);
        }

        private void btnPickUp_Click(object sender, EventArgs e)
        {
            UpdateBodyType("Pickup");
            PopulateFlowLayout(false);
        }

        // Helper method to handle fuel type button logic
        private void UpdateFuelType(string fuelType)
        {
            if (isFuelTypeSelected && !(lblShowSelectedFuelType.Text == "Fuel Type: " + fuelType))// Different Type
            {
                lblShowSelectedFuelType.Text = "Fuel Type: " + fuelType;
                isFuelTypeSelected = true;
                currentFuelType = fuelType;//new fueltype
            }
            else
            {
                if (lblShowSelectedFuelType.Text == "Fuel Type: " + fuelType) // Pressed 2 times
                {
                    lblShowSelectedFuelType.Text = "Fuel Type:";  // Clears
                    isFuelTypeSelected = false;
                    currentFuelType = null;
                }
                else//First Selected
                {
                    lblShowSelectedFuelType.Text = "Fuel Type: " + fuelType;
                    isFuelTypeSelected = true;
                    currentFuelType = fuelType;

                }
            }
            HighLightFilter(lblShowSelectedFuelType, isFuelTypeSelected);
            FuelType = fuelType;
            UpdateFuelButtonColors(fuelType);
        }

        private void UpdateFuelButtonColors(string selectedFuelType)
        {
            // unselect 
            btnGas.BackColor = unselectedColor;
            btnDiesel.BackColor = unselectedColor;
            btnElectric.BackColor = unselectedColor;

            if (!isFuelTypeSelected)//deselect ng current fuel
            {
                return;
            }
            if (selectedFuelType == "Gasoline")
            {
                btnGas.BackColor = highlightedColor;
            }
            else if (selectedFuelType == "Diesel")
            {
                btnDiesel.BackColor = highlightedColor;
            }
            else if (selectedFuelType == "Electric")
            {
                btnElectric.BackColor = highlightedColor;
            }
        }
        private void UpdateBodyType(string bodyType)
        {

            if (isBodyTypeSelected && !(lblShowSelectedBodyType.Text == "Body Type: " + bodyType))// Different Type
            {
                lblShowSelectedBodyType.Text = "Body Type: " + bodyType;
                isBodyTypeSelected = true;
                currentBodyType = bodyType;//different
            }
            else
            {
                if (lblShowSelectedBodyType.Text == "Body Type: " + bodyType) // Pressed 2 times
                {
                    lblShowSelectedBodyType.Text = "Body Type: ";  // Clears
                    isBodyTypeSelected = false;
                    currentBodyType = null;
                }
                else//First Selected
                {
                    lblShowSelectedBodyType.Text = "Body Type: " + bodyType;
                    isBodyTypeSelected = true;
                    currentBodyType = bodyType;

                }
            }
            HighLightFilter(lblShowSelectedBodyType, isBodyTypeSelected);
            BodyType = bodyType;
            UpdateBodyButtonColors(bodyType);
        }
        private void UpdateBodyButtonColors(string selectedBodyType)
        {
            // unselect 
            btnSedan.BackColor = unselectedColor;
            btnVan.BackColor = unselectedColor;
            btnSUV.BackColor = unselectedColor;
            btnPickUp.BackColor = unselectedColor;

            if (!isBodyTypeSelected)//deselect ng current Body
            {
                return;
            }

            // highlight
            if (selectedBodyType == "Sedan")
            {
                btnSedan.BackColor = highlightedColor;
            }
            else if (selectedBodyType == "Van")
            {
                btnVan.BackColor = highlightedColor;
            }
            else if (selectedBodyType == "SUV")
            {
                btnSUV.BackColor = highlightedColor;
            }
            else if (selectedBodyType == "Pick-Up")
            {
                btnPickUp.BackColor = highlightedColor;
            }
        }

        private void UpdateBrand(string brand)
        {
            if (isBrandSelected && !(lblShowSelectedBrand.Text == "Brand: " + brand))
            {
                lblShowSelectedBrand.Text = "Brand: " + brand;
                isBrandSelected = true;
                currentBrand = brand; // Update the current brand
            }

            else
            {
                if (lblShowSelectedBrand.Text == "Brand: " + brand)
                {
                    lblShowSelectedBrand.Text = "Brand:";  // Clear
                    isBrandSelected = false;
                    currentBrand = null;
                }
                else
                {
                    lblShowSelectedBrand.Text = "Brand: " + brand;
                    isBrandSelected = true;
                    currentBrand = brand;
                }
            }
            HighLightFilter(lblShowSelectedBrand, isBrandSelected);

            Brand = brand;
            UpdateBrandButtonColors(brand);  // Update button colors based on brand
        }

        private void UpdateBrandButtonColors(string selectedBrand)
        {
            // unselect 
            btnHonda.BackColor = unselectedColor;
            btnToyota.BackColor = unselectedColor;
            btnSuzuki.BackColor = unselectedColor;
            btnNissan.BackColor = unselectedColor;
            if (!isBrandSelected)//de-highlight ng current Brand
            {
                return;
            }
            // highlight
            if (selectedBrand == "Honda")
            {
                btnHonda.BackColor = highlightedColor;
            }
            else if (selectedBrand == "Toyota")
            {
                btnToyota.BackColor = highlightedColor;
            }
            else if (selectedBrand == "Suzuki")
            {
                btnSuzuki.BackColor = highlightedColor;
            }
            else if (selectedBrand == "Nissan")
            {
                btnNissan.BackColor = highlightedColor;
            }
        }

        private void PopulateFlowLayout(bool isSearched)
        {
            flowLayoutPanel1.Controls.Clear();

            string searchKey = isSearched ? tbSearch.Text : null;

            List<CarInfo> cars = SQLQueries.GetFilteredAndSearchedCars(
                searchKey: searchKey,
                carID: currentCarID,
                brand: currentBrand,
                bodyType: currentBodyType,
                fuelType: currentFuelType,
                transmission: currentTransmission,
                seatingCapacity: currentSeatingCapacity
            );

            foreach (var car in cars)
            {
                Panel tile = CreateTile(car.ImgPath, car.Price, car);
                flowLayoutPanel1.Controls.Add(tile);
            }
        }


        private void btnGas_Click(object sender, EventArgs e)
        {
            UpdateFuelType("Gasoline");
            PopulateFlowLayout(false);
        }

        private void btnDiesel_Click(object sender, EventArgs e)
        {
            UpdateFuelType("Diesel");
            PopulateFlowLayout(false);
        }

        private void btnElectric_Click(object sender, EventArgs e)
        {
            UpdateFuelType("Electric");
            PopulateFlowLayout(false);
        }

        private void UCCarSelection_Load(object sender, EventArgs e)
        {
            PopulateFlowLayout(false);
        }

        private Panel CreateTile(string imagePath, string price, CarInfo car)
        {
            RoundedPanel tilePanel = new RoundedPanel();
            tilePanel.Width = 245;  //200
            tilePanel.Height = 290; //250
            tilePanel.Margin = new Padding(4);  //rn 4 on all | perfect
            tilePanel.BackColor = Color.FromArgb(56, 182, 255);

            PictureBox pictureBox = new PictureBox();
            pictureBox.Width = 225;//180 //-20 sa tilePanel
            pictureBox.Height = 230;//150
            pictureBox.ImageLocation = imagePath; //db
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage; // Auto Fit
            pictureBox.Location = new Point(10, 10);
            pictureBox.Cursor = Cursors.Hand;
            pictureBox.Tag = car;
            pictureBox.Click += PictureBox_Click;

            Label rate = new Label();
            rate.Text = "Rate per Day:";
            rate.Font = new Font("Arial", 10, FontStyle.Bold);
            rate.ForeColor = Color.Black;
            rate.AutoSize = true;
            rate.Location = new Point(10, 260);


            Label priceLabel = new Label();
            priceLabel.Text = "₱ " + price;//db
            priceLabel.Font = new Font("Arial", 10, FontStyle.Regular);
            priceLabel.ForeColor = Color.Red; // Green text sa price
            priceLabel.AutoSize = true;
            priceLabel.Location = new Point(120, 260); 

            tilePanel.Controls.Add(pictureBox);
            tilePanel.Controls.Add(rate);
            tilePanel.Controls.Add(priceLabel);

            return tilePanel;
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            if (sender is PictureBox pictureBox && pictureBox.Tag is CarInfo carInfo)
            {
                FrmDimBackground frmDimBackground = new FrmDimBackground(carInfo);
                frmDimBackground.Show();
                lblCarSelected.ForeColor= Color.Yellow;
             }
        }

        private void trackBarSeatingCapacity_Scroll(object sender, EventArgs e)
        {
            byte x = 0;
            switch (trackBarSeatingCapacity.Value)
            {
                case 0:
                    x = 0;
                    break;
                case 1:
                    x = 2;
                    break;
                case 2:
                    x = 5;
                    break;
                case 3:
                    x = 7;
                    break;
                case 4:
                    x = 10;
                    break;
                default:
                    MessageBox.Show("Error: TrackBarSeating Value");
                    break;
            }
            if (x == 0)
            {
                lblCarSelected.Text = "Seating Capacity:";
                lblShowSelectedSeatingCapacity.Text = "Seating Capacity: ";
                currentSeatingCapacity = 0;
                HighLightFilter(lblShowSelectedSeatingCapacity, false);
            }
            else
            {
                lblCarSelected.Text = "Seating Capacity: " + x.ToString();
                lblShowSelectedSeatingCapacity.Text = "Seating Capacity: " + x.ToString() + " Seater";
                currentSeatingCapacity = x;
                HighLightFilter(lblShowSelectedSeatingCapacity, true);
            }
            PopulateFlowLayout(false);
        }

        private void trackBarTransmission_Scroll(object sender, EventArgs e)
        {
            string y = "";
            switch (trackBarTransmission.Value)
            {
                case 0:
                    y = "Manual";
                    break;
                case 1:
                    y = null;
                    break;
                case 2:
                    y = "Automatic";
                    break;
                default:
                    MessageBox.Show("Error: TrackBarTransmission Value");
                    break;
            }
            if (string.IsNullOrEmpty(y))
            {
                lblCarSelected.Text = "Transmission: ";
                lblShowSelectedTransmission.Text = "Transmission: ";
                currentTransmission = null;
                HighLightFilter(lblShowSelectedTransmission, false);
            }
            else//may laman
            {
                lblCarSelected.Text = "Transmission: " + y;
                lblShowSelectedTransmission.Text = "Transmission: " + y;
                currentTransmission = y;
                HighLightFilter(lblShowSelectedTransmission, true);

            }
            PopulateFlowLayout(false);
        }
        private void HighLightFilter(Label lblShowSelected, bool isSelected)
        {
            if (isSelected)
            {
                lblShowSelected.ForeColor = Color.Red;
            }
            else//lowlight
            {
                lblShowSelected.ForeColor = Color.Black;
            }

        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            PopulateFlowLayout(true);
        }

        private void iconSearch_Click(object sender, EventArgs e)
        {
            tbSearch.Focus();
        }
    }















    /// ///////////////////////////////////////////////////
    /// </summary>


    public class RoundedPanel : Panel
    {
        private int _cornerRadius = 20; // Roundness

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            // High-quality rendering settings//mas even lang yung border
            e.Graphics.CompositingQuality = CompositingQuality.HighQuality;
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

            GraphicsPath path = new GraphicsPath();
            path.AddArc(new Rectangle(0, 0, _cornerRadius, _cornerRadius), 180, 90);
            path.AddArc(new Rectangle(Width - _cornerRadius, 0, _cornerRadius, _cornerRadius), 270, 90);
            path.AddArc(new Rectangle(Width - _cornerRadius, Height - _cornerRadius, _cornerRadius, _cornerRadius), 0, 90);
            path.AddArc(new Rectangle(0, Height - _cornerRadius, _cornerRadius, _cornerRadius), 90, 90);
            path.CloseAllFigures();

            Region = new Region(path);

            // Draw the border
            using (Pen pen = new Pen(Color.DimGray, 2)) // color tsaka kapal
                e.Graphics.DrawPath(pen, path);
        }
    }
}
