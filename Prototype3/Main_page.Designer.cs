namespace Prototype3
{
    partial class Main_page
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
            this.Main_order = new System.Windows.Forms.Button();
            this.Main_management = new System.Windows.Forms.Button();
            this.Main_login = new System.Windows.Forms.Button();
            this.Main_Welcome = new System.Windows.Forms.Label();
            this.Main_Mytasks = new System.Windows.Forms.Button();
            this.Main_IT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Main_order
            // 
            this.Main_order.Location = new System.Drawing.Point(117, 11);
            this.Main_order.Name = "Main_order";
            this.Main_order.Size = new System.Drawing.Size(114, 35);
            this.Main_order.TabIndex = 0;
            this.Main_order.Text = "Order";
            this.Main_order.UseVisualStyleBackColor = true;
            this.Main_order.Click += new System.EventHandler(this.Main_order_Click);
            // 
            // Main_management
            // 
            this.Main_management.Location = new System.Drawing.Point(237, 11);
            this.Main_management.Name = "Main_management";
            this.Main_management.Size = new System.Drawing.Size(122, 35);
            this.Main_management.TabIndex = 1;
            this.Main_management.Text = "Management";
            this.Main_management.UseVisualStyleBackColor = true;
            this.Main_management.Click += new System.EventHandler(this.Main_management_Click);
            // 
            // Main_login
            // 
            this.Main_login.Location = new System.Drawing.Point(690, 8);
            this.Main_login.Name = "Main_login";
            this.Main_login.Size = new System.Drawing.Size(98, 35);
            this.Main_login.TabIndex = 2;
            this.Main_login.Text = "Login";
            this.Main_login.UseVisualStyleBackColor = true;
            this.Main_login.Click += new System.EventHandler(this.Main_login_Click);
            // 
            // Main_Welcome
            // 
            this.Main_Welcome.AutoSize = true;
            this.Main_Welcome.Location = new System.Drawing.Point(20, 18);
            this.Main_Welcome.Name = "Main_Welcome";
            this.Main_Welcome.Size = new System.Drawing.Size(71, 20);
            this.Main_Welcome.TabIndex = 3;
            this.Main_Welcome.Text = "welcome";
            // 
            // Main_Mytasks
            // 
            this.Main_Mytasks.Location = new System.Drawing.Point(366, 11);
            this.Main_Mytasks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Main_Mytasks.Name = "Main_Mytasks";
            this.Main_Mytasks.Size = new System.Drawing.Size(112, 35);
            this.Main_Mytasks.TabIndex = 4;
            this.Main_Mytasks.Text = "My Tasks";
            this.Main_Mytasks.UseVisualStyleBackColor = true;
            this.Main_Mytasks.Click += new System.EventHandler(this.Main_Mytasks_Click);
            // 
            // Main_IT
            // 
            this.Main_IT.Location = new System.Drawing.Point(485, 12);
            this.Main_IT.Name = "Main_IT";
            this.Main_IT.Size = new System.Drawing.Size(96, 34);
            this.Main_IT.TabIndex = 5;
            this.Main_IT.Text = "IT";
            this.Main_IT.UseVisualStyleBackColor = true;
            this.Main_IT.Click += new System.EventHandler(this.Main_IT_Click);
            // 
            // Main_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.Main_IT);
            this.Controls.Add(this.Main_Mytasks);
            this.Controls.Add(this.Main_Welcome);
            this.Controls.Add(this.Main_login);
            this.Controls.Add(this.Main_management);
            this.Controls.Add(this.Main_order);
            this.Name = "Main_page";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_page_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Main_order;
        private System.Windows.Forms.Button Main_management;
        private System.Windows.Forms.Button Main_login;
        private System.Windows.Forms.Label Main_Welcome;
        private System.Windows.Forms.Button Main_Mytasks;
        private System.Windows.Forms.Button Main_IT;
    }
}

