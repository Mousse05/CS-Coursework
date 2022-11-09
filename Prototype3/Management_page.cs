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
    public partial class Management_page : Form
    {
        public Management_page()
        {
            Database database = new Database();
            database.Getorders();
            InitializeComponent();
            object []order; 
            Management_datagrid.Rows.Add();
            
        }
        
    }
}
