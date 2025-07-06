using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CarRentalSystem_RideXpress
{
    public partial class IssueCar : UserControl
    {
        SqlConnection connect = new SqlConnection(DBConnection.ConnectionString);

        public IssueCar()
        {
            InitializeComponent();
            AppEvents.CarListUpdated += LoadData;
        }

        public void LoadData()
        {
            // Load Customer IDs
            SqlDataAdapter custAdapter = new SqlDataAdapter("SELECT customer_id FROM customers", connect);
            DataTable custTable = new DataTable();
            custAdapter.Fill(custTable);
            cmbCustomerID.DataSource = custTable;
            cmbCustomerID.DisplayMember = "customer_id";
            cmbCustomerID.ValueMember = "customer_id";

            // Load Available Cars (not currently rented)
            SqlDataAdapter carAdapter = new SqlDataAdapter(
    "SELECT regNo FROM cars WHERE regNo NOT IN (SELECT r.regNo FROM rentals r WHERE r.rental_id NOT IN (SELECT rental_id FROM returns))",
    connect);
            DataTable carTable = new DataTable();
            carAdapter.Fill(carTable);
            cmbRegNo.DataSource = carTable;
            cmbRegNo.DisplayMember = "regNo";
            cmbRegNo.ValueMember = "regNo";

            // Load Available Cars Grid
            SqlDataAdapter availableAdapter = new SqlDataAdapter(
     "SELECT * FROM cars WHERE regNo NOT IN (SELECT r.regNo FROM rentals r WHERE r.rental_id NOT IN (SELECT rental_id FROM returns))",
     connect);

            DataTable dtAvailable = new DataTable();
            availableAdapter.Fill(dtAvailable);
            dataGridAvailableCars.DataSource = null;
            dataGridAvailableCars.DataSource = dtAvailable;

            dataGridAvailableCars.Columns["regNo"].HeaderText = "Reg No";
            dataGridAvailableCars.Columns["brand"].HeaderText = "Brand";
            dataGridAvailableCars.Columns["model"].HeaderText = "Model";
            dataGridAvailableCars.Columns["year"].HeaderText = "Year";
            dataGridAvailableCars.Columns["color"].HeaderText = "Color";
            dataGridAvailableCars.Columns["price"].HeaderText = "Price";

            // Load Rented Cars Grid (fixed query to include today's rentals)
            SqlDataAdapter rentedAdapter = new SqlDataAdapter(
                "SELECT * FROM rentals",
            connect);

            DataTable dtRented = new DataTable();
            rentedAdapter.Fill(dtRented);
            dataGridRentedCars.DataSource = null;
            dataGridRentedCars.DataSource = dtRented;

            dataGridRentedCars.Columns["rental_id"].HeaderText = "Rental ID";
            dataGridRentedCars.Columns["customer_id"].HeaderText = "Customer ID";
            dataGridRentedCars.Columns["regNo"].HeaderText = "Reg No";
            dataGridRentedCars.Columns["rental_date"].HeaderText = "Rental Date";
            dataGridRentedCars.Columns["return_date"].HeaderText = "Return Date";
            dataGridRentedCars.Columns["rental_price"].HeaderText = "Rental Price";

            dataGridAvailableCars.Refresh();
            dataGridRentedCars.Refresh();
        }

        private void ClearFields()
        {
            txtRentalID.Clear();
            cmbCustomerID.SelectedIndex = -1;
            cmbRegNo.SelectedIndex = -1;
            dtRentalDate.Value = DateTime.Today;
            dtReturnDate.Value = DateTime.Today;
            txtRentalPrice.Clear();
        }

        private void IssueCar_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO rentals (rental_id, customer_id, regNo, rental_date, return_date, rental_price) VALUES (@id, @cust, @reg, @rdate, @retdate, @price)", connect);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtRentalID.Text));
                cmd.Parameters.AddWithValue("@cust", cmbCustomerID.SelectedValue);
                cmd.Parameters.AddWithValue("@reg", cmbRegNo.SelectedValue);
                cmd.Parameters.AddWithValue("@rdate", dtRentalDate.Value.Date);
                cmd.Parameters.AddWithValue("@retdate", dtReturnDate.Value.Date);
                cmd.Parameters.AddWithValue("@price", Convert.ToDecimal(txtRentalPrice.Text));

                cmd.ExecuteNonQuery();
                MessageBox.Show("Rental added successfully.");
                AppEvents.RaiseCarListUpdated();

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Add Error: " + ex.Message);
            }
            finally
            {
                connect.Close();
                LoadData();
                ClearFields();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand("UPDATE rentals SET customer_id=@cust, regNo=@reg, rental_date=@rdate, return_date=@retdate, rental_price=@price WHERE rental_id=@id", connect);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtRentalID.Text));
                cmd.Parameters.AddWithValue("@cust", cmbCustomerID.SelectedValue);
                cmd.Parameters.AddWithValue("@reg", cmbRegNo.SelectedValue);
                cmd.Parameters.AddWithValue("@rdate", dtRentalDate.Value.Date);
                cmd.Parameters.AddWithValue("@retdate", dtReturnDate.Value.Date);
                cmd.Parameters.AddWithValue("@price", Convert.ToDecimal(txtRentalPrice.Text));

                cmd.ExecuteNonQuery();
                MessageBox.Show("Rental updated successfully.");
                AppEvents.RaiseCarListUpdated();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Edit Error: " + ex.Message);
            }
            finally
            {
                connect.Close();
                LoadData();
                ClearFields();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this rental?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    connect.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM rentals WHERE rental_id=@id", connect);
                    cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtRentalID.Text));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Rental deleted successfully.");
                    AppEvents.RaiseCarListUpdated();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Delete Error: " + ex.Message);
                }
                finally
                {
                    connect.Close();
                    LoadData();
                    ClearFields();
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void dataGridRentedCars_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridRentedCars.Rows[e.RowIndex];
                txtRentalID.Text = row.Cells["rental_id"].Value.ToString();
                cmbCustomerID.SelectedValue = row.Cells["customer_id"].Value.ToString();
                cmbRegNo.SelectedValue = row.Cells["regNo"].Value.ToString();
                dtRentalDate.Value = Convert.ToDateTime(row.Cells["rental_date"].Value);
                dtReturnDate.Value = Convert.ToDateTime(row.Cells["return_date"].Value);
                txtRentalPrice.Text = row.Cells["rental_price"].Value.ToString();
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Optional: handle if needed
        }
    }
}
