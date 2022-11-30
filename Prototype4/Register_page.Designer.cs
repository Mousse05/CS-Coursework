namespace Prototype4
{
    partial class Register_page
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
            this.Register_forename = new System.Windows.Forms.TextBox();
            this.Register_password = new System.Windows.Forms.TextBox();
            this.Register_password2 = new System.Windows.Forms.TextBox();
            this.Regester_regester = new System.Windows.Forms.Button();
            this.Register_surname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Home_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Register_forename
            // 
            this.Register_forename.Location = new System.Drawing.Point(191, 10);
            this.Register_forename.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Register_forename.Name = "Register_forename";
            this.Register_forename.Size = new System.Drawing.Size(125, 20);
            this.Register_forename.TabIndex = 0;
            // 
            // Register_password
            // 
            this.Register_password.Location = new System.Drawing.Point(191, 62);
            this.Register_password.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Register_password.Name = "Register_password";
            this.Register_password.Size = new System.Drawing.Size(125, 20);
            this.Register_password.TabIndex = 2;
            // 
            // Register_password2
            // 
            this.Register_password2.Location = new System.Drawing.Point(191, 92);
            this.Register_password2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Register_password2.Name = "Register_password2";
            this.Register_password2.Size = new System.Drawing.Size(125, 20);
            this.Register_password2.TabIndex = 3;
            // 
            // Regester_regester
            // 
            this.Regester_regester.Location = new System.Drawing.Point(191, 122);
            this.Regester_regester.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Regester_regester.Name = "Regester_regester";
            this.Regester_regester.Size = new System.Drawing.Size(125, 29);
            this.Regester_regester.TabIndex = 4;
            this.Regester_regester.Text = "Register";
            this.Regester_regester.UseVisualStyleBackColor = true;
            this.Regester_regester.Click += new System.EventHandler(this.Regester_regester_Click);
            // 
            // Register_surname
            // 
            this.Register_surname.Location = new System.Drawing.Point(191, 37);
            this.Register_surname.Name = "Register_surname";
            this.Register_surname.Size = new System.Drawing.Size(125, 20);
            this.Register_surname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Firstname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(132, 94);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Password";
            // 
            // Home_button
            // 
            this.Home_button.Location = new System.Drawing.Point(191, 156);
            this.Home_button.Name = "Home_button";
            this.Home_button.Size = new System.Drawing.Size(125, 29);
            this.Home_button.TabIndex = 25;
            this.Home_button.Text = "Home";
            this.Home_button.UseVisualStyleBackColor = true;
            this.Home_button.Click += new System.EventHandler(this.Home_button_Click);
            // 
            // Register_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.Home_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Register_surname);
            this.Controls.Add(this.Regester_regester);
            this.Controls.Add(this.Register_password2);
            this.Controls.Add(this.Register_password);
            this.Controls.Add(this.Register_forename);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Register_page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register_page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Register_forename;
        private System.Windows.Forms.TextBox Register_password;
        private System.Windows.Forms.TextBox Register_password2;
        private System.Windows.Forms.Button Regester_regester;
        private System.Windows.Forms.TextBox Register_surname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Home_button;
    }
}