using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Prototype4
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
            OleDbCommand command = new OleDbCommand($"INSERT INTO [User](Username,[Password]) VALUES ('{Username}' , '{Password}')", Connectstring);
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
        public void Login(string Username, string Password)//change into a function 
        {
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
            int ID = GetUserID(Login_page.Username);
            OleDbCommand command = new OleDbCommand($"INSERT INTO [Order](User_ID,info,Order_date,Percent ) VALUES ({ID},'{Info}', '{Time}',{0})", Connectstring);
            OleDbCommand command1 = new OleDbCommand($"UPDATE [User] SET [Email] = '{Email}' WHERE User_ID = {ID}", Connectstring);
            Connectstring.Open();
            command.ExecuteNonQuery();
            command1.ExecuteNonQuery();
            int OrderID = GetUserID(Login_page.Username);//change it broken
            OleDbCommand command2 = new OleDbCommand($"INSERT INTO [Tasks] (Team_ID,Order_ID) VALUES ({1},'{OrderID}')", Connectstring);
            command2.ExecuteNonQuery();
            Connectstring.Close();
        }
        public void AcceptOrder(string OrderID)
        {
            OleDbCommand command = new OleDbCommand($"UPDATE [Order] SET [Accepted] = {true} " +
                $"WHERE Order_ID = {OrderID}", Connectstring);
            Connectstring.Open();
            command.ExecuteNonQuery();
            Connectstring.Close();
        }
        public int GetPercent()
        {
            int UserID = GetUserID(Login_page.Username);
            OleDbCommand command = new OleDbCommand($"SELECT Percent FROM [Order] WHERE User_ID = {UserID}", Connectstring);
            Connectstring.Open();
            OleDbDataReader reader = command.ExecuteReader();
            int Percent = 0;
            while (reader.Read())
            {
                Percent = Convert.ToInt32(reader[0]);
            }
            Connectstring.Close();
            return Percent;
        }
        public void TaskComplete(int TeamID, int Tasks)
        {
            if (TeamID < 4)
            {
                int Percent = 25 + GetPercent();
                int UserID = GetUserID(Login_page.Username);
                OleDbCommand command = new OleDbCommand($"UPDATE [Tasks] SET Team_ID = {TeamID} WHERE Tasks = {Tasks}", Connectstring);
                OleDbCommand command1 = new OleDbCommand($"UPDATE [Order] SET [Percent] = {Percent} WHERE User_ID = {UserID}", Connectstring);
                Connectstring.Open();
                command.ExecuteNonQuery();
                command1.ExecuteNonQuery();
                Connectstring.Close();
            }
            else
            {
                MessageBox.Show("Go set the price of the product");
            }
        }
        public string GetCommunication(int OrderID, string field)
        {
            OleDbCommand command = new OleDbCommand($"SELECT {field} FROM [Order] WHERE Order_ID = {OrderID}", Connectstring);
            Connectstring.Open();
            OleDbDataReader reader = command.ExecuteReader();
            string info = "test fail";
            try
            {
                while (reader.Read())
                {
                    info = reader[0].ToString();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return null;
            }
            finally
            {
                Connectstring.Close();
            }
            return info;
        }
        public void AddCommunicatio(string field, string info, int ID)
        {
            OleDbCommand command = new OleDbCommand($"UPDATE [Order] SET {field} = '{info}' WHERE Order_ID = {ID}", Connectstring);
            Connectstring.Open();
            command.ExecuteNonQuery();
            Connectstring.Close();
        }
        public void UpdateTable(object[][] AddToDatabase, string[] CoulmnName, string Table)
        {
            Connectstring.Open();
            for (int column = 1; column < CoulmnName.Length; column++)
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
        public int GetUserID(string Username)
        {
            OleDbCommand command = new OleDbCommand($"SELECT User_ID FROM [User] WHERE Username = '{Username}'", Connectstring);
            Connectstring.Open();
            OleDbDataReader reader = command.ExecuteReader();
            int ID = 0;
            while (reader.Read())
            {
                ID = (int)reader[0];
            }
            Connectstring.Close();
            //MessageBox.Show(ID.ToString()); test
            return ID;
        }
        public void GetCurrentSettings()
        {
            int ID = GetUserID(Login_page.Username);
            OleDbCommand command = new OleDbCommand($"SELECT * FROM [User] WHERE USER_ID = {ID}", Connectstring);
            Connectstring.Open();
            //command.Parameters.AddWithValue("@par", "Name"); pramitesed query
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Settings_page.Username = reader.GetString(1);
                Settings_page.Password = reader.GetString(2);
                Settings_page.Email = reader.GetString(3);
                Settings_page.Priority = reader[4].ToString();
            }
            Connectstring.Close();
        }
        public object[] GetOrder(int OrderID)
        {
            OleDbCommand Command = new OleDbCommand($"SELECT * FROM [Order] WHERE Order_ID = {OrderID}", Connectstring);
            Connectstring.Open();
            OleDbDataReader reader = Command.ExecuteReader();
            while (reader.Read())
            {//adds the valuse form a row to the AddToArray array 
                object[] AddToArray = new object[6];
                for (int i = 0; i < AddToArray.Length; i++)
                {//adds the data to the array
                    AddToArray[i] = reader[i];
                }
                Connectstring.Close();
                return AddToArray;
            }
            return null;
        }
        public object GetValues(string Tablename, string[] ColumnName, int? ID)
        {
            OleDbCommand command;
            if (ID == null)
            {
                command = new OleDbCommand($"SELECT * FROM [{Tablename}]", Connectstring);
            }
            else
            {
                command = new OleDbCommand($"SELECT * FROM [{Tablename}] WHERE Team_ID = {ID}", Connectstring);
            }

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
                {//adds the valuse form a row to the AddToArray array 
                    object[] AddToArray = new object[ColumnName.Length];
                    for (int j = 0; j < ColumnName.Length; j++)
                    {
                        AddToArray[j] = reader[j];
                    }
                    //AddToArray arry is added to AddToDGV jagged array
                    AddToDGV[i] = AddToArray;
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
            int UserID = GetUserID(Login_page.Username);
            OleDbCommand command = new OleDbCommand($"UPDATE [User] SET [Username] = '{Username}',[Password] = '{Password}',[Email] = '{Email}' WHERE UserID = {UserID}", Connectstring);
            Connectstring.Open();
            command.ExecuteNonQuery();
            Connectstring.Close();
        }
        public int TeamID()
        {
            Database database = new Database();
            int UserID = database.GetUserID(Login_page.Username);
            OleDbCommand command = new OleDbCommand($"SELECT Team_ID FROM [Teams] WHERE User_ID = {UserID}", Connectstring);
            Connectstring.Open();
            OleDbDataReader reader = command.ExecuteReader();
            int TeamID = 0;
            while (reader.Read())
            {
                TeamID = (int)reader[0];
            }
            Connectstring.Close();
            return TeamID;
        }
        public int GetOrderID(int UserID)
        {
            OleDbCommand command = new OleDbCommand($"SELECT Order_ID FROM [Order] WHERE User_ID = {UserID}", Connectstring);
            Connectstring.Open();
            OleDbDataReader reader = command.ExecuteReader();
            int OrderID = 0;
            while (reader.Read())
            {
                OrderID = (int)reader[0];
            }
            Connectstring.Close();
            return OrderID;
        }
        public bool Payment(string Cardnumber)
        {//not for database but easy to keep in the same place
            if (Cardnumber == "")
            {
                return false;
            }
            else
            {
                return Cardnumber.All(char.IsDigit) && Cardnumber.Reverse()
                .Select(c => c - 48)
                .Select((thisNum, i) => i % 2 == 0
                    ? thisNum
                    : ((thisNum *= 2) > 9 ? thisNum - 9 : thisNum)
                ).Sum() % 10 == 0;
            }

        }
        public void AddCardInfo(int Order_ID, int Cardnumber, int CVC, string First_name, string Last_name, DateTime Expiry_date)
        {
            OleDbCommand command = new OleDbCommand($"INSERT INTO [Payment] (Order_ID,Cardnumber,CVC,First_name,Last_name,Expiry_date) " +
                $"VALUES({Order_ID},{Cardnumber},{CVC},{First_name},{Last_name},{Expiry_date})", Connectstring);
            Connectstring.Open();
            command.ExecuteNonQuery();
            Connectstring.Close();
        }
        public double GetPrice()
        {
            double Price = 0;
            int ID = GetUserID(Login_page.Username);
            OleDbCommand command = new OleDbCommand($"SELECT Price FROM [Order] WHERE User_ID = {ID}", Connectstring);
            Connectstring.Open();
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Price = (double)reader[0];
            }
            Connectstring.Close();
            return Price;
        }
        public void AddPrice(double Price, int UserID)
        {
            OleDbCommand command = new OleDbCommand($"UPDATE [Order] SET [Price] = {Price} WHERE User_ID = {UserID}", Connectstring);
            Connectstring.Open();
            command.ExecuteNonQuery();
            Connectstring.Close();
        }
        public int GetPriority()//broken
        {
            string Username = Login_page.Username;
            int UserID = GetUserID(Username);
            int priority = 0;
            OleDbCommand command = new OleDbCommand($"SELECT Priority FROM [User] WHERE User_ID = {UserID}",Connectstring);
            Connectstring.Open();
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                priority = (int)reader[0];
            }
            Connectstring.Close();
            return priority;
        }
    }
}