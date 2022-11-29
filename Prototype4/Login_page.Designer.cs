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
            this.SuspendLayout();
            // 
            // Login_password
            // 
            this.Login_password.Location = new System.Drawing.Point(345, 135);
            this.Login_password.Name = "Login_password";
            this.Login_password.Size = new System.Drawing.Size(145, 26);
            this.Login_password.TabIndex = 1;
            this.Login_password.Text = "hi";
            // 
            // Login_username
            // 
            this.Login_username.Location = new System.Drawing.Point(345, 88);
            this.Login_username.Name = "Login_username";
            this.Login_username.Size = new System.Drawing.Size(145, 26);
            this.Login_username.TabIndex = 2;
            this.Login_username.Text = "mushussa";
            // 
            // Login_login
            // 
            this.Login_login.Location = new System.Drawing.Point(342, 175);
            this.Login_login.Name = "Login_login";
            this.Login_login.Size = new System.Drawing.Size(88, 37);
            this.Login_login.TabIndex = 3;
            this.Login_login.Text = "Login";
            this.Login_login.UseVisualStyleBackColor = true;
            this.Login_login.Click += new System.EventHandler(this.Login_login_Click);
            // 
            // Login_register
            // 
            this.Login_register.Location = new System.Drawing.Point(436, 175);
            this.Login_register.Name = "Login_register";
            this.Login_register.Size = new System.Drawing.Size(86, 37);
            this.Login_register.TabIndex = 4;
            this.Login_register.Text = "Register";
            this.Login_register.UseVisualStyleBackColor = true;
            this.Login_register.Click += new System.EventHandler(this.Login_register_Click);
            // 
            // Login_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.Login_register);
            this.Controls.Add(this.Login_login);
            this.Controls.Add(this.Login_username);
            this.Controls.Add(this.Login_password);
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
    }
}