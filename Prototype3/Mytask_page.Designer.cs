namespace Prototype3
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
            this.Mytask_panelorder = new System.Windows.Forms.Panel();
            this.Mytask_info = new System.Windows.Forms.TextBox();
            this.Mytask_delivered = new System.Windows.Forms.CheckBox();
            this.Mytask_Accepted = new System.Windows.Forms.CheckBox();
            this.Mytask_date = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Mytask_OrderID = new System.Windows.Forms.TextBox();
            this.Mytask_search = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
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
            this.Tasks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Team_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Order_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.Mytask_dataGridView.Name = "Mytask_dataGridView";
            this.Mytask_dataGridView.RowHeadersWidth = 62;
            this.Mytask_dataGridView.RowTemplate.Height = 28;
            this.Mytask_dataGridView.Size = new System.Drawing.Size(814, 715);
            this.Mytask_dataGridView.TabIndex = 0;
            // 
            // Mytask_panelorder
            // 
            this.Mytask_panelorder.AllowDrop = true;
            this.Mytask_panelorder.Controls.Add(this.Mytask_info);
            this.Mytask_panelorder.Controls.Add(this.Mytask_delivered);
            this.Mytask_panelorder.Controls.Add(this.Mytask_Accepted);
            this.Mytask_panelorder.Controls.Add(this.Mytask_date);
            this.Mytask_panelorder.Controls.Add(this.label1);
            this.Mytask_panelorder.Controls.Add(this.Mytask_OrderID);
            this.Mytask_panelorder.Controls.Add(this.Mytask_search);
            this.Mytask_panelorder.Location = new System.Drawing.Point(820, 0);
            this.Mytask_panelorder.Name = "Mytask_panelorder";
            this.Mytask_panelorder.Size = new System.Drawing.Size(586, 246);
            this.Mytask_panelorder.TabIndex = 1;
            // 
            // Mytask_info
            // 
            this.Mytask_info.Location = new System.Drawing.Point(16, 95);
            this.Mytask_info.Multiline = true;
            this.Mytask_info.Name = "Mytask_info";
            this.Mytask_info.Size = new System.Drawing.Size(230, 144);
            this.Mytask_info.TabIndex = 7;
            // 
            // Mytask_delivered
            // 
            this.Mytask_delivered.AutoSize = true;
            this.Mytask_delivered.Location = new System.Drawing.Point(254, 168);
            this.Mytask_delivered.Name = "Mytask_delivered";
            this.Mytask_delivered.Size = new System.Drawing.Size(101, 24);
            this.Mytask_delivered.TabIndex = 6;
            this.Mytask_delivered.Text = "Delivered";
            this.Mytask_delivered.UseVisualStyleBackColor = true;
            // 
            // Mytask_Accepted
            // 
            this.Mytask_Accepted.AutoSize = true;
            this.Mytask_Accepted.Location = new System.Drawing.Point(254, 123);
            this.Mytask_Accepted.Name = "Mytask_Accepted";
            this.Mytask_Accepted.Size = new System.Drawing.Size(103, 24);
            this.Mytask_Accepted.TabIndex = 5;
            this.Mytask_Accepted.Text = "Accepted";
            this.Mytask_Accepted.UseVisualStyleBackColor = true;
            // 
            // Mytask_date
            // 
            this.Mytask_date.AutoSize = true;
            this.Mytask_date.Location = new System.Drawing.Point(249, 89);
            this.Mytask_date.Name = "Mytask_date";
            this.Mytask_date.Size = new System.Drawing.Size(115, 20);
            this.Mytask_date.TabIndex = 4;
            this.Mytask_date.Text = "Date of order : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Order Info";
            // 
            // Mytask_OrderID
            // 
            this.Mytask_OrderID.Location = new System.Drawing.Point(16, 12);
            this.Mytask_OrderID.Name = "Mytask_OrderID";
            this.Mytask_OrderID.Size = new System.Drawing.Size(100, 26);
            this.Mytask_OrderID.TabIndex = 1;
            // 
            // Mytask_search
            // 
            this.Mytask_search.Location = new System.Drawing.Point(136, 12);
            this.Mytask_search.Name = "Mytask_search";
            this.Mytask_search.Size = new System.Drawing.Size(75, 31);
            this.Mytask_search.TabIndex = 0;
            this.Mytask_search.Text = "Search";
            this.Mytask_search.UseVisualStyleBackColor = true;
            this.Mytask_search.Click += new System.EventHandler(this.Mytask_search_Click);
            // 
            // panel2
            // 
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
            this.panel2.Location = new System.Drawing.Point(822, 249);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(585, 477);
            this.panel2.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 424);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Task ID";
            // 
            // Mytask_taskID
            // 
            this.Mytask_taskID.Location = new System.Drawing.Point(123, 424);
            this.Mytask_taskID.Name = "Mytask_taskID";
            this.Mytask_taskID.Size = new System.Drawing.Size(181, 26);
            this.Mytask_taskID.TabIndex = 10;
            // 
            // Mytask_Complete
            // 
            this.Mytask_Complete.Location = new System.Drawing.Point(310, 409);
            this.Mytask_Complete.Name = "Mytask_Complete";
            this.Mytask_Complete.Size = new System.Drawing.Size(264, 57);
            this.Mytask_Complete.TabIndex = 3;
            this.Mytask_Complete.Text = "Task Complete";
            this.Mytask_Complete.UseVisualStyleBackColor = true;
            this.Mytask_Complete.Click += new System.EventHandler(this.Mytask_Complete_Click);
            // 
            // Mytask_InfoID
            // 
            this.Mytask_InfoID.Location = new System.Drawing.Point(310, 39);
            this.Mytask_InfoID.Name = "Mytask_InfoID";
            this.Mytask_InfoID.Size = new System.Drawing.Size(125, 26);
            this.Mytask_InfoID.TabIndex = 3;
            // 
            // Mytask_refresh
            // 
            this.Mytask_refresh.Location = new System.Drawing.Point(441, 32);
            this.Mytask_refresh.Name = "Mytask_refresh";
            this.Mytask_refresh.Size = new System.Drawing.Size(131, 39);
            this.Mytask_refresh.TabIndex = 3;
            this.Mytask_refresh.Text = "Search/Refresh";
            this.Mytask_refresh.UseVisualStyleBackColor = true;
            this.Mytask_refresh.Click += new System.EventHandler(this.Mytask_refresh_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Order ID";
            // 
            // Mytask_acceptorder
            // 
            this.Mytask_acceptorder.Location = new System.Drawing.Point(162, 32);
            this.Mytask_acceptorder.Name = "Mytask_acceptorder";
            this.Mytask_acceptorder.Size = new System.Drawing.Size(126, 39);
            this.Mytask_acceptorder.TabIndex = 8;
            this.Mytask_acceptorder.Text = "Accept order";
            this.Mytask_acceptorder.UseVisualStyleBackColor = true;
            this.Mytask_acceptorder.Click += new System.EventHandler(this.Mytask_acceptorder_Click);
            // 
            // Mytask_ID
            // 
            this.Mytask_ID.Location = new System.Drawing.Point(15, 38);
            this.Mytask_ID.Name = "Mytask_ID";
            this.Mytask_ID.Size = new System.Drawing.Size(141, 26);
            this.Mytask_ID.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(311, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Employee response";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Customer infomation";
            // 
            // Mytask_employeeinfo
            // 
            this.Mytask_employeeinfo.Location = new System.Drawing.Point(310, 112);
            this.Mytask_employeeinfo.Multiline = true;
            this.Mytask_employeeinfo.Name = "Mytask_employeeinfo";
            this.Mytask_employeeinfo.Size = new System.Drawing.Size(272, 291);
            this.Mytask_employeeinfo.TabIndex = 4;
            // 
            // Mytask_customerinfo
            // 
            this.Mytask_customerinfo.Location = new System.Drawing.Point(14, 112);
            this.Mytask_customerinfo.Multiline = true;
            this.Mytask_customerinfo.Name = "Mytask_customerinfo";
            this.Mytask_customerinfo.Size = new System.Drawing.Size(290, 291);
            this.Mytask_customerinfo.TabIndex = 3;
            // 
            // Tasks
            // 
            this.Tasks.HeaderText = "Tasks";
            this.Tasks.MinimumWidth = 8;
            this.Tasks.Name = "Tasks";
            this.Tasks.Width = 150;
            // 
            // Team_ID
            // 
            this.Team_ID.HeaderText = "Team_ID";
            this.Team_ID.MinimumWidth = 8;
            this.Team_ID.Name = "Team_ID";
            this.Team_ID.Width = 150;
            // 
            // Order_ID
            // 
            this.Order_ID.HeaderText = "Order_ID";
            this.Order_ID.MinimumWidth = 8;
            this.Order_ID.Name = "Order_ID";
            this.Order_ID.Width = 150;
            // 
            // Mytask_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1408, 727);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Mytask_panelorder);
            this.Controls.Add(this.Mytask_dataGridView);
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
    }
}