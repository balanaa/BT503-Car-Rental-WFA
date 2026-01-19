using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Admin
{
    public partial class UCUpdateLogTable : UserControl
    {
        static string connectToDB = "Data Source=LENOVO-V14-ARE\\SQLEXPRESS;Database=CarRental;Integrated Security=True;Trust Server Certificate=True";

        public UCUpdateLogTable()
        {
            InitializeComponent();
            LoadUpdateLogData();
        }

        public void LoadUpdateLogData()
        {
            DataTable dt = Select();
            dgvUpdateLogsTable.DataSource = dt;
        }

        public DataTable Select()
        {
            SqlConnection con = new SqlConnection(connectToDB);
            DataTable dt = new DataTable();

            try
            {
                string query = "SELECT * FROM UpdateLog";
                SqlCommand cmd = new SqlCommand(query, con);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                con.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); // Log or handle the exception as needed
            }
            finally
            {
                con.Close();
            }

            return dt;
        }
    }
}
