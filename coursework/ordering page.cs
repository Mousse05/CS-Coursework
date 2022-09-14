using System;
using System.Collections;
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
    public partial class ordering_page : Form
    {
        public Queue orderqueue = new Queue(); // creates a queue
        string input;
        public static string Value;
        public ordering_page()
        {
            InitializeComponent();
            
        }

        private void ordering_page_Load(object sender, EventArgs e)
        {
         
        }

        public void order_Click(object sender, EventArgs e)
        {
            input = order_input.Text;
            orderqueue.Enqueue(input); // adds the value of the variable to the queue
            order_input.Clear(); // clear the textbox
            int num1 = orderqueue.Count; // displays how many values are in the queue
            numorder.Text = num1.ToString();
            
        }

        private void numorder_Click(object sender, EventArgs e)
        {

        }

        private void order_input_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void order_view_Click(object sender, EventArgs e)
        {
            foreach (var item in orderqueue)
            {
                order_value.Text += "\n " + item.ToString(); // outputs all the data form the queue without changeing the data
                Value += " "+item; 
            }
        }

        private void ordering_management_Click(object sender, EventArgs e)
        {
            var Management_page = new management_page();
            Management_page.Show();
            this.Hide();
        }
    }
}
