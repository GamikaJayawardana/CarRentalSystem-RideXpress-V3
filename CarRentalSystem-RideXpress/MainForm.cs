using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalSystem_RideXpress
{
    public partial class MainForm : Form
    {

        public static MainForm Instance;
        public MainForm()
        {
            InitializeComponent();
            Instance = this;
            
            

            cars1.Visible = false;
            issueCar1.Visible = false;
            carReturn1.Visible = false;
            customers1.Visible = false;
            dashboard1.Visible = true;
            rentalReportForm1.Visible = true;


        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            cars1.Visible = false;
            issueCar1.Visible = false;
            carReturn1.Visible = false;
            customers1.Visible = false;
            dashboard1.Visible = true;
            rentalReportForm1.Visible = true;

            dashboard1.LoadDashboardStats();

            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                return; // User chose not to logout
            }
            else if (result == DialogResult.Yes)
            {
                // Perform logout actions
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Hide();
            }

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddCars_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            cars1.Visible = true;
            issueCar1.Visible = false;
            carReturn1.Visible = false;
            customers1.Visible = false;
            rentalReportForm1.Visible = false;

        }

        private void btnIssueCar_Click(object sender, EventArgs e)
        {
            cars1.Visible = false;
            issueCar1.Visible = true;
            carReturn1.Visible = false;
            customers1.Visible = false;
            dashboard1.Visible = false;
            rentalReportForm1.Visible = false;
        }

        private void btnReturnCar_Click(object sender, EventArgs e)
        {
            cars1.Visible = false;
            issueCar1.Visible = false;
            carReturn1.Visible = true;
            customers1.Visible = false;
            dashboard1.Visible = false;
            rentalReportForm1.Visible = false;
        }

        private void customers1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cars1.Visible = false;
            issueCar1.Visible = false;
            carReturn1.Visible = false;
            customers1.Visible = true;
            dashboard1.Visible = false;
            rentalReportForm1.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dashboard1_Load(object sender, EventArgs e)
        {

        }
    }
}
