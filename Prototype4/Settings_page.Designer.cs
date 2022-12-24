namespace Prototype4
{
    partial class Settings_page
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
            this.Settings_username = new System.Windows.Forms.TextBox();
            this.Settings_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Settings_email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Settings_priority = new System.Windows.Forms.Label();
            this.Settings_update = new System.Windows.Forms.Button();
            this.Home_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Settings_username
            // 
            this.Settings_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Settings_username.Location = new System.Drawing.Point(352, 125);
            this.Settings_username.Name = "Settings_username";
            this.Settings_username.Size = new System.Drawing.Size(490, 62);
            this.Settings_username.TabIndex = 0;
            // 
            // Settings_password
            // 
            this.Settings_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Settings_password.Location = new System.Drawing.Point(352, 207);
            this.Settings_password.Name = "Settings_password";
            this.Settings_password.ReadOnly = true;
            this.Settings_password.Size = new System.Drawing.Size(490, 62);
            this.Settings_password.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 55);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ussername";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 55);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // Settings_email
            // 
            this.Settings_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Settings_email.Location = new System.Drawing.Point(352, 302);
            this.Settings_email.Name = "Settings_email";
            this.Settings_email.Size = new System.Drawing.Size(490, 62);
            this.Settings_email.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 55);
            this.label3.TabIndex = 6;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(75, 387);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 55);
            this.label4.TabIndex = 7;
            this.label4.Text = "Priority";
            // 
            // Settings_priority
            // 
            this.Settings_priority.AutoSize = true;
            this.Settings_priority.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Settings_priority.Location = new System.Drawing.Point(152, 114);
            this.Settings_priority.Name = "Settings_priority";
            this.Settings_priority.Size = new System.Drawing.Size(0, 55);
            this.Settings_priority.TabIndex = 8;
            // 
            // Settings_update
            // 
            this.Settings_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Settings_update.Location = new System.Drawing.Point(68, 454);
            this.Settings_update.Margin = new System.Windows.Forms.Padding(2);
            this.Settings_update.Name = "Settings_update";
            this.Settings_update.Size = new System.Drawing.Size(1258, 77);
            this.Settings_update.TabIndex = 9;
            this.Settings_update.Text = "Update";
            this.Settings_update.UseVisualStyleBackColor = true;
            this.Settings_update.Click += new System.EventHandler(this.Settings_update_Click);
            // 
            // Home_button
            // 
            this.Home_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home_button.Location = new System.Drawing.Point(68, 536);
            this.Home_button.Name = "Home_button";
            this.Home_button.Size = new System.Drawing.Size(1258, 84);
            this.Home_button.TabIndex = 26;
            this.Home_button.Text = "Home";
            this.Home_button.UseVisualStyleBackColor = true;
            this.Home_button.Click += new System.EventHandler(this.Home_button_Click);
            // 
            // Settings_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 647);
            this.Controls.Add(this.Home_button);
            this.Controls.Add(this.Settings_update);
            this.Controls.Add(this.Settings_priority);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Settings_email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Settings_password);
            this.Controls.Add(this.Settings_username);
            this.Name = "Settings_page";
            this.Text = "Settings_page";
            this.Load += new System.EventHandler(this.Settings_page_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Settings_username;
        private System.Windows.Forms.TextBox Settings_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Settings_email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Settings_priority;
        private System.Windows.Forms.Button Settings_update;
        private System.Windows.Forms.Button Home_button;
    }
}