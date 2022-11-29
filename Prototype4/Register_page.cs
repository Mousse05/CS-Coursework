using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Prototype4
{
    public partial class Register_page : Form
    {
        public string Forename;
        public string Surname;
        static public string Password;
        public string Password2;
        static public string Username;
        public Register_page()
        {
            InitializeComponent();
        }

        private void Regester_regester_Click(object sender, EventArgs e)
        {
            if (Register_forename.Text == "" ||Register_surname.Text == "" || Register_password.Text == "" || Register_password2.Text == "")// checks if any of the textboxes are empty
            {
                MessageBox.Show("you can't leave a box empty");
            }
            else
            {
                Forename = Register_forename.Text.Trim();
                Surname = Register_surname.Text.Trim();
                Password = Register_password.Text.Trim();
                Password2 = Register_password2.Text.Trim(); 
                if (Password == Password2)// checks if the password mathces withthe password but inputed in a second taxtbox
                {
                    Username = Forename.Substring(0, 3) + Surname.Substring(0, 5);// takes the forst three chracters from Forename and the first five from surname and combindes them
                    MessageBox.Show(Username);//test
                    Database Reg = new Database();
                    Reg.Is_Username_Taken();//runs the is the username taken method
                }
                else
                {
                    MessageBox.Show("your passwords don't match");
                }
            }
         
        }
    }
}
