namespace Prototype1
{
    partial class management_page
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
            this.management_view = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // management_view
            // 
            this.management_view.Location = new System.Drawing.Point(274, 95);
            this.management_view.Name = "management_view";
            this.management_view.Size = new System.Drawing.Size(75, 23);
            this.management_view.TabIndex = 0;
            this.management_view.Text = "view order";
            this.management_view.UseVisualStyleBackColor = true;
            this.management_view.Click += new System.EventHandler(this.management_view_Click);
            // 
            // management_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.management_view);
            this.Name = "management_page";
            this.Text = "management_page";
            this.Load += new System.EventHandler(this.management_page_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button management_view;
    }
}