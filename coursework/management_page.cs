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
    public partial class management_page : Form
    {
        OrderValue ordervalue = new OrderValue();// creates an instace of OrderValue
        public management_page()
        {
            InitializeComponent();
        }

        private void management_page_Load(object sender, EventArgs e)
        {

        }

        public void management_view_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ordervalue.newValue);// outputs newvalue as an object of OderValue class
        }
    }
    public class OrderValue : ordering_page// inherates from the ordering form
    {
        public string newValue = Value;// setts newvalue to the variable value form the other form 
    }
}
