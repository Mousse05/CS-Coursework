
namespace Prototype1
{
    partial class ordering_page
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
            this.numorder = new System.Windows.Forms.Label();
            this.order = new System.Windows.Forms.Button();
            this.order_input = new System.Windows.Forms.TextBox();
            this.order_value = new System.Windows.Forms.Label();
            this.order_view = new System.Windows.Forms.Button();
            this.ordering_management = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numorder
            // 
            this.numorder.AutoSize = true;
            this.numorder.Location = new System.Drawing.Point(394, 35);
            this.numorder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.numorder.Name = "numorder";
            this.numorder.Size = new System.Drawing.Size(13, 13);
            this.numorder.TabIndex = 0;
            this.numorder.Text = "0";
            this.numorder.Click += new System.EventHandler(this.numorder_Click);
            // 
            // order
            // 
            this.order.Location = new System.Drawing.Point(299, 27);
            this.order.Margin = new System.Windows.Forms.Padding(2);
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(67, 28);
            this.order.TabIndex = 1;
            this.order.Text = "order";
            this.order.UseVisualStyleBackColor = true;
            this.order.Click += new System.EventHandler(this.order_Click);
            // 
            // order_input
            // 
            this.order_input.Location = new System.Drawing.Point(181, 32);
            this.order_input.Name = "order_input";
            this.order_input.Size = new System.Drawing.Size(100, 20);
            this.order_input.TabIndex = 2;
            this.order_input.TextChanged += new System.EventHandler(this.order_input_TextChanged);
            // 
            // order_value
            // 
            this.order_value.AutoSize = true;
            this.order_value.Location = new System.Drawing.Point(412, 35);
            this.order_value.Name = "order_value";
            this.order_value.Size = new System.Drawing.Size(0, 13);
            this.order_value.TabIndex = 3;
            // 
            // order_view
            // 
            this.order_view.Location = new System.Drawing.Point(299, 60);
            this.order_view.Name = "order_view";
            this.order_view.Size = new System.Drawing.Size(75, 23);
            this.order_view.TabIndex = 4;
            this.order_view.Text = "view order";
            this.order_view.UseVisualStyleBackColor = true;
            this.order_view.Click += new System.EventHandler(this.order_view_Click);
            // 
            // ordering_management
            // 
            this.ordering_management.Location = new System.Drawing.Point(36, 25);
            this.ordering_management.Name = "ordering_management";
            this.ordering_management.Size = new System.Drawing.Size(80, 23);
            this.ordering_management.TabIndex = 5;
            this.ordering_management.Text = "management";
            this.ordering_management.UseVisualStyleBackColor = true;
            this.ordering_management.Click += new System.EventHandler(this.ordering_management_Click);
            // 
            // ordering_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.ordering_management);
            this.Controls.Add(this.order_view);
            this.Controls.Add(this.order_value);
            this.Controls.Add(this.order_input);
            this.Controls.Add(this.order);
            this.Controls.Add(this.numorder);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ordering_page";
            this.Text = "ordering_page";
            this.Load += new System.EventHandler(this.ordering_page_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label numorder;
        private System.Windows.Forms.Button order;
        private System.Windows.Forms.TextBox order_input;
        private System.Windows.Forms.Label order_value;
        private System.Windows.Forms.Button order_view;
        private System.Windows.Forms.Button ordering_management;
    }
}