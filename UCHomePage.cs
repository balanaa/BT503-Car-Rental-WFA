using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vehicle_Rental
{
    public partial class UCHomePage : UserControl
    {
        FrmMain mainForm;
        string mapAllLocations = @"https://my.atlist.com/map/0e254a3f-5ddf-4b1d-80b3-a2b71171f843";
        public UCHomePage(FrmMain mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private async void UCHomePage_Load(object sender, EventArgs e)
        {
            await webMaps.EnsureCoreWebView2Async();
            webMaps.CoreWebView2.Navigate(mapAllLocations);

        }

        private void webMaps_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (FrmLogin loginForm = new FrmLogin(mainForm))
            {
                loginForm.ShowDialog(); // Show the login form as a dialog

                if (loginForm.IsAuthenticated)
                {
                    MessageBox.Show("Welcome, Admin!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Access Denied.", "Login Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
