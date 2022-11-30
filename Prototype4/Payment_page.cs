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
    public partial class Payment_page : Form
    {
        int OrderID;
        public Payment_page()
        {
            InitializeComponent();
            Payment_cardnumber.MaxLength = 16;
            Payment_cvv.MaxLength = 3;
            Database database = new Database();
            string Username = Login_page.Username;
            int UserID = database.GetUserID(Username);
            OrderID = database.GetOrderID(UserID);
            double Price = database.GetPrice();
            
            double Vat = Price - (Price / 1.2); //works out how much VAt is 
            Vat = Math.Round(Vat,2);// rounds the Vat to two decimal places
            Payment_orderID.Text = "Order ID = " + OrderID.ToString();
            Payment_price.Text = "Price = £" + Price.ToString();
            Payment_vat.Text = "VAT = £" + Vat.ToString();
        }

        private void Payment_cardnumber_TextChanged(object sender, EventArgs e)
        {
            string Cardnumber = Payment_cardnumber.Text;
            Database database = new Database();
            bool valid = database.Payment(Cardnumber);
            Payment_cardvalid.Checked = valid;
        }

        private void Payment_cvv_TextChanged(object sender, EventArgs e)
        {
            if (Payment_cvv.Text.Length == 3)
            {
                Payment_cvvvalid.Checked = true;
            }
        }

        private void Payment_lastname_TextChanged(object sender, EventArgs e)
        {
            if (Payment_lastname.Text != "")
            {
                Payment_lastvalid.Checked = true;
            }
        }

        private void Payment_firstname_TextChanged(object sender, EventArgs e)
        {
            if (Payment_firstname.Text != "")
            {
                Payment_firstvalid.Checked = true;
            }
        }
        private void Payment_pay_Click(object sender, EventArgs e)
        {// checks if all the textboxes are valid and if the date is not the same as the original  value 
            DateTime FalseTime = DateTime.Parse("01/01/2022");
            if (Payment_cardvalid.Checked == true && Payment_cardvalid.Checked == true
                && Payment_dateTimePicker.Value != FalseTime && Payment_lastvalid.Checked == true
                && Payment_lastvalid.Checked == true)
            {
                Database database = new Database();
                database.AddCardInfo(OrderID, int.Parse(Payment_cardnumber.Text),
                int.Parse(Payment_cvv.Text),Payment_firstname.Text,
                Payment_lastname.Text,Payment_dateTimePicker.Value);
            }
            else
            {
                MessageBox.Show("One of the fields is not valid");
            }
        }
    }
}
