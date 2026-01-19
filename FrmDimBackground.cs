using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using progressbar;
using static Vehicle_Rental.SQLQueries;

namespace Vehicle_Rental
{
    public partial class FrmDimBackground : Form
    {
        private frmPopUp pop;
        public FrmDimBackground(CarInfo carInfo)
        {
            InitializeComponent();

            pop = new frmPopUp(carInfo);
            pop.Owner = this;
            pop.Show();
            pop.ClosePopUp += FrmDimBackground_Click;

        }

        private void FrmDimBackground_Click(object sender, EventArgs e)
        {
            pop.Close();
            pop.Dispose();

            this.Close();
            this.Dispose();
        }


    }
}
