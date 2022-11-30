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
    public partial class Mytask_page : Form
    {
        int OrderID;
        public Mytask_page()
        {
            InitializeComponent();

            Database database = new Database();
            //Gets the name of all the columns adn stors them in an array
            string[] ColumnName = new string[Mytask_dataGridView.ColumnCount];
            for (int i = 0; i < ColumnName.Length; i++)
            {
                ColumnName[i] = Mytask_dataGridView.Columns[i].Name;
            }
            int TeamID = database.TeamID();
            //Sends TAbleName, ColmnName and teamID as prameters and gets the jaggered array with the data in return
            object[][] AddToDGV = (object[][])database.GetValues("Tasks",ColumnName,TeamID);

            //Adds the Jagged Array to the Datagridview
            for (int i = 0; i < AddToDGV.Length; i++)
            {
                Mytask_dataGridView.Rows.Add(AddToDGV[i]);//adds the jagged array to the datagridview
            }
        }

        private void Mytask_search_Click(object sender, EventArgs e)
        {
            Database database = new Database();
            object[] Order = database.GetOrder(int.Parse(Mytask_OrderID.Text));
            Mytask_info.Text = Order[2].ToString();
            Mytask_date.Text =" Date of order :" + Order[3].ToString();
            Mytask_Accepted.Checked = (bool)Order[4];
            Mytask_delivered.Checked = (bool)Order[5];
            
        }
        private void Mytask_acceptorder_Click(object sender, EventArgs e)
        {
            string Order_ID = Mytask_ID.Text;
            Database database = new Database();
            database.AcceptOrder(Order_ID);
        }

        private void Mytask_refresh_Click(object sender, EventArgs e)
        {
            // add two new columns to the order table and management data grid
            OrderID = int.Parse(Mytask_InfoID.Text);
            Database database = new Database();
            string info = database.GetCommunication(OrderID,"Customer_info");
            Mytask_customerinfo.Text = info;
        }

        private void Mytask_Complete_Click(object sender, EventArgs e)
        {
            Database database = new Database();
            int TeamID = 1 + database.TeamID();
            int TaskID = int.Parse(Mytask_taskID.Text);;
            database.TaskComplete(TeamID,TaskID);

            var Main_page = new Main_page();
            Main_page.Show();
            this.Hide();
        }
            /* task ID 1 for design team 
             * tAsk ID 2 for programering team 
             * task ID 3 acounting team basicly payment price
             */
        private void Mytask_save_Click(object sender, EventArgs e)
        {
            string Info = Mytask_employeeinfo.Text;
            Database database = new Database();
            database.AddCommunicatio("Employee_response",Info,OrderID);
        }

        private void Home_button_Click(object sender, EventArgs e)
        {
            var Main_page = new Main_page();
            Main_page.Show();
            this.Hide();
        }
    }
}
