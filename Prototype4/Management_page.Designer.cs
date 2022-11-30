namespace Prototype4
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
            this.Task = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Team_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Order_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Info = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Order_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Accepted = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Delivered = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Management_save = new System.Windows.Forms.Button();
            this.Managemnet_comboBox = new System.Windows.Forms.ComboBox();
            this.Home_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Management_datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Management_datagrid
            // 
            this.Management_datagrid.AllowUserToAddRows = false;
            this.Management_datagrid.AllowUserToDeleteRows = false;
            this.Management_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Management_datagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Task,
            this.Team_ID,
            this.Order_ID,
            this.User_ID,
            this.Info,
            this.Order_date,
            this.Accepted,
            this.Delivered});
            this.Management_datagrid.Location = new System.Drawing.Point(0, 0);
            this.Management_datagrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Management_datagrid.Name = "Management_datagrid";
            this.Management_datagrid.RowHeadersWidth = 62;
            this.Management_datagrid.RowTemplate.Height = 28;
            this.Management_datagrid.Size = new System.Drawing.Size(874, 355);
            this.Management_datagrid.TabIndex = 0;
            // 
            // Task
            // 
            this.Task.HeaderText = "Task";
            this.Task.MinimumWidth = 8;
            this.Task.Name = "Task";
            this.Task.Width = 150;
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
            this.Order_ID.HeaderText = "Order ID";
            this.Order_ID.MinimumWidth = 8;
            this.Order_ID.Name = "Order_ID";
            this.Order_ID.ReadOnly = true;
            this.Order_ID.Width = 150;
            // 
            // User_ID
            // 
            this.User_ID.HeaderText = "User ID";
            this.User_ID.MinimumWidth = 8;
            this.User_ID.Name = "User_ID";
            this.User_ID.ReadOnly = true;
            this.User_ID.Width = 150;
            // 
            // Info
            // 
            this.Info.HeaderText = "Order info";
            this.Info.MinimumWidth = 8;
            this.Info.Name = "Info";
            this.Info.ReadOnly = true;
            this.Info.Width = 200;
            // 
            // Order_date
            // 
            this.Order_date.HeaderText = "Order date";
            this.Order_date.MinimumWidth = 8;
            this.Order_date.Name = "Order_date";
            this.Order_date.ReadOnly = true;
            this.Order_date.Width = 150;
            // 
            // Accepted
            // 
            this.Accepted.HeaderText = "Accepted";
            this.Accepted.MinimumWidth = 8;
            this.Accepted.Name = "Accepted";
            this.Accepted.Width = 80;
            // 
            // Delivered
            // 
            this.Delivered.HeaderText = "Delivered";
            this.Delivered.MinimumWidth = 8;
            this.Delivered.Name = "Delivered";
            this.Delivered.Width = 80;
            // 
            // Management_save
            // 
            this.Management_save.Location = new System.Drawing.Point(11, 359);
            this.Management_save.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Management_save.Name = "Management_save";
            this.Management_save.Size = new System.Drawing.Size(57, 27);
            this.Management_save.TabIndex = 1;
            this.Management_save.Text = "Save";
            this.Management_save.UseVisualStyleBackColor = true;
            this.Management_save.Click += new System.EventHandler(this.Management_save_Click);
            // 
            // Managemnet_comboBox
            // 
            this.Managemnet_comboBox.FormattingEnabled = true;
            this.Managemnet_comboBox.Items.AddRange(new object[] {
            "Order",
            "Tasks",
            "Teams"});
            this.Managemnet_comboBox.Location = new System.Drawing.Point(81, 364);
            this.Managemnet_comboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Managemnet_comboBox.Name = "Managemnet_comboBox";
            this.Managemnet_comboBox.Size = new System.Drawing.Size(99, 21);
            this.Managemnet_comboBox.TabIndex = 2;
            this.Managemnet_comboBox.SelectedIndexChanged += new System.EventHandler(this.Managemnet_comboBox_SelectedIndexChanged);
            // 
            // Home_button
            // 
            this.Home_button.Location = new System.Drawing.Point(756, 359);
            this.Home_button.Name = "Home_button";
            this.Home_button.Size = new System.Drawing.Size(118, 43);
            this.Home_button.TabIndex = 21;
            this.Home_button.Text = "Home";
            this.Home_button.UseVisualStyleBackColor = true;
            this.Home_button.Click += new System.EventHandler(this.Home_button_Click);
            // 
            // Management_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 450);
            this.Controls.Add(this.Home_button);
            this.Controls.Add(this.Managemnet_comboBox);
            this.Controls.Add(this.Management_save);
            this.Controls.Add(this.Management_datagrid);
            this.Name = "Management_page";
            this.Text = "Management_page";
            ((System.ComponentModel.ISupportInitialize)(this.Management_datagrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Management_datagrid;
        private System.Windows.Forms.Button Management_save;
        private System.Windows.Forms.ComboBox Managemnet_comboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Task;
        private System.Windows.Forms.DataGridViewTextBoxColumn Team_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Info;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order_date;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Accepted;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Delivered;
        private System.Windows.Forms.Button Home_button;
    }
}