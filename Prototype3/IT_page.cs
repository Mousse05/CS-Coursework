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
    public partial class IT_page : Form
    {
        public IT_page()
        {
            InitializeComponent();

            Database database = new Database();

            string[] ColumnName = new string[IT_datagrid.ColumnCount];
            for (int i = 0; i < ColumnName.Length; i++)
            {
                ColumnName[i] = IT_datagrid.Columns[i].Name;
            }

            object[][] AddToDGV = (object[][])database.GetValues("User", ColumnName);

            for (int i = 0; i < AddToDGV.Length; i++)
            {
                IT_datagrid.Rows.Add(AddToDGV[i]);//adds the jagged array to the datagridview
            }
        }

        private void IT_save_Click(object sender, EventArgs e)
        {
            string[] ColumName = new string[IT_datagrid.ColumnCount];
            for (int i = 0; i < ColumName.Length; i++)
            {
                ColumName[i] = IT_datagrid.Columns[i].Name;
            }

            object[][] AddToDatabase = new object[IT_datagrid.Rows.Count][];
            for (int rows = 0; rows < AddToDatabase.Length; rows++)
            {
                object[] AddToArray = new object[IT_datagrid.ColumnCount];//adds the valuse form a row to the AddToArray array 
                for (int i = 0; i < AddToArray.Length; i++)
                {
                    AddToArray[i] = IT_datagrid.Rows[rows].Cells[i].Value;
                }
                AddToDatabase[rows] = AddToArray;
            }
            Database database = new Database();
            database.UpdateTable(AddToDatabase, ColumName,"User");
        }
    }
}
