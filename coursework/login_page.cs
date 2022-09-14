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
    public partial class login_page : Form
    {
        public login_page()
        {
            InitializeComponent();
        }

        private void login_page_Load(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            var Main_page = new main_page();//
            Main_page.Show();//opens the main page form
            this.Hide();// hides the login form 
        }
    }
}
