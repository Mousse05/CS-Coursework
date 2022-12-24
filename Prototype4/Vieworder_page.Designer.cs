namespace Prototype4
{
    partial class Vieworder_page
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Home_button = new System.Windows.Forms.Button();
            this.Vieworder_price = new System.Windows.Forms.Label();
            this.Vieworder_payment = new System.Windows.Forms.Button();
            this.Vieworder_percent = new System.Windows.Forms.Label();
            this.Vieworder_Info = new System.Windows.Forms.TextBox();
            this.Vieworder_progressBar = new System.Windows.Forms.ProgressBar();
            this.Vieworder_Orderdate = new System.Windows.Forms.Label();
            this.lable = new System.Windows.Forms.Label();
            this.Vieworder_Accepted = new System.Windows.Forms.CheckBox();
            this.Vieworder_Delivered = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Vieworder_save = new System.Windows.Forms.Button();
            this.Vieworder_employee = new System.Windows.Forms.TextBox();
            this.Vieworder_user = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Vieworder_price);
            this.panel1.Controls.Add(this.Vieworder_payment);
            this.panel1.Controls.Add(this.Vieworder_percent);
            this.panel1.Controls.Add(this.Vieworder_Info);
            this.panel1.Controls.Add(this.Vieworder_progressBar);
            this.panel1.Controls.Add(this.Vieworder_Orderdate);
            this.panel1.Controls.Add(this.lable);
            this.panel1.Controls.Add(this.Vieworder_Accepted);
            this.panel1.Controls.Add(this.Vieworder_Delivered);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1381, 305);
            this.panel1.TabIndex = 0;
            // 
            // Home_button
            // 
            this.Home_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home_button.Location = new System.Drawing.Point(15, 256);
            this.Home_button.Name = "Home_button";
            this.Home_button.Size = new System.Drawing.Size(1363, 68);
            this.Home_button.TabIndex = 27;
            this.Home_button.Text = "Home";
            this.Home_button.UseVisualStyleBackColor = true;
            this.Home_button.Click += new System.EventHandler(this.Home_button_Click);
            // 
            // Vieworder_price
            // 
            this.Vieworder_price.AutoSize = true;
            this.Vieworder_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vieworder_price.Location = new System.Drawing.Point(397, 206);
            this.Vieworder_price.Name = "Vieworder_price";
            this.Vieworder_price.Size = new System.Drawing.Size(82, 33);
            this.Vieworder_price.TabIndex = 8;
            this.Vieworder_price.Text = "Price";
            // 
            // Vieworder_payment
            // 
            this.Vieworder_payment.Enabled = false;
            this.Vieworder_payment.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vieworder_payment.Location = new System.Drawing.Point(683, 206);
            this.Vieworder_payment.Name = "Vieworder_payment";
            this.Vieworder_payment.Size = new System.Drawing.Size(674, 96);
            this.Vieworder_payment.TabIndex = 1;
            this.Vieworder_payment.Text = "Pay";
            this.Vieworder_payment.UseVisualStyleBackColor = true;
            this.Vieworder_payment.Click += new System.EventHandler(this.Vieworder_payment_Click);
            // 
            // Vieworder_percent
            // 
            this.Vieworder_percent.AutoSize = true;
            this.Vieworder_percent.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vieworder_percent.Location = new System.Drawing.Point(1285, 120);
            this.Vieworder_percent.Name = "Vieworder_percent";
            this.Vieworder_percent.Size = new System.Drawing.Size(72, 42);
            this.Vieworder_percent.TabIndex = 7;
            this.Vieworder_percent.Text = "0%";
            // 
            // Vieworder_Info
            // 
            this.Vieworder_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vieworder_Info.Location = new System.Drawing.Point(11, 74);
            this.Vieworder_Info.Margin = new System.Windows.Forms.Padding(2);
            this.Vieworder_Info.Multiline = true;
            this.Vieworder_Info.Name = "Vieworder_Info";
            this.Vieworder_Info.ReadOnly = true;
            this.Vieworder_Info.Size = new System.Drawing.Size(331, 209);
            this.Vieworder_Info.TabIndex = 6;
            // 
            // Vieworder_progressBar
            // 
            this.Vieworder_progressBar.Cursor = System.Windows.Forms.Cursors.Default;
            this.Vieworder_progressBar.Location = new System.Drawing.Point(683, 31);
            this.Vieworder_progressBar.Margin = new System.Windows.Forms.Padding(2);
            this.Vieworder_progressBar.Name = "Vieworder_progressBar";
            this.Vieworder_progressBar.Size = new System.Drawing.Size(674, 74);
            this.Vieworder_progressBar.TabIndex = 5;
            // 
            // Vieworder_Orderdate
            // 
            this.Vieworder_Orderdate.AutoSize = true;
            this.Vieworder_Orderdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vieworder_Orderdate.Location = new System.Drawing.Point(397, 31);
            this.Vieworder_Orderdate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Vieworder_Orderdate.Name = "Vieworder_Orderdate";
            this.Vieworder_Orderdate.Size = new System.Drawing.Size(162, 33);
            this.Vieworder_Orderdate.TabIndex = 4;
            this.Vieworder_Orderdate.Text = "Order date:";
            // 
            // lable
            // 
            this.lable.AutoSize = true;
            this.lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable.Location = new System.Drawing.Point(11, 31);
            this.lable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(234, 33);
            this.lable.TabIndex = 3;
            this.lable.Text = "Order Infomation";
            // 
            // Vieworder_Accepted
            // 
            this.Vieworder_Accepted.AutoSize = true;
            this.Vieworder_Accepted.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vieworder_Accepted.Location = new System.Drawing.Point(397, 88);
            this.Vieworder_Accepted.Margin = new System.Windows.Forms.Padding(2);
            this.Vieworder_Accepted.Name = "Vieworder_Accepted";
            this.Vieworder_Accepted.Size = new System.Drawing.Size(155, 37);
            this.Vieworder_Accepted.TabIndex = 1;
            this.Vieworder_Accepted.Text = "Accepted";
            this.Vieworder_Accepted.UseVisualStyleBackColor = true;
            // 
            // Vieworder_Delivered
            // 
            this.Vieworder_Delivered.AutoSize = true;
            this.Vieworder_Delivered.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vieworder_Delivered.Location = new System.Drawing.Point(397, 141);
            this.Vieworder_Delivered.Margin = new System.Windows.Forms.Padding(2);
            this.Vieworder_Delivered.Name = "Vieworder_Delivered";
            this.Vieworder_Delivered.Size = new System.Drawing.Size(158, 37);
            this.Vieworder_Delivered.TabIndex = 2;
            this.Vieworder_Delivered.Text = "Delivered";
            this.Vieworder_Delivered.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Home_button);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.Vieworder_save);
            this.panel2.Controls.Add(this.Vieworder_employee);
            this.panel2.Controls.Add(this.Vieworder_user);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 309);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1381, 327);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(626, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(342, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "Employee Question/Response";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Customer Question/Response";
            // 
            // Vieworder_save
            // 
            this.Vieworder_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vieworder_save.Location = new System.Drawing.Point(1161, 33);
            this.Vieworder_save.Margin = new System.Windows.Forms.Padding(2);
            this.Vieworder_save.Name = "Vieworder_save";
            this.Vieworder_save.Size = new System.Drawing.Size(217, 218);
            this.Vieworder_save.TabIndex = 8;
            this.Vieworder_save.Text = "Save";
            this.Vieworder_save.UseVisualStyleBackColor = true;
            this.Vieworder_save.Click += new System.EventHandler(this.Vieworder_save_Click);
            // 
            // Vieworder_employee
            // 
            this.Vieworder_employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vieworder_employee.Location = new System.Drawing.Point(631, 33);
            this.Vieworder_employee.Margin = new System.Windows.Forms.Padding(2);
            this.Vieworder_employee.Multiline = true;
            this.Vieworder_employee.Name = "Vieworder_employee";
            this.Vieworder_employee.Size = new System.Drawing.Size(526, 218);
            this.Vieworder_employee.TabIndex = 7;
            // 
            // Vieworder_user
            // 
            this.Vieworder_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vieworder_user.Location = new System.Drawing.Point(15, 33);
            this.Vieworder_user.Margin = new System.Windows.Forms.Padding(2);
            this.Vieworder_user.Multiline = true;
            this.Vieworder_user.Name = "Vieworder_user";
            this.Vieworder_user.Size = new System.Drawing.Size(612, 218);
            this.Vieworder_user.TabIndex = 6;
            // 
            // Vieworder_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1392, 647);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Vieworder_page";
            this.Text = "Vieworder_page";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox Vieworder_Accepted;
        private System.Windows.Forms.CheckBox Vieworder_Delivered;
        private System.Windows.Forms.ProgressBar Vieworder_progressBar;
        private System.Windows.Forms.Label Vieworder_Orderdate;
        private System.Windows.Forms.Label lable;
        private System.Windows.Forms.Button Vieworder_save;
        private System.Windows.Forms.TextBox Vieworder_employee;
        private System.Windows.Forms.TextBox Vieworder_user;
        private System.Windows.Forms.TextBox Vieworder_Info;
        private System.Windows.Forms.Label Vieworder_percent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Vieworder_price;
        private System.Windows.Forms.Button Vieworder_payment;
        private System.Windows.Forms.Button Home_button;
    }
}