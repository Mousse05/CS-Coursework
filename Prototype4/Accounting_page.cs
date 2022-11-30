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
    public partial class Accounting_page : Form
    {
        double num1;
        double Output;
        int Count;
        double Price;
        public Accounting_page()
        {
            InitializeComponent();
        }
        private void Button0_Click(object sender, EventArgs e)
        {
            Calculator.Text += 0;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Calculator.Text += 1;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Calculator.Text += 2;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Calculator.Text += 3;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Calculator.Text += 4;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Calculator.Text += 5;
        }
        private void Button6_Click(object sender, EventArgs e)
        {
            Calculator.Text += 6;
        }
        private void Button7_Click(object sender, EventArgs e)
        {
            Calculator.Text += 7;
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            Calculator.Text += 8;
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            Calculator.Text += 9;
        }

        private void Button_Add_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(Calculator.Text);
            Calculator.Clear();
            Calculator.Focus();
            Count = 1;
        }

        private void Button_Subtract_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(Calculator.Text);
            Calculator.Clear();
            Calculator.Focus();
            Count = 2;
        }

        private void Button_Multiply_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(Calculator.Text);
            Calculator.Clear();
            Calculator.Focus();
            Count = 3;
        }

        private void Button_Divide_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(Calculator.Text);
            Calculator.Clear();
            Calculator.Focus();
            Count = 4;
        }

        private void Button_Decimal_Click(object sender, EventArgs e)
        {
            Calculator.Text += ".";
        }

        private void Button_Equals_Click(object sender, EventArgs e)
        {
            switch (Count)
            {
                case 1:
                    Output = num1 + float.Parse(Calculator.Text);
                    Calculator.Text = Output.ToString();
                    break;
                case 2:
                    Output = num1 - float.Parse(Calculator.Text);
                    Calculator.Text = Output.ToString();
                    break;
                case 3:
                    Output = num1 * float.Parse(Calculator.Text);
                    Calculator.Text = Output.ToString();
                    break;
                case 4:
                    Output = num1 / float.Parse(Calculator.Text);
                    Calculator.Text = Output.ToString();
                    break;
                default:
                    break;
            }
        }

        private void Button_Back_Click(object sender, EventArgs e)
        {
            Calculator.Clear();
            Count = 0;
        }

        private void Accouinting_Calculate_Click(object sender, EventArgs e)
        {
            int Hours = int.Parse(Accounting_Hours.Text);
            Price = 1.2*(Hours * 100);//calculate total price including VAT
            double VAT = Price - (Price / 1.2);//calculate VAT amount
            VAT = Math.Round(VAT, 2);//rounds to two decimal place
            Price = Math.Round(Price, 2);
            Accounting_VAT.Text = "VAT = £" + VAT.ToString();
            Accounting_Price.Text = "Toatl Price = £" + Price.ToString();
        }

        private void Accounting_Save_Click(object sender, EventArgs e)
        {
            Database database = new Database();
            database.AddPrice(Price, int.Parse(Accounting_OrderID.Text));
            MessageBox.Show("Price added");
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            var Main_page = new Main_page();
            Main_page.Show();
            this.Hide();

        }
    }
}
