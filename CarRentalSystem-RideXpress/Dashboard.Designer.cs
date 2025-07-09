namespace CarRentalSystem_RideXpress
{
    partial class Dashboard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            lblTotalCars = new Label();
            label1 = new Label();
            panel5 = new Panel();
            lblTotalCustomers = new Label();
            label4 = new Label();
            panel2 = new Panel();
            lblAvailableCars = new Label();
            label6 = new Label();
            panel3 = new Panel();
            lblRentedCars = new Label();
            Re = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(182, 24, 23);
            panel1.Controls.Add(lblTotalCars);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(20, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 100);
            panel1.TabIndex = 0;
            // 
            // lblTotalCars
            // 
            lblTotalCars.AutoSize = true;
            lblTotalCars.BackColor = Color.Transparent;
            lblTotalCars.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalCars.ForeColor = Color.White;
            lblTotalCars.Location = new Point(123, 35);
            lblTotalCars.Name = "lblTotalCars";
            lblTotalCars.Size = new Size(84, 65);
            lblTotalCars.TabIndex = 4;
            lblTotalCars.Text = "00";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(72, 0);
            label1.Name = "label1";
            label1.Size = new Size(125, 37);
            label1.TabIndex = 3;
            label1.Text = "Total Cars";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(182, 24, 23);
            panel5.Controls.Add(lblTotalCustomers);
            panel5.Controls.Add(label4);
            panel5.Location = new Point(233, 20);
            panel5.Name = "panel5";
            panel5.Size = new Size(200, 100);
            panel5.TabIndex = 3;
            // 
            // lblTotalCustomers
            // 
            lblTotalCustomers.AutoSize = true;
            lblTotalCustomers.BackColor = Color.Transparent;
            lblTotalCustomers.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalCustomers.ForeColor = Color.White;
            lblTotalCustomers.Location = new Point(122, 35);
            lblTotalCustomers.Name = "lblTotalCustomers";
            lblTotalCustomers.Size = new Size(84, 65);
            lblTotalCustomers.TabIndex = 5;
            lblTotalCustomers.Text = "00";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(5, 0);
            label4.Name = "label4";
            label4.Size = new Size(192, 37);
            label4.TabIndex = 3;
            label4.Text = "Total Customers";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(182, 24, 23);
            panel2.Controls.Add(lblAvailableCars);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(446, 20);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 100);
            panel2.TabIndex = 5;
            // 
            // lblAvailableCars
            // 
            lblAvailableCars.AutoSize = true;
            lblAvailableCars.BackColor = Color.Transparent;
            lblAvailableCars.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAvailableCars.ForeColor = Color.White;
            lblAvailableCars.Location = new Point(120, 35);
            lblAvailableCars.Name = "lblAvailableCars";
            lblAvailableCars.Size = new Size(84, 65);
            lblAvailableCars.TabIndex = 6;
            lblAvailableCars.Text = "00";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Poppins SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(24, 0);
            label6.Name = "label6";
            label6.Size = new Size(173, 37);
            label6.TabIndex = 3;
            label6.Text = "Available Cars";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(182, 24, 23);
            panel3.Controls.Add(lblRentedCars);
            panel3.Controls.Add(Re);
            panel3.Location = new Point(659, 20);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 100);
            panel3.TabIndex = 6;
            panel3.Paint += panel3_Paint;
            // 
            // lblRentedCars
            // 
            lblRentedCars.AutoSize = true;
            lblRentedCars.BackColor = Color.Transparent;
            lblRentedCars.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRentedCars.ForeColor = Color.White;
            lblRentedCars.Location = new Point(120, 35);
            lblRentedCars.Name = "lblRentedCars";
            lblRentedCars.Size = new Size(84, 65);
            lblRentedCars.TabIndex = 7;
            lblRentedCars.Text = "00";
            // 
            // Re
            // 
            Re.AutoSize = true;
            Re.Font = new Font("Poppins SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Re.ForeColor = Color.White;
            Re.Location = new Point(50, 0);
            Re.Name = "Re";
            Re.Size = new Size(147, 37);
            Re.TabIndex = 3;
            Re.Text = "Rented Cars";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.Connection = null;
            sqlCommand1.Notification = null;
            sqlCommand1.Transaction = null;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel5);
            Controls.Add(panel1);
            Name = "Dashboard";
            Size = new Size(880, 575);
            Load += Dashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel4;
        private Label label1;
        private Label lblTotalCars;
        private Panel panel5;
        private Panel panel2;
        private Label label5;
        private Label label6;
        private Label label4;
        private Label lblTotalCustomers;
        private Label lblAvailableCars;
        private Panel panel3;
        private Label lblRentedCars;
        private Label Re;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
    }
}
