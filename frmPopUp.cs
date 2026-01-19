using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vehicle_Rental;
using static Vehicle_Rental.SQLQueries;
namespace progressbar
{
    public partial class frmPopUp : Form
    {
        SQLQueries sql = new SQLQueries();
        private CarInfo carInfo;
        public static string currentCarID;
        public static string currentImgPath;
        public static string currentName;
        public static string currentBrand;
        public static string currentBodyType;
        public static string currentTransmission;
        public static string currentFuelType;
        public static string currentSeatingCapacity;
        public static string currentPrice;
        public static string currentDescription;

        public frmPopUp(CarInfo carInfo)
        {
            InitializeComponent();
            this.carInfo = carInfo;
            LoadCarDetails();
        }

        private void LoadCarDetails()
        {
            frmPopUp.currentCarID = carInfo.CarID;
            frmPopUp.currentImgPath = carInfo.ImgPath;
            frmPopUp.currentName = carInfo.CarName;
            frmPopUp.currentBrand = carInfo.Brand;
            frmPopUp.currentBodyType = carInfo.BodyType;
            frmPopUp.currentTransmission = carInfo.Transmission;
            frmPopUp.currentFuelType = carInfo.FuelType;
            frmPopUp.currentSeatingCapacity = carInfo.SeatingCapacity.ToString();
            frmPopUp.currentPrice = carInfo.Price;
            frmPopUp.currentDescription = carInfo.Description;

            SQLQueries.CarID = currentCarID;
            SQLQueries.ImgPath = carInfo.ImgPath;
            pbPopUpImg.Image = Image.FromFile(currentImgPath);
            lblPopUpPrice.Text = "₱ " + currentPrice;
            tbPopUpDescription.Text = currentDescription;
        }

        public event EventHandler ClosePopUp;
        private void btnSelectCar_Click(object sender, EventArgs e)
        {
            SQLQueries.isValidToDriverInfo = true;
            MessageBox.Show("Selected: " + currentName);

            OnCarSelected(EventArgs.Empty);
        }
        protected virtual void OnCarSelected(EventArgs e)
        {
            ClosePopUp.Invoke(this, e);
        }

        public static string GetCarImageUrl(int CarID)
        {
            switch (CarID)
            {
                case 1:
                    return "https://i.ibb.co/6vsq0gT/1.png";
                case 2:
                    return "https://i.ibb.co/TvWsjHK/3.png";
                case 3:
                    return "https://i.ibb.co/4jRy5dX/5.png";
                case 4:
                    return "https://i.ibb.co/GdT4hdY/7.png";
                case 5:
                    return "https://i.ibb.co/gjyYVCb/9.png";
                case 6:
                    return "https://i.ibb.co/kBhp7vG/11.png";
                case 7:
                    return "https://i.ibb.co/ZN6fVxB/13.png";
                case 8:
                    return "https://i.ibb.co/pPntLC2/15.png";
                case 9:
                    return "https://i.ibb.co/Y3w82QN/17.png";
                case 10:
                    return "https://i.ibb.co/myMHZbv/19.png";
                case 11:
                    return "https://i.ibb.co/0MP3k7H/21.png";
                case 12:
                    return "https://i.ibb.co/nbCD6sx/23.png";
                case 13:
                    return "https://i.ibb.co/KyL6c9f/25.png";
                case 14:
                    return "https://i.ibb.co/gz8D0wg/27.png";
                case 15:
                    return "https://i.ibb.co/bWMdMX2/29.png";
                case 16:
                    return "https://i.ibb.co/DDwN1g3/31.png";
                default:
                    return "Invalid CarID";
            }
        }

    }

}
