using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototype4
{
    public partial class Main_page : Form
    {
        public int Priority = 0;
        static public string Username = null;
        public Main_page()
        {
            InitializeComponent();

        }
        /* prioery levels 
        1 is for clients 
        2 is for designers and developers
        3 is for managers
        4 is for IT
        5 is for acounts team
        */
        private void Main_page_Load(object sender, EventArgs e)
        {
            if (Username != null)
            {
                Main_login.Text = "Settings";
                Main_Welcome.Text = "welcome \n" + Username;
                Database database = new Database();
                Priority = database.GetPriority();
            }
            if (Priority == 1)
            {
                Main_management.Visible = false;
                Main_Mytasks.Text = "My Order";
            }
            else if(Priority == 3)
            {
                Main_management.Visible = true;
            }
            else if (Priority == 5)
            {
                Main_management.Text = "Acounting";
            }
        }

        private void Main_management_Click(object sender, EventArgs e)
        {
            if (Priority == 5)
            {
                var Accounting_page = new Accounting_page();
                Accounting_page.Show();
                this.Hide();
            }
            else if (Priority == 3)
            {
                var Management_page = new Management_page();
                Management_page.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("You don't have priority for this page");
            }
        }

        private void Main_order_Click(object sender, EventArgs e)
        {
            Database database = new Database();
            if (Priority == 1)
            {
                bool Exist = database.OrderExist();
                if ( Exist == true)
                {
                    MessageBox.Show("Only one order per user");
                }
                else
                {
                    var Order_page = new Order_page();//
                    Order_page.Show();//opens the order page form
                    this.Hide();// hides the main form 
                }
            }
            else
            {
                MessageBox.Show("You don't have priority for this page");
            }
            
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
            if (Priority == 4)
            {
                var IT_page = new IT_page();
                IT_page.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("You don't have priority for this page");
            }

        }

        private void Main_Mytasks_Click(object sender, EventArgs e)
        {
            if (Priority == 1)
            {
                var Vieworder_page = new Vieworder_page();
                Vieworder_page.Show();
                this.Hide();
            }
            else if (Priority == 0)
            {
                MessageBox.Show("You need to login");
            }
            else
            {
                var Mytask_page = new Mytask_page();
                Mytask_page.Show();
                this.Hide();
            }
        }

        private void Main_page_Shown(object sender, EventArgs e)
        {
            if (Priority == 0)
            {
                MessageBox.Show("login please");
            }
        }
    }
}