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
             Connectstring = new OleDbConnection (@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/musa2/Documents/Sixforrm/CS/code/CS Coursework/Database/database.accdb");
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
        public bool Is_username_taken()
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
        public void Addorder()
        {
            string Email = Order_page.Email;
            string Info = Order_page.Info;
            DateTime Time = Order_page.Time;
            int ID = GetuserID();
            OleDbCommand command = new OleDbCommand($"INSERT INTO [Order](User_ID,info,Order_date ) VALUES ('{ID}' , '{Info}', '{Time}')", Connectstring);
            OleDbCommand commandE = new OleDbCommand($"UPDATE [User] SET [Email] = '{Email}' WHERE User_ID = { ID }", Connectstring); 
            Connectstring.Open();
            command.ExecuteNonQuery();
            commandE.ExecuteNonQuery();
            Connectstring.Close();
        }
        public void Declineorder()
        {

        }
        public void Acceptorder()
        {

        }
        public void Checkmyorder()
        {

        }
        public int GetuserID()
        {
            string Username = Login_page.Username;
            OleDbCommand command = new OleDbCommand($"SELECT User_ID FROM [User] WHERE Username = '{Username}'", Connectstring);
            Connectstring.Open();
            int ID = (int)command.ExecuteScalar();
            Connectstring.Close();
            //MessageBox.Show(ID.ToString()); test
            return ID;
        }
        public void Getcurrentsettings()
        {
            int ID = GetuserID();
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
        public object Getorders()
        {
            OleDbCommand command = new OleDbCommand($"SELECT * FROM [Order]", Connectstring);
            OleDbCommand command1 = new OleDbCommand($"SELECT COUNT(*) FROM [Order]", Connectstring);
            Connectstring.Open();
            OleDbDataReader reader = command.ExecuteReader();
            int rowcount = (int)command1.ExecuteScalar();
            int i = 0;
            Object[][] AddToDGV = new Object[rowcount][];//jagged arry to store the whole table form the databse 
            //array for row that is being looked at
            try
            {
                while (reader.Read())
                {
                Object[] AddToArray = new Object[6];//adds the valuse form a row to the AddToArray array 
                AddToArray[0] = reader["Order_ID"];
                AddToArray[1] = reader["User_ID"];
                AddToArray[2] = reader["Info"];
                AddToArray[3] = reader["Order_date"];
                AddToArray[4] = reader["Accepted"];
                AddToArray[5] = reader["Delivered"];
                
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
        public void Updateinfo()
        {
            string Username = Settings_page.Username;
            string Password = Settings_page.Password;
            string Email = Settings_page.Email;
            int UserID = GetuserID();
            OleDbCommand command = new OleDbCommand($"UPDATE [User] where UserID = {UserID} SET [Username] = '{Username}',[Password] = '{Password}',[Email] = '{Email}'",Connectstring);
            Connectstring.Open();
            command.ExecuteNonQuery();
            Connectstring.Close();
        }
    }
}
