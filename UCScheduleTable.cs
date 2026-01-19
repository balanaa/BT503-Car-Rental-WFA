using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Admin
{
    public partial class UCScheduleTable : UserControl
    {
        public int SheduleID { get; set; }
        public string Status { get; set; }


        string connectToDB = "Data Source=LENOVO-V14-ARE\\SQLEXPRESS;Database=CarRental;Integrated Security=True;Trust Server Certificate=True";
        public UCScheduleTable()
        {
            InitializeComponent();
            DataTable dt = Select();
            dgvScheduleList.DataSource = dt;

        }
        public DataTable Select()
        {
            SqlConnection con = new SqlConnection(connectToDB);
            DataTable dt = new DataTable();

            try
            {
                string query = "SELECT * FROM Schedule";
                SqlCommand cmd = new SqlCommand(query, con);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                con.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return dt;
        }

        private void dgvScheduleList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;

            tbScheduleID.Text = dgvScheduleList.Rows[rowIndex].Cells[0].Value.ToString();
            comboBox1.Text = dgvScheduleList.Rows[rowIndex].Cells[9].Value.ToString();
        }

        private void btnChangeStatus_Click(object sender, EventArgs e)
        {
            // Assuming you have a way to get the selected ScheduleID, for example from a selected row in a DataGridView
            int scheduleID = int.Parse(tbScheduleID.Text); // Replace tbScheduleID with your actual control to get the ScheduleID

            if (ApproveSchedule(scheduleID, comboBox1.Text))
            {
                MessageBox.Show("Schedule approved successfully!");

            }
            else
            {
                MessageBox.Show("Failed to approve schedule.");
            }
        }

        public bool ApproveSchedule(int scheduleID, string status)
        {
            bool isSuccess = false;
            SqlConnection con = new SqlConnection(connectToDB);
            try
            {
                string query = "UPDATE Schedule SET Status = @Status WHERE ScheduleID = @scheduleID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@scheduleID", scheduleID);
                cmd.Parameters.AddWithValue("@Status", status);

                con.Open();
                int rows = cmd.ExecuteNonQuery();
                isSuccess = rows > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); // Log or handle the exception as needed
            }
            finally
            {
                con.Close();
            }

            return isSuccess;
        }

    }
}
