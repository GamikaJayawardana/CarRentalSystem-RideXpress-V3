namespace CarRentalSystem_RideXpress
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            button1 = new Button();
            btnLogout = new Button();
            btnReturnCar = new Button();
            btnIssueCar = new Button();
            btnAddCars = new Button();
            btnDashboard = new Button();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            panel4 = new Panel();
            dashboard1 = new Dashboard();
            customers1 = new Customers();
            cars1 = new Cars();
            issueCar1 = new IssueCar();
            carReturn1 = new CarReturn();
            rentalReportForm1 = new RentalReportForm();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(1080, 1);
            label1.Name = "label1";
            label1.Size = new Size(19, 23);
            label1.TabIndex = 1;
            label1.Text = "X";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(182, 24, 23);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-3, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1208, 25);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.Controls.Add(btnLogout);
            panel2.Controls.Add(btnReturnCar);
            panel2.Controls.Add(btnIssueCar);
            panel2.Controls.Add(btnAddCars);
            panel2.Controls.Add(btnDashboard);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(220, 600);
            panel2.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(5, 15, 60);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatAppearance.CheckedBackColor = Color.FromArgb(182, 24, 23);
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(182, 24, 23);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(182, 24, 23);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Poppins SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Image = Properties.Resources.icons8_customers_32;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(12, 219);
            button1.Name = "button1";
            button1.Size = new Size(193, 43);
            button1.TabIndex = 12;
            button1.Text = "Customers";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(5, 15, 60);
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatAppearance.BorderColor = Color.White;
            btnLogout.FlatAppearance.BorderSize = 2;
            btnLogout.FlatAppearance.CheckedBackColor = Color.FromArgb(182, 24, 23);
            btnLogout.FlatAppearance.MouseDownBackColor = Color.FromArgb(182, 24, 23);
            btnLogout.FlatAppearance.MouseOverBackColor = Color.FromArgb(182, 24, 23);
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Poppins SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.Image = Properties.Resources.icons8_logout_32;
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(12, 534);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(193, 43);
            btnLogout.TabIndex = 11;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnReturnCar
            // 
            btnReturnCar.BackColor = Color.FromArgb(5, 15, 60);
            btnReturnCar.Cursor = Cursors.Hand;
            btnReturnCar.FlatAppearance.BorderColor = Color.White;
            btnReturnCar.FlatAppearance.BorderSize = 2;
            btnReturnCar.FlatAppearance.CheckedBackColor = Color.FromArgb(182, 24, 23);
            btnReturnCar.FlatAppearance.MouseDownBackColor = Color.FromArgb(182, 24, 23);
            btnReturnCar.FlatAppearance.MouseOverBackColor = Color.FromArgb(182, 24, 23);
            btnReturnCar.FlatStyle = FlatStyle.Flat;
            btnReturnCar.Font = new Font("Poppins SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReturnCar.ForeColor = Color.White;
            btnReturnCar.Image = Properties.Resources.icons8_return_32;
            btnReturnCar.ImageAlign = ContentAlignment.MiddleLeft;
            btnReturnCar.Location = new Point(12, 410);
            btnReturnCar.Name = "btnReturnCar";
            btnReturnCar.Size = new Size(193, 43);
            btnReturnCar.TabIndex = 10;
            btnReturnCar.Text = "Return Cars";
            btnReturnCar.UseVisualStyleBackColor = false;
            btnReturnCar.Click += btnReturnCar_Click;
            // 
            // btnIssueCar
            // 
            btnIssueCar.BackColor = Color.FromArgb(5, 15, 60);
            btnIssueCar.Cursor = Cursors.Hand;
            btnIssueCar.FlatAppearance.BorderColor = Color.White;
            btnIssueCar.FlatAppearance.BorderSize = 2;
            btnIssueCar.FlatAppearance.CheckedBackColor = Color.FromArgb(182, 24, 23);
            btnIssueCar.FlatAppearance.MouseDownBackColor = Color.FromArgb(182, 24, 23);
            btnIssueCar.FlatAppearance.MouseOverBackColor = Color.FromArgb(182, 24, 23);
            btnIssueCar.FlatStyle = FlatStyle.Flat;
            btnIssueCar.Font = new Font("Poppins SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIssueCar.ForeColor = Color.White;
            btnIssueCar.Image = Properties.Resources.icons8_lease_32;
            btnIssueCar.ImageAlign = ContentAlignment.MiddleLeft;
            btnIssueCar.Location = new Point(12, 346);
            btnIssueCar.Name = "btnIssueCar";
            btnIssueCar.Size = new Size(193, 43);
            btnIssueCar.TabIndex = 9;
            btnIssueCar.Text = "Issue Cars";
            btnIssueCar.UseVisualStyleBackColor = false;
            btnIssueCar.Click += btnIssueCar_Click;
            // 
            // btnAddCars
            // 
            btnAddCars.BackColor = Color.FromArgb(5, 15, 60);
            btnAddCars.Cursor = Cursors.Hand;
            btnAddCars.FlatAppearance.BorderColor = Color.White;
            btnAddCars.FlatAppearance.BorderSize = 2;
            btnAddCars.FlatAppearance.CheckedBackColor = Color.FromArgb(182, 24, 23);
            btnAddCars.FlatAppearance.MouseDownBackColor = Color.FromArgb(182, 24, 23);
            btnAddCars.FlatAppearance.MouseOverBackColor = Color.FromArgb(182, 24, 23);
            btnAddCars.FlatStyle = FlatStyle.Flat;
            btnAddCars.Font = new Font("Poppins SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddCars.ForeColor = Color.White;
            btnAddCars.Image = Properties.Resources.icons8_cars_32;
            btnAddCars.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddCars.Location = new Point(12, 282);
            btnAddCars.Name = "btnAddCars";
            btnAddCars.Size = new Size(193, 43);
            btnAddCars.TabIndex = 8;
            btnAddCars.Text = "Cars";
            btnAddCars.UseVisualStyleBackColor = false;
            btnAddCars.Click += btnAddCars_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(5, 15, 60);
            btnDashboard.Cursor = Cursors.Hand;
            btnDashboard.FlatAppearance.BorderColor = Color.White;
            btnDashboard.FlatAppearance.BorderSize = 2;
            btnDashboard.FlatAppearance.CheckedBackColor = Color.FromArgb(182, 24, 23);
            btnDashboard.FlatAppearance.MouseDownBackColor = Color.FromArgb(182, 24, 23);
            btnDashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(182, 24, 23);
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Poppins SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Image = Properties.Resources.icons8_dashboard_32;
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(12, 154);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(193, 43);
            btnDashboard.TabIndex = 7;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnLogin_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo_white;
            pictureBox1.Location = new Point(12, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(193, 43);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(220, 25);
            panel3.Name = "panel3";
            panel3.Size = new Size(880, 575);
            panel3.TabIndex = 3;
            panel3.Paint += panel3_Paint;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(224, 224, 224);
            panel4.Controls.Add(rentalReportForm1);
            panel4.Controls.Add(dashboard1);
            panel4.Controls.Add(customers1);
            panel4.Controls.Add(cars1);
            panel4.Controls.Add(issueCar1);
            panel4.Controls.Add(carReturn1);
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(880, 575);
            panel4.TabIndex = 0;
            // 
            // dashboard1
            // 
            dashboard1.BackColor = SystemColors.ControlLight;
            dashboard1.Location = new Point(2, 0);
            dashboard1.Name = "dashboard1";
            dashboard1.Size = new Size(880, 575);
            dashboard1.TabIndex = 4;
            dashboard1.Load += dashboard1_Load;
            // 
            // customers1
            // 
            customers1.Location = new Point(-3, 0);
            customers1.Name = "customers1";
            customers1.Size = new Size(880, 575);
            customers1.TabIndex = 3;
            // 
            // cars1
            // 
            cars1.Location = new Point(0, 0);
            cars1.Name = "cars1";
            cars1.Size = new Size(880, 575);
            cars1.TabIndex = 2;
            // 
            // issueCar1
            // 
            issueCar1.BackColor = SystemColors.ControlLight;
            issueCar1.Location = new Point(0, 0);
            issueCar1.Name = "issueCar1";
            issueCar1.Size = new Size(880, 575);
            issueCar1.TabIndex = 1;
            // 
            // carReturn1
            // 
            carReturn1.Location = new Point(0, 0);
            carReturn1.Name = "carReturn1";
            carReturn1.Size = new Size(880, 575);
            carReturn1.TabIndex = 0;
            // 
            // rentalReportForm1
            // 
            rentalReportForm1.Location = new Point(23, 131);
            rentalReportForm1.Name = "rentalReportForm1";
            rentalReportForm1.Size = new Size(839, 409);
            rentalReportForm1.TabIndex = 5;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(5, 15, 60);
            ClientSize = new Size(1100, 600);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button btnReturnCar;
        private Button btnIssueCar;
        private Button btnAddCars;
        private Button btnDashboard;
        private Button btnLogout;
        private Panel panel3;
        private Button button1;
        private Panel panel4;
        private Cars cars1;
        private IssueCar issueCar1;
        private CarReturn carReturn1;
        private Customers customers1;
        private Dashboard dashboard1;
        public RentalReportForm rentalReportForm1;
    }
}