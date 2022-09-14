
namespace Prototype1
{
    partial class main_page
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
            this.main_order = new System.Windows.Forms.Button();
            this.main_login = new System.Windows.Forms.Button();
            this.Main_logo = new System.Windows.Forms.PictureBox();
            this.Main_price = new System.Windows.Forms.Button();
            this.Main_support = new System.Windows.Forms.Button();
            this.Main_mangement = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Main_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // main_order
            // 
            this.main_order.Location = new System.Drawing.Point(163, 8);
            this.main_order.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.main_order.Name = "main_order";
            this.main_order.Size = new System.Drawing.Size(79, 30);
            this.main_order.TabIndex = 0;
            this.main_order.Text = "order";
            this.main_order.UseVisualStyleBackColor = true;
            this.main_order.Click += new System.EventHandler(this.main_order_Click);
            // 
            // main_login
            // 
            this.main_login.Location = new System.Drawing.Point(455, 8);
            this.main_login.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.main_login.Name = "main_login";
            this.main_login.Size = new System.Drawing.Size(71, 30);
            this.main_login.TabIndex = 1;
            this.main_login.Text = "Login";
            this.main_login.UseVisualStyleBackColor = true;
            this.main_login.Click += new System.EventHandler(this.main_login_Click);
            // 
            // Main_logo
            // 
            this.Main_logo.Location = new System.Drawing.Point(8, 8);
            this.Main_logo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Main_logo.Name = "Main_logo";
            this.Main_logo.Size = new System.Drawing.Size(67, 32);
            this.Main_logo.TabIndex = 2;
            this.Main_logo.TabStop = false;
            // 
            // Main_price
            // 
            this.Main_price.Location = new System.Drawing.Point(247, 8);
            this.Main_price.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Main_price.Name = "Main_price";
            this.Main_price.Size = new System.Drawing.Size(72, 30);
            this.Main_price.TabIndex = 3;
            this.Main_price.Text = "Price";
            this.Main_price.UseVisualStyleBackColor = true;
            // 
            // Main_support
            // 
            this.Main_support.Location = new System.Drawing.Point(379, 8);
            this.Main_support.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Main_support.Name = "Main_support";
            this.Main_support.Size = new System.Drawing.Size(72, 30);
            this.Main_support.TabIndex = 4;
            this.Main_support.Text = "support";
            this.Main_support.UseVisualStyleBackColor = true;
            // 
            // Main_mangement
            // 
            this.Main_mangement.Location = new System.Drawing.Point(83, 8);
            this.Main_mangement.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Main_mangement.Name = "Main_mangement";
            this.Main_mangement.Size = new System.Drawing.Size(76, 30);
            this.Main_mangement.TabIndex = 5;
            this.Main_mangement.Text = "management";
            this.Main_mangement.UseVisualStyleBackColor = true;
            this.Main_mangement.Click += new System.EventHandler(this.Main_mangement_Click);
            // 
            // main_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 300);
            this.Controls.Add(this.Main_mangement);
            this.Controls.Add(this.Main_support);
            this.Controls.Add(this.Main_price);
            this.Controls.Add(this.Main_logo);
            this.Controls.Add(this.main_login);
            this.Controls.Add(this.main_order);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "main_page";
            this.Text = "main_page";
            this.Load += new System.EventHandler(this.main_page_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Main_logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button main_order;
        private System.Windows.Forms.Button main_login;
        private System.Windows.Forms.PictureBox Main_logo;
        private System.Windows.Forms.Button Main_price;
        private System.Windows.Forms.Button Main_support;
        private System.Windows.Forms.Button Main_mangement;
    }
}