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

namespace CarRentalSystem_RideXpress
{
    public partial class CarReturn : UserControl
    {
        SqlConnection connect = new SqlConnection(DBConnection.ConnectionString);

        public CarReturn()
        {
            InitializeComponent();
            AppEvents.CarListUpdated += LoadData;
        }

        private void ClearFields()
        {
            txtReturnID.Clear();
            cmbRentalID.SelectedIndex = -1;
            dtReturnDate.Value = DateTime.Today;
            txtDelayDays.Clear();
            txtCondition.Clear();
        }

        public void LoadData()
        {
            // Load Rental IDs of ongoing (not returned) rentals (not in returns)
            SqlDataAdapter rentalAdapter = new SqlDataAdapter(
                "SELECT rental_id FROM rentals WHERE rental_id NOT IN (SELECT rental_id FROM returns)", connect);
            DataTable rentalTable = new DataTable();
            rentalAdapter.Fill(rentalTable);
            cmbRentalID.DataSource = rentalTable;
            cmbRentalID.DisplayMember = "rental_id";
            cmbRentalID.ValueMember = "rental_id";
            cmbRentalID.SelectedIndex = -1;

            // Load Rented Cars Grid
            SqlDataAdapter ongoingAdapter = new SqlDataAdapter(
                "SELECT * FROM rentals WHERE rental_id NOT IN (SELECT rental_id FROM returns)", connect);
            DataTable dtOngoing = new DataTable();
            ongoingAdapter.Fill(dtOngoing);
            dataGridaRentedCars.DataSource = dtOngoing;

            // Load Returned Cars Grid (returns + join with rentals if needed)
            SqlDataAdapter returnedAdapter = new SqlDataAdapter(
                "SELECT r.return_id, r.rental_id, r.return_date, r.delay_days, r.condition FROM returns r", connect);
            DataTable dtReturned = new DataTable();
            returnedAdapter.Fill(dtReturned);
            dataGridReturnedCars.DataSource = dtReturned;

            dataGridaRentedCars.Refresh();
            dataGridReturnedCars.Refresh();
        }

        private void dataGridReturnedCars_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridReturnedCars.Rows[e.RowIndex];
                txtReturnID.Text = row.Cells["return_id"].Value.ToString();
                cmbRentalID.SelectedValue = row.Cells["rental_id"].Value.ToString();
                dtReturnDate.Value = Convert.ToDateTime(row.Cells["return_date"].Value);
                txtDelayDays.Text = row.Cells["delay_days"].Value.ToString();
                txtCondition.Text = row.Cells["condition"].Value.ToString();
            }
        }

        private void CarReturn_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbRentalID.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a rental ID.");
                return;
            }

            try
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO returns (return_id, rental_id, return_date, delay_days, condition) VALUES (@retID, @rentalID, @retDate, @delay, @cond)", connect);
                cmd.Parameters.AddWithValue("@retID", Convert.ToInt32(txtReturnID.Text));
                cmd.Parameters.AddWithValue("@rentalID", Convert.ToInt32(cmbRentalID.SelectedValue));
                cmd.Parameters.AddWithValue("@retDate", dtReturnDate.Value.Date);
                cmd.Parameters.AddWithValue("@delay", Convert.ToInt32(txtDelayDays.Text));
                cmd.Parameters.AddWithValue("@cond", txtCondition.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Return record added successfully.");
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
                AppEvents.RaiseCarListUpdated();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand(
                    "UPDATE returns SET rental_id = @rentalID, return_date = @retDate, delay_days = @delay, condition = @cond WHERE return_id = @retID", connect);
                cmd.Parameters.AddWithValue("@retID", Convert.ToInt32(txtReturnID.Text));
                cmd.Parameters.AddWithValue("@rentalID", Convert.ToInt32(cmbRentalID.SelectedValue));
                cmd.Parameters.AddWithValue("@retDate", dtReturnDate.Value.Date);
                cmd.Parameters.AddWithValue("@delay", Convert.ToInt32(txtDelayDays.Text));
                cmd.Parameters.AddWithValue("@cond", txtCondition.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Return record updated successfully.");
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
                AppEvents.RaiseCarListUpdated();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this return record?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    connect.Open();
                    SqlCommand cmd = new SqlCommand(
                        "DELETE FROM returns WHERE return_id = @retID", connect);
                    cmd.Parameters.AddWithValue("@retID", Convert.ToInt32(txtReturnID.Text));

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Return record deleted.");
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
                    AppEvents.RaiseCarListUpdated();
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
