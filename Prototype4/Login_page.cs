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
    
    public partial class Login_page : Form
    {
        static public string Username;
        public string Password;
        public bool Valid;
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
                Valid = Log.Login(Username,Password);//runs the register method 
                
                if (Valid == true)
                {
                    var Main_page = new Main_page();
                    Main_page.Show();
                    this.Hide();
                    Database ID = new Database();
                    ID.GetUserID(Username);
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
