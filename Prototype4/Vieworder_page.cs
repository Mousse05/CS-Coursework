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
    public partial class Vieworder_page : Form
    {
        int UserID;
        int OrderID;
        
        public Vieworder_page()
        {
            InitializeComponent();

            Database database = new Database();
            string Username = Login_page.Username;

            UserID = database.GetUserID(Username);
            OrderID = database.GetOrderID(UserID);
            object[] Order = database.GetOrder(OrderID);
            string Info = database.GetCommunication(OrderID, "Employee_response");
            int Percent = database.GetPercent();
            if (Percent == 75)
            {
                Vieworder_payment.Enabled = true;
            }
            
            Vieworder_Orderdate.Text = " Date of order :" + Order[3].ToString();
            Vieworder_Accepted.Checked = (bool)Order[4];
            Vieworder_Delivered.Checked = (bool)Order[5];
            Vieworder_employee.Text = Info;
            Vieworder_progressBar.Value = Percent;
            Vieworder_percent.Text = Percent.ToString() + "%";
            
        }

        private void Vieworder_save_Click(object sender, EventArgs e)
        {
            string Addinfo = Vieworder_user.Text;
            Database database = new Database();
            database.AddCommunicatio("Customer_info",Addinfo,OrderID);
        }

        private void Vieworder_payment_Click(object sender, EventArgs e)
        {
            var Payment_page = new Payment_page();
            Payment_page.Show();
            this.Hide();
        }

        private void Home_button_Click(object sender, EventArgs e)
        {
            var Main_page = new Main_page();
            Main_page.Show();
            this.Hide();
        }
    }
}
