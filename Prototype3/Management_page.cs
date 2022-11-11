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
            InitializeComponent();
            Database database = new Database();
            object [][] AddToDGV = (object[][])database.Getorders();
            
            for (int i = 0; i < AddToDGV.Length; i++)
            {
                Management_datagrid.Rows.Add(AddToDGV[i]);

            }
        }
        
    }
}
