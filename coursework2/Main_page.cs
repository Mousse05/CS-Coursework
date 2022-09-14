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
        public Main_page()
        {
            InitializeComponent();
        }

        private void Main_page_Load(object sender, EventArgs e)
        {

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
            var Login_page = new Login_page();
            Login_page.Show();
            this.Hide();
        }
    }
}
