using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace Vehicle_Rental
{
    public partial class UCSchedule : UserControl
    {
        SQLQueries sql = new SQLQueries();
        string mapAllLocations = @"https://my.atlist.com/map/0e254a3f-5ddf-4b1d-80b3-a2b71171f843";

        string mapNAIA = @"https://my.atlist.com/map/9933f0ba-40ed-4e32-a373-6014c1820886";
        string mapManBay = @"https://my.atlist.com/map/5b721cfa-0ffe-4298-87ce-7f2ecaefea2d";
        string mapQuiapo = @"https://my.atlist.com/map/2c67ba21-1b6c-48fd-9e59-6743a6ed9f29";
        string mapRobinson = @"https://my.atlist.com/map/016d567d-898d-46de-895c-b1dc1eedb1c0";
        string mapMOA = @"https://my.atlist.com/map/5f7fb569-3cc3-4825-a817-d15a5629c01d";
        string mapCBD = @"https://my.atlist.com/map/5982cb75-25d5-4928-b694-f3aaa90fc28b";
        string mapBGC = @"https://my.atlist.com/map/2fbad8c0-5467-4d37-8589-2b9293d0f21a";
        string mapSMNorth = @"https://my.atlist.com/map/441c06dc-af06-4c75-a95f-62644277e7a0?share=true";

        bool isManilaExpanded1 = false;
        bool isPasayExpanded1 = false;
        bool isMakatiExpanded1 = false;
        bool isTaguigExpanded1 = false;
        bool isQuezonExpanded1 = false;

        bool isManilaExpanded2 = false;
        bool isPasayExpanded2 = false;
        bool isMakatiExpanded2 = false;
        bool isTaguigExpanded2 = false;
        bool isQuezonExpanded2 = false;

        //private System.Windows.Forms.Timer dropdownTimer = new System.Windows.Forms.Timer();

        private Panel currentPanel = null;
        private bool isCurrentExpanded = false;
        private int animationStep = 10;          // px height per tick\


        public void LoadUserControl(UserControl userControl)
        {
            Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            Controls.Add(userControl);
        }

        public UCSchedule()
        {
            InitializeComponent();
            cbPickUpTime.SelectedIndex = 4;
            cbDropOffTime.SelectedIndex = 4;
        }

        private async void UCSchedule_Load(object sender, EventArgs e)
        {
            await webMapsPickUpLoc.EnsureCoreWebView2Async();
            await webMapsDropOffLoc.EnsureCoreWebView2Async();
            webMapsPickUpLoc.CoreWebView2.Navigate(mapSMNorth);
            webMapsDropOffLoc.CoreWebView2.Navigate(mapSMNorth);
        }
        private void DropdownTimer_Tick(object sender, EventArgs e)
        {

            if (currentPanel == null) return;
            if (!isCurrentExpanded)//dropdown
            {
                currentPanel.Height += animationStep;
                if (currentPanel.Height >= currentPanel.MaximumSize.Height)
                {
                    currentPanel.Height = currentPanel.MaximumSize.Height;
                    dropdownTimer.Stop();
                    UpdateExpandedState(true);
                }
            }
            else//close
            {
                currentPanel.Height -= animationStep;
                if (currentPanel.Height <= currentPanel.MinimumSize.Height)
                {
                    currentPanel.Height = currentPanel.MinimumSize.Height;
                    dropdownTimer.Stop();
                    UpdateExpandedState(false);
                }
            }
        }
        private void UpdateExpandedState(bool expanded) //gamit ung panel malalaman anong flag ang babaguhin
        {
            isCurrentExpanded = expanded;//connecting ng global at local

            if (currentPanel == pnlManila1)
                isManilaExpanded1 = expanded;
            else if (currentPanel == pnlPasay1)
                isPasayExpanded1 = expanded;
            else if (currentPanel == pnlMakati1)
                isMakatiExpanded1 = expanded;
            else if (currentPanel == pnlTaguig1)
                isTaguigExpanded1 = expanded;
            else if (currentPanel == pnlQuezon1)
                isQuezonExpanded1 = expanded;

            if (currentPanel == pnlManila2)
                isManilaExpanded2 = expanded;
            else if (currentPanel == pnlPasay2)
                isPasayExpanded2 = expanded;
            else if (currentPanel == pnlMakati2)
                isMakatiExpanded2 = expanded;
            else if (currentPanel == pnlTaguig2)
                isTaguigExpanded2 = expanded;
            else if (currentPanel == pnlQuezon2)
                isQuezonExpanded2 = expanded;

        }
        private void StartDropdownAnimation(Panel panel, ref bool isExpanded)
        {
            currentPanel = panel;
            isCurrentExpanded = isExpanded;

            //flipping
            isExpanded = !isExpanded;

            dropdownTimer.Start();
        }

        private void btnManilaDropdown1_Click(object sender, EventArgs e)
        {
            StartDropdownAnimation(pnlManila1, ref isManilaExpanded1);
            //ibato
            CurrentPickUpDropdown(isManilaExpanded1, "MANILA");

        }
        private void btnPasayDropdown1_Click(object sender, EventArgs e)
        {
            StartDropdownAnimation(pnlPasay1, ref isPasayExpanded1);

            CurrentPickUpDropdown(isPasayExpanded1, "PASAY");

        }

        private void btnMakatiDropdown1_Click(object sender, EventArgs e)
        {
            StartDropdownAnimation(pnlMakati1, ref isMakatiExpanded1);

            CurrentPickUpDropdown(isMakatiExpanded1, "MAKATI");
        }

        private void btnTaguigDropdown1_Click(object sender, EventArgs e)
        {
            StartDropdownAnimation(pnlTaguig1, ref isTaguigExpanded1);
            CurrentPickUpDropdown(isTaguigExpanded1, "TAGUIG");
        }

        private void btnQuezonDropdown1_Click(object sender, EventArgs e)
        {
            StartDropdownAnimation(pnlQuezon1, ref isQuezonExpanded1);
            CurrentPickUpDropdown(isQuezonExpanded1, "QUEZON");
        }
        private void CurrentPickUpDropdown(bool isExpanded, string currentDropdown)
        {
            if (isExpanded)
                AppendAndShowLoc(currentDropdown, true);//pickup to
            else
                lblShowChosenPickUpLoc.Text = "";
        }

        private void CurrentDropOffDropdown(bool isExpanded, string currentDropdown)
        {
            if (isExpanded)
                AppendAndShowLoc(currentDropdown, false);//dropoff to
            else
                lblShowChosenDropOffLoc.Text = "";
        }
        private void btnManilaDropdown2_Click(object sender, EventArgs e)
        {
            StartDropdownAnimation(pnlManila2, ref isManilaExpanded2);
            CurrentDropOffDropdown(isManilaExpanded2, "MANILA");
        }

        private void btnPasayDropdown2_Click(object sender, EventArgs e)
        {
            StartDropdownAnimation(pnlPasay2, ref isPasayExpanded2);
            CurrentDropOffDropdown(isPasayExpanded2, "PASAY");
        }

        private void btnMakatiDropdown2_Click(object sender, EventArgs e)
        {
            StartDropdownAnimation(pnlMakati2, ref isMakatiExpanded2);
            CurrentDropOffDropdown(isMakatiExpanded2, "MAKATI");
        }

        private void btnTaguigDropdown2_Click(object sender, EventArgs e)
        {
            StartDropdownAnimation(pnlTaguig2, ref isTaguigExpanded2);
            CurrentDropOffDropdown(isTaguigExpanded2, "TAGUIG");
        }

        private void btnQuezonDropdown2_Click(object sender, EventArgs e)
        {
            StartDropdownAnimation(pnlQuezon2, ref isQuezonExpanded2);
            CurrentDropOffDropdown(isQuezonExpanded2, "QUEZON");
        }

        /// ////////////////////

        private void dtpPickUpDate_DropDown(object sender, EventArgs e)
        {
            pnlPickUpTimeAdj.Size = new Size(310, 291);//Binaba yung time combobox
        }

        private void dtpPickUpDate_CloseUp(object sender, EventArgs e)
        {

            pnlPickUpTimeAdj.Size = new Size(310, 128);//Inangat yung time combobox
        }
        private void dtpDropOffDate_DropDown(object sender, EventArgs e)
        {
            pnlDropOffTimeAdj.Size = new Size(310, 291);//Binaba yung time combobox
        }

        private void dtpDropOffDate_CloseUp(object sender, EventArgs e)
        {

            pnlDropOffTimeAdj.Size = new Size(310, 128);//Inangat yung time combobox
        }



        private void btnNAIA1_Click(object sender, EventArgs e)
        {
            AppendAndShowLoc("MANILA > Ninoy Aquino International Airport (NAIA)", true);
            ConvertToDBFriendlyLocation(SBPickUpLoc, ref selectedPickUpLocation);
            webMapsPickUpLoc.CoreWebView2.Navigate(mapNAIA);
        }

        private void btnManBay1_Click(object sender, EventArgs e)
        {
            AppendAndShowLoc("MANILA > Manila Bay Area", true);
            ConvertToDBFriendlyLocation(SBPickUpLoc, ref selectedPickUpLocation);
            webMapsPickUpLoc.CoreWebView2.Navigate(mapManBay);
        }

        private void btnQuiapo1_Click(object sender, EventArgs e)
        {
            AppendAndShowLoc("MANILA > Quiapo Church", true);
            ConvertToDBFriendlyLocation(SBPickUpLoc, ref selectedPickUpLocation);
            webMapsPickUpLoc.CoreWebView2.Navigate(mapQuiapo);
        }

        private void btnRobinson1_Click(object sender, EventArgs e)
        {
            AppendAndShowLoc("MANILA > Robinsons Manila and Ermita", true);
            ConvertToDBFriendlyLocation(SBPickUpLoc, ref selectedPickUpLocation);
            webMapsPickUpLoc.CoreWebView2.Navigate(mapRobinson);
        }

        private void btnMOA1_Click(object sender, EventArgs e)
        {
            AppendAndShowLoc("PASAY > SM Mall of Asia (MOA)", true);
            ConvertToDBFriendlyLocation(SBPickUpLoc, ref selectedPickUpLocation);
            webMapsPickUpLoc.CoreWebView2.Navigate(mapMOA);
        }

        private void btnCBD1_Click(object sender, EventArgs e)
        {
            AppendAndShowLoc("MAKATI > Makati Central Business District (CBD)", true);
            ConvertToDBFriendlyLocation(SBPickUpLoc, ref selectedPickUpLocation);
            webMapsPickUpLoc.CoreWebView2.Navigate(mapCBD);
        }

        private void btnBGC1_Click(object sender, EventArgs e)
        {
            AppendAndShowLoc("TAGUIG > Bonifacio Global City (BGC)", true);
            ConvertToDBFriendlyLocation(SBPickUpLoc, ref selectedPickUpLocation);
            webMapsPickUpLoc.CoreWebView2.Navigate(mapBGC);
        }

        private void btnSMNorth1_Click(object sender, EventArgs e)
        {
            AppendAndShowLoc("QUEZON > Trinoma, SM North Edsa", true);
            ConvertToDBFriendlyLocation(SBPickUpLoc, ref selectedPickUpLocation);
            webMapsPickUpLoc.CoreWebView2.Navigate(mapSMNorth);
        }

        private void btnNAIA2_Click(object sender, EventArgs e)
        {
            AppendAndShowLoc("MANILA > Ninoy Aquino International Airport (NAIA)", false);
            ConvertToDBFriendlyLocation(SBDropOffLoc, ref selectedDropOffLocation);
            webMapsDropOffLoc.CoreWebView2.Navigate(mapNAIA);
        }

        private void btnManBay2_Click(object sender, EventArgs e)
        {
            AppendAndShowLoc("MANILA > Manila Bay Area", false);
            ConvertToDBFriendlyLocation(SBDropOffLoc, ref selectedDropOffLocation);
            webMapsDropOffLoc.CoreWebView2.Navigate(mapManBay);
        }

        private void btnQuiapo2_Click(object sender, EventArgs e)
        {
            AppendAndShowLoc("MANILA > Quiapo Church", false);
            ConvertToDBFriendlyLocation(SBDropOffLoc, ref selectedDropOffLocation);
            webMapsDropOffLoc.CoreWebView2.Navigate(mapQuiapo);
        }

        private void btnRobinson2_Click(object sender, EventArgs e)
        {
            AppendAndShowLoc("MANILA > Robinsons Manila and Ermita", false);
            ConvertToDBFriendlyLocation(SBDropOffLoc, ref selectedDropOffLocation);
            webMapsDropOffLoc.CoreWebView2.Navigate(mapRobinson);
        }

        private void btnMOA2_Click(object sender, EventArgs e)
        {
            AppendAndShowLoc("PASAY > SM Mall of Asia (MOA)", false);
            ConvertToDBFriendlyLocation(SBDropOffLoc, ref selectedDropOffLocation);
            webMapsDropOffLoc.CoreWebView2.Navigate(mapMOA);
        }
        private void btnCBD2_Click(object sender, EventArgs e)
        {
            AppendAndShowLoc("MAKATI > Makati Central Business District (CBD)", false);
            ConvertToDBFriendlyLocation(SBDropOffLoc, ref selectedDropOffLocation);
            webMapsDropOffLoc.CoreWebView2.Navigate(mapCBD);  // Navigate to CBD map (if URL is available)
        }

        private void btnBGC2_Click(object sender, EventArgs e)
        {
            AppendAndShowLoc("TAGUIG > Bonifacio Global City (BGC)", false);
            ConvertToDBFriendlyLocation(SBDropOffLoc, ref selectedDropOffLocation);
            webMapsDropOffLoc.CoreWebView2.Navigate(mapBGC);
        }

        // Global variables
        string selectedPickUpLocation = "";
        string selectedDropOffLocation = "";
        StringBuilder SBPickUpLoc = new StringBuilder();
        StringBuilder SBDropOffLoc = new StringBuilder();

        private void btnSMNorth2_Click(object sender, EventArgs e)
        {
            AppendAndShowLoc("QUEZON > Trinoma, SM North Edsa", false);
            ConvertToDBFriendlyLocation(SBDropOffLoc, ref selectedDropOffLocation);
            webMapsDropOffLoc.CoreWebView2.Navigate(mapSMNorth);
        }

        private void AppendAndShowLoc(string lblText, bool isPickUp)//1 == PickUp 2 ==DropOff
        {
            if (isPickUp)
            {
                SBPickUpLoc.Clear();
                SBPickUpLoc.Append(lblText);
                lblShowChosenPickUpLoc.Text = SBPickUpLoc.ToString();
            }
            else
            {
                SBDropOffLoc.Clear();
                SBDropOffLoc.Append(lblText);
                lblShowChosenDropOffLoc.Text = SBDropOffLoc.ToString();
            }
        }



        private void ConvertToDBFriendlyLocation(StringBuilder SBLocation, ref string selectedLocation)
        {
            string location = SBLocation.ToString().Trim();
            string[] parts = location.Split(new string[] { " > " }, StringSplitOptions.None);

            string city = parts[0];
            string place = parts[1];
            // Prepend the city to the place
            selectedLocation = $"{city}, {place}";  // "QUEZON, Trinoma, SM North Edsa"
        }


        private bool NullLocation(string location, System.Windows.Forms.Label lblErrMsg)
        {
            if (string.IsNullOrEmpty(location))
            {
                lblErrMsg.Text = "Error: No Selected Location";
                return true;//null nga
            }
            else
            {
                lblErrMsg.Text = "";
                return false;
            }
        }



        private void dtpDropOffDate_ValueChanged(object sender, EventArgs e)
        {
            checkValidDate();
        }

        private void dtpPickUpDate_ValueChanged(object sender, EventArgs e)
        {
            checkValidDate();
        }

        private void checkValidDate()
        {
            if (dtpDropOffDate.Value <= dtpPickUpDate.Value)
            {
                pnlErrDropOffDate.BackColor = Color.Red;
                lblErrDropOffDate.Text = "Drop-Off Date Should be atleast 1 day after Pick-Up Date";
            }
            else
            {
                pnlErrDropOffDate.BackColor = Color.Transparent;
                lblErrDropOffDate.Text = "";
            }
        }

        private SQLQueries squery;

        public event EventHandler UpdateLabels;
        public event EventHandler ProceedToChooseSelection;



        private void btnConfirmSchedule_Click(object sender, EventArgs e)
        {
            // Validate the pickup location
            if (NullLocation(selectedPickUpLocation, lblErrPickUpLoc))
            {
                this.AutoScrollPosition = new Point(0, 0);
                SQLQueries.isValidToChooseCar = false;
                return;
            }

            // Validate the drop-off location
            if (NullLocation(selectedDropOffLocation, lblErrDropOffLoc))
            {
                this.AutoScrollPosition = new Point(0, 0);
                SQLQueries.isValidToChooseCar = false;
                return;
            }

            // Check if the drop-off date is after the pick-up date
            if (dtpDropOffDate.Value > dtpPickUpDate.Value)
            {
                // Set values to SQLQueries
                SQLQueries.PickUpLocation = selectedPickUpLocation;
                SQLQueries.PickUpDate = dtpPickUpDate.Value.ToString("yyyy-MM-dd").Trim();
                SQLQueries.PickUpTime = cbPickUpTime.Text;

                SQLQueries.DropOffLocation = selectedDropOffLocation;
                SQLQueries.DropOffDate = dtpDropOffDate.Value.ToString("yyyy-MM-dd").Trim();
                SQLQueries.DropOffTime = cbDropOffTime.Text;
                MessageBox.Show(SQLQueries.PickUpDate);

                UpdateLabels?.Invoke(this, EventArgs.Empty);
                ProceedToChooseSelection?.Invoke(this, EventArgs.Empty);
                SQLQueries.isValidToChooseCar = true;
              }
            else
            {
                this.AutoScrollPosition = new Point(0, 0);
                SQLQueries.isValidToChooseCar = false;
                return;
            }
        }

    }
}
