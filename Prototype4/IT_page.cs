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
    public partial class IT_page : Form
    {
        public IT_page()
        {
            InitializeComponent();
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
            string Tablename = IT_comboBox.Text;
            Database database = new Database();
            database.UpdateTable(AddToDatabase, ColumName, Tablename);
        }

        private void IT_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Tablename = IT_comboBox.Text;
            if (Tablename == "Tasks")
            {
                IT_datagrid.Columns.Clear();
                IT_datagrid.Columns.Add(Team_ID);
                IT_datagrid.Columns.Add(User_ID);
            }
            else if(Tablename == "User")
            {
                IT_datagrid.Columns.Clear();
                IT_datagrid.Columns.Add(User_ID);
                IT_datagrid.Columns.Add(Username);
                IT_datagrid.Columns.Add(Password);
                IT_datagrid.Columns.Add(Email);
                IT_datagrid.Columns.Add(Priority);
            }

            Database database = new Database();
            string[] ColumnName = new string[IT_datagrid.ColumnCount];
            for (int i = 0; i < ColumnName.Length; i++)
            {
                ColumnName[i] = IT_datagrid.Columns[i].Name;
            }

            object[][] AddToDGV = (object[][])database.GetValues(Tablename, ColumnName, null);

            for (int i = 0; i < AddToDGV.Length; i++)
            {
                IT_datagrid.Rows.Add(AddToDGV[i]);//adds the jagged array to the datagridview
            }

        }

        private void Home_button_Click(object sender, EventArgs e)
        {
            var Main_page = new Main_page();
            Main_page.Show();
            this.Hide();
        }
    }
}
