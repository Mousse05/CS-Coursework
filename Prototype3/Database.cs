using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Prototype3
{
    public class Database
    {
        public OleDbConnection Connectstring;
        public Database()
        {
            Connectstring = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/musa2/Documents/Sixforrm/CS/code/CS Coursework/Database/database.accdb");
        }
        public void Register()
        {
            string Password = Register_page.Password;
            string Username = Register_page.Username;
            MessageBox.Show(Username);//test 
            OleDbCommand command = new OleDbCommand($"INSERT INTO [User](Username,[Password]) VALUES ('{Username}' , '{Password} ')", Connectstring);
            Connectstring.Open();
            command.ExecuteNonQuery();
            Connectstring.Close();
        }
        public bool Is_Username_Taken()
        {

            string Username = Register_page.Username;
            OleDbCommand command = new OleDbCommand($"SELECT COUNT(Username) FROM [User] WHERE Username = '{Username}'", Connectstring);
            Connectstring.Open();
            int ID = (int)command.ExecuteScalar();
            Connectstring.Close();
            if (ID == 0)
            {
                Register();
                return false;
            }
            else
            {
                MessageBox.Show("the username is taken");//test
                return true;
            }
        }
        public void Login()//change into a function 
        {
            string Username = Login_page.Username;
            string Password = Login_page.Password;
            OleDbCommand command = new OleDbCommand($"SELECT [Password] FROM [User] WHERE Username = '{Username}'", Connectstring);
            Connectstring.Open();
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string Output = reader["Password"].ToString();
                //Connectstring.Close();

                if (Output == Password)
                {
                    MessageBox.Show("login ok");
                    Main_page.Username = Username;
                    Login_page.Valid = true;
                }
                else
                {
                    Login_page.Valid = false;
                }

            }
            Connectstring.Close();


        }
        public void AddOrder()
        {
            string Email = Order_page.Email;
            string Info = Order_page.Info;
            DateTime Time = Order_page.Time;
            int ID = GetUserID();
            OleDbCommand command = new OleDbCommand($"INSERT INTO [Order](User_ID,info,Order_date ) VALUES ('{ID}' , '{Info}', '{Time}')", Connectstring);
            OleDbCommand commandE = new OleDbCommand($"UPDATE [User] SET [Email] = '{Email}' WHERE User_ID = {ID}", Connectstring);
            Connectstring.Open();
            command.ExecuteNonQuery();
            commandE.ExecuteNonQuery();
            Connectstring.Close();
        }
        public void CheckMyOrder()
        {

        }

        public void UpdateTable(object[][]AddToDatabase,string[]CoulmnName,string Table)
        {
            Connectstring.Open();
            for(int column = 1; column < CoulmnName.Length; column++)
            {
                for (int i = 0; i < AddToDatabase.Length; i++)
                {
                    if (AddToDatabase[i][column] is bool | AddToDatabase[i][column] is int)
                    {
                        OleDbCommand command = new OleDbCommand($"UPDATE [{Table}] SET " +
                        $"[{CoulmnName[column]}] = {AddToDatabase[i][column]} WHERE {CoulmnName[0]} = {i + 1}", Connectstring);

                        command.ExecuteNonQuery();
                    }
                    else
                    {
                        OleDbCommand command = new OleDbCommand($"UPDATE [{Table}] SET " +
                        $"[{CoulmnName[column]}] = '{AddToDatabase[i][column]}' WHERE {CoulmnName[0]} = {i + 1}", Connectstring);

                        command.ExecuteNonQuery();
                    }
                    //MessageBox.Show(coulmnName[coulmn], AddToDatabase[i][coulmn].ToString());
                }
            }
            Connectstring.Close();
        }
        public int GetUserID()
        {
            string Username = Login_page.Username;
            OleDbCommand command = new OleDbCommand($"SELECT User_ID FROM [User] WHERE Username = '{Username}'", Connectstring);
            Connectstring.Open();
            int ID = (int)command.ExecuteScalar();
            Connectstring.Close();
            //MessageBox.Show(ID.ToString()); test
            return ID;
        }
        public void GetCurrentSettings()
        {
            int ID = GetUserID();
            OleDbCommand command = new OleDbCommand($"SELECT * FROM [User] WHERE USER_ID = {ID}", Connectstring);
            Connectstring.Open();
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Settings_page.Username = reader.GetString(1);
                Settings_page.Password = reader.GetString(2);
                Settings_page.Email = reader.GetString(3);
                Settings_page.Priority = reader.GetString(4);
            }
            Connectstring.Close();
        }
        public object GetValues(string Tablename,string[] ColumnName)
        {
            OleDbCommand command = new OleDbCommand($"SELECT * FROM [{Tablename}]", Connectstring);
            OleDbCommand command1 = new OleDbCommand($"SELECT COUNT(*) FROM [{Tablename}]", Connectstring);
            Connectstring.Open();
            OleDbDataReader reader = command.ExecuteReader();
            int rowcount = (int)command1.ExecuteScalar();
            int i = 0;
            object[][] AddToDGV = new object[rowcount][];//jagged arry to store the whole table form the databse 
            //array for row that is being looked at
            try
            {
                while (reader.Read())
                {
                    object[] AddToArray = new object[ColumnName.Length];//adds the valuse form a row to the AddToArray array 
                    for (int j = 0; j < ColumnName.Length; j++)
                    {
                        AddToArray[j] = reader[j];
                    }
                AddToDGV[i] = AddToArray;//AddToArray arry is added to AddToDGV jagged array
                i++;
                }
                Connectstring.Close();
                return AddToDGV;
            }
            catch (Exception e)// catches error 
            {
                MessageBox.Show(e.ToString());
                return null;
            }
                
            
            
        }
        public void UpdateInfo()
        {
            string Username = Settings_page.Username;
            string Password = Settings_page.Password;
            string Email = Settings_page.Email;
            int UserID = GetUserID();
            OleDbCommand command = new OleDbCommand($"UPDATE [User] SET [Username] = '{Username}',[Password] = '{Password}',[Email] = '{Email}' WHERE UserID = {UserID}",Connectstring);
            Connectstring.Open();
            command.ExecuteNonQuery();
            Connectstring.Close();
        }
    }
}
