namespace Prototype4
{
    partial class Order_page
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
            this.Order_info = new System.Windows.Forms.TextBox();
            this.Order_order = new System.Windows.Forms.Button();
            this.Order_email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Home_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Order_info
            // 
            this.Order_info.Location = new System.Drawing.Point(192, 16);
            this.Order_info.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Order_info.Multiline = true;
            this.Order_info.Name = "Order_info";
            this.Order_info.Size = new System.Drawing.Size(145, 99);
            this.Order_info.TabIndex = 0;
            this.Order_info.TextChanged += new System.EventHandler(this.Order_info_TextChanged);
            // 
            // Order_order
            // 
            this.Order_order.Location = new System.Drawing.Point(192, 141);
            this.Order_order.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Order_order.Name = "Order_order";
            this.Order_order.Size = new System.Drawing.Size(72, 19);
            this.Order_order.TabIndex = 1;
            this.Order_order.Text = "Order";
            this.Order_order.UseVisualStyleBackColor = true;
            this.Order_order.Click += new System.EventHandler(this.Order_order_Click);
            // 
            // Order_email
            // 
            this.Order_email.Location = new System.Drawing.Point(192, 117);
            this.Order_email.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Order_email.Name = "Order_email";
            this.Order_email.Size = new System.Drawing.Size(145, 20);
            this.Order_email.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 119);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 1);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "any infomation on the order";
            // 
            // Home_button
            // 
            this.Home_button.Location = new System.Drawing.Point(269, 141);
            this.Home_button.Name = "Home_button";
            this.Home_button.Size = new System.Drawing.Size(68, 22);
            this.Home_button.TabIndex = 23;
            this.Home_button.Text = "Home";
            this.Home_button.UseVisualStyleBackColor = true;
            this.Home_button.Click += new System.EventHandler(this.Home_button_Click);
            // 
            // Order_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.Home_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Order_email);
            this.Controls.Add(this.Order_order);
            this.Controls.Add(this.Order_info);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Order_page";
            this.Text = "Order";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Order_info;
        private System.Windows.Forms.Button Order_order;
        private System.Windows.Forms.TextBox Order_email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Home_button;
    }
}