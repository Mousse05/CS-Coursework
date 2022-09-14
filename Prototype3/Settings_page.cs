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
    public partial class Settings_page : Form
    {
        static public string Username;
        static public string Password;
        static public string Email;
        static public string Priority;
        public Settings_page()
        {
            InitializeComponent();

        }

        private void Settings_page_Load(object sender, EventArgs e)
        {
            Database Settings = new Database();
            Settings.Getcurrentsettings();
            Settings_username.Text = Username;
            Settings_password.Text = Password;
            Settings_email.Text = Email;
            Settings_priority.Text = Priority;
        }
    }
}
