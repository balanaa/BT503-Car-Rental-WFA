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
    public partial class UCCarsTable : UserControl
    {
        public int CarID { get; set; } // Maps to CarID INT IDENTITY(1,1) PRIMARY KEY
        public string ImgPath { get; set; } // Maps to ImgPath NVARCHAR(100) NOT NULL
        public string CarName { get; set; } // Maps to CarName NVARCHAR(50) NOT NULL
        public string Brand { get; set; } // Maps to Brand NVARCHAR(20) NOT NULL
        public string BodyType { get; set; } // Maps to BodyType VARCHAR(20) NOT NULL
        public string Transmission { get; set; } // Maps to Transmission VARCHAR(10) NOT NULL
        public string FuelType { get; set; } // Maps to FuelType VARCHAR(10) NOT NULL
        public byte SeatingCapacity { get; set; } // Maps to SeatingCapacity TINYINT NOT NULL
        public byte Doors { get; set; } // Maps to Doors TINYINT NOT NULL
        public string Description { get; set; } // Maps to Description NVARCHAR(1000) NULL
        public decimal Price { get; set; } // Maps to Price DECIMAL(10,2) NOT NULL
        public string PlateNumber { get; set; }
        public string Available { get; set; }

        static string connectToDB = "Data Source=LENOVO-V14-ARE\\SQLEXPRESS;Database=CarRental;Integrated Security=True;Trust Server Certificate=True";
        public UCCarsTable()
        {
            InitializeComponent();
            DataTable dt = Select();
            dgvCarList.DataSource = dt;
        }
        public DataTable Select()
        {
            SqlConnection con = new SqlConnection(connectToDB);
            DataTable dt = new DataTable();

            try
            {
                string query = "SELECT * FROM Cars";
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

        private void dgvCarList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;

            tbCarID.Text = dgvCarList.Rows[rowIndex].Cells[0].Value.ToString();
            tbImgFilePath.Text = dgvCarList.Rows[rowIndex].Cells[1].Value.ToString();
            tbCarName.Text = dgvCarList.Rows[rowIndex].Cells[2].Value.ToString();
            tbCarBrand.Text = dgvCarList.Rows[rowIndex].Cells[3].Value.ToString();
            tbBodyType.Text = dgvCarList.Rows[rowIndex].Cells[4].Value.ToString();
            tbTransmission.Text = dgvCarList.Rows[rowIndex].Cells[5].Value.ToString();
            tbFuelType.Text = dgvCarList.Rows[rowIndex].Cells[6].Value.ToString();
            tbSeatingCapacity.Text = dgvCarList.Rows[rowIndex].Cells[7].Value.ToString();
            tbDoors.Text = dgvCarList.Rows[rowIndex].Cells[8].Value.ToString();
            tbDescription.Text = dgvCarList.Rows[rowIndex].Cells[9].Value.ToString();
            tbPrice.Text = dgvCarList.Rows[rowIndex].Cells[10].Value.ToString();
            tbPlateNumber.Text = dgvCarList.Rows[rowIndex].Cells[11].Value.ToString();
            tbAvailable.Text = dgvCarList.Rows[rowIndex].Cells[12].Value.ToString();

            pictureBox1.Image = Image.FromFile(tbImgFilePath.Text);

        }

        private void tbImgFilePath_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;//pwede mag bura
            }
            if (tbImgFilePath.Text.Length > 99)
            {
                e.Handled = true; // parang exception throw
                return;
            }
        }
        private void tbCarName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;//pwede mag bura
            }
            if (tbCarName.Text.Length >= 50)//
            {
                e.Handled = true; // parang exception throw
            }
        }

        private void tbCarBrand_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;//pwede mag bura
            }
            if (tbCarBrand.Text.Length >= 20)//
            {
                e.Handled = true; // parang exception throw
            }
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // bawal hindi digit
            }
        }
        private void tbBodyType_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;//pwede mag bura
            }
            if (tbBodyType.Text.Length >= 9)//
            {
                e.Handled = true; // parang exception throw
            }
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // bawal digit
            }
        }
        private void tbTransmission_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;//pwede mag bura
            }
            if (tbTransmission.Text.Length >= 9)
            {
                e.Handled = true; // parang exception throw
            }
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // bawal digit
            }
        }
        private void tbFuelType_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;//pwede mag bura
            }
            if (tbFuelType.Text.Length > 8)
            {
                e.Handled = true; // parang exception throw
                return;
            }
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // bawal digit
            }
        }

        private void tbDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
        }
        private void tbSeatingCapacity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }
            if (e.KeyChar == '0')
            {
                e.Handled = true;
                return;
            }
            if (int.TryParse(tbSeatingCapacity.Text + e.KeyChar, out int seatingCapacity))
            {
                if (seatingCapacity > 16)
                {
                    e.Handled = true;
                }
                else
                {
                    return;
                }
            }
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbDoors_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }
            if (e.KeyChar == '0')
            {
                e.Handled = true;
                return;
            }
            if (tbDoors.Text.Length == '0' && !(e.KeyChar == '1'))
            {
                e.Handled = true;
                return;
            }
            if (int.TryParse(tbDoors.Text + e.KeyChar, out int doorCount))
            {
                if (doorCount > 6)
                {
                    e.Handled = true;
                }
                else
                {
                    return;
                }
            }
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;//pwede mag bura
            }
            if (tbPrice.Text.Length > 7)
            {
                e.Handled = true; // parang exception throw
                return;
            }
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // bawal hindi digit
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            tbCarID.Clear();
            tbImgFilePath.Clear();
            tbCarName.Clear();
            tbCarBrand.Clear();
            tbBodyType.Clear();
            tbTransmission.Clear();
            tbFuelType.Clear();
            tbSeatingCapacity.Clear();
            tbDoors.Clear();
            tbDescription.Clear();
            tbPrice.Clear();
            tbPlateNumber.Clear();
            tbAvailable.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CarID = int.Parse(tbCarID.Text);
            ImgPath = tbImgFilePath.Text;
            CarName = tbCarName.Text;
            Brand = tbCarBrand.Text;
            BodyType = tbBodyType.Text;
            Transmission = tbTransmission.Text;
            FuelType = tbFuelType.Text;
            SeatingCapacity = byte.Parse(tbSeatingCapacity.Text);
            Doors = byte.Parse(tbDoors.Text);
            Description = tbDescription.Text;
            Price = decimal.Parse(tbPrice.Text);
            PlateNumber = tbPlateNumber.Text;
            Available = tbAvailable.Text;

            AddCar();
        }

        public bool AddCar()
        {
            bool isSuccess = false;
            SqlConnection con = new SqlConnection(connectToDB);
            try
            {
                string query = "INSERT INTO Cars (ImgPath, CarName, Brand, BodyType, Transmission, FuelType, SeatingCapacity, Doors, Description, Price, PlateNumber, Available) " +
                               "VALUES (@ImgPath, @CarName, @Brand, @BodyType, @Transmission, @FuelType, @SeatingCapacity, @Doors, @Description, @Price, @PlateNumber, @Available);";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@ImgPath", ImgPath);
                cmd.Parameters.AddWithValue("@CarName", CarName);
                cmd.Parameters.AddWithValue("@Brand", Brand);
                cmd.Parameters.AddWithValue("@BodyType", BodyType);
                cmd.Parameters.AddWithValue("@Transmission", Transmission);
                cmd.Parameters.AddWithValue("@FuelType", FuelType);
                cmd.Parameters.AddWithValue("@SeatingCapacity", SeatingCapacity);
                cmd.Parameters.AddWithValue("@Doors", Doors);
                cmd.Parameters.AddWithValue("@Description", Description);
                cmd.Parameters.AddWithValue("@Price", Price);
                cmd.Parameters.AddWithValue("@PlateNumber", PlateNumber);
                cmd.Parameters.AddWithValue("@Available", Available);

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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            CarID = int.Parse(tbCarID.Text);
            ImgPath = tbImgFilePath.Text;
            CarName = tbCarName.Text;
            Brand = tbCarBrand.Text;
            BodyType = tbBodyType.Text;
            Transmission = tbTransmission.Text;
            FuelType = tbFuelType.Text;
            SeatingCapacity = byte.Parse(tbSeatingCapacity.Text);
            Doors = byte.Parse(tbDoors.Text);
            Description = tbDescription.Text;
            Price = decimal.Parse(tbPrice.Text);
            PlateNumber = tbPlateNumber.Text;
            Available = tbAvailable.Text;

            UpdateCar();
        }

        public bool UpdateCar()
        {
            bool isSuccess = false;
            SqlConnection con = new SqlConnection(connectToDB);
            try
            {
                string query = "UPDATE Cars " +
                               "SET ImgPath = @ImgPath, CarName = @CarName, Brand = @Brand, BodyType = @BodyType, Transmission = @Transmission, FuelType = @FuelType, SeatingCapacity = @SeatingCapacity, Doors = @Doors, Description = @Description, Price = @Price, PlateNumber = @PlateNumber, Available = @Available " +
                               "WHERE CarID = @CarID";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@ImgPath", ImgPath);
                cmd.Parameters.AddWithValue("@CarName", CarName);
                cmd.Parameters.AddWithValue("@Brand", Brand);
                cmd.Parameters.AddWithValue("@BodyType", BodyType);
                cmd.Parameters.AddWithValue("@Transmission", Transmission);
                cmd.Parameters.AddWithValue("@FuelType", FuelType);
                cmd.Parameters.AddWithValue("@SeatingCapacity", SeatingCapacity);
                cmd.Parameters.AddWithValue("@Doors", Doors);
                cmd.Parameters.AddWithValue("@Description", Description);
                cmd.Parameters.AddWithValue("@Price", Price);
                cmd.Parameters.AddWithValue("@PlateNumber", PlateNumber);
                cmd.Parameters.AddWithValue("@Available", Available);
                cmd.Parameters.AddWithValue("@CarID", CarID);

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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            CarID = int.Parse(tbCarID.Text);
            if (!string.IsNullOrEmpty(tbCarID.Text))
            {
                DeleteCar();
            }
            else
            {
                MessageBox.Show("Select a Car To Delete!");
            }
        }
        public bool DeleteCar()
        {
            bool isSuccess = false;
            SqlConnection con = new SqlConnection(connectToDB);

            try
            {
                string query = "DELETE FROM Contacts WHERE CarID = @CarID";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@CarID", CarID);

                con.Open();
                int rows = cmd.ExecuteNonQuery();
                isSuccess = rows > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { con.Close(); }
            return isSuccess;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DataTable dt = Select();
        }
    }
}
