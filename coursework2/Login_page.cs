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
    
    public partial class Login_page : Form
    {
        static public string Username;
        static public string Password;
        static public bool Valid;
        public Login_page()
        {
            InitializeComponent();
        }

        private void Login_login_Click(object sender, EventArgs e)
        {
            if (Login_username.Text == "" || Login_password.Text == "")// if textboxes are epmty
            {
                MessageBox.Show("You can't leave a box empty");
            }
            else
            {
                Username = Login_username.Text.Trim();// set the value of te textbox to the variable and get rid of any white space
                Password = Login_password.Text.Trim();
                //MessageBox.Show("good job");//test
                Database Log = new Database();
                Log.Login();//runs the register method 
                Database ID = new Database();
                ID.GetUserID();
                if (Valid == true)
                {
                    var Main_page = new Main_page();
                    Main_page.Show();
                    this.Hide();
                }
                else if (Valid == false)
                {
                    MessageBox.Show("your username or password is incorrct");
                }
            }
        }

        private void Login_register_Click(object sender, EventArgs e)
        {
            var Register_page = new Register_page();
            Register_page.Show();
            this.Hide();
        }
    }
}
