namespace Prototype4
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
            this.Main_order.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Main_order.Location = new System.Drawing.Point(11, 21);
            this.Main_order.Margin = new System.Windows.Forms.Padding(2);
            this.Main_order.Name = "Main_order";
            this.Main_order.Size = new System.Drawing.Size(238, 137);
            this.Main_order.TabIndex = 0;
            this.Main_order.Text = "Order";
            this.Main_order.UseVisualStyleBackColor = true;
            this.Main_order.Click += new System.EventHandler(this.Main_order_Click);
            // 
            // Main_management
            // 
            this.Main_management.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Main_management.Location = new System.Drawing.Point(269, 21);
            this.Main_management.Margin = new System.Windows.Forms.Padding(2);
            this.Main_management.Name = "Main_management";
            this.Main_management.Size = new System.Drawing.Size(243, 137);
            this.Main_management.TabIndex = 1;
            this.Main_management.Text = "Management";
            this.Main_management.UseVisualStyleBackColor = true;
            this.Main_management.Click += new System.EventHandler(this.Main_management_Click);
            // 
            // Main_login
            // 
            this.Main_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Main_login.Location = new System.Drawing.Point(1116, 31);
            this.Main_login.Margin = new System.Windows.Forms.Padding(2);
            this.Main_login.Name = "Main_login";
            this.Main_login.Size = new System.Drawing.Size(249, 137);
            this.Main_login.TabIndex = 2;
            this.Main_login.Text = "Login/Register";
            this.Main_login.UseVisualStyleBackColor = true;
            this.Main_login.Click += new System.EventHandler(this.Main_login_Click);
            // 
            // Main_Welcome
            // 
            this.Main_Welcome.AutoSize = true;
            this.Main_Welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Main_Welcome.Location = new System.Drawing.Point(637, 333);
            this.Main_Welcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Main_Welcome.Name = "Main_Welcome";
            this.Main_Welcome.Size = new System.Drawing.Size(142, 37);
            this.Main_Welcome.TabIndex = 3;
            this.Main_Welcome.Text = "welcome";
            // 
            // Main_Mytasks
            // 
            this.Main_Mytasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Main_Mytasks.Location = new System.Drawing.Point(531, 21);
            this.Main_Mytasks.Name = "Main_Mytasks";
            this.Main_Mytasks.Size = new System.Drawing.Size(237, 137);
            this.Main_Mytasks.TabIndex = 4;
            this.Main_Mytasks.Text = "My Tasks";
            this.Main_Mytasks.UseVisualStyleBackColor = true;
            this.Main_Mytasks.Click += new System.EventHandler(this.Main_Mytasks_Click);
            // 
            // Main_IT
            // 
            this.Main_IT.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Main_IT.Location = new System.Drawing.Point(783, 22);
            this.Main_IT.Margin = new System.Windows.Forms.Padding(2);
            this.Main_IT.Name = "Main_IT";
            this.Main_IT.Size = new System.Drawing.Size(226, 136);
            this.Main_IT.TabIndex = 5;
            this.Main_IT.Text = "IT";
            this.Main_IT.UseVisualStyleBackColor = true;
            this.Main_IT.Click += new System.EventHandler(this.Main_IT_Click);
            // 
            // Main_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 651);
            this.Controls.Add(this.Main_IT);
            this.Controls.Add(this.Main_Mytasks);
            this.Controls.Add(this.Main_Welcome);
            this.Controls.Add(this.Main_login);
            this.Controls.Add(this.Main_management);
            this.Controls.Add(this.Main_order);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main_page";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_page_Load);
            this.Shown += new System.EventHandler(this.Main_page_Shown);
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

