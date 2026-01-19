using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Admin
{
    
        public partial class UCDriverInformationTable : UserControl
        {
            // Define properties for driver information
            public int DriverID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public string Country { get; set; }
            public string Address { get; set; }
            public string City { get; set; }
            public string StateProvince { get; set; }
            public string PostalZip { get; set; }
            public string Landline { get; set; }
            public string MobileNumber { get; set; }
            public string Note { get; set; }



            static string connectToDB = "Data Source=LENOVO-V14-ARE\\SQLEXPRESS;Database=CarRental;Integrated Security=True;Trust Server Certificate=True";

            public UCDriverInformationTable()
            {
                InitializeComponent();
                LoadDriverData();
            }

            public void LoadDriverData()
            {
                DataTable dt = Select();
                dgvDriverInfoList.DataSource = dt;
            }

            public DataTable Select()
            {
                SqlConnection con = new SqlConnection(connectToDB);
                DataTable dt = new DataTable();

                try
                {
                    string query = "SELECT * FROM DriverInformation";
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

            private void dgvDriverInfoList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
            {
                int rowIndex = e.RowIndex;
                tbDriverID.Text = dgvDriverInfoList.Rows[rowIndex].Cells[0].Value.ToString();
                tbFirstName.Text = dgvDriverInfoList.Rows[rowIndex].Cells[1].Value.ToString();
                tbLastName.Text = dgvDriverInfoList.Rows[rowIndex].Cells[2].Value.ToString();
                tbEmail.Text = dgvDriverInfoList.Rows[rowIndex].Cells[3].Value.ToString();
                tbCountry.Text = dgvDriverInfoList.Rows[rowIndex].Cells[4].Value.ToString();
                tbAddress.Text = dgvDriverInfoList.Rows[rowIndex].Cells[5].Value.ToString();
                tbCity.Text = dgvDriverInfoList.Rows[rowIndex].Cells[6].Value.ToString();
                tbStateProvince.Text = dgvDriverInfoList.Rows[rowIndex].Cells[7].Value.ToString();
                tbPostalZip.Text = dgvDriverInfoList.Rows[rowIndex].Cells[8].Value.ToString();
                tbLandline.Text = dgvDriverInfoList.Rows[rowIndex].Cells[9].Value.ToString();
                tbMobileNumber.Text = dgvDriverInfoList.Rows[rowIndex].Cells[10].Value.ToString();
                tbNote.Text = dgvDriverInfoList.Rows[rowIndex].Cells[11].Value.ToString();
            }

            private void btnRefresh_Click(object sender, EventArgs e)
            {
                LoadDriverData();
            }

            private void btnAdd_Click(object sender, EventArgs e)
            {
                FirstName = tbFirstName.Text;
                LastName = tbLastName.Text;
                Email = tbEmail.Text;
                Country = tbCountry.Text;
                Address = tbAddress.Text;
                City = tbCity.Text;
                StateProvince = tbStateProvince.Text;
                PostalZip = tbPostalZip.Text;
                Landline = tbLandline.Text;
                MobileNumber = tbMobileNumber.Text;
                Note = tbNote.Text;

                if (AddDriver())
                {
                    MessageBox.Show("Driver added successfully!");
                    LoadDriverData(); // Refresh data
                }
                else
                {
                    MessageBox.Show("Failed to add driver.");
                }
            }

            private void btnUpdate_Click(object sender, EventArgs e)
            {
                DriverID = int.Parse(tbDriverID.Text);
                FirstName = tbFirstName.Text;
                LastName = tbLastName.Text;
                Email = tbEmail.Text;
                Country = tbCountry.Text;
                Address = tbAddress.Text;
                City = tbCity.Text;
                StateProvince = tbStateProvince.Text;
                PostalZip = tbPostalZip.Text;
                Landline = tbLandline.Text;
                MobileNumber = tbMobileNumber.Text;
                Note = tbNote.Text;

                if (UpdateDriver())
                {
                    MessageBox.Show("Driver updated successfully!");
                    LoadDriverData(); // Refresh data
                }
                else
                {
                    MessageBox.Show("Failed to update driver.");
                }
            }

            private void btnDelete_Click(object sender, EventArgs e)
            {
                DriverID = int.Parse(tbDriverID.Text);
                if (!string.IsNullOrEmpty(tbDriverID.Text))
                {
                    if (DeleteDriver())
                    {
                        MessageBox.Show("Driver deleted successfully!");
                        LoadDriverData(); // Refresh data
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete driver.");
                    }
                }
                else
                {
                    MessageBox.Show("Select a Driver To Delete!");
                }
            }

            public bool AddDriver()
            {
                bool isSuccess = false;
                SqlConnection con = new SqlConnection(connectToDB);
                try
                {
                    string query = "INSERT INTO DriverInformation (FirstName, LastName, Email, Country, Address, City, StateProvince, PostalZip, Landline, MobileNumber, Note) " +
                                   "VALUES (@FirstName, @LastName, @Email, @Country, @Address, @City, @StateProvince, @PostalZip, @Landline, @MobileNumber, @Note);";

                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@FirstName", FirstName);
                    cmd.Parameters.AddWithValue("@LastName", LastName);
                    cmd.Parameters.AddWithValue("@Email", Email);
                    cmd.Parameters.AddWithValue("@Country", Country);
                    cmd.Parameters.AddWithValue("@Address", Address);
                    cmd.Parameters.AddWithValue("@City", City);
                    cmd.Parameters.AddWithValue("@StateProvince", StateProvince);
                    cmd.Parameters.AddWithValue("@PostalZip", PostalZip);
                    cmd.Parameters.AddWithValue("@Landline", Landline);
                    cmd.Parameters.AddWithValue("@MobileNumber", MobileNumber);
                    cmd.Parameters.AddWithValue("@Note", Note);

                    con.Open();
                    int rows = cmd.ExecuteNonQuery();
                    isSuccess = rows > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    con.Close(); // Ensure the connection is closed
                }

                return isSuccess;
            }

            public bool UpdateDriver()
            {
                bool isSuccess = false;
                SqlConnection con = new SqlConnection(connectToDB);
                try
                {
                    string query = "UPDATE DriverInformation " +
                                   "SET FirstName = @FirstName, LastName = @LastName, Email = @Email, Country = @Country, Address = @Address, City = @City, StateProvince = @StateProvince, PostalZip = @PostalZip, Landline = @Landline, MobileNumber = @MobileNumber, Note = @Note " +
                                   "WHERE DriverID = @DriverID";

                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@FirstName", FirstName);
                    cmd.Parameters.AddWithValue("@LastName", LastName);
                    cmd.Parameters.AddWithValue("@Email", Email);
                    cmd.Parameters.AddWithValue("@Country", Country);
                    cmd.Parameters.AddWithValue("@Address", Address);
                    cmd.Parameters.AddWithValue("@City", City);
                    cmd.Parameters.AddWithValue("@StateProvince", StateProvince);
                    cmd.Parameters.AddWithValue("@PostalZip", PostalZip);
                    cmd.Parameters.AddWithValue("@Landline", Landline);
                    cmd.Parameters.AddWithValue("@MobileNumber", MobileNumber);
                    cmd.Parameters.AddWithValue("@Note", Note);
                    cmd.Parameters.AddWithValue("@DriverID", DriverID);

                    con.Open();
                    int rows = cmd.ExecuteNonQuery();
                    isSuccess = rows > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    con.Close();
                }

                return isSuccess;
            }

            public bool DeleteDriver()
            {
                bool isSuccess = false;
                SqlConnection con = new SqlConnection(connectToDB);

                try
                {
                    string query = "DELETE FROM DriverInformation WHERE DriverID = @DriverID";

                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@DriverID", DriverID);

                    con.Open();
                    int rows = cmd.ExecuteNonQuery();
                    isSuccess = rows > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    con.Close();
                }
                return isSuccess;
            }
        }

    }
