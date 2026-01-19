using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using progressbar;

namespace Vehicle_Rental
{
    public class CarInfo
    {
        public string CarID { get; set; }
        public string ImgPath { get; set; }
        public string CarName { get; set; }
        public string Brand { get; set; }
        public string BodyType { get; set; }
        public string Transmission { get; set; }
        public string FuelType { get; set; }
        public byte SeatingCapacity { get; set; }
        public string Price { get; set; }
        public string Description { get; set; }
    }
    public class SQLQueries
    {
        public static bool isValidToChooseCar = false;
        public static bool isValidToDriverInfo = false;
        public static bool isValidToCheckout = false;


        public static string CarID { get; set; }
        public static string ImgPath { get; set; }
        // SCHEDULE TAB
        public static string PickUpLocation { get; set; }
        public static string PickUpDate { get; set; }
        public static string PickUpTime { get; set; }

        public static string DropOffLocation { get; set; }
        public static string DropOffDate { get; set; }
        public static string DropOffTime { get; set; }

        // DRIVER INFORMATION TAB
        
        public static int DriverID { get; set; }
        public static string FirstName { get; set; }
        public static string LastName { get; set; }
        public static string Email { get; set; }
        public static string Country { get; set; }
        public static string Address { get; set; }
        public static string? City { get; set; }
        public static string? StateProvince { get; set; }
        public static string? PostalZip { get; set; }
        public static string? Landline { get; set; }
        public static string MobileNumber { get; set; }
        public static string? Note { get; set; }



        static string connectToDB = "Data Source=LENOVO-V14-ARE\\SQLEXPRESS;Database=CarRental;Integrated Security=True;Trust Server Certificate=True";

        public static bool InsertDriverAndSchedule()
        {
            bool isSuccess = false;
            string insertDriverQuery = @"
    INSERT INTO DriverInformation (FirstName, LastName, Email, Country, Address, City, StateProvince, PostalZip, Landline, MobileNumber, Note)
    VALUES (@FirstName, @LastName, @Email, @Country, @Address, @City, @StateProvince, @PostalZip, @Landline, @MobileNumber, @Note);
    SELECT SCOPE_IDENTITY();";

            string rentQuery = @"
    INSERT INTO Schedule (DriverID, CarID, PickUpLocation, PickUpDate, PickUpTime, DropOffLocation, DropOffDate, DropOffTime, Status) 
    VALUES (@DriverID, @CarID, @PickUpLocation, @PickUpDate, @PickUpTime, @DropOffLocation, @DropOffDate, @DropOffTime, @Status)";

            string updateQuery = @"
    UPDATE Cars
    SET Available = 'No'
    WHERE CarID = @CarID;";

            using (SqlConnection connection = new SqlConnection(connectToDB))
            {
                connection.Open();
                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Insert into DriverInformation and get the DriverID
                        int driverID;
                        using (SqlCommand cmd = new SqlCommand(insertDriverQuery, connection, transaction))
                        {
                            cmd.Parameters.AddWithValue("@FirstName", SQLQueries.FirstName);
                            cmd.Parameters.AddWithValue("@LastName", SQLQueries.LastName);
                            cmd.Parameters.AddWithValue("@Email", SQLQueries.Email);
                            cmd.Parameters.AddWithValue("@Country", SQLQueries.Country);
                            cmd.Parameters.AddWithValue("@Address", SQLQueries.Address);
                            cmd.Parameters.AddWithValue("@MobileNumber", SQLQueries.MobileNumber);

                            cmd.Parameters.AddWithValue("@City", string.IsNullOrWhiteSpace(SQLQueries.City) ? (object)DBNull.Value : SQLQueries.City);
                            cmd.Parameters.AddWithValue("@StateProvince", string.IsNullOrWhiteSpace(SQLQueries.StateProvince) ? (object)DBNull.Value : SQLQueries.StateProvince);
                            cmd.Parameters.AddWithValue("@PostalZip", string.IsNullOrWhiteSpace(SQLQueries.PostalZip) ? (object)DBNull.Value : SQLQueries.PostalZip);
                            cmd.Parameters.AddWithValue("@Landline", string.IsNullOrWhiteSpace(SQLQueries.Landline) ? (object)DBNull.Value : SQLQueries.Landline);
                            cmd.Parameters.AddWithValue("@Note", string.IsNullOrWhiteSpace(SQLQueries.Note) ? (object)DBNull.Value : SQLQueries.Note);

                            driverID = Convert.ToInt32(cmd.ExecuteScalar());
                        }

                        // Insert into Schedule using the obtained DriverID
                        using (SqlCommand cmd = new SqlCommand(rentQuery, connection, transaction))
                        {
                            cmd.Parameters.AddWithValue("@DriverID", driverID);
                            cmd.Parameters.AddWithValue("@CarID", frmPopUp.currentCarID);
                            cmd.Parameters.AddWithValue("@PickUpLocation", string.IsNullOrWhiteSpace(SQLQueries.PickUpLocation) ? (object)DBNull.Value : SQLQueries.PickUpLocation);
                            cmd.Parameters.AddWithValue("@PickUpDate", SQLQueries.PickUpDate);
                            cmd.Parameters.AddWithValue("@PickUpTime", SQLQueries.PickUpTime);
                            cmd.Parameters.AddWithValue("@DropOffLocation", string.IsNullOrWhiteSpace(SQLQueries.DropOffLocation) ? (object)DBNull.Value : SQLQueries.DropOffLocation);
                            cmd.Parameters.AddWithValue("@DropOffDate", SQLQueries.DropOffDate);
                            cmd.Parameters.AddWithValue("@DropOffTime", SQLQueries.DropOffTime);
                            cmd.Parameters.AddWithValue("@Status", "To Be Approved");

                            cmd.ExecuteNonQuery();
                        }

                        // Update the Car availability
                        using (SqlCommand cmd = new SqlCommand(updateQuery, connection, transaction))
                        {
                            cmd.Parameters.AddWithValue("@CarID", frmPopUp.currentCarID);

                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        MessageBox.Show("Database operation successful");
                        isSuccess = true;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Error: " + ex.Message);
                        isSuccess = false;
                    }
                }
            }
            return isSuccess;
        }


