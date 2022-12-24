namespace Prototype4
{
    partial class Mytask_page
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
            this.Mytask_dataGridView = new System.Windows.Forms.DataGridView();
            this.Tasks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Team_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Order_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mytask_panelorder = new System.Windows.Forms.Panel();
            this.Home_button = new System.Windows.Forms.Button();
            this.Mytask_info = new System.Windows.Forms.TextBox();
            this.Mytask_delivered = new System.Windows.Forms.CheckBox();
            this.Mytask_Accepted = new System.Windows.Forms.CheckBox();
            this.Mytask_date = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Mytask_OrderID = new System.Windows.Forms.TextBox();
            this.Mytask_search = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Mytask_save = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Mytask_taskID = new System.Windows.Forms.TextBox();
            this.Mytask_Complete = new System.Windows.Forms.Button();
            this.Mytask_InfoID = new System.Windows.Forms.TextBox();
            this.Mytask_refresh = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Mytask_acceptorder = new System.Windows.Forms.Button();
            this.Mytask_ID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Mytask_employeeinfo = new System.Windows.Forms.TextBox();
            this.Mytask_customerinfo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Mytask_dataGridView)).BeginInit();
            this.Mytask_panelorder.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Mytask_dataGridView
            // 
            this.Mytask_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Mytask_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tasks,
            this.Team_ID,
            this.Order_ID});
            this.Mytask_dataGridView.Location = new System.Drawing.Point(0, 0);
            this.Mytask_dataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.Mytask_dataGridView.Name = "Mytask_dataGridView";
            this.Mytask_dataGridView.RowHeadersWidth = 62;
            this.Mytask_dataGridView.RowTemplate.Height = 28;
            this.Mytask_dataGridView.Size = new System.Drawing.Size(543, 641);
            this.Mytask_dataGridView.TabIndex = 0;
            // 
            // Tasks
            // 
            this.Tasks.HeaderText = "Tasks";
            this.Tasks.MinimumWidth = 8;
            this.Tasks.Name = "Tasks";
            this.Tasks.ReadOnly = true;
            this.Tasks.Width = 150;
            // 
            // Team_ID
            // 
            this.Team_ID.HeaderText = "Team_ID";
            this.Team_ID.MinimumWidth = 8;
            this.Team_ID.Name = "Team_ID";
            this.Team_ID.ReadOnly = true;
            this.Team_ID.Width = 150;
            // 
            // Order_ID
            // 
            this.Order_ID.HeaderText = "Order_ID";
            this.Order_ID.MinimumWidth = 8;
            this.Order_ID.Name = "Order_ID";
            this.Order_ID.ReadOnly = true;
            this.Order_ID.Width = 150;
            // 
            // Mytask_panelorder
            // 
            this.Mytask_panelorder.AllowDrop = true;
            this.Mytask_panelorder.Controls.Add(this.label6);
            this.Mytask_panelorder.Controls.Add(this.Home_button);
            this.Mytask_panelorder.Controls.Add(this.Mytask_info);
            this.Mytask_panelorder.Controls.Add(this.Mytask_delivered);
            this.Mytask_panelorder.Controls.Add(this.Mytask_Accepted);
            this.Mytask_panelorder.Controls.Add(this.Mytask_date);
            this.Mytask_panelorder.Controls.Add(this.label1);
            this.Mytask_panelorder.Controls.Add(this.Mytask_OrderID);
            this.Mytask_panelorder.Controls.Add(this.Mytask_search);
            this.Mytask_panelorder.Location = new System.Drawing.Point(547, 0);
            this.Mytask_panelorder.Margin = new System.Windows.Forms.Padding(2);
            this.Mytask_panelorder.Name = "Mytask_panelorder";
            this.Mytask_panelorder.Size = new System.Drawing.Size(845, 210);
            this.Mytask_panelorder.TabIndex = 1;
            // 
            // Home_button
            // 
            this.Home_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home_button.Location = new System.Drawing.Point(626, 8);
            this.Home_button.Name = "Home_button";
            this.Home_button.Size = new System.Drawing.Size(216, 199);
            this.Home_button.TabIndex = 22;
            this.Home_button.Text = "Home";
            this.Home_button.UseVisualStyleBackColor = true;
            this.Home_button.Click += new System.EventHandler(this.Home_button_Click);
            // 
            // Mytask_info
            // 
            this.Mytask_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mytask_info.Location = new System.Drawing.Point(10, 102);
            this.Mytask_info.Margin = new System.Windows.Forms.Padding(2);
            this.Mytask_info.Multiline = true;
            this.Mytask_info.Name = "Mytask_info";
            this.Mytask_info.ReadOnly = true;
            this.Mytask_info.Size = new System.Drawing.Size(155, 95);
            this.Mytask_info.TabIndex = 7;
            // 
            // Mytask_delivered
            // 
            this.Mytask_delivered.AutoSize = true;
            this.Mytask_delivered.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mytask_delivered.Location = new System.Drawing.Point(168, 157);
            this.Mytask_delivered.Margin = new System.Windows.Forms.Padding(2);
            this.Mytask_delivered.Name = "Mytask_delivered";
            this.Mytask_delivered.Size = new System.Drawing.Size(122, 29);
            this.Mytask_delivered.TabIndex = 6;
            this.Mytask_delivered.Text = "Delivered";
            this.Mytask_delivered.UseVisualStyleBackColor = true;
            // 
            // Mytask_Accepted
            // 
            this.Mytask_Accepted.AutoSize = true;
            this.Mytask_Accepted.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mytask_Accepted.Location = new System.Drawing.Point(168, 127);
            this.Mytask_Accepted.Margin = new System.Windows.Forms.Padding(2);
            this.Mytask_Accepted.Name = "Mytask_Accepted";
            this.Mytask_Accepted.Size = new System.Drawing.Size(121, 29);
            this.Mytask_Accepted.TabIndex = 5;
            this.Mytask_Accepted.Text = "Accepted";
            this.Mytask_Accepted.UseVisualStyleBackColor = true;
            // 
            // Mytask_date
            // 
            this.Mytask_date.AutoSize = true;
            this.Mytask_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mytask_date.Location = new System.Drawing.Point(165, 98);
            this.Mytask_date.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Mytask_date.Name = "Mytask_date";
            this.Mytask_date.Size = new System.Drawing.Size(155, 25);
            this.Mytask_date.TabIndex = 4;
            this.Mytask_date.Text = "Date of order : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Order Info";
            // 
            // Mytask_OrderID
            // 
            this.Mytask_OrderID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mytask_OrderID.Location = new System.Drawing.Point(3, 28);
            this.Mytask_OrderID.Margin = new System.Windows.Forms.Padding(2);
            this.Mytask_OrderID.Name = "Mytask_OrderID";
            this.Mytask_OrderID.Size = new System.Drawing.Size(180, 31);
            this.Mytask_OrderID.TabIndex = 1;
            // 
            // Mytask_search
            // 
            this.Mytask_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mytask_search.Location = new System.Drawing.Point(187, 28);
            this.Mytask_search.Margin = new System.Windows.Forms.Padding(2);
            this.Mytask_search.Name = "Mytask_search";
            this.Mytask_search.Size = new System.Drawing.Size(158, 31);
            this.Mytask_search.TabIndex = 0;
            this.Mytask_search.Text = "Search";
            this.Mytask_search.UseVisualStyleBackColor = true;
            this.Mytask_search.Click += new System.EventHandler(this.Mytask_search_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Mytask_save);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.Mytask_taskID);
            this.panel2.Controls.Add(this.Mytask_Complete);
            this.panel2.Controls.Add(this.Mytask_InfoID);
            this.panel2.Controls.Add(this.Mytask_refresh);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.Mytask_acceptorder);
            this.panel2.Controls.Add(this.Mytask_ID);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.Mytask_employeeinfo);
            this.panel2.Controls.Add(this.Mytask_customerinfo);
            this.panel2.Location = new System.Drawing.Point(548, 215);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(844, 443);
            this.panel2.TabIndex = 2;
            // 
            // Mytask_save
            // 
            this.Mytask_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mytask_save.Location = new System.Drawing.Point(2, 356);
            this.Mytask_save.Margin = new System.Windows.Forms.Padding(2);
            this.Mytask_save.Name = "Mytask_save";
            this.Mytask_save.Size = new System.Drawing.Size(424, 67);
            this.Mytask_save.TabIndex = 12;
            this.Mytask_save.Text = "Save";
            this.Mytask_save.UseVisualStyleBackColor = true;
            this.Mytask_save.Click += new System.EventHandler(this.Mytask_save_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(430, 354);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Task ID";
            // 
            // Mytask_taskID
            // 
            this.Mytask_taskID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mytask_taskID.Location = new System.Drawing.Point(430, 381);
            this.Mytask_taskID.Margin = new System.Windows.Forms.Padding(2);
            this.Mytask_taskID.Multiline = true;
            this.Mytask_taskID.Name = "Mytask_taskID";
            this.Mytask_taskID.Size = new System.Drawing.Size(201, 42);
            this.Mytask_taskID.TabIndex = 10;
            // 
            // Mytask_Complete
            // 
            this.Mytask_Complete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mytask_Complete.Location = new System.Drawing.Point(635, 356);
            this.Mytask_Complete.Margin = new System.Windows.Forms.Padding(2);
            this.Mytask_Complete.Name = "Mytask_Complete";
            this.Mytask_Complete.Size = new System.Drawing.Size(191, 67);
            this.Mytask_Complete.TabIndex = 3;
            this.Mytask_Complete.Text = "Task Complete";
            this.Mytask_Complete.UseVisualStyleBackColor = true;
            this.Mytask_Complete.Click += new System.EventHandler(this.Mytask_Complete_Click);
            // 
            // Mytask_InfoID
            // 
            this.Mytask_InfoID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mytask_InfoID.Location = new System.Drawing.Point(441, 6);
            this.Mytask_InfoID.Margin = new System.Windows.Forms.Padding(2);
            this.Mytask_InfoID.Multiline = true;
            this.Mytask_InfoID.Name = "Mytask_InfoID";
            this.Mytask_InfoID.Size = new System.Drawing.Size(148, 40);
            this.Mytask_InfoID.TabIndex = 3;
            // 
            // Mytask_refresh
            // 
            this.Mytask_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mytask_refresh.Location = new System.Drawing.Point(606, 6);
            this.Mytask_refresh.Margin = new System.Windows.Forms.Padding(2);
            this.Mytask_refresh.Name = "Mytask_refresh";
            this.Mytask_refresh.Size = new System.Drawing.Size(235, 52);
            this.Mytask_refresh.TabIndex = 3;
            this.Mytask_refresh.Text = "Search/Refresh";
            this.Mytask_refresh.UseVisualStyleBackColor = true;
            this.Mytask_refresh.Click += new System.EventHandler(this.Mytask_refresh_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 6);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Order ID";
            // 
            // Mytask_acceptorder
            // 
            this.Mytask_acceptorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mytask_acceptorder.Location = new System.Drawing.Point(243, 6);
            this.Mytask_acceptorder.Margin = new System.Windows.Forms.Padding(2);
            this.Mytask_acceptorder.Name = "Mytask_acceptorder";
            this.Mytask_acceptorder.Size = new System.Drawing.Size(183, 50);
            this.Mytask_acceptorder.TabIndex = 8;
            this.Mytask_acceptorder.Text = "Accept order";
            this.Mytask_acceptorder.UseVisualStyleBackColor = true;
            this.Mytask_acceptorder.Click += new System.EventHandler(this.Mytask_acceptorder_Click);
            // 
            // Mytask_ID
            // 
            this.Mytask_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mytask_ID.Location = new System.Drawing.Point(10, 25);
            this.Mytask_ID.Margin = new System.Windows.Forms.Padding(2);
            this.Mytask_ID.Multiline = true;
            this.Mytask_ID.Name = "Mytask_ID";
            this.Mytask_ID.Size = new System.Drawing.Size(229, 31);
            this.Mytask_ID.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(438, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(302, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Employee Question/Response";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(299, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Customer Question/Response";
            // 
            // Mytask_employeeinfo
            // 
            this.Mytask_employeeinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mytask_employeeinfo.Location = new System.Drawing.Point(430, 90);
            this.Mytask_employeeinfo.Margin = new System.Windows.Forms.Padding(2);
            this.Mytask_employeeinfo.Multiline = true;
            this.Mytask_employeeinfo.Name = "Mytask_employeeinfo";
            this.Mytask_employeeinfo.Size = new System.Drawing.Size(406, 258);
            this.Mytask_employeeinfo.TabIndex = 4;
            // 
            // Mytask_customerinfo
            // 
            this.Mytask_customerinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mytask_customerinfo.Location = new System.Drawing.Point(9, 90);
            this.Mytask_customerinfo.Margin = new System.Windows.Forms.Padding(2);
            this.Mytask_customerinfo.Multiline = true;
            this.Mytask_customerinfo.Name = "Mytask_customerinfo";
            this.Mytask_customerinfo.ReadOnly = true;
            this.Mytask_customerinfo.Size = new System.Drawing.Size(417, 258);
            this.Mytask_customerinfo.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1, 1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 25);
            this.label6.TabIndex = 23;
            this.label6.Text = "Order ID";
            // 
            // Mytask_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1395, 652);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Mytask_panelorder);
            this.Controls.Add(this.Mytask_dataGridView);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Mytask_page";
            this.Text = "Mytask_page";
            ((System.ComponentModel.ISupportInitialize)(this.Mytask_dataGridView)).EndInit();
            this.Mytask_panelorder.ResumeLayout(false);
            this.Mytask_panelorder.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Mytask_dataGridView;
        private System.Windows.Forms.Panel Mytask_panelorder;
        private System.Windows.Forms.TextBox Mytask_OrderID;
        private System.Windows.Forms.Button Mytask_search;
        private System.Windows.Forms.CheckBox Mytask_delivered;
        private System.Windows.Forms.CheckBox Mytask_Accepted;
        private System.Windows.Forms.Label Mytask_date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Mytask_info;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox Mytask_customerinfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Mytask_acceptorder;
        private System.Windows.Forms.TextBox Mytask_ID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Mytask_employeeinfo;
        private System.Windows.Forms.Button Mytask_refresh;
        private System.Windows.Forms.TextBox Mytask_InfoID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Mytask_taskID;
        private System.Windows.Forms.Button Mytask_Complete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tasks;
        private System.Windows.Forms.DataGridViewTextBoxColumn Team_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order_ID;
        private System.Windows.Forms.Button Mytask_save;
        private System.Windows.Forms.Button Home_button;
        private System.Windows.Forms.Label label6;
    }
}