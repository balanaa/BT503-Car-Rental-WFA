using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using progressbar;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Image = System.Drawing.Image;
using System.Diagnostics;

namespace Vehicle_Rental
{
    public partial class UCDriverInformation : UserControl
    {
        Regex nameRegex = new Regex(@"^[\p{L}\s]+$");
        Regex emailRegex = new Regex(@"^[\p{L}0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}(\.[a-zA-Z]{2,})*$");
        Regex specialCharacterRegex = new Regex(@"[!@#$%^&*()?"":{}|<>]");
        Regex phMobileNumRegex = new Regex("^09[0-9]{9}$");

        bool isFnameValid = false;
        bool isLnameValid = false;
        bool isEmailValid = false;
        bool isCountryValid = false;
        bool isAddressValid = false;
        bool isMobileValid = false;

        bool agreedToTermsAndConditions = false;
        // true para pwede kagad mapasok kahit walang pang laman
        bool isCityValid = true;
        bool isStateProvinceValid = true;
        bool isZipPostalCodeValid = true;
        bool isLandlineValid = true;
        public UCDriverInformation()
        {
            InitializeComponent();
            cbCountry.SelectedIndex = 134;

        }

        private void ErrorInput(System.Windows.Forms.Label lblInputType, System.Windows.Forms.Label lblErrMessage, Panel panel, ref bool valid)
        {
            lblInputType.ForeColor = Color.Red;
            panel.BackColor = Color.Red;
            lblErrMessage.ForeColor = Color.Red;
            valid = false;

        }
        private void ValidInput(System.Windows.Forms.Label lblInputType, System.Windows.Forms.Label lblErrMessage, Panel panel, ref bool valid)
        {
            lblInputType.ForeColor = Color.Black;
            panel.BackColor = Color.Transparent;
            lblErrMessage.Text = "";
            valid = true;
        }
        private void NameValidation(string nameInput, System.Windows.Forms.Label lblInputType, System.Windows.Forms.Label lblErrMessage, Panel panel, ref bool valid)
        {
            if (!nameRegex.IsMatch(nameInput))
            {
                ErrorInput(lblInputType, lblErrMessage, panel, ref valid);
                lblErrMessage.Text = "Error: Invalid Characters";
            }
            else if (string.IsNullOrWhiteSpace(nameInput))
            {
                ErrorInput(lblInputType, lblErrMessage, panel, ref valid);
                lblErrMessage.Text = "Error: Blank Name";
            }
            else if (nameInput.Contains("  "))
            {
                ErrorInput(lblInputType, lblErrMessage, panel, ref valid);
                lblErrMessage.Text = "Error: Double Space";
            }
            else if (nameInput.Length < 3 || nameInput.Length > 30)
            {
                ErrorInput(lblInputType, lblErrMessage, panel, ref valid);
                lblErrMessage.Text = "Error: Name Length";
            }
            else
            {
                ValidInput(lblInputType, lblErrMessage, panel, ref valid);
            }
        }