        /// ////////////////////////////////////////////////////////////////////////////////
        public static bool DriverAndScheduleTransaction()
        {
            StringBuilder messageBuilder = new StringBuilder();////////////
            //int DriverID;

            bool isSuccess = false;
            using (SqlConnection connection = new SqlConnection(connectToDB))
            {
                connection.Open();

                SqlTransaction transaction = connection.BeginTransaction();
                try
                {
                    string insertDriverQuery = @"
                        INSERT INTO DriverInformation (FirstName, LastName, Email, Country, Address, City, StateProvince, PostalZip, Landline, MobileNumber, Note)
                        VALUES (@FirstName, @LastName, @Email, @Country, @Address, @City, @StateProvince, @PostalZip, @Landline, @MobileNumber, @Note);
                        SELECT SCOPE_IDENTITY();";
                    using (SqlCommand cmd = new SqlCommand(insertDriverQuery, connection, transaction))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", SQLQueries.FirstName);
                        cmd.Parameters.AddWithValue("@LastName", SQLQueries.LastName);
                        cmd.Parameters.AddWithValue("@Email", SQLQueries.Email);
                        cmd.Parameters.AddWithValue("@Country", SQLQueries.Country);
                        cmd.Parameters.AddWithValue("@Address", SQLQueries.Address);
                        cmd.Parameters.AddWithValue("@MobileNumber", SQLQueries.MobileNumber);

                        cmd.Parameters.AddWithValue("@City", string.IsNullOrWhiteSpace(SQLQueries.City) ? (object)DBNull.Value : SQLQueries.City);
                        cmd.Parameters.AddWithValue("@StateProvince", string.IsNullOrWhiteSpace(SQLQueries.StateProvince) ? (object)DBNull.Value : SQLQueries.StateProvince);
                        cmd.Parameters.AddWithValue("@PostalZip", string.IsNullOrWhiteSpace(SQLQueries.PostalZip) ? (object)DBNull.Value : SQLQueries.PostalZip);
                        cmd.Parameters.AddWithValue("@Landline", string.IsNullOrWhiteSpace(SQLQueries.Landline) ? (object)DBNull.Value : SQLQueries.Landline);
                        cmd.Parameters.AddWithValue("@Note", string.IsNullOrWhiteSpace(SQLQueries.Note) ? (object)DBNull.Value : SQLQueries.Note);

                        DriverID = Convert.ToInt32(cmd.ExecuteScalar());
                        MessageBox.Show(DriverID.ToString());
                    }
                    ////////////////
                    string rentQuery  = @" INSERT INTO Schedule  (DriverID, CarID, PickUpLocation, PickUpDate, PickUpTime, DropOffLocation, DropOffDate, DropOffTime, Status)" +
                        "VALUES  (@DriverID, @CarID, @PickUpLocation, @PickUpDate, @PickUpTime, @DropOffLocation, @DropOffDate, @DropOffTime, @Status)";
                    //string updateTime = "EXEC UpdateSchedule;";

                    using (SqlCommand cmd = new SqlCommand(rentQuery, connection, transaction))
                    {
                        cmd.Parameters.AddWithValue("@DriverID", DriverID);
                        cmd.Parameters.AddWithValue("@CarID", 1);

                        cmd.Parameters.AddWithValue("@PickUpLocation", string.IsNullOrWhiteSpace(SQLQueries.PickUpLocation) ? (object)DBNull.Value : SQLQueries.PickUpLocation);
                        cmd.Parameters.AddWithValue("@PickUpDate", SQLQueries.PickUpDate);
                        cmd.Parameters.AddWithValue("@PickUpTime", SQLQueries.PickUpTime);
                        cmd.Parameters.AddWithValue("@DropOffLocation", string.IsNullOrWhiteSpace(SQLQueries.DropOffLocation) ? (object)DBNull.Value : SQLQueries.DropOffLocation);
                        cmd.Parameters.AddWithValue("@DropOffDate", SQLQueries.DropOffDate);
                        cmd.Parameters.AddWithValue("@DropOffTime", SQLQueries.DropOffTime);
                        cmd.Parameters.AddWithValue("@Status", "To Be Approved");
                        cmd.ExecuteNonQuery();
                    }
                    ////////////////

                    using (SqlCommand updateCmd = new SqlCommand("EXEC UpdateSchedule;", connection, transaction))
                    {
                        updateCmd.ExecuteNonQuery();
                    }
                    string updateQuery = @"UPDATE Car
                                        SET Available = 'No'
                                        WHERE CarID = @CarID;";

                    using (SqlConnection conn = new SqlConnection(connectToDB))
                    {
                        conn.Open();
                    using (SqlCommand cmd = new SqlCommand(rentQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@CarID", SQLQueries.CarID);

                        // Execute the combined query.
                        cmd.ExecuteNonQuery();
                    }
                    }
                    // Commit the transaction
                    transaction.Commit();
                    MessageBox.Show("Data inserted successfully.");
                    isSuccess = true; 
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error: " + ex.Message);
                    isSuccess = false;
                }

                return isSuccess;
            }
        }


