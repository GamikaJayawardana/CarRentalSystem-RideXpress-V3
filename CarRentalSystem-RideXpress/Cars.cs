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
    public partial class Cars : UserControl
    {
        SqlConnection connect = new SqlConnection(DBConnection.ConnectionString);

        private void loaddata()
        {
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM cars", connect);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

                dataGridView1.Columns["regNo"].HeaderText = "Reg No";
                dataGridView1.Columns["brand"].HeaderText = "Brand";
                dataGridView1.Columns["model"].HeaderText = "Model";
                dataGridView1.Columns["year"].HeaderText = "Year";
                dataGridView1.Columns["color"].HeaderText = "Color";
                dataGridView1.Columns["price"].HeaderText = "price";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }

        }

        private void ClearFields()
        {
            txtRegNo.Clear();
            txtBrand.Clear();
            txtModel.Clear();
            txtYear.Clear();
            txtColor.Clear();
            txtPrice.Clear();
        }
        public Cars()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO cars (regNo, brand, model, year, color, price) VALUES (@reg, @brand, @model, @year, @color, @price)", connect);
                cmd.Parameters.AddWithValue("@reg", txtRegNo.Text);
                cmd.Parameters.AddWithValue("@brand", txtBrand.Text);
                cmd.Parameters.AddWithValue("@model", txtModel.Text);
                cmd.Parameters.AddWithValue("@year", Convert.ToInt32(txtYear.Text));
                cmd.Parameters.AddWithValue("@color", txtColor.Text);
                cmd.Parameters.AddWithValue("@price", Convert.ToDecimal(txtPrice.Text));

                cmd.ExecuteNonQuery();
                MessageBox.Show("Car added successfully.");
                connect.Close();
                loaddata();
                ClearFields();

                AppEvents.RaiseCarListUpdated();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Add Error: " + ex.Message);
                connect.Close();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand("UPDATE cars SET brand=@brand, model=@model, year=@year, color=@color, price=@price WHERE regNo=@reg", connect);
                cmd.Parameters.AddWithValue("@reg", txtRegNo.Text);
                cmd.Parameters.AddWithValue("@brand", txtBrand.Text);
                cmd.Parameters.AddWithValue("@model", txtModel.Text);
                cmd.Parameters.AddWithValue("@year", Convert.ToInt32(txtYear.Text));
                cmd.Parameters.AddWithValue("@color", txtColor.Text);
                cmd.Parameters.AddWithValue("@price", Convert.ToDecimal(txtPrice.Text));

                cmd.ExecuteNonQuery();
                MessageBox.Show("Car updated successfully.");
                connect.Close();
                loaddata();
                ClearFields();

                AppEvents.RaiseCarListUpdated();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Edit Error: " + ex.Message);
                connect.Close();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this car?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    connect.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM cars WHERE regNo=@reg", connect);
                    cmd.Parameters.AddWithValue("@reg", txtRegNo.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Car deleted successfully.");
                    connect.Close();
                    loaddata();
                    ClearFields();

                    AppEvents.RaiseCarListUpdated();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Delete Error: " + ex.Message);
                    connect.Close();
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void Cars_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure the user clicked on a valid row
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Assign each cell's value to the corresponding text fields
                txtRegNo.Text = row.Cells["regNo"].Value.ToString();
                txtBrand.Text = row.Cells["brand"].Value.ToString();
                txtModel.Text = row.Cells["model"].Value.ToString();
                txtYear.Text = row.Cells["year"].Value.ToString();
                txtColor.Text = row.Cells["color"].Value.ToString();
                txtPrice.Text = row.Cells["price"].Value.ToString();
            }
        }
    }
}
