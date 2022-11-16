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
    public partial class Order_page : Form
    {
        static public string Info;
        static public string Email;
        static public DateTime Time;
        public Order_page()
        {
            InitializeComponent();
        }

        private void Order_info_TextChanged(object sender, EventArgs e)
        {

        }

        private void Order_order_Click(object sender, EventArgs e)
        {
            if (Order_info.Text == "" || Order_email.Text == "")
            {
                MessageBox.Show("the boxes can't be blank");
            }
            else
            {
                Email = Order_email.Text;
                Info = Order_info.Text;
                Time = DateTime.Now;
                Database AddOrder = new Database();
                AddOrder.AddOrder();
            }
        }
    }
}
