

using Microsoft.IdentityModel.Tokens;
using Payment;
using progressbar;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Vehicle_Rental
{
    public partial class FrmMain : Form
    {

        private UCHomePage homePageTab;
        private UCSchedule scheduleTab = new UCSchedule();
        private UCCarSelection carSelectionTab = new UCCarSelection();
        private UCDriverInformation driverInfoTab = new UCDriverInformation();
        private UCCheckout checkoutTab = new UCCheckout();
        private SQLQueries sql = new SQLQueries();

        public event EventHandler CheckoutClicked;
        public event EventHandler DriverInfoClicked;
        public FrmMain()
        {
            InitializeComponent();

            // Subscribe to the event
            scheduleTab.UpdateLabels += ScheduleTab_UpdateLabels;
            scheduleTab.ProceedToChooseSelection += btnChooseCar_Click;


            driverInfoTab.ChangeCarClicked += btnChooseCar_Click;
            driverInfoTab.ProcessClicked += btnCheckout_Click;///parang pinindot mo lang yung choose car
            checkoutTab.SubscribeToEvents(this);
            driverInfoTab.SubscribeToEvents(this);

            LoadUserControl(new UCHomePage(this));
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UCHomePage(this));
            pnlHighlightCurrentPnl.BackColor = Color.Red;
        }

        public void ScheduleTab_UpdateLabels(object sender, EventArgs e)
        {
            lblHeadingPickUpLoc.Text = SQLQueries.PickUpLocation;
            lblHeadingPickUpDateTime.Text = $"{SQLQueries.PickUpDate} {SQLQueries.PickUpTime}";
            lblHeadingDropOffLoc.Text = SQLQueries.DropOffLocation;  // Corrected the location name here
            lblHeadingDropOffDateTime.Text = $"{SQLQueries.DropOffDate} {SQLQueries.DropOffTime}";
        }

        public void LoadUserControl(UserControl userControl)
        {
            pnlMain.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(userControl);
        }
        private void btnSchedule_Click(object sender, EventArgs e)
        {

            LoadUserControl(scheduleTab);
            pnlHighlightCurrentPnl.BackColor = Color.FromArgb(255, 222, 89);
            pnlHighlightCurrentPnl.Location = new Point(116, 50);
        }
        private void btnChooseCar_Click(object sender, EventArgs e)
        {
            if (SQLQueries.isValidToChooseCar)
            {
                LoadUserControl(carSelectionTab);
                pnlHighlightCurrentPnl.BackColor = Color.FromArgb(255, 222, 89);
                pnlHighlightCurrentPnl.Location = new Point(385, 50);
            }
            else
            {
                MessageBox.Show("Click Confirm Schedule!");
            }
        }
        private void btnDriverInfo_Click(object sender, EventArgs e)
        {
            if (SQLQueries.isValidToDriverInfo)
            {
                LoadUserControl(driverInfoTab);
                pnlHighlightCurrentPnl.BackColor = Color.FromArgb(255, 222, 89);
                pnlHighlightCurrentPnl.Location = new Point(653, 50);
                OnDriverInformationClicked(EventArgs.Empty);
            }
            else
            {
                MessageBox.Show("Select Car First!");
            }
            
        }
        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (SQLQueries.isValidToCheckout)
            {
                LoadUserControl(checkoutTab);
                pnlHighlightCurrentPnl.BackColor = Color.FromArgb(255, 222, 89);
                pnlHighlightCurrentPnl.Location = new Point(923, 50);

                OnCheckoutClicked(EventArgs.Empty);
            }
            else
            {
                MessageBox.Show("Click Proceed to Payment!");
            }
        }
        protected virtual void OnCheckoutClicked(EventArgs e) 
        { 
            CheckoutClicked?.Invoke(this, e); 
        }
        protected virtual void OnDriverInformationClicked(EventArgs e)
        {
            DriverInfoClicked?.Invoke(this, e);
        }

        private void exitIcon_Click(object sender, EventArgs e)
        {
            //var result = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo);
            //if (result == DialogResult.Yes)
            Close(); //eto muna ngayon
        }
        
    }
}
