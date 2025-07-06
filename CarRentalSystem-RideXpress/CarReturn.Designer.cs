namespace CarRentalSystem_RideXpress
{
    partial class CarReturn
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
            label3 = new Label();
            panel1 = new Panel();
            txtCondition = new TextBox();
            dtReturnDate = new DateTimePicker();
            cmbRentalID = new ComboBox();
            btnClear = new Button();
            txtDelayDays = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtReturnID = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnDel = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            label7 = new Label();
            dataGridaRentedCars = new DataGridView();
            dataGridReturnedCars = new DataGridView();
            label8 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridaRentedCars).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridReturnedCars).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins Medium", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(467, 62);
            label3.Name = "label3";
            label3.Size = new Size(96, 26);
            label3.TabIndex = 27;
            label3.Text = "Condition";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(txtCondition);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(dtReturnDate);
            panel1.Controls.Add(cmbRentalID);
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(txtDelayDays);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtReturnID);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnDel);
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(btnAdd);
            panel1.Location = new Point(16, 368);
            panel1.Name = "panel1";
            panel1.Size = new Size(849, 195);
            panel1.TabIndex = 19;
            // 
            // txtCondition
            // 
            txtCondition.BackColor = Color.FromArgb(224, 224, 224);
            txtCondition.BorderStyle = BorderStyle.FixedSingle;
            txtCondition.Location = new Point(607, 62);
            txtCondition.Name = "txtCondition";
            txtCondition.Size = new Size(204, 23);
            txtCondition.TabIndex = 28;
            // 
            // dtReturnDate
            // 
            dtReturnDate.Location = new Point(175, 108);
            dtReturnDate.Name = "dtReturnDate";
            dtReturnDate.Size = new Size(204, 23);
            dtReturnDate.TabIndex = 26;
            // 
            // cmbRentalID
            // 
            cmbRentalID.BackColor = Color.FromArgb(224, 224, 224);
            cmbRentalID.FormattingEnabled = true;
            cmbRentalID.Location = new Point(175, 64);
            cmbRentalID.Name = "cmbRentalID";
            cmbRentalID.Size = new Size(204, 23);
            cmbRentalID.TabIndex = 23;
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
            // txtDelayDays
            // 
            txtDelayDays.BackColor = Color.FromArgb(224, 224, 224);
            txtDelayDays.BorderStyle = BorderStyle.FixedSingle;
            txtDelayDays.Location = new Point(607, 25);
            txtDelayDays.Name = "txtDelayDays";
            txtDelayDays.Size = new Size(204, 23);
            txtDelayDays.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins Medium", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(467, 25);
            label4.Name = "label4";
            label4.Size = new Size(107, 26);
            label4.TabIndex = 18;
            label4.Text = "Delay Days";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poppins Medium", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(35, 108);
            label5.Name = "label5";
            label5.Size = new Size(113, 26);
            label5.TabIndex = 17;
            label5.Text = "Return Date";
            // 
            // txtReturnID
            // 
            txtReturnID.BackColor = Color.FromArgb(224, 224, 224);
            txtReturnID.BorderStyle = BorderStyle.FixedSingle;
            txtReturnID.Location = new Point(175, 25);
            txtReturnID.Name = "txtReturnID";
            txtReturnID.Size = new Size(204, 23);
            txtReturnID.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins Medium", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(35, 62);
            label2.Name = "label2";
            label2.Size = new Size(83, 26);
            label2.TabIndex = 11;
            label2.Text = "RentalID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins Medium", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(35, 25);
            label1.Name = "label1";
            label1.Size = new Size(90, 26);
            label1.TabIndex = 10;
            label1.Text = "Return ID";
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
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Poppins Medium", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(360, 190);
            label7.Name = "label7";
            label7.Size = new Size(124, 26);
            label7.TabIndex = 21;
            label7.Text = "Returned Car";
            // 
            // dataGridaRentedCars
            // 
            dataGridaRentedCars.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridaRentedCars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridaRentedCars.Location = new Point(16, 40);
            dataGridaRentedCars.Name = "dataGridaRentedCars";
            dataGridaRentedCars.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridaRentedCars.Size = new Size(848, 141);
            dataGridaRentedCars.TabIndex = 20;
            // 
            // dataGridReturnedCars
            // 
            dataGridReturnedCars.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridReturnedCars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridReturnedCars.Location = new Point(17, 219);
            dataGridReturnedCars.Name = "dataGridReturnedCars";
            dataGridReturnedCars.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridReturnedCars.Size = new Size(848, 132);
            dataGridReturnedCars.TabIndex = 18;
            dataGridReturnedCars.CellContentClick += dataGridReturnedCars_CellContentClick;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Poppins Medium", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(353, 11);
            label8.Name = "label8";
            label8.Size = new Size(135, 26);
            label8.TabIndex = 22;
            label8.Text = "Cars to Return";
            // 
            // CarReturn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(label7);
            Controls.Add(dataGridaRentedCars);
            Controls.Add(dataGridReturnedCars);
            Controls.Add(label8);
            Name = "CarReturn";
            Size = new Size(880, 575);
            Load += CarReturn_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridaRentedCars).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridReturnedCars).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Panel panel1;
        private TextBox txtCondition;
        private DateTimePicker dtReturnDate;
        private ComboBox cmbRentalID;
        private Button btnClear;
        private TextBox txtDelayDays;
        private Label label4;
        private Label label5;
        private TextBox txtReturnID;
        private Label label2;
        private Label label1;
        private Button btnDel;
        private Button btnEdit;
        private Button btnAdd;
        private Label label7;
        private DataGridView dataGridaRentedCars;
        private DataGridView dataGridReturnedCars;
        private Label label8;
    }
}
