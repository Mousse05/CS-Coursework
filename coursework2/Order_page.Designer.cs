namespace Prototype3
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
            this.Order_order.Location = new System.Drawing.Point(235, 138);
            this.Order_order.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Order_order.Name = "Order_order";
            this.Order_order.Size = new System.Drawing.Size(57, 19);
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
            // Order_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
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
    }
}