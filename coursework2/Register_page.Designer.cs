namespace Prototype3
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
            this.SuspendLayout();
            // 
            // Register_forename
            // 
            this.Register_forename.Location = new System.Drawing.Point(291, 88);
            this.Register_forename.Name = "Register_forename";
            this.Register_forename.Size = new System.Drawing.Size(186, 26);
            this.Register_forename.TabIndex = 0;
            // 
            // Register_password
            // 
            this.Register_password.Location = new System.Drawing.Point(291, 168);
            this.Register_password.Name = "Register_password";
            this.Register_password.Size = new System.Drawing.Size(186, 26);
            this.Register_password.TabIndex = 1;
            // 
            // Register_password2
            // 
            this.Register_password2.Location = new System.Drawing.Point(291, 215);
            this.Register_password2.Name = "Register_password2";
            this.Register_password2.Size = new System.Drawing.Size(186, 26);
            this.Register_password2.TabIndex = 2;
            // 
            // Regester_regester
            // 
            this.Regester_regester.Location = new System.Drawing.Point(324, 261);
            this.Regester_regester.Name = "Regester_regester";
            this.Regester_regester.Size = new System.Drawing.Size(120, 45);
            this.Regester_regester.TabIndex = 3;
            this.Regester_regester.Text = "Regester";
            this.Regester_regester.UseVisualStyleBackColor = true;
            this.Regester_regester.Click += new System.EventHandler(this.Regester_regester_Click);
            // 
            // Register_surname
            // 
            this.Register_surname.Location = new System.Drawing.Point(291, 130);
            this.Register_surname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Register_surname.Name = "Register_surname";
            this.Register_surname.Size = new System.Drawing.Size(186, 26);
            this.Register_surname.TabIndex = 4;
            // 
            // Register_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.Register_surname);
            this.Controls.Add(this.Regester_regester);
            this.Controls.Add(this.Register_password2);
            this.Controls.Add(this.Register_password);
            this.Controls.Add(this.Register_forename);
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
    }
}