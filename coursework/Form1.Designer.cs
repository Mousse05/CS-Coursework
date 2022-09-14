
namespace Prototype1
{
    partial class login_page
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
            this.login_regiter = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.Button();
            this.login_username = new System.Windows.Forms.TextBox();
            this.login_password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // login_regiter
            // 
            this.login_regiter.Location = new System.Drawing.Point(426, 326);
            this.login_regiter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.login_regiter.Name = "login_regiter";
            this.login_regiter.Size = new System.Drawing.Size(112, 35);
            this.login_regiter.TabIndex = 0;
            this.login_regiter.Text = "register";
            this.login_regiter.UseVisualStyleBackColor = true;
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(548, 326);
            this.login.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(112, 35);
            this.login.TabIndex = 1;
            this.login.Text = "login";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // login_username
            // 
            this.login_username.Location = new System.Drawing.Point(432, 220);
            this.login_username.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.login_username.Name = "login_username";
            this.login_username.Size = new System.Drawing.Size(226, 26);
            this.login_username.TabIndex = 3;
            this.login_username.Text = "username";
            // 
            // login_password
            // 
            this.login_password.Location = new System.Drawing.Point(432, 260);
            this.login_password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.login_password.Name = "login_password";
            this.login_password.Size = new System.Drawing.Size(226, 26);
            this.login_password.TabIndex = 4;
            this.login_password.Text = "password";
            // 
            // login_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.login_password);
            this.Controls.Add(this.login_username);
            this.Controls.Add(this.login);
            this.Controls.Add(this.login_regiter);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "login_page";
            this.Text = "login page";
            this.Load += new System.EventHandler(this.login_page_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login_regiter;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.TextBox login_username;
        private System.Windows.Forms.TextBox login_password;
    }
}

