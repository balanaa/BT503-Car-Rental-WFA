using Vehicle_Rental;

namespace Admin
{
    public partial class FrmAdmin : Form
    {
        FrmMain mainForm;
        UCCarsTable carTableTab = new UCCarsTable();
        UCDriverInformationTable driverInfoTableTab = new UCDriverInformationTable();
        UCScheduleTable scheduleTableTab = new UCScheduleTable();
        UCUpdateLogTable updateLogTableTab = new UCUpdateLogTable();

        private Color pressedBtnColor = Color.LightYellow;
        private Color unselectedBtnColor = Color.Yellow;
        public FrmAdmin(FrmMain mainForm)
        {
            InitializeComponent();
            btnCarsTable.BackColor = unselectedBtnColor;
            btnDriverInformation.BackColor = unselectedBtnColor;
            btnSchedule.BackColor = unselectedBtnColor;
            btnUpdateLogsTable.BackColor = unselectedBtnColor;
            this.mainForm = mainForm;
        }

        private void LoadUserControl(UserControl userControl)
        {
            pnlMain.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(userControl);
        }

        private void btnCarsTable_Click(object sender, EventArgs e)
        {
            LoadUserControl(carTableTab);
            btnCarsTable.BackColor = pressedBtnColor;
            btnDriverInformation.BackColor = unselectedBtnColor;
            btnSchedule.BackColor = unselectedBtnColor;
            btnUpdateLogsTable.BackColor = unselectedBtnColor;

        }

        private void btnDriverInformation_Click(object sender, EventArgs e)
        {
            LoadUserControl(driverInfoTableTab);
            btnCarsTable.BackColor = unselectedBtnColor;
            btnDriverInformation.BackColor = pressedBtnColor;
            btnSchedule.BackColor = unselectedBtnColor;
            btnUpdateLogsTable.BackColor = unselectedBtnColor;
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            LoadUserControl(scheduleTableTab);
            btnCarsTable.BackColor = unselectedBtnColor;
            btnDriverInformation.BackColor = unselectedBtnColor;
            btnSchedule.BackColor = pressedBtnColor;
            btnUpdateLogsTable.BackColor = unselectedBtnColor;
        }
        private void btnUpdateLogsTable_Click(object sender, EventArgs e)
        {
            LoadUserControl(updateLogTableTab);
            btnCarsTable.BackColor = unselectedBtnColor;
            btnDriverInformation.BackColor = unselectedBtnColor;
            btnSchedule.BackColor = unselectedBtnColor;
            btnUpdateLogsTable.BackColor = pressedBtnColor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm.Show();
        }
    }
}
