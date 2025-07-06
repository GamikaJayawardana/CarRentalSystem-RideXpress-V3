using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using Microsoft.VisualBasic.Logging;

namespace CarRentalSystem_RideXpress
{
    public partial class RegisterForm : Form
    {
        SqlConnection connect = new SqlConnection(DBConnection.ConnectionString);

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnLoginR_Click(object sender, EventArgs e)
        {
            LoginForm lForm = new LoginForm();
            lForm.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSignUpR_Click(object sender, EventArgs e)
        {
            if (register_email.Text == "" || register_username.Text == "" || register_password.Text == "")
            {
                MessageBox.Show("Please fill all the fields.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();

                        String checkUsername = "SELECT COUNT(*) FROM Users WHERE Username=@Username";

                        using(SqlCommand checkCMD = new SqlCommand(checkUsername, connect))
                        {
                            checkCMD.Parameters.AddWithValue("username", register_username.Text.Trim());
                            int count = (int)checkCMD.ExecuteScalar();

                            if(count >= 1)
                            {
                                MessageBox.Show(register_username.Text.Trim() +
                                    " is already taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                DateTime day = DateTime.Today;

                                String insertData = "INSERT INTO users (email, username, password, data_register) VALUES (@email, @username, @password, @date)";


                                using (SqlCommand insertCMD = new SqlCommand (insertData, connect))
                                {
                                    insertCMD.Parameters.AddWithValue("@email",register_email.Text.Trim());
                                    insertCMD.Parameters.AddWithValue("@username", register_username.Text.Trim());
                                    insertCMD.Parameters.AddWithValue("@password", register_password.Text.Trim());
                                    insertCMD.Parameters.AddWithValue("@date", day.ToString());

                                    insertCMD.ExecuteNonQuery();

                                    MessageBox.Show("Registration successfully!", "Informationn Message",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    LoginForm lform = new LoginForm();
                                    lform.Show();
                                    this.Hide();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error connecting to database: " + ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        private void register_showpass_CheckedChanged(object sender, EventArgs e)
        {
            register_password.PasswordChar = register_showpass.Checked ? '\0' : '*';
        }
    }
}
