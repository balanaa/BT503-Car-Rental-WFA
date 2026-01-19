using System.Windows.Forms;

namespace Payment
{
    partial class UCCheckoutCard
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
            lblShowCardTab = new Label();
            lblEmail = new Label();
            lblCardInformation = new Label();
            lblCardHolderName = new Label();
            lblCountry = new Label();
            tbEmail = new PaddedTextBox();
            tbCardNum = new PaddedTextBox();
            tbCardDate = new PaddedTextBox();
            tbCVC = new PaddedTextBox();
            cbCardCountry = new PaddedComboBox();
            btnCardPay = new Button();
            pnlErrEmail = new Panel();
            pnlErrCardNum = new Panel();
            pnlErrCardDate = new Panel();
            pnlErrCVC = new Panel();
            pnlErrCardHolderName = new Panel();
            tbCardHolderName = new PaddedTextBox();
            lblErrEmail = new Label();
            lblErrCardNum = new Label();
            lblErrCardHolder = new Label();
            lblErrCountry = new Label();
            lblErrCardDate = new Label();
            lblErrCVC = new Label();
            pnlErrCountry = new Panel();
            pnlErrEmail.SuspendLayout();
            pnlErrCardNum.SuspendLayout();
            pnlErrCardDate.SuspendLayout();
            pnlErrCVC.SuspendLayout();
            pnlErrCardHolderName.SuspendLayout();
            pnlErrCountry.SuspendLayout();
            SuspendLayout();
            // 
            // lblShowCardTab
            // 
            lblShowCardTab.AutoSize = true;
            lblShowCardTab.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblShowCardTab.ForeColor = Color.White;
            lblShowCardTab.Location = new Point(130, 26);
            lblShowCardTab.Margin = new Padding(130, 0, 0, 0);
            lblShowCardTab.Name = "lblShowCardTab";
            lblShowCardTab.Size = new Size(233, 27);
            lblShowCardTab.TabIndex = 11;
            lblShowCardTab.Text = "Pay with Credit Card";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = Color.White;
            lblEmail.Location = new Point(30, 61);
            lblEmail.Margin = new Padding(0, 0, 0, 4);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(57, 22);
            lblEmail.TabIndex = 12;
            lblEmail.Text = "Email";
            // 
            // lblCardInformation
            // 
            lblCardInformation.AutoSize = true;
            lblCardInformation.Font = new Font("Arial", 14.25F);
            lblCardInformation.ForeColor = Color.White;
            lblCardInformation.Location = new Point(30, 149);
            lblCardInformation.Margin = new Padding(0, 0, 0, 4);
            lblCardInformation.Name = "lblCardInformation";
            lblCardInformation.Size = new Size(149, 22);
            lblCardInformation.TabIndex = 13;
            lblCardInformation.Text = "Card information";
            // 
            // lblCardHolderName
            // 
            lblCardHolderName.AutoSize = true;
            lblCardHolderName.Font = new Font("Arial", 14.25F);
            lblCardHolderName.ForeColor = Color.White;
            lblCardHolderName.Location = new Point(30, 293);
            lblCardHolderName.Margin = new Padding(0, 0, 0, 4);
            lblCardHolderName.Name = "lblCardHolderName";
            lblCardHolderName.Size = new Size(156, 22);
            lblCardHolderName.TabIndex = 14;
            lblCardHolderName.Text = "Cardholder name";
            // 
            // lblCountry
            // 
            lblCountry.AutoSize = true;
            lblCountry.Font = new Font("Arial", 14.25F);
            lblCountry.ForeColor = Color.White;
            lblCountry.Location = new Point(36, 384);
            lblCountry.Margin = new Padding(0, 0, 0, 4);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(155, 22);
            lblCountry.TabIndex = 15;
            lblCountry.Text = "Country or region";
            // 
            // tbEmail
            // 
            tbEmail.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbEmail.Location = new Point(2, 2);
            tbEmail.Margin = new Padding(4, 3, 4, 3);
            tbEmail.Multiline = true;
            tbEmail.Name = "tbEmail";
            tbEmail.PaddingBottom = 6;
            tbEmail.PaddingLeft = 10;
            tbEmail.PaddingRight = 0;
            tbEmail.PaddingTop = 6;
            tbEmail.Size = new Size(418, 41);
            tbEmail.TabIndex = 16;
            tbEmail.TextChanged += tbEmail_TextChanged;
            // 
            // tbCardNum
            // 
            tbCardNum.Font = new Font("Arial", 14.25F);
            tbCardNum.ForeColor = Color.Gray;
            tbCardNum.Location = new Point(2, 2);
            tbCardNum.Margin = new Padding(0);
            tbCardNum.Multiline = true;
            tbCardNum.Name = "tbCardNum";
            tbCardNum.PaddingBottom = 6;
            tbCardNum.PaddingLeft = 10;
            tbCardNum.PaddingRight = 0;
            tbCardNum.PaddingTop = 6;
            tbCardNum.Size = new Size(418, 41);
            tbCardNum.TabIndex = 17;
            tbCardNum.Text = "1234 1234 1234 1234";
            tbCardNum.TextChanged += tbCardNum_TextChanged;
            tbCardNum.Enter += tbCardNum_Enter;
            tbCardNum.KeyPress += tbCardNum_KeyPress;
            // 
            // tbCardDate
            // 
            tbCardDate.Font = new Font("Arial", 14.25F);
            tbCardDate.ForeColor = Color.Gray;
            tbCardDate.Location = new Point(2, 2);
            tbCardDate.Margin = new Padding(0);
            tbCardDate.Multiline = true;
            tbCardDate.Name = "tbCardDate";
            tbCardDate.PaddingBottom = 6;
            tbCardDate.PaddingLeft = 10;
            tbCardDate.PaddingRight = 0;
            tbCardDate.PaddingTop = 6;
            tbCardDate.Size = new Size(205, 41);
            tbCardDate.TabIndex = 18;
            tbCardDate.Text = "MM/YY";
            tbCardDate.TextChanged += tbCardDate_TextChanged;
            tbCardDate.Enter += tbCardDate_Enter;
            tbCardDate.KeyPress += tbCardDate_KeyPress;
            // 
            // tbCVC
            // 
            tbCVC.Font = new Font("Arial", 14.25F);
            tbCVC.ForeColor = Color.Gray;
            tbCVC.Location = new Point(2, 2);
            tbCVC.Margin = new Padding(0);
            tbCVC.Multiline = true;
            tbCVC.Name = "tbCVC";
            tbCVC.PaddingBottom = 6;
            tbCVC.PaddingLeft = 10;
            tbCVC.PaddingRight = 0;
            tbCVC.PaddingTop = 6;
            tbCVC.Size = new Size(205, 41);
            tbCVC.TabIndex = 19;
            tbCVC.Text = "CVC";
            tbCVC.TextChanged += tbCVC_TextChanged;
            tbCVC.Enter += tbCVC_Enter;
            tbCVC.KeyPress += tbCVC_KeyPress;
            // 
            // cbCardCountry
            // 
            cbCardCountry.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbCardCountry.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbCardCountry.DrawMode = DrawMode.OwnerDrawFixed;
            cbCardCountry.DropDownHeight = 250;
            cbCardCountry.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCardCountry.Font = new Font("Arial", 14.25F);
            cbCardCountry.FormattingEnabled = true;
            cbCardCountry.IntegralHeight = false;
            cbCardCountry.ItemHeight = 28;
            cbCardCountry.Items.AddRange(new object[] { "Afghanistan", "Albania", "Algeria", "Andorra", "Angola", "Antigua and Barbuda", "Argentina", "Armenia", "Australia", "Austria", "Azerbaijan", "Bahamas", "Bahrain", "Bangladesh", "Barbados", "Belarus", "Belgium", "Belize", "Benin", "Bhutan", "Bolivia", "Bosnia and Herzegovina", "Botswana", "Brazil", "Brunei Darussalam", "Bulgaria", "Burkina Faso", "Burundi", "Cabo Verde", "Cambodia", "Cameroon", "Canada", "Central African Republic", "Chad", "Chile", "China", "Colombia", "Comoros", "Congo", "Costa Rica", "Croatia", "Cuba", "Cyprus", "Czech Republic", "Denmark", "Djibouti", "Dominica", "Dominican Republic", "Ecuador", "Egypt", "El Salvador", "Equatorial Guinea", "Eritrea", "Estonia", "Eswatini", "Ethiopia", "Fiji", "Finland", "France", "Gabon", "Gambia", "Georgia", "Germany", "Ghana", "Greece", "Grenada", "Guatemala", "Guinea", "Guinea-Bissau", "Guyana", "Haiti", "Honduras", "Hungary", "Iceland", "India", "Indonesia", "Iran", "Iraq", "Ireland", "Israel", "Italy", "Jamaica", "Japan", "Jordan", "Kazakhstan", "Kenya", "Kiribati", "Kuwait", "Kyrgyzstan", "Lao People's Democratic Republic", "Latvia", "Lebanon", "Lesotho", "Liberia", "Libya", "Liechtenstein", "Lithuania", "Luxembourg", "Madagascar", "Malawi", "Malaysia", "Maldives", "Mali", "Malta", "Marshall Islands", "Mauritania", "Mauritius", "Mexico", "Micronesia", "Moldova", "Monaco", "Mongolia", "Montenegro", "Morocco", "Mozambique", "Myanmar", "Namibia", "Nauru", "Nepal", "Netherlands", "New Zealand", "Nicaragua", "Niger", "Nigeria", "North Korea", "North Macedonia", "Norway", "Oman", "Pakistan", "Palau", "Panama", "Papua New Guinea", "Paraguay", "Peru", "Philippines", "Poland", "Portugal", "Qatar", "Romania", "Russia", "Rwanda", "Saint Kitts and Nevis", "Saint Lucia", "Saint Vincent and the Grenadines", "Samoa", "San Marino", "Sao Tome and Principe", "Saudi Arabia", "Senegal", "Serbia", "Seychelles", "Sierra Leone", "Singapore", "Slovakia", "Slovenia", "Solomon Islands", "Somalia", "South Africa", "South Korea", "South Sudan", "Spain", "Sri Lanka", "Sudan", "Suriname", "Sweden", "Switzerland", "Syria", "Taiwan", "Tajikistan", "Tanzania, United Republic of", "Thailand", "Timor-Leste", "Togo", "Tokelau", "Tonga", "Trinidad and Tobago", "Tunisia", "Turkey", "Turkmenistan", "Tuvalu", "Uganda", "Ukraine", "United Arab Emirates", "United Kingdom of Great Britain", "United States of America", "Uruguay", "Uzbekistan", "Vanuatu", "Vatican City", "Venezuela", "Viet Nam", "Yemen", "Zambia", "Zimbabwe" });
            cbCardCountry.Location = new Point(2, 2);
            cbCardCountry.Margin = new Padding(4, 3, 4, 3);
            cbCardCountry.Name = "cbCardCountry";
            cbCardCountry.PaddingBottom = 3;
            cbCardCountry.PaddingLeft = 10;
            cbCardCountry.PaddingRight = 0;
            cbCardCountry.PaddingTop = 3;
            cbCardCountry.Size = new Size(418, 34);
            cbCardCountry.TabIndex = 21;
            cbCardCountry.SelectedIndexChanged += cbCardCountry_SelectedIndexChanged;
            // 
            // btnCardPay
            // 
            btnCardPay.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCardPay.Location = new Point(36, 488);
            btnCardPay.Margin = new Padding(4, 3, 4, 3);
            btnCardPay.Name = "btnCardPay";
            btnCardPay.Size = new Size(418, 53);
            btnCardPay.TabIndex = 22;
            btnCardPay.Text = "Pay";
            btnCardPay.UseVisualStyleBackColor = true;
            btnCardPay.Click += btnCardPay_Click;
            // 
            // pnlErrEmail
            // 
            pnlErrEmail.BackColor = Color.Transparent;
            pnlErrEmail.Controls.Add(tbEmail);
            pnlErrEmail.Location = new Point(34, 90);
            pnlErrEmail.Name = "pnlErrEmail";
            pnlErrEmail.Size = new Size(422, 45);
            pnlErrEmail.TabIndex = 31;
            // 
            // pnlErrCardNum
            // 
            pnlErrCardNum.BackColor = Color.Transparent;
            pnlErrCardNum.Controls.Add(tbCardNum);
            pnlErrCardNum.Location = new Point(34, 178);
            pnlErrCardNum.Name = "pnlErrCardNum";
            pnlErrCardNum.Size = new Size(422, 45);
            pnlErrCardNum.TabIndex = 32;
            // 
            // pnlErrCardDate
            // 
            pnlErrCardDate.BackColor = Color.Transparent;
            pnlErrCardDate.Controls.Add(tbCardDate);
            pnlErrCardDate.Location = new Point(34, 222);
            pnlErrCardDate.Name = "pnlErrCardDate";
            pnlErrCardDate.Size = new Size(209, 45);
            pnlErrCardDate.TabIndex = 33;
            // 
            // pnlErrCVC
            // 
            pnlErrCVC.BackColor = Color.Transparent;
            pnlErrCVC.Controls.Add(tbCVC);
            pnlErrCVC.Location = new Point(247, 222);
            pnlErrCVC.Name = "pnlErrCVC";
            pnlErrCVC.Size = new Size(209, 45);
            pnlErrCVC.TabIndex = 35;
            // 
            // pnlErrCardHolderName
            // 
            pnlErrCardHolderName.BackColor = Color.Transparent;
            pnlErrCardHolderName.Controls.Add(tbCardHolderName);
            pnlErrCardHolderName.Location = new Point(36, 320);
            pnlErrCardHolderName.Name = "pnlErrCardHolderName";
            pnlErrCardHolderName.Size = new Size(422, 45);
            pnlErrCardHolderName.TabIndex = 36;
            // 
            // tbCardHolderName
            // 
            tbCardHolderName.Font = new Font("Arial", 14.25F);
            tbCardHolderName.ForeColor = Color.Gray;
            tbCardHolderName.Location = new Point(2, 2);
            tbCardHolderName.Margin = new Padding(4, 3, 4, 3);
            tbCardHolderName.Multiline = true;
            tbCardHolderName.Name = "tbCardHolderName";
            tbCardHolderName.PaddingBottom = 6;
            tbCardHolderName.PaddingLeft = 10;
            tbCardHolderName.PaddingRight = 0;
            tbCardHolderName.PaddingTop = 6;
            tbCardHolderName.Size = new Size(418, 41);
            tbCardHolderName.TabIndex = 20;
            tbCardHolderName.Tag = "";
            tbCardHolderName.Text = "Full name on card";
            tbCardHolderName.TextChanged += tbCardHolderName_TextChanged;
            tbCardHolderName.Enter += tbCardHolderName_Enter;
            // 
            // lblErrEmail
            // 
            lblErrEmail.AutoSize = true;
            lblErrEmail.ForeColor = Color.Red;
            lblErrEmail.Location = new Point(90, 67);
            lblErrEmail.Name = "lblErrEmail";
            lblErrEmail.Size = new Size(0, 15);
            lblErrEmail.TabIndex = 37;
            // 
            // lblErrCardNum
            // 
            lblErrCardNum.AutoSize = true;
            lblErrCardNum.ForeColor = Color.Red;
            lblErrCardNum.Location = new Point(182, 155);
            lblErrCardNum.Name = "lblErrCardNum";
            lblErrCardNum.Size = new Size(0, 15);
            lblErrCardNum.TabIndex = 38;
            // 
            // lblErrCardHolder
            // 
            lblErrCardHolder.AutoSize = true;
            lblErrCardHolder.ForeColor = Color.Red;
            lblErrCardHolder.Location = new Point(189, 299);
            lblErrCardHolder.Name = "lblErrCardHolder";
            lblErrCardHolder.Size = new Size(0, 15);
            lblErrCardHolder.TabIndex = 39;
            // 
            // lblErrCountry
            // 
            lblErrCountry.AutoSize = true;
            lblErrCountry.ForeColor = Color.Red;
            lblErrCountry.Location = new Point(194, 390);
            lblErrCountry.Name = "lblErrCountry";
            lblErrCountry.Size = new Size(0, 15);
            lblErrCountry.TabIndex = 40;
            // 
            // lblErrCardDate
            // 
            lblErrCardDate.AutoSize = true;
            lblErrCardDate.ForeColor = Color.Red;
            lblErrCardDate.Location = new Point(34, 270);
            lblErrCardDate.Name = "lblErrCardDate";
            lblErrCardDate.Size = new Size(0, 15);
            lblErrCardDate.TabIndex = 42;
            // 
            // lblErrCVC
            // 
            lblErrCVC.AutoSize = true;
            lblErrCVC.ForeColor = Color.Red;
            lblErrCVC.Location = new Point(249, 270);
            lblErrCVC.Name = "lblErrCVC";
            lblErrCVC.Size = new Size(0, 15);
            lblErrCVC.TabIndex = 43;
            // 
            // pnlErrCountry
            // 
            pnlErrCountry.BackColor = Color.Transparent;
            pnlErrCountry.Controls.Add(cbCardCountry);
            pnlErrCountry.Location = new Point(36, 411);
            pnlErrCountry.Name = "pnlErrCountry";
            pnlErrCountry.Size = new Size(422, 38);
            pnlErrCountry.TabIndex = 44;
            // 
            // UCCheckoutCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            Controls.Add(pnlErrCountry);
            Controls.Add(lblErrCVC);
            Controls.Add(lblErrCardDate);
            Controls.Add(lblErrCountry);
            Controls.Add(lblErrCardHolder);
            Controls.Add(lblErrCardNum);
            Controls.Add(lblErrEmail);
            Controls.Add(pnlErrCardHolderName);
            Controls.Add(pnlErrCVC);
            Controls.Add(pnlErrCardDate);
            Controls.Add(pnlErrCardNum);
            Controls.Add(pnlErrEmail);
            Controls.Add(btnCardPay);
            Controls.Add(lblCountry);
            Controls.Add(lblCardHolderName);
            Controls.Add(lblCardInformation);
            Controls.Add(lblEmail);
            Controls.Add(lblShowCardTab);
            Margin = new Padding(0);
            Name = "UCCheckoutCard";
            Size = new Size(490, 581);
            pnlErrEmail.ResumeLayout(false);
            pnlErrEmail.PerformLayout();
            pnlErrCardNum.ResumeLayout(false);
            pnlErrCardNum.PerformLayout();
            pnlErrCardDate.ResumeLayout(false);
            pnlErrCardDate.PerformLayout();
            pnlErrCVC.ResumeLayout(false);
            pnlErrCVC.PerformLayout();
            pnlErrCardHolderName.ResumeLayout(false);
            pnlErrCardHolderName.PerformLayout();
            pnlErrCountry.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblShowCardTab;
        private Label lblEmail;
        private Label lblCardInformation;
        private Label lblCardHolderName;
        private Label lblCountry;
        private PaddedTextBox tbCardNum;
        private PaddedTextBox tbCardDate;
        private PaddedTextBox tbCVC;
        private PaddedComboBox cbCardCountry;
        private Button btnCardPay;
        private Button backcarddebitbtn;
        private Panel pnlErrFname;
        private PaddedTextBox tbEmail;
        private Panel pnlErrEmail;
        private Panel pnlErrCardNum;
        private Panel pnlErrCardDate;
        private Panel pnlErrCVC;
        private Panel pnlErrCardHolderName;
        private PaddedTextBox tbCardHolderName;
        private Label lblErrEmail;
        private Label lblErrCardNum;
        private Label lblErrCardHolder;
        private Label lblErrCountry;
        private Label lblErrCardDate;
        private Label lblErrCVC;
        private Panel pnlErrCountry;
    }
}
