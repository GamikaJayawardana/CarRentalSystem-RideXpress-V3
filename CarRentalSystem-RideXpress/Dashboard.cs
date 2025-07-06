using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace CarRentalSystem_RideXpress
{
    public partial class Dashboard : UserControl
    {

       

        SqlConnection connect = new SqlConnection(DBConnection.ConnectionString);

        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            LoadDashboardStats();
           
        }

        public void LoadDashboardStats()
        {
            try
            {
                connect.Open();

                // Total Cars
                SqlCommand cmdTotalCars = new SqlCommand("SELECT COUNT(*) FROM cars", connect);
                lblTotalCars.Text = cmdTotalCars.ExecuteScalar().ToString();

                // Available Cars
                SqlCommand cmdAvailableCars = new SqlCommand(
                    "SELECT COUNT(*) FROM cars WHERE regNo NOT IN (SELECT regNo FROM rentals WHERE rental_id NOT IN (SELECT rental_id FROM returns))", connect);
                lblAvailableCars.Text = cmdAvailableCars.ExecuteScalar().ToString();

                // Rented Cars
                SqlCommand cmdRentedCars = new SqlCommand(
                    "SELECT COUNT(*) FROM rentals WHERE rental_id NOT IN (SELECT rental_id FROM returns)", connect);
                lblRentedCars.Text = cmdRentedCars.ExecuteScalar().ToString();

                // Total Customers
                SqlCommand cmdTotalCustomers = new SqlCommand("SELECT COUNT(*) FROM customers", connect);
                lblTotalCustomers.Text = cmdTotalCustomers.ExecuteScalar().ToString();

                // Today's Rentals
                SqlCommand cmdTodayRentals = new SqlCommand("SELECT COUNT(*) FROM rentals WHERE rental_date = CAST(GETDATE() AS DATE)", connect);
                //lblTodayRentals.Text = cmdTodayRentals.ExecuteScalar().ToString();

                // Today's Returns
                SqlCommand cmdTodayReturns = new SqlCommand("SELECT COUNT(*) FROM returns WHERE return_date = CAST(GETDATE() AS DATE)", connect);
                //lblTodayReturns.Text = cmdTodayReturns.ExecuteScalar().ToString();

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dashboard load error: " + ex.Message);
            }
            finally
            {
                connect.Close();
            }
        }
    }
}
