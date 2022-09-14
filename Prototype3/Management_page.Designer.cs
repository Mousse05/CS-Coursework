namespace Prototype3
{
    partial class Management_page
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
            this.Management_datagrid = new System.Windows.Forms.DataGridView();
            this.Management_orderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Management_Info = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Management_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Management_accepted = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Management_delivered = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Management_datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Management_datagrid
            // 
            this.Management_datagrid.AllowUserToAddRows = false;
            this.Management_datagrid.AllowUserToDeleteRows = false;
            this.Management_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Management_datagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Management_orderID,
            this.Management_Info,
            this.Management_date,
            this.Management_accepted,
            this.Management_delivered});
            this.Management_datagrid.Location = new System.Drawing.Point(0, 0);
            this.Management_datagrid.Name = "Management_datagrid";
            this.Management_datagrid.RowHeadersWidth = 62;
            this.Management_datagrid.RowTemplate.Height = 28;
            this.Management_datagrid.Size = new System.Drawing.Size(813, 365);
            this.Management_datagrid.TabIndex = 0;
            // 
            // Management_orderID
            // 
            this.Management_orderID.HeaderText = "OrderID";
            this.Management_orderID.MinimumWidth = 8;
            this.Management_orderID.Name = "Management_orderID";
            this.Management_orderID.Width = 150;
            // 
            // Management_Info
            // 
            this.Management_Info.HeaderText = "Order info";
            this.Management_Info.MinimumWidth = 8;
            this.Management_Info.Name = "Management_Info";
            this.Management_Info.Width = 150;
            // 
            // Management_date
            // 
            this.Management_date.HeaderText = "Order date";
            this.Management_date.MinimumWidth = 8;
            this.Management_date.Name = "Management_date";
            this.Management_date.Width = 150;
            // 
            // Management_accepted
            // 
            this.Management_accepted.HeaderText = "Accepted";
            this.Management_accepted.MinimumWidth = 8;
            this.Management_accepted.Name = "Management_accepted";
            this.Management_accepted.Width = 150;
            // 
            // Management_delivered
            // 
            this.Management_delivered.HeaderText = "Delivered";
            this.Management_delivered.MinimumWidth = 8;
            this.Management_delivered.Name = "Management_delivered";
            this.Management_delivered.Width = 150;
            // 
            // Management_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 692);
            this.Controls.Add(this.Management_datagrid);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Management_page";
            this.Text = "Management_page";
            ((System.ComponentModel.ISupportInitialize)(this.Management_datagrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Management_datagrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Management_orderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Management_Info;
        private System.Windows.Forms.DataGridViewTextBoxColumn Management_date;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Management_accepted;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Management_delivered;
    }
}