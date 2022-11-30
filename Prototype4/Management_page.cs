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
    public partial class Management_page : Form
    {
        public Management_page()
        {
            InitializeComponent();
        }
        private void Management_save_Click(object sender, EventArgs e)
        {
            string[] ColumName= new string[Management_datagrid.ColumnCount];// sets size of array to howmany columns their are
            for (int i = 0; i < ColumName.Length; i++)
            {
                ColumName[i] = Management_datagrid.Columns[i].Name;//adds the names of the columns form the datagridview to the array
            }

            object[][] AddToDatabase = new object[Management_datagrid.Rows.Count][]; //inisalises the jagged array and set its size to how many rows thier are in  the datagridview.
            for (int rows = 0; rows < AddToDatabase.Length; rows++)
            {
                object[] AddToArray = new object[Management_datagrid.ColumnCount];//inisalises the array and set its size to how many columns thier are in  the datagridview.
                for (int i = 0; i < AddToArray.Length; i++)
                {
                    AddToArray[i] = Management_datagrid.Rows[rows].Cells[i].Value;//adds the valuse form a row to the AddToArray array  
                }
                AddToDatabase[rows] = AddToArray;//adds the array to jagged array
            }
            string Tablename = Managemnet_comboBox.Text;
            Database database = new Database();
            database.UpdateTable(AddToDatabase,ColumName, Tablename);
        }

        private void Managemnet_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            Database database = new Database();
            string Tablename = Managemnet_comboBox.Text;
            if (Tablename == "Tasks")
            {
                Management_datagrid.Columns.Clear();
                Management_datagrid.Columns.Add(Task);
                Management_datagrid.Columns.Add(Team_ID);
                Management_datagrid.Columns.Add(Order_ID);
            }
            else if(Tablename == "Teams")
            {
                Management_datagrid.Columns.Clear();
                Management_datagrid.Columns.Add(Team_ID);
                Management_datagrid.Columns.Add(User_ID);
            }
            else if(Tablename == "Order")
            {
                Management_datagrid.Columns.Clear();
                Management_datagrid.Columns.Add(Order_ID);
                Management_datagrid.Columns.Add(User_ID);
                Management_datagrid.Columns.Add(Info);
                Management_datagrid.Columns.Add(Order_date);
                Management_datagrid.Columns.Add(Accepted);
                Management_datagrid.Columns.Add(Delivered);

            }

            //Gets the name of all the columns adn stors them in an array
            string[] ColumnName = new string[Management_datagrid.ColumnCount];
            for (int i = 0; i < ColumnName.Length; i++)
            {
             ColumnName[i] = Management_datagrid.Columns[i].Name;
             }

            //Sends TAbleName and ColmnName as prameters and gets the jaggered array with the data in return
            object [][] AddToDGV = (object[][])database.GetValues(Tablename,ColumnName,null);

            //Adds the Jagged Array to the Datagridview
            for (int i = 0; i < AddToDGV.Length; i++)
            {
                Management_datagrid.Rows.Add(AddToDGV[i]);//adds the jagged array to the datagridview
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