        /////FLOW_LAYOUT_PANEL

        public static List<CarInfo> GetFilteredAndSearchedCars(
        string searchKey = null, string carID = null, string carName = null, string brand = null,
        string bodyType = null, string transmission = null, string fuelType = null,
        byte? seatingCapacity = null)
        {
            List<CarInfo> cars = new List<CarInfo>();

            using (SqlConnection con = new SqlConnection(connectToDB))
            {
                try
                {
                    string query = "SELECT * FROM Cars WHERE 1=1";//1=1 para pwedeng masaksakan ng kahit anong condition basta may ^AND 
                    SqlCommand cmd = new SqlCommand(query, con);

                    if (!string.IsNullOrEmpty(carID))
                    {
                        query += " AND CarID = @CarID";
                        cmd.Parameters.AddWithValue("@CarID", carID);
                    }
                    if (!string.IsNullOrEmpty(carName))
                    {
                        query += " AND CarName = @CarName";
                        cmd.Parameters.AddWithValue("@CarName", carName);
                    }
                    if (!string.IsNullOrEmpty(brand))
                    {
                        query += " AND Brand = @Brand";
                        cmd.Parameters.AddWithValue("@Brand", brand);
                    }
                    if (!string.IsNullOrEmpty(bodyType))
                    {
                        query += " AND BodyType = @BodyType";
                        cmd.Parameters.AddWithValue("@BodyType", bodyType);
                    }
                    if (!string.IsNullOrEmpty(transmission))
                    {
                        query += " AND Transmission = @Transmission";
                        cmd.Parameters.AddWithValue("@Transmission", transmission);
                    }
                    if (!string.IsNullOrEmpty(fuelType))
                    {
                        query += " AND FuelType = @FuelType";
                        cmd.Parameters.AddWithValue("@FuelType", fuelType);
                    }
                    if (seatingCapacity > 0)
                    {
                        query += " AND SeatingCapacity = @SeatingCapacity";
                        cmd.Parameters.AddWithValue("@SeatingCapacity", seatingCapacity.Value);
                    }

                    // kung may search
                    if (!string.IsNullOrEmpty(searchKey))
                    {
                        query += " AND (CarName LIKE @SearchKey OR " +
                                 "Brand LIKE @SearchKey OR " +
                                 "BodyType LIKE @SearchKey OR " +
                                 "Transmission LIKE @SearchKey OR " +
                                 "FuelType LIKE @SearchKey OR " +
                                 "SeatingCapacity LIKE @SearchKey)";
                        cmd.Parameters.AddWithValue("@SearchKey", $"%{searchKey}%");
                    }

                    cmd.CommandText = query;
                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cars.Add(new CarInfo
                            {
                                CarID = reader["CarID"].ToString(),
                                ImgPath = reader["ImgPath"].ToString(),
                                CarName = reader["CarName"].ToString(),
                                Brand = reader["Brand"].ToString(),
                                BodyType = reader["BodyType"].ToString(),
                                Transmission = reader["Transmission"].ToString(),
                                FuelType = reader["FuelType"].ToString(),
                                SeatingCapacity = Convert.ToByte(reader["SeatingCapacity"]),
                                Price = reader["Price"].ToString(),
                                Description = reader["Description"].ToString()
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
            return cars;
        }
    }
}
