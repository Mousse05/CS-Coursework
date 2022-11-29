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
            this.SuspendLayout();
            // 
            // Order_info
            // 
            this.Order_info.Location = new System.Drawing.Point(288, 25);
            this.Order_info.Multiline = true;
            this.Order_info.Name = "Order_info";
            this.Order_info.Size = new System.Drawing.Size(216, 150);
            this.Order_info.TabIndex = 0;
            this.Order_info.TextChanged += new System.EventHandler(this.Order_info_TextChanged);
            // 
            // Order_order
            // 
            this.Order_order.Location = new System.Drawing.Point(352, 212);
            this.Order_order.Name = "Order_order";
            this.Order_order.Size = new System.Drawing.Size(86, 29);
            this.Order_order.TabIndex = 1;
            this.Order_order.Text = "Order";
            this.Order_order.UseVisualStyleBackColor = true;
            this.Order_order.Click += new System.EventHandler(this.Order_order_Click);
            // 
            // Order_email
            // 
            this.Order_email.Location = new System.Drawing.Point(288, 180);
            this.Order_email.Name = "Order_email";
            this.Order_email.Size = new System.Drawing.Size(216, 26);
            this.Order_email.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "any infomation on the order";
            // 
            // Order_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Order_email);
            this.Controls.Add(this.Order_order);
            this.Controls.Add(this.Order_info);
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
    }
}