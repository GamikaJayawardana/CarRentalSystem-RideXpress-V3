namespace CarRentalSystem_RideXpress
{
    partial class LoginForm
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
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            login_username = new TextBox();
            login_password = new TextBox();
            btnLogin = new Button();
            btnSignUp = new Button();
            label4 = new Label();
            login_showpass = new CheckBox();
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
            panel1.TabIndex = 0;
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
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo_white;
            pictureBox1.Location = new Point(145, 61);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(293, 72);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(144, 178);
            label2.Name = "label2";
            label2.Size = new Size(93, 26);
            label2.TabIndex = 2;
            label2.Text = "User Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(144, 213);
            label3.Name = "label3";
            label3.Size = new Size(86, 26);
            label3.TabIndex = 3;
            label3.Text = "Password";
            label3.Click += label3_Click;
            // 
            // login_username
            // 
            login_username.Font = new Font("Poppins", 9F);
            login_username.Location = new Point(243, 175);
            login_username.Name = "login_username";
            login_username.Size = new Size(194, 25);
            login_username.TabIndex = 4;
            // 
            // login_password
            // 
            login_password.Font = new Font("Poppins", 9F);
            login_password.Location = new Point(243, 213);
            login_password.Name = "login_password";
            login_password.PasswordChar = '*';
            login_password.Size = new Size(194, 25);
            login_password.TabIndex = 5;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(182, 24, 23);
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Font = new Font("Poppins SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(145, 273);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(293, 32);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.FromArgb(182, 24, 23);
            btnSignUp.FlatStyle = FlatStyle.Popup;
            btnSignUp.Font = new Font("Poppins SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignUp.ForeColor = Color.White;
            btnSignUp.Location = new Point(145, 355);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(293, 32);
            btnSignUp.TabIndex = 7;
            btnSignUp.Text = "Sign Up";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(204, 326);
            label4.Name = "label4";
            label4.Size = new Size(180, 26);
            label4.TabIndex = 8;
            label4.Text = "Create a New Account";
            // 
            // login_showpass
            // 
            login_showpass.AutoSize = true;
            login_showpass.ForeColor = Color.White;
            login_showpass.Location = new Point(243, 245);
            login_showpass.Name = "login_showpass";
            login_showpass.Size = new Size(108, 19);
            login_showpass.TabIndex = 9;
            login_showpass.Text = "Show Password";
            login_showpass.UseVisualStyleBackColor = true;
            login_showpass.CheckedChanged += login_showpass_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poppins SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(205, 146);
            label5.Name = "label5";
            label5.Size = new Size(179, 26);
            label5.TabIndex = 19;
            label5.Text = "Login to Your Account";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(5, 15, 60);
            ClientSize = new Size(600, 468);
            Controls.Add(label5);
            Controls.Add(login_showpass);
            Controls.Add(label4);
            Controls.Add(btnSignUp);
            Controls.Add(btnLogin);
            Controls.Add(login_password);
            Controls.Add(login_username);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            Load += LoginForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private TextBox login_username;
        private TextBox login_password;
        private Button btnLogin;
        private Button btnSignUp;
        private Label label4;
        private CheckBox login_showpass;
        private Label label5;
    }
}