        private void tbFname_TextChanged(object sender, EventArgs e)
        {

            NameValidation(tbFname.Text, lblFname, lblErrFname, pnlErrFname, ref isFnameValid);
        }
        private void tbLname_TextChanged(object sender, EventArgs e)
        {
            NameValidation(tbLname.Text, lblLname, lblErrLname, pnlErrLname, ref isLnameValid);
        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {
            if (tbEmail.Text.Contains(" "))
            {
                ErrorInput(lblEmail, lblErrEmail, pnlErrEmail, ref isEmailValid);
                lblErrEmail.Text = "Error: Space in Email";
            }
            else if (!emailRegex.IsMatch(tbEmail.Text))
            {
                ErrorInput(lblEmail, lblErrEmail, pnlErrEmail, ref isEmailValid);
                lblErrEmail.Text = "Error: Invalid Email";
            }
            else if (tbEmail.Text.Length < 16 || tbEmail.Text.Length > 39)
            {
                ErrorInput(lblEmail, lblErrEmail, pnlErrEmail, ref isEmailValid);
                lblErrEmail.Text = "Error: Name Length";
            }
            else
            {
                ValidInput(lblEmail, lblErrEmail, pnlErrEmail, ref isEmailValid);
            }
        }

        private void cbCountry_TextChanged(object sender, EventArgs e)
        {
            if (cbCountry.Items.Contains(cbCountry.Text))
            {
                ValidInput(lblCountry, lblErrCountry, pnlErrCountry, ref isCountryValid);
            }
            else
            {
                ErrorInput(lblCountry, lblErrCountry, pnlErrCountry, ref isCountryValid);
                lblErrCountry.Text = "Error: Invalid Country";
            }
        }

        private void tbAddress_TextChanged(object sender, EventArgs e)
        {
            if (specialCharacterRegex.IsMatch(tbAddress.Text))
            {
                ErrorInput(lblAddress, lblErrAddress, pnlErrAddress, ref isAddressValid);
                lblErrAddress.Text = "Error: Invalid Address";
            }
            else if (tbAddress.Text.Length < 9 || tbAddress.Text.Length > 99)
            {
                ErrorInput(lblAddress, lblErrAddress, pnlErrAddress, ref isAddressValid);
                lblErrAddress.Text = "Error: Address Length";
            }
            else if (tbAddress.Text.Contains("  "))
            {
                ErrorInput(lblAddress, lblErrAddress, pnlErrAddress, ref isAddressValid);
                lblErrAddress.Text = "Error: Double Space";
            }
            else if (string.IsNullOrWhiteSpace(tbAddress.Text))
            {
                ErrorInput(lblAddress, lblErrAddress, pnlErrAddress, ref isAddressValid);
                lblErrAddress.Text = "Error: Blank Address";
            }
            else
            {
                ValidInput(lblAddress, lblErrAddress, pnlErrAddress, ref isAddressValid);
            }
        }


        private void tbCity_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbCity.Text))
            {
                ValidInput(lblCity, lblErrCity, pnlErrorCity, ref isCityValid);
                return;
            }
            if (specialCharacterRegex.IsMatch(tbCity.Text))
            {
                ErrorInput(lblCity, lblErrCity, pnlErrorCity, ref isCityValid);
                lblErrCity.Text = "Error: Invalid City";
            }
            else if (tbCity.Text.Length < 2 || tbCity.Text.Length > 19)
            {
                ErrorInput(lblCity, lblErrCity, pnlErrorCity, ref isCityValid);
                lblErrCity.Text = "Error: City Length";
            }
            else if (tbCity.Text.Contains("  "))
            {
                ErrorInput(lblCity, lblErrCity, pnlErrorCity, ref isCityValid);
                lblErrCity.Text = "Error: Double Space";
            }
            else
            {
                ValidInput(lblCity, lblErrCity, pnlErrorCity, ref isCityValid);
            }
        }

        private void tbStateProvince_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbStateProvince.Text))
            {
                ValidInput(lblStateProvince, lblErrStateProvince, pnlErrStateProvince, ref isStateProvinceValid);
                return;
            }
            if (specialCharacterRegex.IsMatch(tbStateProvince.Text))
            {
                ErrorInput(lblStateProvince, lblErrStateProvince, pnlErrStateProvince, ref isStateProvinceValid);
                lblErrStateProvince.Text = "Error: Invalid State/Province";
            }
            else if (tbStateProvince.Text.Length < 2 || tbStateProvince.Text.Length > 49)
            {
                ErrorInput(lblStateProvince, lblErrStateProvince, pnlErrStateProvince, ref isStateProvinceValid);
                lblErrStateProvince.Text = "Error: State/Province Length";
            }
            else if (tbStateProvince.Text.Contains("  "))
            {
                ErrorInput(lblStateProvince, lblErrStateProvince, pnlErrStateProvince, ref isStateProvinceValid);
                lblErrStateProvince.Text = "Error: Double Space";
            }
            else
            {
                ValidInput(lblStateProvince, lblErrStateProvince, pnlErrStateProvince, ref isStateProvinceValid);
            }
        }
        private void PostalZipValidation(string country)
        {
            int maxLength = 0;
            switch (country)
            {
                case "Philippines":
                    maxLength = 4;
                    break;
                case "China":
                    maxLength = 6;
                    break;
                case "India":
                    maxLength = 6;
                    break;
                case "United States of America":
                    maxLength = 5;
                    break;
                case "Japan":
                    maxLength = 7;
                    break;
                default:
                    HandleUnsupportedCountriesPostalCode(country);
                    return;
            }
            if (!tbPostalZip.Text.All(char.IsDigit))
            {
                ErrorInput(lblPostalZip, lblErrPostalZip, pnlErrPostalZip, ref isZipPostalCodeValid);
                lblErrPostalZip.Text = "Error: Invalid " + country + " Code";
            }
            else if (tbPostalZip.Text.Length != maxLength)
            {
                ErrorInput(lblPostalZip, lblErrPostalZip, pnlErrPostalZip, ref isZipPostalCodeValid);
                lblErrPostalZip.Text = "Error: " + country + " Code Length";
            }
            else
            {
                ValidInput(lblPostalZip, lblErrPostalZip, pnlErrPostalZip, ref isZipPostalCodeValid);
            }
        }

        private void HandleUnsupportedCountriesPostalCode(string country)
        {
            if (!tbPostalZip.Text.All(char.IsDigit))
            {
                ErrorInput(lblPostalZip, lblErrPostalZip, pnlErrPostalZip, ref isZipPostalCodeValid);
                lblErrPostalZip.Text = "Error: Invalid " + country + " Code";
            }
            else if (tbPostalZip.Text.Length < 4 || tbPostalZip.Text.Length > 11)
            {
                ErrorInput(lblPostalZip, lblErrPostalZip, pnlErrPostalZip, ref isZipPostalCodeValid);
                lblErrPostalZip.Text = "Error: " + country + " Code Length";
            }
            else
            {
                ValidInput(lblPostalZip, lblErrPostalZip, pnlErrPostalZip, ref isZipPostalCodeValid);
            }
        }
        private void tbPostalZip_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbPostalZip.Text))
            {
                ValidInput(lblPostalZip, lblErrPostalZip, pnlErrPostalZip, ref isZipPostalCodeValid);
            }
            else
            {
                PostalZipValidation(cbCountry.Text);
            }
        }

        private void tbLandline_TextChanged(object sender, EventArgs e)
        {
            int ignoreMe;
            if (string.IsNullOrWhiteSpace(tbLandline.Text))
            {
                ValidInput(lblLandline, lblErrLandline, pnlErrLandline, ref isLandlineValid);
                return;
            }

            if (!int.TryParse(tbLandline.Text, out ignoreMe))
            {
                ErrorInput(lblLandline, lblErrLandline, pnlErrLandline, ref isLandlineValid);
                lblErrLandline.Text = "Error: Invalid Character";
            }
            else if (tbLandline.Text.Length < 6 || tbLandline.Text.Length > 14) //other countries
            {
                ErrorInput(lblLandline, lblErrLandline, pnlErrLandline, ref isLandlineValid);
                lblErrLandline.Text = "Error: Landline Number Length";
            }
            else
            {
                ValidInput(lblLandline, lblErrLandline, pnlErrLandline, ref isLandlineValid);
            }
        }

        private void tbMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void tbMobile_TextChanged(object sender, EventArgs e)
        {
            if (cbCountry.Text == "Philippines")
            {
                if (tbMobile.Text.Length > 11)
                {
                    ErrorInput(lblMobile, lblErrMobile, pnlErrMobile, ref isMobileValid);
                    lblErrMobile.Text = "Error: Philippine Mobile Number Length";
                }
                else if (!phMobileNumRegex.IsMatch(tbMobile.Text))
                {
                    ErrorInput(lblMobile, lblErrMobile, pnlErrMobile, ref isMobileValid);
                    lblErrMobile.Text = "Error: Invalid Philippine Mobile Number";
                }
                else
                {
                    ValidInput(lblMobile, lblErrMobile, pnlErrMobile, ref isMobileValid);
                }
            }
            else if (tbMobile.Text.Length < 7 || tbMobile.Text.Length > 13) //other countries
            {
                ErrorInput(lblMobile, lblErrMobile, pnlErrMobile, ref isMobileValid);
                lblErrMobile.Text = "Error: Mobile Number Length";
            }
            else
            {
                ValidInput(lblMobile, lblErrMobile, pnlErrMobile, ref isMobileValid);
            }

        }
        private void btnProcessOrder_Click(object sender, EventArgs e)
        {
            if (isFnameValid && isLnameValid && isEmailValid && isCountryValid && isAddressValid && isCityValid &&
                isStateProvinceValid && isZipPostalCodeValid && isLandlineValid && isMobileValid)
            {
                SQLQueries.FirstName = tbFname.Text;
                SQLQueries.LastName = tbLname.Text;
                SQLQueries.Email = tbEmail.Text;
                SQLQueries.Country = cbCountry.Text;
                SQLQueries.Address = tbAddress.Text;
                SQLQueries.City = tbCity.Text;
                SQLQueries.StateProvince = tbStateProvince.Text;
                SQLQueries.PostalZip = tbPostalZip.Text;
                SQLQueries.Landline = tbLandline.Text;
                SQLQueries.MobileNumber = tbMobile.Text;
                SQLQueries.Note = tbNote.Text;

                ProcessClicked?.Invoke(this, EventArgs.Empty);
                SQLQueries.isValidToCheckout = true;
                MessageBox.Show("Information Valid");
            }
            else
            {
                MessageBox.Show("Complete All Required Fields First!");
                SQLQueries.isValidToCheckout = false;
            }
        }

        private void UCDriverInformation_Load(object sender, EventArgs e)
        {
            pbCurrentCar.Image = Image.FromFile(frmPopUp.currentImgPath);
            tbCarDesc.Text = frmPopUp.currentDescription;
        }

        public void SubscribeToEvents(FrmMain form)
        {
            form.DriverInfoClicked += Form_DriverInfoClicked;
        }

        private void Form_DriverInfoClicked(object sender, EventArgs e)
        {
            pbCurrentCar.Image = Image.FromFile(frmPopUp.currentImgPath);
            tbCarDesc.Text = frmPopUp.currentDescription;
        }

        public event EventHandler ProcessClicked;

        public event EventHandler ChangeCarClicked;//wild

        private void btnChangeCar_Click(object sender, EventArgs e)
        {
            ChangeCarClicked?.Invoke(this, EventArgs.Empty);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbFname.Text = "Marcus Jerremy";
            tbLname.Text = "Gonzaga";
            tbEmail.Text = "marcusjerremyg@gmail.com";
            cbCountry.Text = "Philippines";
            tbAddress.Text = "Navotas City, Metro Manila";
            tbMobile.Text = "09252324291";
            checkBTermsAndConditions.Checked = true;
        }

        private void TermsConLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://balanaa.github.io/Car-Rental-Manila-Term-s-Conditions/") { UseShellExecute = true });
        }

        private void checkBTermsAndConditions_CheckedChanged(object sender, EventArgs e)
        {
            btnProcessOrder.Enabled = checkBTermsAndConditions.Checked;
        }
    }
}
