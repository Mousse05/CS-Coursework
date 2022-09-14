using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototype1
{
    public partial class main_page : Form
    {
        public main_page()
        {
            InitializeComponent();
        }

        private void main_order_Click(object sender, EventArgs e)
        {
            var Ordering_page = new ordering_page();//
            Ordering_page.Show();//opens the order page form
            this.Hide();// hides the main form 
        }

        private void main_page_Load(object sender, EventArgs e)
        {
         
        }

        private void main_login_Click(object sender, EventArgs e)
        {
            var Login_page = new login_page();
            Login_page.Show();
            this.Hide();
        }

        private void Main_mangement_Click(object sender, EventArgs e)
        {
            var Management_page = new management_page();
            Management_page.Show();
            this.Hide();
        }
    }
}
