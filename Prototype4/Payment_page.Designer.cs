namespace Prototype4
{
    partial class Payment_page
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
            this.Payment_firstname = new System.Windows.Forms.TextBox();
            this.Payment_lastname = new System.Windows.Forms.TextBox();
            this.Payment_cardnumber = new System.Windows.Forms.TextBox();
            this.Payment_cvv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Payment_price = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Payment_cvvvalid = new System.Windows.Forms.CheckBox();
            this.Payment_lastvalid = new System.Windows.Forms.CheckBox();
            this.Payment_firstvalid = new System.Windows.Forms.CheckBox();
            this.Payment_pay = new System.Windows.Forms.Button();
            this.Payment_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Payment_cardvalid = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Payment_orderID = new System.Windows.Forms.Label();
            this.Payment_vat = new System.Windows.Forms.Label();
            this.Home_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Payment_firstname
            // 
            this.Payment_firstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Payment_firstname.Location = new System.Drawing.Point(14, 70);
            this.Payment_firstname.Name = "Payment_firstname";
            this.Payment_firstname.Size = new System.Drawing.Size(240, 62);
            this.Payment_firstname.TabIndex = 0;
            this.Payment_firstname.TextChanged += new System.EventHandler(this.Payment_firstname_TextChanged);
            // 
            // Payment_lastname
            // 
            this.Payment_lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Payment_lastname.Location = new System.Drawing.Point(419, 70);
            this.Payment_lastname.Name = "Payment_lastname";
            this.Payment_lastname.Size = new System.Drawing.Size(209, 62);
            this.Payment_lastname.TabIndex = 1;
            this.Payment_lastname.TextChanged += new System.EventHandler(this.Payment_lastname_TextChanged);
            // 
            // Payment_cardnumber
            // 
            this.Payment_cardnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Payment_cardnumber.Location = new System.Drawing.Point(14, 213);
            this.Payment_cardnumber.Name = "Payment_cardnumber";
            this.Payment_cardnumber.PasswordChar = '*';
            this.Payment_cardnumber.Size = new System.Drawing.Size(269, 62);
            this.Payment_cardnumber.TabIndex = 2;
            this.Payment_cardnumber.TextChanged += new System.EventHandler(this.Payment_cardnumber_TextChanged);
            // 
            // Payment_cvv
            // 
            this.Payment_cvv.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Payment_cvv.Location = new System.Drawing.Point(760, 100);
            this.Payment_cvv.Name = "Payment_cvv";
            this.Payment_cvv.PasswordChar = '*';
            this.Payment_cvv.Size = new System.Drawing.Size(100, 62);
            this.Payment_cvv.TabIndex = 3;
            this.Payment_cvv.TextChanged += new System.EventHandler(this.Payment_cvv_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 55);
            this.label1.TabIndex = 5;
            this.label1.Text = "First name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(409, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 55);
            this.label2.TabIndex = 6;
            this.label2.Text = "Last name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(306, 55);
            this.label3.TabIndex = 7;
            this.label3.Text = "Card number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(750, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 55);
            this.label4.TabIndex = 8;
            this.label4.Text = "cvv";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(409, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(272, 55);
            this.label5.TabIndex = 9;
            this.label5.Text = "Expiry Date";
            // 
            // Payment_price
            // 
            this.Payment_price.AutoSize = true;
            this.Payment_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Payment_price.Location = new System.Drawing.Point(15, 282);
            this.Payment_price.Name = "Payment_price";
            this.Payment_price.Size = new System.Drawing.Size(133, 55);
            this.Payment_price.TabIndex = 10;
            this.Payment_price.Text = "Price";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Payment_cvvvalid);
            this.panel1.Controls.Add(this.Payment_lastvalid);
            this.panel1.Controls.Add(this.Payment_firstvalid);
            this.panel1.Controls.Add(this.Payment_pay);
            this.panel1.Controls.Add(this.Payment_dateTimePicker);
            this.panel1.Controls.Add(this.Payment_cardvalid);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Payment_firstname);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Payment_lastname);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Payment_cardnumber);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Payment_cvv);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(23, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(997, 533);
            this.panel1.TabIndex = 11;
            // 
            // Payment_cvvvalid
            // 
            this.Payment_cvvvalid.AutoSize = true;
            this.Payment_cvvvalid.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Payment_cvvvalid.Location = new System.Drawing.Point(879, 124);
            this.Payment_cvvvalid.Name = "Payment_cvvvalid";
            this.Payment_cvvvalid.Size = new System.Drawing.Size(15, 14);
            this.Payment_cvvvalid.TabIndex = 18;
            this.Payment_cvvvalid.UseVisualStyleBackColor = true;
            // 
            // Payment_lastvalid
            // 
            this.Payment_lastvalid.AutoSize = true;
            this.Payment_lastvalid.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Payment_lastvalid.Location = new System.Drawing.Point(643, 94);
            this.Payment_lastvalid.Name = "Payment_lastvalid";
            this.Payment_lastvalid.Size = new System.Drawing.Size(15, 14);
            this.Payment_lastvalid.TabIndex = 17;
            this.Payment_lastvalid.UseVisualStyleBackColor = true;
            // 
            // Payment_firstvalid
            // 
            this.Payment_firstvalid.AutoSize = true;
            this.Payment_firstvalid.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Payment_firstvalid.Location = new System.Drawing.Point(281, 94);
            this.Payment_firstvalid.Name = "Payment_firstvalid";
            this.Payment_firstvalid.Size = new System.Drawing.Size(15, 14);
            this.Payment_firstvalid.TabIndex = 16;
            this.Payment_firstvalid.UseVisualStyleBackColor = true;
            // 
            // Payment_pay
            // 
            this.Payment_pay.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Payment_pay.Location = new System.Drawing.Point(14, 414);
            this.Payment_pay.Name = "Payment_pay";
            this.Payment_pay.Size = new System.Drawing.Size(962, 91);
            this.Payment_pay.TabIndex = 15;
            this.Payment_pay.Text = "Pay";
            this.Payment_pay.UseVisualStyleBackColor = true;
            this.Payment_pay.Click += new System.EventHandler(this.Payment_pay_Click);
            // 
            // Payment_dateTimePicker
            // 
            this.Payment_dateTimePicker.CustomFormat = "MM/yyyy";
            this.Payment_dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Payment_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Payment_dateTimePicker.Location = new System.Drawing.Point(419, 230);
            this.Payment_dateTimePicker.Name = "Payment_dateTimePicker";
            this.Payment_dateTimePicker.Size = new System.Drawing.Size(222, 62);
            this.Payment_dateTimePicker.TabIndex = 14;
            this.Payment_dateTimePicker.Value = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            // 
            // Payment_cardvalid
            // 
            this.Payment_cardvalid.AutoCheck = false;
            this.Payment_cardvalid.AutoSize = true;
            this.Payment_cardvalid.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Payment_cardvalid.Location = new System.Drawing.Point(295, 230);
            this.Payment_cardvalid.Name = "Payment_cardvalid";
            this.Payment_cardvalid.Size = new System.Drawing.Size(15, 14);
            this.Payment_cardvalid.TabIndex = 13;
            this.Payment_cardvalid.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Home_button);
            this.panel2.Controls.Add(this.Payment_orderID);
            this.panel2.Controls.Add(this.Payment_vat);
            this.panel2.Controls.Add(this.Payment_price);
            this.panel2.Location = new System.Drawing.Point(1041, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(332, 548);
            this.panel2.TabIndex = 12;
            // 
            // Payment_orderID
            // 
            this.Payment_orderID.AutoSize = true;
            this.Payment_orderID.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Payment_orderID.Location = new System.Drawing.Point(9, 122);
            this.Payment_orderID.Name = "Payment_orderID";
            this.Payment_orderID.Size = new System.Drawing.Size(195, 55);
            this.Payment_orderID.TabIndex = 12;
            this.Payment_orderID.Text = "OrderID";
            // 
            // Payment_vat
            // 
            this.Payment_vat.AutoSize = true;
            this.Payment_vat.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Payment_vat.Location = new System.Drawing.Point(9, 204);
            this.Payment_vat.Name = "Payment_vat";
            this.Payment_vat.Size = new System.Drawing.Size(117, 55);
            this.Payment_vat.TabIndex = 11;
            this.Payment_vat.Text = "VAT";
            // 
            // Home_button
            // 
            this.Home_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home_button.Location = new System.Drawing.Point(12, 357);
            this.Home_button.Name = "Home_button";
            this.Home_button.Size = new System.Drawing.Size(308, 154);
            this.Home_button.TabIndex = 24;
            this.Home_button.Text = "Home";
            this.Home_button.UseVisualStyleBackColor = true;
            this.Home_button.Click += new System.EventHandler(this.Home_button_Click);
            // 
            // Payment_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1385, 650);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Payment_page";
            this.Text = "Payment";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox Payment_firstname;
        private System.Windows.Forms.TextBox Payment_lastname;
        private System.Windows.Forms.TextBox Payment_cardnumber;
        private System.Windows.Forms.TextBox Payment_cvv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Payment_price;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox Payment_cardvalid;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Payment_orderID;
        private System.Windows.Forms.Label Payment_vat;
        private System.Windows.Forms.DateTimePicker Payment_dateTimePicker;
        private System.Windows.Forms.Button Payment_pay;
        private System.Windows.Forms.CheckBox Payment_cvvvalid;
        private System.Windows.Forms.CheckBox Payment_lastvalid;
        private System.Windows.Forms.CheckBox Payment_firstvalid;
        private System.Windows.Forms.Button Home_button;
    }
}