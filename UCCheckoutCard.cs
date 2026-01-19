using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Net.Mail;
using System.Net;
using Vehicle_Rental;


namespace Payment
{
    public partial class UCCheckoutCard : UserControl
    {
        SQLQueries sql = new SQLQueries();
        Regex nameRegex = new Regex(@"^[\p{L}\s]*(\.[\p{L}\s]*)?$");
        Regex emailRegex = new Regex(@"^[\p{L}0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}(\.[a-zA-Z]{2,})*$");

        bool isEmailValid = false;

        bool isCardNumValid = false;
        bool isCardDateValid = false;
        bool isCVCValid = false;

        bool isCardHolderNameValid = false;
        bool isCountryValid = false;

        public UCCheckoutCard(string cardType)
        {
            InitializeComponent();
            lblShowCardTab.Text = "Payment with " + cardType;
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
        private void ValidateCardDate()
        {
            if (tbCardDate.Text.Length == 5 && tbCardDate.Text[2] == '/')
            {
                ValidInput(lblCardInformation, lblErrCardDate, pnlErrCardDate, ref isCardDateValid);
            }
            else
            {
                ErrorInput(lblCardInformation, lblErrCardDate, pnlErrCardDate, ref isCardDateValid);
                lblErrCardDate.Text = "Error: Incomplete";
            }
        }

        private void tbCardNum_Enter(object sender, EventArgs e)
        {
            ClearTextFormat(tbCardNum);

        }

        private void tbCardDate_Enter(object sender, EventArgs e)
        {
            ClearTextFormat(tbCardDate);

        }

        private void tbCVC_Enter(object sender, EventArgs e)
        {
            ClearTextFormat(tbCVC);

        }

        private void tbCardHolderName_Enter(object sender, EventArgs e)
        {
            ClearTextFormat(tbCardHolderName);
        }

        private void ClearTextFormat(TextBox tbSuggested)
        {
            tbSuggested.ForeColor = Color.Black;
            tbSuggested.Text = "";
        }

        private void tbCardNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;//pwede mag bura
            }
            if (tbCardNum.Text.Length > 18)
            {
                e.Handled = true; // parang exception throw
                return;
            }
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // bawal hindi digit
            }
        }

        private void tbCardDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tbCardDate.Text.Length == 2 && e.KeyChar == '/')
            {
                return;
            }

            if (char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Back) // Handle bura after makumpleto
                {
                    if (tbCardDate.Text.Length > 0)
                    {
                        tbCardDate.Text = tbCardDate.Text.Remove(tbCardDate.Text.Length - 1); // Remove last character
                        tbCardDate.SelectionStart = tbCardDate.Text.Length;
                    }
                    ValidateCardDate();
                }
                e.Handled = true;
                return;
            }
            if (tbCardDate.Text.Length >= 5)
            {
                e.Handled = true; // parang exception throw
                return;
            }
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // bawal hindi digit
            }
            int length = tbCardDate.Text.Length;
            switch (length)
            {
                case 0:
                    if (e.KeyChar >= '2' && e.KeyChar <= '9')
                    {
                        tbCardDate.Text = "0" + e.KeyChar + "/";//this create 02/'2' user inputs the '2'
                        tbCardDate.SelectionStart = tbCardDate.Text.Length;
                        ErrorInput(lblCardInformation, lblErrCardDate, pnlErrCardDate, ref isCardDateValid);
                        lblErrCardDate.Text = "Error: Incomplete";
                        e.Handled = true;
                    }
                    else if (e.KeyChar == '1')
                    {
                        tbCardDate.Text = "1";
                        tbCardDate.SelectionStart = tbCardDate.Text.Length;
                        e.Handled = true;
                        ErrorInput(lblCardInformation, lblErrCardDate, pnlErrCardDate, ref isCardDateValid);
                        lblErrCardDate.Text = "Error: Incomplete";
                    }
                    else if (e.KeyChar >= '0' && e.KeyChar <= '1')
                    {
                        ErrorInput(lblCardInformation, lblErrCardDate, pnlErrCardDate, ref isCardDateValid);
                        lblErrCardDate.Text = "Error: Incomplete";
                        return;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                    break;

                case 1:
                    if (tbCardDate.Text == "0")
                    {
                        if (e.KeyChar >= '1' && e.KeyChar <= '9')
                        {

                            tbCardDate.Text += e.KeyChar + "/";
                            tbCardDate.SelectionStart = tbCardDate.Text.Length;
                            e.Handled = true;
                            ErrorInput(lblCardInformation, lblErrCardDate, pnlErrCardDate, ref isCardDateValid);
                            lblErrCardDate.Text = "Error: Incomplete";
                        }
                        else
                        {
                            e.Handled = true; // Prevent non-valid input
                        }
                    }
                    else if (tbCardDate.Text == "1")
                    {
                        if (e.KeyChar >= '0' && e.KeyChar <= '2')
                        {

                            tbCardDate.Text += e.KeyChar + "/";
                            tbCardDate.SelectionStart = tbCardDate.Text.Length;
                            e.Handled = true;
                            ErrorInput(lblCardInformation, lblErrCardDate, pnlErrCardDate, ref isCardDateValid);
                            lblErrCardDate.Text = "Error: Incomplete";
                        }
                        else
                        {
                            e.Handled = true; // Prevent non-valid input
                        }
                    }
                    break;


                case 3: // First digit of the year
                    if (e.KeyChar >= '0' && e.KeyChar <= '9')
                    {
                        tbCardDate.Text += e.KeyChar;
                        tbCardDate.SelectionStart = tbCardDate.Text.Length;
                        e.Handled = true;
                    }
                    else
                    {
                        e.Handled = true; // Invalid year input
                    }
                    break;

                case 4: // Second digit of the year
                    if (e.KeyChar >= '0' && e.KeyChar <= '9')
                    {
                        tbCardDate.Text += e.KeyChar;
                        tbCardDate.SelectionStart = tbCardDate.Text.Length;

                        ValidInput(lblCardInformation, lblErrCardDate, pnlErrCardDate, ref isCardDateValid);
                        e.Handled = true;
                    }
                    else
                    {
                        e.Handled = true; // Invalid year input
                    }
                    break;

                default:
                    e.Handled = true; // Prevent input if length is not 0 or 1
                    break;
            }
        }
        private void tbCVC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;//pwede mag bura
            }
            if (tbCVC.Text.Length > 2)
            {
                e.Handled = true; // parang exception throw
                return;
            }
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // bawal hindi digit
            }
        }

        ///EXTRA VALIDATION
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

        private void tbCardNum_TextChanged(object sender, EventArgs e)
        {
            if (tbCardNum.Text.Length <= 18)
            {
                string textWithoutSpaces = tbCardNum.Text.Replace(" ", "");

                StringBuilder formattedText = new StringBuilder();
                for (int i = 0; i < textWithoutSpaces.Length; i++)
                {
                    if (i > 0 && i % 4 == 0)
                    {
                        formattedText.Append(" ");
                    }
                    formattedText.Append(textWithoutSpaces[i]);
                }

                int selectionStart = tbCardNum.SelectionStart;
                tbCardNum.TextChanged -= tbCardNum_TextChanged; // Temporarily remove event handler to avoid recursion
                tbCardNum.Text = formattedText.ToString();
                tbCardNum.TextChanged += tbCardNum_TextChanged; // Reattach event handler
                tbCardNum.SelectionStart = selectionStart + 1;

                ErrorInput(lblCardInformation, lblErrCardNum, pnlErrCardNum, ref isCardNumValid);
                lblErrCardNum.Text = "Error: Card Number Incomplete";
            }
            else
            {
                ValidInput(lblCardInformation, lblErrCardNum, pnlErrCardNum, ref isCardNumValid);
                return;
            }



        }

        private void tbCardDate_TextChanged(object sender, EventArgs e)
{
    DateTime today = DateTime.Today;

    // Get the expiration date from the single text box (e.g., "12/25")
    string expDate = tbCardDate.Text.Trim();

    // Validate expiration date format and check if it's valid
    if (expDate.Length == 5 && expDate[2] == '/')
    {
        string[] expParts = expDate.Split('/');
        if (expParts.Length == 2)
        {
            // Parse the expiration month and year
            int cardExpMonth = int.Parse(expParts[0]);
            int cardExpYear = int.Parse("20" + expParts[1]); // Assuming the year is in YY format (e.g., "25" for 2025)

            // Check if the expiration date is before today
            if (cardExpYear < today.Year || (cardExpYear == today.Year && cardExpMonth < today.Month))
            {
                // Call ErrorInput method if expiration date is invalid
                ErrorInput(lblCardInformation, lblErrCardDate, pnlErrCardDate, ref isCardDateValid); // Invalid input
            }
            else
            {
                // Call ValidInput method if expiration date is valid
                ValidInput(lblCardInformation, lblErrCardDate, pnlErrCardDate, ref isCardDateValid); // Valid input
            }
        }
        else
        {
            // Invalid format, call ErrorInput method
            ErrorInput(lblCardInformation, lblErrCardDate, pnlErrCardDate, ref isCardDateValid); // Invalid format
        }
    }
    else
    {
        // Invalid format, call ErrorInput method
        ErrorInput(lblCardInformation, lblErrCardDate, pnlErrCardDate, ref isCardDateValid); // Invalid format
    }
}






        private void tbCVC_TextChanged(object sender, EventArgs e)
        {

            if (tbCVC.Text.Length < 3)
            {
                ErrorInput(lblCardInformation, lblErrCVC, pnlErrCVC, ref isCVCValid);
                lblErrCVC.Text = "Error: CVC Length";
            }
            else
            {
                ValidInput(lblCardInformation, lblErrCVC, pnlErrCVC, ref isCVCValid);
            }
        }






        private void tbCardHolderName_TextChanged(object sender, EventArgs e)
        {
            string nameInput = tbCardHolderName.Text;
            Label lblInputType = lblErrCardHolder;
            Label lblErrMessage = lblErrCardHolder;
            Panel panel = pnlErrCardHolderName;

            if (!nameRegex.IsMatch(nameInput))
            {
                ErrorInput(lblInputType, lblErrMessage, panel, ref isCardHolderNameValid);
                lblErrMessage.Text = "Error: Invalid Characters";
            }
            else if (string.IsNullOrWhiteSpace(nameInput))
            {
                ErrorInput(lblInputType, lblErrMessage, panel, ref isCardHolderNameValid);
                lblErrMessage.Text = "Error: Blank Name";
            }
            else if (nameInput.Contains("  "))
            {
                ErrorInput(lblInputType, lblErrMessage, panel, ref isCardHolderNameValid);
                lblErrMessage.Text = "Error: Double Space";
            }
            else if (nameInput.Length < 3 || nameInput.Length > 30)
            {
                ErrorInput(lblInputType, lblErrMessage, panel, ref isCardHolderNameValid);
                lblErrMessage.Text = "Error: Name Length";
            }
            else
            {
                ValidInput(lblInputType, lblErrMessage, panel, ref isCardHolderNameValid);
            }
        }







        ////////////////////////////////////////////////////////////////////////////////////
        private void cbCardCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCardCountry.Items.Contains(cbCardCountry.Text))
            {
                ValidInput(lblCountry, lblErrCountry, pnlErrCountry, ref isCountryValid);
            }
            else
            {
                ErrorInput(lblCountry, lblErrCountry, pnlErrCountry, ref isCountryValid);
                lblErrCountry.Text = "Error: Invalid Country";
            }
        }
        private SQLQueries data;
        public void BindData(SQLQueries data)
        {
            this.data = data;
        }
        private void btnCardPay_Click(object sender, EventArgs e)
        {
            if (isEmailValid && isCardNumValid && isCardDateValid && isCVCValid && isCardHolderNameValid && isCountryValid)
            {
                SQLQueries.InsertDriverAndSchedule();

                // Email parameters
                string userEmail = tbEmail.Text;
                string subject = "Payment Confirmation";
                string body = $"Dear {tbCardHolderName.Text},\n\n" +
                              $"Thank you for your payment.\n" +
                              $"Card Type: {lblShowCardTab.Text.Replace("Payment with ", "")}\n" +
                              $"Amount: [Insert Amount Here]\n\n" +
                              "This is a confirmation of your successful payment.\n\n" +
                              "Best regards,\nVehicle Rental Team";

                try
                {
                    SendEmail(userEmail, subject, body);
                    MessageBox.Show("Payment successful! Confirmation email sent.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Payment was successful, but we couldn't send the email. Error: {ex.Message}", "Email Error");
                }
                
            }
            else
            {
                MessageBox.Show("Complete Valid Fields!");
            }
        }
        private void SendEmail(string recipientEmail, string subject, string body)
        {
            try
            {
                var smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential("carrentalmanilanoreply@gmail.com", "yein lcig ykuu uqbr\r\n"),
                    EnableSsl = true,
                };

                var mailMessage = new MailMessage
                {
                    From = new MailAddress("carrentalmanilanoreply@gmail.com", "Car Rental Manila"),
                    Subject = subject,
                    Body = body,
                    IsBodyHtml = true,
                };

                mailMessage.To.Add(recipientEmail);

                smtpClient.Send(mailMessage);
                MessageBox.Show("Email sent successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Payment was successful but we couldn't send the email.\nError: {ex.Message}",
                                "Email Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }




























    /// ////////////////////////////////
    public class PaddedTextBox : TextBox
    {
        private int _paddingLeft = 10;
        private int _paddingTop = 6;
        private int _paddingRight = 0;
        private int _paddingBottom = 6;

        public int PaddingLeft
        {
            get => _paddingLeft;
            set
            {
                _paddingLeft = value;
                AdjustPadding();
            }
        }

        public int PaddingTop
        {
            get => _paddingTop;
            set
            {
                _paddingTop = value;
                AdjustPadding();
            }
        }

        public int PaddingRight
        {
            get => _paddingRight;
            set
            {
                _paddingRight = value;
                AdjustPadding();
            }
        }

        public int PaddingBottom
        {
            get => _paddingBottom;
            set
            {
                _paddingBottom = value;
                AdjustPadding();
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            AdjustPadding();
        }

        private void AdjustPadding()
        {
            var rect = new Rectangle(
                _paddingLeft,
                _paddingTop,
                Width - _paddingLeft - _paddingRight,
                Height - _paddingTop - _paddingBottom
            );

            SendMessage(this.Handle, EM_SETRECT, IntPtr.Zero, ref rect);
            Invalidate();
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            AdjustPadding();
        }

        private const int EM_SETRECT = 0xB3;

        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam, ref Rectangle lParam);
    }

public class PaddedComboBox : ComboBox
    {
        private int _paddingLeft = 5;
        private int _paddingTop = 5;
        private int _paddingRight = 5;
        private int _paddingBottom = 5;
        public int PaddingLeft
        {
            get => _paddingLeft;
            set
            {
                _paddingLeft = value;
                AdjustPadding();
            }
        }
        public int PaddingTop
        {
            get => _paddingTop;
            set
            {
                _paddingTop = value;
                AdjustPadding();
            }
        }
        public int PaddingRight
        {
            get => _paddingRight;
            set
            {
                _paddingRight = value;
                AdjustPadding();
            }
        }
        public int PaddingBottom
        {
            get => _paddingBottom;
            set
            {
                _paddingBottom = value;
                AdjustPadding();
            }
        }

        public PaddedComboBox()
        {
            DrawMode = DrawMode.OwnerDrawVariable; // Allows custom drawing and item height adjustments
        }

        private void AdjustPadding()
        {
            // Ensure the control is redrawn to reflect padding changes
            ItemHeight = Font.Height + _paddingTop + _paddingBottom; // Adjust item height dynamically
            Invalidate();
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            e.DrawBackground();

            string text = Items[e.Index].ToString();
            using (var brush = new SolidBrush(e.ForeColor))
            {
                var bounds = e.Bounds;
                var paddedBounds = new Rectangle(
                    bounds.Left + _paddingLeft,
                    bounds.Top + _paddingTop,
                    bounds.Width - _paddingLeft - _paddingRight,
                    bounds.Height - _paddingTop - _paddingBottom
                );
                e.Graphics.DrawString(text, e.Font, brush, paddedBounds);
            }

            e.DrawFocusRectangle();
        }

        protected override void OnMeasureItem(MeasureItemEventArgs e)
        {
            if (e.Index < 0) return;
            e.ItemHeight = Font.Height + _paddingTop + _paddingBottom;
            e.ItemWidth = e.ItemWidth; // Keep the width as default
        }
    }
}
