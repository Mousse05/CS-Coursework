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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Main_order
            // 
            this.Main_order.Location = new System.Drawing.Point(78, 7);
            this.Main_order.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Main_order.Name = "Main_order";
            this.Main_order.Size = new System.Drawing.Size(76, 23);
            this.Main_order.TabIndex = 0;
            this.Main_order.Text = "Order";
            this.Main_order.UseVisualStyleBackColor = true;
            this.Main_order.Click += new System.EventHandler(this.Main_order_Click);
            // 
            // Main_management
            // 
            this.Main_management.Location = new System.Drawing.Point(158, 7);
            this.Main_management.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Main_management.Name = "Main_management";
            this.Main_management.Size = new System.Drawing.Size(81, 23);
            this.Main_management.TabIndex = 1;
            this.Main_management.Text = "Management";
            this.Main_management.UseVisualStyleBackColor = true;
            this.Main_management.Click += new System.EventHandler(this.Main_management_Click);
            // 
            // Main_login
            // 
            this.Main_login.Location = new System.Drawing.Point(460, 5);
            this.Main_login.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Main_login.Name = "Main_login";
            this.Main_login.Size = new System.Drawing.Size(65, 23);
            this.Main_login.TabIndex = 2;
            this.Main_login.Text = "Login";
            this.Main_login.UseVisualStyleBackColor = true;
            this.Main_login.Click += new System.EventHandler(this.Main_login_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(7, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 32);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Main_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Main_login);
            this.Controls.Add(this.Main_management);
            this.Controls.Add(this.Main_order);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Main_page";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_page_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Main_order;
        private System.Windows.Forms.Button Main_management;
        private System.Windows.Forms.Button Main_login;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

