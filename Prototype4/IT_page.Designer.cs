﻿namespace Prototype4
{
    partial class IT_page
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
            this.IT_datagrid = new System.Windows.Forms.DataGridView();
            this.IT_save = new System.Windows.Forms.Button();
            this.IT_comboBox = new System.Windows.Forms.ComboBox();
            this.Home_button = new System.Windows.Forms.Button();
            this.Team_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Priority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.IT_datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // IT_datagrid
            // 
            this.IT_datagrid.AllowUserToAddRows = false;
            this.IT_datagrid.AllowUserToDeleteRows = false;
            this.IT_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IT_datagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Team_ID,
            this.User_ID,
            this.Username,
            this.Password,
            this.Email,
            this.Priority});
            this.IT_datagrid.Location = new System.Drawing.Point(1, -1);
            this.IT_datagrid.Margin = new System.Windows.Forms.Padding(2);
            this.IT_datagrid.Name = "IT_datagrid";
            this.IT_datagrid.RowHeadersWidth = 62;
            this.IT_datagrid.RowTemplate.Height = 28;
            this.IT_datagrid.Size = new System.Drawing.Size(1380, 520);
            this.IT_datagrid.TabIndex = 11;
            // 
            // IT_save
            // 
            this.IT_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IT_save.Location = new System.Drawing.Point(11, 550);
            this.IT_save.Margin = new System.Windows.Forms.Padding(2);
            this.IT_save.Name = "IT_save";
            this.IT_save.Size = new System.Drawing.Size(242, 79);
            this.IT_save.TabIndex = 12;
            this.IT_save.Text = "Save";
            this.IT_save.UseVisualStyleBackColor = true;
            this.IT_save.Click += new System.EventHandler(this.IT_save_Click);
            // 
            // IT_comboBox
            // 
            this.IT_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IT_comboBox.FormattingEnabled = true;
            this.IT_comboBox.Items.AddRange(new object[] {
            "Tasks",
            "User"});
            this.IT_comboBox.Location = new System.Drawing.Point(277, 550);
            this.IT_comboBox.Margin = new System.Windows.Forms.Padding(2);
            this.IT_comboBox.Name = "IT_comboBox";
            this.IT_comboBox.Size = new System.Drawing.Size(162, 45);
            this.IT_comboBox.TabIndex = 13;
            this.IT_comboBox.SelectedIndexChanged += new System.EventHandler(this.IT_comboBox_SelectedIndexChanged);
            // 
            // Home_button
            // 
            this.Home_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home_button.Location = new System.Drawing.Point(1122, 524);
            this.Home_button.Name = "Home_button";
            this.Home_button.Size = new System.Drawing.Size(259, 104);
            this.Home_button.TabIndex = 19;
            this.Home_button.Text = "Home";
            this.Home_button.UseVisualStyleBackColor = true;
            this.Home_button.Click += new System.EventHandler(this.Home_button_Click);
            // 
            // Team_ID
            // 
            this.Team_ID.HeaderText = "Team ID";
            this.Team_ID.MinimumWidth = 8;
            this.Team_ID.Name = "Team_ID";
            this.Team_ID.Width = 150;
            // 
            // User_ID
            // 
            this.User_ID.HeaderText = "User ID";
            this.User_ID.MinimumWidth = 8;
            this.User_ID.Name = "User_ID";
            this.User_ID.ReadOnly = true;
            this.User_ID.Width = 150;
            // 
            // Username
            // 
            this.Username.HeaderText = "Username";
            this.Username.MinimumWidth = 8;
            this.Username.Name = "Username";
            this.Username.Width = 150;
            // 
            // Password
            // 
            this.Password.HeaderText = "Password";
            this.Password.MinimumWidth = 8;
            this.Password.Name = "Password";
            this.Password.Width = 150;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 8;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 150;
            // 
            // Priority
            // 
            this.Priority.HeaderText = "Priority";
            this.Priority.MinimumWidth = 8;
            this.Priority.Name = "Priority";
            this.Priority.Width = 90;
            // 
            // IT_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1393, 640);
            this.Controls.Add(this.Home_button);
            this.Controls.Add(this.IT_comboBox);
            this.Controls.Add(this.IT_save);
            this.Controls.Add(this.IT_datagrid);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "IT_page";
            this.Text = "IT_page";
            ((System.ComponentModel.ISupportInitialize)(this.IT_datagrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView IT_datagrid;
        private System.Windows.Forms.Button IT_save;
        private System.Windows.Forms.ComboBox IT_comboBox;
        private System.Windows.Forms.Button Home_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn Team_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Priority;
    }
}