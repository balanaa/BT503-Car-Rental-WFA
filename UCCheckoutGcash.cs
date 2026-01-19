using System.Net.Mail;
using System.Net;
using System.Text.RegularExpressions;
using Payment;
using progressbar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;
using System.Drawing.Printing;
using System.Drawing;
using System.Windows.Forms;

namespace Vehicle_Rental
{
    public partial class UCCheckoutGcash : UserControl
    {
        Regex referenceRegex = new Regex(@"^\d+$");
        Regex emailRegex = new Regex(@"^[\p{L}0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}(\.[a-zA-Z]{2,})*$");

        bool isEmailValid = false;
        bool isReferenceValid = false;
        public UCCheckoutGcash()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userEmail = tbEmail.Text;
            string referenceNumber = ReferenceNo.Text;

            if (string.IsNullOrWhiteSpace(userEmail))
            {
                MessageBox.Show("Please enter your email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(referenceNumber))
            {
                MessageBox.Show("Please enter your reference number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!referenceRegex.IsMatch(referenceNumber))
            {
                MessageBox.Show("Invalid reference number format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!isReferenceValid)
            {
                MessageBox.Show("Reference number must be exactly 13 digits.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (IsPaymentSuccessful())
            {
                SQLQueries.InsertDriverAndSchedule();
                SendEmailConfirmation(userEmail, referenceNumber);
                MessageBox.Show("Payment successful! Continue to the cashier.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Payment failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private bool IsPaymentSuccessful()
        {

            return true; 
        }

        private void SendEmailConfirmation(string email, string referenceNumber)
        {
            try
            {
                // SMTP Configuration
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential("carrentalmanilanoreply@gmail.com", "yein lcig ykuu uqbr\r\n"), // Replace with your app-specific password
                    EnableSsl = true
                };
                

                MailMessage mail = new MailMessage
                {
                    From = new MailAddress("carrentalmanilanoreply@gmail.com", "Vehicle Rental Manila"),
                    Subject = "Thank You for Your Payment",
                    Body = @$"
                    <!DOCTYPE html>
                    <html>
                    <head>
                        <style>
                            body {{
                                font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
                                background-color: #f9f9f9;
                                padding: 0;
                                color: #333;
                            }}
                            .image-container {{
                                display: flex;
                                justify-content: center;
                                align-items: center;
                                width: 100%;
                                overflow: hidden;
                            }}
                            img {{
                                width: 100%;
                                height: 100%;
                                max-width: 600px;
                                max-height: 400px;
                                object-fit: contain;
                            }}
                            .email-container {{
                                max-width: 800px;
                                margin-left: auto;
                                margin-right: auto;
                                background-color: lightblue;
                                border-radius: 8px;
                                box-shadow: 0 4px 6px rgba(0, 0, 0, 0.1);
                                overflow: hidden;
                            }}
                            .header {{
                                background-color: rgb(56, 182, 255);
                                color: #fff;
                                padding: 20px;
                                text-align: center;
                            }}
                            .header h1 {{
                                margin: 0;
                                font-size: 24px;
                            }}
                            .content {{
                                padding: 20px;
                            }}
                            .paragraph {{
                                margin-bottom: 20px;
                                line-height: 1.6;
                            }}
                            .highlight {{
                                background-color: rgb(255, 222, 89);
                                padding: 5px 10px;
                                border-radius: 5px;
                                display: inline-block;
                            }}
                            .footer {{
                                background-color: rgb(56, 182, 255);
                                color: #fff;
                                text-align: center;
                                padding: 10px;
                                font-size: 14px;
                            }}
                            .footer a {{
                                color: #fff;
                                text-decoration: underline;
                            }}
                        </style>
                    </head>
                    <body>
                        <div class='email-container'>
                            <div class='header'>
                                <h1>Thank You for Your Payment!</h1>
                            </div>
                            <div class='content'>
                                <h3>Thank you for choosing Car Rental Manila!</h3>
                                <div class='image-container'> 
                                    <img src='{frmPopUp.GetCarImageUrl(int.Parse(frmPopUp.currentCarID))}'> 
                                </div>
                                <div class='paragraph'>
                                    You have successfully booked a {frmPopUp.currentName}, which features a {frmPopUp.currentBodyType} body type, {frmPopUp.currentTransmission} transmission, and runs on {frmPopUp.currentFuelType}. It seats up to {frmPopUp.currentSeatingCapacity} passengers, making it a perfect choice for your trip.
                                </div>
                                <div class='paragraph'>
                                    Your driver, {SQLQueries.FirstName} {SQLQueries.LastName}, can be contacted via email at {SQLQueries.Email} or by phone at {SQLQueries.MobileNumber}. We have your address listed as {SQLQueries.Address}, {SQLQueries.Country}.
                                </div>
                                <div class='paragraph'>
                                    Your rental starts at {SQLQueries.PickUpLocation} on {SQLQueries.PickUpDate} at {SQLQueries.PickUpTime} and ends at {SQLQueries.DropOffLocation} on {SQLQueries.DropOffDate} at {SQLQueries.DropOffTime}. Please make sure to arrive on time to ensure a smooth handoff.
                                </div>
                                <div class='paragraph'>
                                    The daily rental rate for your vehicle is <span class='highlight'>₱ {frmPopUp.currentPrice}</span>. Based on your rental duration, the total cost amounts to <span class='highlight'>₱ {UCCheckout.CalculatePrice().ToString("F2")}</span>. This includes {UCCheckout.DisplayRentalCost()}.
                                </div>
                                <div class='paragraph'>
                                    As stated in our <a href='https://balanaa.github.io/Car-Rental-Manila-Term-s-Conditions/' target='_blank' title='Go to Term's and conditions'>Terms & Conditions</a> A Valid ID from your driver, {SQLQueries.FirstName} {SQLQueries.LastName}, will be surrendered for the rest of the Rental Schedule.
                                </div>
                            </div>
                            <div class='footer'>
                                <p>Thank you for choosing Vehicle Rental Manila. We wish you a safe and enjoyable journey!</p>
                                <p>Need help? <a href='mailto:carrentalmanilanoreply@gmail.com'>Contact Us</a></p>
                            </div>
                        </div>
                    </body>
                    </html>",
                    IsBodyHtml = true,
                };
                mail.To.Add(email);



                // Send Email
                smtpClient.Send(mail);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to send email: {ex.Message}", "Email Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
        private void paddedTextBox1_TextChanged(object sender, EventArgs e)
        {
            string input = ReferenceNo.Text;

            if (input.Length > 13 || !Regex.IsMatch(input, @"^\d{0,13}$"))
            {
                // Error Handling: Only allow up to 13 digits
                ErrorInput(lblreference, lblErrReference, panel1, ref isReferenceValid);
                lblErrReference.Text = "Error: Reference number must be exactly 13 digits.";
            }
            else if (input.Length == 13)
            {
                // Input is valid
                ValidInput(lblreference, lblErrReference, panel1, ref isReferenceValid);
            }
            else
            {
                // Reset input if it's incomplete but not invalid
                lblErrReference.Text = "Reference number should be 13 digits.";
                panel1.BackColor = Color.Transparent;
                lblreference.ForeColor = Color.Black;
            }
        }

        public void ReferenceNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (ReferenceNo.Text.Length >= 13)
            {
                e.Handled = true;
                return;
            }
        }

    }
}