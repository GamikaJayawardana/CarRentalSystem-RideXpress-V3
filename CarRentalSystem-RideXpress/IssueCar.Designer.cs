namespace CarRentalSystem_RideXpress
{
    partial class IssueCar
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
            dtReturnDate = new DateTimePicker();
            dtRentalDate = new DateTimePicker();
            cmbRegNo = new ComboBox();
            cmbCustomerID = new ComboBox();
            btnClear = new Button();
            txtRentalPrice = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtRentalID = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnDel = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            dataGridRentedCars = new DataGridView();
            dataGridAvailableCars = new DataGridView();
            label7 = new Label();
            label8 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridRentedCars).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridAvailableCars).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(dtReturnDate);
            panel1.Controls.Add(dtRentalDate);
            panel1.Controls.Add(cmbRegNo);
            panel1.Controls.Add(cmbCustomerID);
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(txtRentalPrice);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtRentalID);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnDel);
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(btnAdd);
            panel1.Location = new Point(16, 365);
            panel1.Name = "panel1";
            panel1.Size = new Size(849, 195);
            panel1.TabIndex = 5;
            // 
            // dtReturnDate
            // 
            dtReturnDate.Location = new Point(607, 59);
            dtReturnDate.Name = "dtReturnDate";
            dtReturnDate.Size = new Size(204, 23);
            dtReturnDate.TabIndex = 26;
            // 
            // dtRentalDate
            // 
            dtRentalDate.Location = new Point(607, 21);
            dtRentalDate.Name = "dtRentalDate";
            dtRentalDate.Size = new Size(204, 23);
            dtRentalDate.TabIndex = 25;
            // 
            // cmbRegNo
            // 
            cmbRegNo.BackColor = Color.FromArgb(224, 224, 224);
            cmbRegNo.FormattingEnabled = true;
            cmbRegNo.Location = new Point(175, 102);
            cmbRegNo.Name = "cmbRegNo";
            cmbRegNo.Size = new Size(204, 23);
            cmbRegNo.TabIndex = 24;
            // 
            // cmbCustomerID
            // 
            cmbCustomerID.BackColor = Color.FromArgb(224, 224, 224);
            cmbCustomerID.FormattingEnabled = true;
            cmbCustomerID.Location = new Point(175, 64);
            cmbCustomerID.Name = "cmbCustomerID";
            cmbCustomerID.Size = new Size(204, 23);
            cmbCustomerID.TabIndex = 23;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(182, 24, 23);
            btnClear.FlatStyle = FlatStyle.Popup;
            btnClear.Font = new Font("Poppins SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(717, 142);
            btnClear.Name = "btnClear";
            btnClear.RightToLeft = RightToLeft.Yes;
            btnClear.Size = new Size(94, 34);
            btnClear.TabIndex = 22;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // txtRentalPrice
            // 
            txtRentalPrice.BackColor = Color.FromArgb(224, 224, 224);
            txtRentalPrice.BorderStyle = BorderStyle.FixedSingle;
            txtRentalPrice.Location = new Point(607, 97);
            txtRentalPrice.Name = "txtRentalPrice";
            txtRentalPrice.Size = new Size(204, 23);
            txtRentalPrice.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins Medium", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(467, 97);
            label4.Name = "label4";
            label4.Size = new Size(113, 26);
            label4.TabIndex = 18;
            label4.Text = "Rental Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poppins Medium", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(467, 59);
            label5.Name = "label5";
            label5.Size = new Size(113, 26);
            label5.TabIndex = 17;
            label5.Text = "Return Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Poppins Medium", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(467, 22);
            label6.Name = "label6";
            label6.Size = new Size(111, 26);
            label6.TabIndex = 16;
            label6.Text = "Rental Date";
            // 
            // txtRentalID
            // 
            txtRentalID.BackColor = Color.FromArgb(224, 224, 224);
            txtRentalID.BorderStyle = BorderStyle.FixedSingle;
            txtRentalID.Location = new Point(175, 25);
            txtRentalID.Name = "txtRentalID";
            txtRentalID.Size = new Size(204, 23);
            txtRentalID.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins Medium", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(35, 100);
            label3.Name = "label3";
            label3.Size = new Size(71, 26);
            label3.TabIndex = 12;
            label3.Text = "Reg No";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins Medium", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(35, 62);
            label2.Name = "label2";
            label2.Size = new Size(118, 26);
            label2.TabIndex = 11;
            label2.Text = "Customer ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins Medium", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(35, 25);
            label1.Name = "label1";
            label1.Size = new Size(88, 26);
            label1.TabIndex = 10;
            label1.Text = "Rental ID";
            // 
            // btnDel
            // 
            btnDel.BackColor = Color.FromArgb(182, 24, 23);
            btnDel.FlatStyle = FlatStyle.Popup;
            btnDel.Font = new Font("Poppins SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDel.ForeColor = Color.White;
            btnDel.Location = new Point(617, 142);
            btnDel.Name = "btnDel";
            btnDel.RightToLeft = RightToLeft.Yes;
            btnDel.Size = new Size(94, 34);
            btnDel.TabIndex = 9;
            btnDel.Text = "Delete";
            btnDel.UseVisualStyleBackColor = false;
            btnDel.Click += btnDel_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(182, 24, 23);
            btnEdit.FlatStyle = FlatStyle.Popup;
            btnEdit.Font = new Font("Poppins SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(517, 142);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 34);
            btnEdit.TabIndex = 8;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(182, 24, 23);
            btnAdd.FlatStyle = FlatStyle.Popup;
            btnAdd.Font = new Font("Poppins SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(417, 142);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 34);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // dataGridRentedCars
            // 
            dataGridRentedCars.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridRentedCars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridRentedCars.Location = new Point(17, 216);
            dataGridRentedCars.Name = "dataGridRentedCars";
            dataGridRentedCars.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridRentedCars.Size = new Size(848, 132);
            dataGridRentedCars.TabIndex = 4;
            dataGridRentedCars.CellContentClick += dataGridRentedCars_CellContentClick;
            // 
            // dataGridAvailableCars
            // 
            dataGridAvailableCars.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridAvailableCars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridAvailableCars.Location = new Point(16, 37);
            dataGridAvailableCars.Name = "dataGridAvailableCars";
            dataGridAvailableCars.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridAvailableCars.Size = new Size(848, 141);
            dataGridAvailableCars.TabIndex = 6;
            dataGridAvailableCars.CellContentClick += dataGridView2_CellContentClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Poppins Medium", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(357, 187);
            label7.Name = "label7";
            label7.Size = new Size(141, 26);
            label7.TabIndex = 11;
            label7.Text = "All Rented Cars";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Poppins Medium", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(363, 8);
            label8.Name = "label8";
            label8.Size = new Size(135, 26);
            label8.TabIndex = 12;
            label8.Text = "Available Cars";
            // 
            // IssueCar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(dataGridAvailableCars);
            Controls.Add(panel1);
            Controls.Add(dataGridRentedCars);
            Name = "IssueCar";
            Size = new Size(880, 575);
            Load += IssueCar_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridRentedCars).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridAvailableCars).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnClear;
        private TextBox txtRentalPrice;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtRentalID;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnDel;
        private Button btnEdit;
        private Button btnAdd;
        private DataGridView dataGridRentedCars;
        private DateTimePicker dtReturnDate;
        private DateTimePicker dtRentalDate;
        private ComboBox cmbRegNo;
        private ComboBox cmbCustomerID;
        private DataGridView dataGridAvailableCars;
        private Label label7;
        private Label label8;
    }
}
