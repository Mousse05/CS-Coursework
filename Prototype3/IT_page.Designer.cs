namespace Prototype3
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
            this.User_ID,
            this.Username,
            this.Password,
            this.Email,
            this.Priority});
            this.IT_datagrid.Location = new System.Drawing.Point(1, -2);
            this.IT_datagrid.Name = "IT_datagrid";
            this.IT_datagrid.RowHeadersWidth = 62;
            this.IT_datagrid.RowTemplate.Height = 28;
            this.IT_datagrid.Size = new System.Drawing.Size(1142, 336);
            this.IT_datagrid.TabIndex = 11;
            // 
            // IT_save
            // 
            this.IT_save.Location = new System.Drawing.Point(36, 340);
            this.IT_save.Name = "IT_save";
            this.IT_save.Size = new System.Drawing.Size(75, 37);
            this.IT_save.TabIndex = 12;
            this.IT_save.Text = "Save";
            this.IT_save.UseVisualStyleBackColor = true;
            this.IT_save.Click += new System.EventHandler(this.IT_save_Click);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 450);
            this.Controls.Add(this.IT_save);
            this.Controls.Add(this.IT_datagrid);
            this.Name = "IT_page";
            this.Text = "IT_page";
            ((System.ComponentModel.ISupportInitialize)(this.IT_datagrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView IT_datagrid;
        private System.Windows.Forms.Button IT_save;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Priority;
    }
}