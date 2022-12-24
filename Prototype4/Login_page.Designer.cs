namespace Prototype4
{
    partial class Login_page
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
            this.Login_password = new System.Windows.Forms.TextBox();
            this.Login_username = new System.Windows.Forms.TextBox();
            this.Login_login = new System.Windows.Forms.Button();
            this.Login_register = new System.Windows.Forms.Button();
            this.Home_button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Login_password
            // 
            this.Login_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_password.Location = new System.Drawing.Point(494, 136);
            this.Login_password.Margin = new System.Windows.Forms.Padding(2);
            this.Login_password.Multiline = true;
            this.Login_password.Name = "Login_password";
            this.Login_password.Size = new System.Drawing.Size(542, 81);
            this.Login_password.TabIndex = 1;
            this.Login_password.Text = "password";
            this.Login_password.TextChanged += new System.EventHandler(this.Login_password_TextChanged);
            // 
            // Login_username
            // 
            this.Login_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_username.Location = new System.Drawing.Point(494, 41);
            this.Login_username.Margin = new System.Windows.Forms.Padding(2);
            this.Login_username.Multiline = true;
            this.Login_username.Name = "Login_username";
            this.Login_username.Size = new System.Drawing.Size(542, 81);
            this.Login_username.TabIndex = 2;
            this.Login_username.Text = "musa";
            this.Login_username.TextChanged += new System.EventHandler(this.Login_username_TextChanged);
            // 
            // Login_login
            // 
            this.Login_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_login.Location = new System.Drawing.Point(494, 235);
            this.Login_login.Margin = new System.Windows.Forms.Padding(2);
            this.Login_login.Name = "Login_login";
            this.Login_login.Size = new System.Drawing.Size(284, 127);
            this.Login_login.TabIndex = 3;
            this.Login_login.Text = "Login";
            this.Login_login.UseVisualStyleBackColor = true;
            this.Login_login.Click += new System.EventHandler(this.Login_login_Click);
            // 
            // Login_register
            // 
            this.Login_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_register.Location = new System.Drawing.Point(782, 235);
            this.Login_register.Margin = new System.Windows.Forms.Padding(2);
            this.Login_register.Name = "Login_register";
            this.Login_register.Size = new System.Drawing.Size(254, 127);
            this.Login_register.TabIndex = 4;
            this.Login_register.Text = "Register";
            this.Login_register.UseVisualStyleBackColor = true;
            this.Login_register.Click += new System.EventHandler(this.Login_register_Click);
            // 
            // Home_button
            // 
            this.Home_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home_button.Location = new System.Drawing.Point(494, 367);
            this.Home_button.Name = "Home_button";
            this.Home_button.Size = new System.Drawing.Size(542, 123);
            this.Home_button.TabIndex = 20;
            this.Home_button.Text = "Home";
            this.Home_button.UseVisualStyleBackColor = true;
            this.Home_button.Click += new System.EventHandler(this.Home_button_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 43);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(312, 449);
            this.textBox1.TabIndex = 21;
            this.textBox1.Text = "Admin Details\r\n\r\nusername = admin\r\npassword = admin\r\n\r\nThis is for the IT page wh" +
    "ich is where you can change the priority of users\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(330, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 37);
            this.label1.TabIndex = 22;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(330, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 37);
            this.label2.TabIndex = 23;
            this.label2.Text = "Password";
            // 
            // Login_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1397, 645);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Home_button);
            this.Controls.Add(this.Login_register);
            this.Controls.Add(this.Login_login);
            this.Controls.Add(this.Login_username);
            this.Controls.Add(this.Login_password);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Login_page";
            this.Text = "Login_page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Login_password;
        private System.Windows.Forms.TextBox Login_username;
        private System.Windows.Forms.Button Login_login;
        private System.Windows.Forms.Button Login_register;
        private System.Windows.Forms.Button Home_button;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}