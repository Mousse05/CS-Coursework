using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototype3
{
    public partial class Main_page : Form
    {
        public string Priovity = null;
        static public string Username = null;
        public Main_page()
        {
            InitializeComponent();
        }

        private void Main_page_Load(object sender, EventArgs e)
        {
           /*if (Priovity == null)
            {
                Main_management.Visible = false;
            }
            else if(Priovity == "management")
            {
                Main_management.Visible = true;
            }

            if (Username != null)
            {
                Main_login.Text = "Settings";
                Main_Welcome.Text = "welcome \n" + Username;
            }*/
        }

        private void Main_management_Click(object sender, EventArgs e)
        {
            var Management_page = new Management_page();
            Management_page.Show();
            this.Hide();
        }

        private void Main_order_Click(object sender, EventArgs e)
        {
            var Order_page = new Order_page();//
            Order_page.Show();//opens the order page form
            this.Hide();// hides the main form 
        }
        private void Main_login_Click(object sender, EventArgs e)
        {
            if (Username == null)
            {
                var Login_page = new Login_page();
                Login_page.Show();
                this.Hide();
            }
            else
            {
                var Settings_page = new Settings_page();
                Settings_page.Show();
                this.Hide();
                
            }
            
        }

        private void Main_IT_Click(object sender, EventArgs e)
        {
            var IT_page = new IT_page();
            IT_page.Show();
            this.Hide();
        }

        private void Main_Mytasks_Click(object sender, EventArgs e)
        {
            var Mytask_page = new Mytask_page();
            Mytask_page.Show();
            this.Hide();
        }
    }
}
