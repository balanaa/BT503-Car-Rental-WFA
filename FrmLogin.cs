using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Admin;
using Microsoft.Data.SqlClient;

namespace Vehicle_Rental
{
    public partial class FrmLogin : Form
    {
        FrmMain mainForm;
        public bool IsAuthenticated { get; private set; } = false; // Default: not authenticated
        public string AdminName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int AdminID { get; set; }

        static string connectToDB = "Data Source=LENOVO-V14-ARE\\SQLEXPRESS;Database=CarRental;Integrated Security=True;Trust Server Certificate=True";
        public FrmLogin(FrmMain mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbUserName.Text.Trim();
            string password = tbPassword.Text.Trim();

            if (ValidateAdminCredentials(username, password))
            {
                IsAuthenticated = true; 
                MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                
                FrmAdmin admin = new FrmAdmin(mainForm);
                admin.Show();
                mainForm.Hide(); ///here

            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateAdminCredentials(string username, string password)
        {

            using (SqlConnection conn = new SqlConnection(connectToDB))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT COUNT(1) FROM AdminAccounts WHERE AdminUser = @username AND AdminPassword = @password";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }
    }
}


    
