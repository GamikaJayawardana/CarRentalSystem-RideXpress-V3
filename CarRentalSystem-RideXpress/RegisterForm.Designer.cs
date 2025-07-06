namespace CarRentalSystem_RideXpress
{
    partial class RegisterForm
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
            panel1 = new Panel();
            label1 = new Label();
            register_showpass = new CheckBox();
            label4 = new Label();
            btnLoginR = new Button();
            btnSignUpR = new Button();
            register_password = new TextBox();
            register_username = new TextBox();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            register_email = new TextBox();
            label6 = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(182, 24, 23);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(600, 25);
            panel1.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(579, 2);
            label1.Name = "label1";
            label1.Size = new Size(19, 23);
            label1.TabIndex = 1;
            label1.Text = "X";
            label1.Click += label1_Click;
            // 
            // register_showpass
            // 
            register_showpass.AutoSize = true;
            register_showpass.ForeColor = Color.White;
            register_showpass.Location = new Point(243, 284);
            register_showpass.Name = "register_showpass";
            register_showpass.Size = new Size(108, 19);
            register_showpass.TabIndex = 19;
            register_showpass.Text = "Show Password";
            register_showpass.UseVisualStyleBackColor = true;
            register_showpass.CheckedChanged += register_showpass_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(202, 365);
            label4.Name = "label4";
            label4.Size = new Size(179, 26);
            label4.TabIndex = 18;
            label4.Text = "Login to Your Account";
            // 
            // btnLoginR
            // 
            btnLoginR.BackColor = Color.FromArgb(182, 24, 23);
            btnLoginR.FlatStyle = FlatStyle.Popup;
            btnLoginR.Font = new Font("Poppins SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoginR.ForeColor = Color.White;
            btnLoginR.Location = new Point(145, 394);
            btnLoginR.Name = "btnLoginR";
            btnLoginR.Size = new Size(293, 32);
            btnLoginR.TabIndex = 17;
            btnLoginR.Text = "Login";
            btnLoginR.UseVisualStyleBackColor = false;
            btnLoginR.Click += btnLoginR_Click;
            // 
            // btnSignUpR
            // 
            btnSignUpR.BackColor = Color.FromArgb(182, 24, 23);
            btnSignUpR.FlatStyle = FlatStyle.Popup;
            btnSignUpR.Font = new Font("Poppins SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignUpR.ForeColor = Color.White;
            btnSignUpR.Location = new Point(145, 314);
            btnSignUpR.Name = "btnSignUpR";
            btnSignUpR.Size = new Size(293, 32);
            btnSignUpR.TabIndex = 16;
            btnSignUpR.Text = "Sign Up";
            btnSignUpR.UseVisualStyleBackColor = false;
            btnSignUpR.Click += btnSignUpR_Click;
            // 
            // register_password
            // 
            register_password.Font = new Font("Poppins", 9F);
            register_password.Location = new Point(243, 255);
            register_password.Name = "register_password";
            register_password.PasswordChar = '*';
            register_password.Size = new Size(194, 25);
            register_password.TabIndex = 15;
            // 
            // register_username
            // 
            register_username.Font = new Font("Poppins", 9F);
            register_username.Location = new Point(243, 217);
            register_username.Name = "register_username";
            register_username.Size = new Size(194, 25);
            register_username.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(144, 252);
            label3.Name = "label3";
            label3.Size = new Size(86, 26);
            label3.TabIndex = 13;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(144, 217);
            label2.Name = "label2";
            label2.Size = new Size(93, 26);
            label2.TabIndex = 12;
            label2.Text = "User Name";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo_white;
            pictureBox1.Location = new Point(145, 61);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(293, 72);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // register_email
            // 
            register_email.Font = new Font("Poppins", 9F);
            register_email.Location = new Point(243, 177);
            register_email.Name = "register_email";
            register_email.Size = new Size(194, 25);
            register_email.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(145, 177);
            label6.Name = "label6";
            label6.Size = new Size(53, 26);
            label6.TabIndex = 21;
            label6.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poppins SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(204, 145);
            label5.Name = "label5";
            label5.Size = new Size(180, 26);
            label5.TabIndex = 23;
            label5.Text = "Create a New Account";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(5, 15, 60);
            ClientSize = new Size(600, 468);
            Controls.Add(label5);
            Controls.Add(register_email);
            Controls.Add(label6);
            Controls.Add(panel1);
            Controls.Add(register_showpass);
            Controls.Add(label4);
            Controls.Add(btnLoginR);
            Controls.Add(btnSignUpR);
            Controls.Add(register_password);
            Controls.Add(register_username);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private CheckBox register_showpass;
        private Label label4;
        private Button btnLoginR;
        private Button btnSignUpR;
        private TextBox register_password;
        private TextBox register_username;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox1;
        private TextBox register_email;
        private Label label6;
        private Label label5;
    }
}