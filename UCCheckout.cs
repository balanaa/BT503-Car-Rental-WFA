using progressbar;
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

namespace Payment
{
    public partial class UCCheckout : UserControl
    {
        UCCheckoutCard creditCardTab = new UCCheckoutCard("Credit Card");
        UCCheckoutCard debitCardTab = new UCCheckoutCard("Debit Card");
        UCCheckoutGcash gCashTab = new UCCheckoutGcash();

        private System.Windows.Forms.Timer slideTimer;
        private UserControl currentUserControl;
        private UserControl nextUserControl;
        private int targetX;
        private int startX;
        private int stepSize = 20;
        private bool isAnimating = false;

        public UCCheckout()
        {
            InitializeComponent();
            slideTimer = new System.Windows.Forms.Timer();
            slideTimer.Interval = 20;
            slideTimer.Tick += SlideTimer_Tick;
        }
        private void btnCreditCard_Click(object sender, EventArgs e)
        {
            NextTab(creditCardTab);
        }
        private void btnDebitCard_Click(object sender, EventArgs e)
        {
            NextTab(debitCardTab);
        }

        private void btnGcash_Click(object sender, EventArgs e)
        {
            NextTab(gCashTab);
        }
        private void NextTab(UserControl newUserControl)
        {
            if (isAnimating)
            {
                ResetAnimation();
            }

            if (currentUserControl != null)
            {
                this.Controls.Remove(currentUserControl);
            }
            nextUserControl = newUserControl;
            startX = this.ClientSize.Width;
            nextUserControl.Left = startX;
            nextUserControl.Width = SConCheckOut.Panel2.Width;
            nextUserControl.Height = SConCheckOut.Panel2.Height;

            this.Controls.Add(nextUserControl);
            nextUserControl.BringToFront();

            targetX = SConCheckOut.Panel2.Left;

            isAnimating = true;
            slideTimer.Start();
        }

        public void SwitchBack()
        {
            if (isAnimating)
            {
                ResetAnimation();
            }

            if (currentUserControl == null) return;

            startX = currentUserControl.Left;
            targetX = this.ClientSize.Width;  // Slide out to the right


            isAnimating = true;
            slideTimer.Start();
        }

        private void ResetAnimation()
        {
            slideTimer.Stop();
            isAnimating = false;

            if (currentUserControl != null)
            {
                Controls.Remove(currentUserControl);
                currentUserControl = null;
            }

            if (nextUserControl != null)
            {
                Controls.Remove(nextUserControl);
                nextUserControl = null;
            }
        }

        private void SlideTimer_Tick(object sender, EventArgs e)
        {
            if (nextUserControl != null)
            {
                int newPosition = nextUserControl.Left - stepSize;

                if (newPosition <= targetX)
                {
                    nextUserControl.Left = targetX;
                    currentUserControl = nextUserControl;
                    nextUserControl = null;
                    slideTimer.Stop();
                    isAnimating = false;
                }
                else
                {
                    nextUserControl.Left = newPosition;
                }
            }
            else if (currentUserControl != null)
            {
                int newPosition = currentUserControl.Left + stepSize;
                if (newPosition >= targetX)
                {
                    this.Controls.Remove(currentUserControl);
                    currentUserControl = null;
                    slideTimer.Stop();
                    isAnimating = false;
                }
                else
                {
                    currentUserControl.Left = newPosition;
                }
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {
            SwitchBack();
        }

        public static double CalculatePrice()
        {
            string pickUpDate = SQLQueries.PickUpDate; // e.g., "2024-12-11"
            string dropOffDate = SQLQueries.DropOffDate; // e.g., "2024-12-13"
            string pickUpTime = SQLQueries.PickUpTime; // e.g., "08:00"
            string dropOffTime = SQLQueries.DropOffTime; // e.g., "23:30"
            double dailyRate = Convert.ToDouble(frmPopUp.currentPrice);

            // Parse the pickup and drop-off DateTime
            DateTime pickUpDateTime = DateTime.Parse($"{pickUpDate} {pickUpTime}");
            DateTime dropOffDateTime = DateTime.Parse($"{dropOffDate} {dropOffTime}");

            // Ensure drop-off is after pickup
            if (dropOffDateTime <= pickUpDateTime)
                throw new ArgumentException("Drop-off date/time must be after pick-up date/time.");

            // Calculate the rental duration
            TimeSpan rentalDuration = dropOffDateTime - pickUpDateTime;

            // Determine the total days and remaining hours
            int totalDays = (int)Math.Floor(rentalDuration.TotalDays);
            double remainingHours = rentalDuration.TotalHours - (totalDays * 24);

            // Calculate total price
            double totalPrice = (totalDays * dailyRate) + (remainingHours * (dailyRate / 24));

            return totalPrice;
        }

        public static string DisplayRentalCost()
        {
            string pickUpDate = SQLQueries.PickUpDate; // e.g., "2024-12-11"
            string dropOffDate = SQLQueries.DropOffDate; // e.g., "2024-12-13"
            string pickUpTime = SQLQueries.PickUpTime; // e.g., "08:00"
            string dropOffTime = SQLQueries.DropOffTime; // e.g., "23:30"
            double dailyRate = Convert.ToDouble(frmPopUp.currentPrice);

            DateTime pickUpDateTime = DateTime.Parse($"{pickUpDate} {pickUpTime}");
            DateTime dropOffDateTime = DateTime.Parse($"{dropOffDate} {dropOffTime}");

            if (dropOffDateTime <= pickUpDateTime)
                throw new ArgumentException("Drop-off date/time must be after pick-up date/time.");

            TimeSpan rentalDuration = dropOffDateTime - pickUpDateTime;

            int totalDays = (int)Math.Floor(rentalDuration.TotalDays);
            int remainingHours = rentalDuration.Hours;

            double totalPrice = totalDays * dailyRate;

            if (remainingHours > 0 || rentalDuration.Minutes > 0)
            {
                totalPrice += (remainingHours + (rentalDuration.Minutes > 0 ? 1 : 0)) * (dailyRate / 24);
            }

            // Build the output string
            if (remainingHours == 0 && rentalDuration.Minutes == 0)
            {
                return $"{totalDays} Day(s) at PHP {totalPrice:F2}";
            }
            else
            {
                return $"{totalDays} Day(s), {remainingHours} Hour(s) at PHP {totalPrice:F2}";
            }
        }



        public void SubscribeToEvents(FrmMain form)
        {
            form.CheckoutClicked += Form_CheckoutClicked;
        }

        private void Form_CheckoutClicked(object sender, EventArgs e)
        {
            pbCarPicCheckout.Image = Image.FromFile(frmPopUp.currentImgPath);
            lblTotalCost.Text = "TOTAL COST: ₱" + CalculatePrice().ToString("F2");
            lblShowDaysandPrice.Text = DisplayRentalCost();
        }
    }
}

