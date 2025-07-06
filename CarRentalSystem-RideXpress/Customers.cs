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
    public partial class Customers : UserControl
    {
        SqlConnection connect = new SqlConnection(DBConnection.ConnectionString);


        public Customers()
        {
            InitializeComponent();
        }

        private void loaddata()
        {
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM customers", connect);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

                dataGridView1.Columns["first_name"].HeaderText = "First Name";
                dataGridView1.Columns["last_name"].HeaderText = "Last Name";
                dataGridView1.Columns["customer_id"].HeaderText = "Customer ID";
                dataGridView1.Columns["phone"].HeaderText = "Phone Number";
                dataGridView1.Columns["email"].HeaderText = "Email Address";
                dataGridView1.Columns["address"].HeaderText = "Address";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }

        }

        private void ClearFields()
        {
            txtCustomerId.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void availability_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO customers (customer_id, first_name, last_name, email, phone, address) VALUES (@id, @fname, @lname, @email, @phone, @address)", connect);
                cmd.Parameters.AddWithValue("@id", txtCustomerId.Text);
                cmd.Parameters.AddWithValue("@fname", txtFirstName.Text);
                cmd.Parameters.AddWithValue("@lname", txtLastName.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                cmd.Parameters.AddWithValue("@address", txtAddress.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer added successfully.");
                connect.Close();
                loaddata();
                ClearFields();
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
                SqlCommand cmd = new SqlCommand("UPDATE customers SET first_name=@fname, last_name=@lname, email=@email, phone=@phone, address=@address WHERE customer_id=@id", connect);
                cmd.Parameters.AddWithValue("@id", txtCustomerId.Text);
                cmd.Parameters.AddWithValue("@fname", txtFirstName.Text);
                cmd.Parameters.AddWithValue("@lname", txtLastName.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                cmd.Parameters.AddWithValue("@address", txtAddress.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer updated successfully.");
                connect.Close();
                loaddata();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update Error: " + ex.Message);
                connect.Close();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this customer?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    connect.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM customers WHERE customer_id=@id", connect);
                    cmd.Parameters.AddWithValue("@id", txtCustomerId.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer deleted successfully.");
                    connect.Close();
                    loaddata();
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Delete Error: " + ex.Message);
                    connect.Close();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtCustomerId.Text = row.Cells["customer_id"].Value.ToString();
                txtFirstName.Text = row.Cells["first_name"].Value.ToString();
                txtLastName.Text = row.Cells["last_name"].Value.ToString();
                txtEmail.Text = row.Cells["email"].Value.ToString();
                txtPhone.Text = row.Cells["phone"].Value.ToString();
                txtAddress.Text = row.Cells["address"].Value.ToString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
