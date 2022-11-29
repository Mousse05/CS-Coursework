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
            Settings.GetCurrentSettings();
            Settings_username.Text = Username;
            Settings_password.Text = Password;
            Settings_email.Text = Email;
            Settings_priority.Text = Priority;
        }

        private void Settings_update_Click(object sender, EventArgs e)
        {
            Username = Settings_username.Text;
            Password = Settings_password.Text;
            Email = Settings_email.Text;
            Priority = Settings_priority.Text;
            Database Update = new Database();
            Update.UpdateInfo();
        }
    }
}
