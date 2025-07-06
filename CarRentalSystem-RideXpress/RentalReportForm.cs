using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;

namespace CarRentalSystem_RideXpress
{
    public partial class RentalReportForm : UserControl
    {
        public RentalReportForm()
        {
            InitializeComponent();
        }



        private List<CustomerRentalsData> GetCustomerRentalsData()
        {
            List<CustomerRentalsData> customerRentals = new List<CustomerRentalsData>();

            using (SqlConnection connect = new SqlConnection(DBConnection.ConnectionString))
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand("SELECT customer_id, COUNT(*) AS rental_count FROM rentals GROUP BY customer_id", connect);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    customerRentals.Add(new CustomerRentalsData
                    {
                        customer_id = reader["customer_id"].ToString(),
                        rental_count = Convert.ToInt32(reader["rental_count"])
                    });
                }
            }

            return customerRentals;
        }


        private List<RentedCarsData> GetRentedCarsData()
        {
            List<RentedCarsData> rentedCars = new List<RentedCarsData>();

            using (SqlConnection connect = new SqlConnection(DBConnection.ConnectionString))
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand("SELECT regNo, COUNT(*) AS rental_count FROM rentals GROUP BY regNo", connect);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    rentedCars.Add(new RentedCarsData
                    {
                        regNo = reader["regNo"].ToString(),
                        rental_count = Convert.ToInt32(reader["rental_count"])
                    });
                }
            }

            return rentedCars;
        }
        private void RentalReportForm_Load(object sender, EventArgs e)
        {
            var reportViewer = new ReportViewer
            {
                Dock = DockStyle.Fill,
                ProcessingMode = ProcessingMode.Local
            };
            this.Controls.Add(reportViewer);

            reportViewer.LocalReport.ReportPath = "D:\\(D) Documents\\Lessons\\Year 03 Sem 01\\BECS 31242 - Visual Programming\\Project\\CarRentalSystem-RideXpress-V3\\CarRentalSystem-RideXpress\\RentalReport.rdlc";
            reportViewer.LocalReport.DataSources.Clear();

            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", GetCustomerRentalsData()));
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("DataSet2", GetRentedCarsData()));

            reportViewer.LocalReport.Refresh();
            reportViewer.RefreshReport();
        }
    }

    public class CustomerRentalsData
    {
        public string customer_id { get; set; }
        public int rental_count { get; set; }
    }


    public class RentedCarsData
    {
        public string regNo { get; set; }
        public int rental_count { get; set; }
    }
}
