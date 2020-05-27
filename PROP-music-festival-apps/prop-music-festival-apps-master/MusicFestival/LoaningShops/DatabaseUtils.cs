using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace LoaningShops
{
    class DatabaseUtils
    {
        private string server;
        private string databaseName;
        private string userId;
        private string password;
        private MySqlConnection myDB;
        private MySqlCommand myCMD;
        private MySqlDataReader myReader;



        public string Server => "Server=" + this.server + ";";
        public string DatabaseName => "Database=" + this.databaseName + ";";
        public string UserID => "Uid=" + this.userId + ";";
        public string Password => "Pwd=" + this.password + ";";

        public DatabaseUtils()
        {
            this.server = "studmysql01.fhict.local";
            this.userId = "dbi401372";
            this.databaseName = "dbi401372";
            this.password = "Xsy2X]XjdL";

        }

        public void Connect()
        {
            try
            {
                string connection = this.Server + this.UserID + this.DatabaseName + this.Password + "SslMode=none;";
                myDB = new MySqlConnection(connection);
                myDB.Open();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Close()
        {
            myDB.Close();
        }

        public MySqlDataReader ExecuteReader(string sqlStatement)
        {

            this.Connect();
            myCMD = new MySqlCommand(sqlStatement, myDB);
            return myCMD.ExecuteReader();

        }

        public List<string> ExecuteReader(string sqlStatement, int number_columns)
        {
            List<string> output = new List<string>();
            try
            {
                myReader = this.ExecuteReader(sqlStatement);
                while (myReader.Read())
                {
                    for (int i = 0; i < number_columns; i++)
                    {
                        output.Add(Convert.ToString(myReader[i]));
                    }
                }
                myDB.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return output;
        }





        public MySqlConnection GetConnection()
        {
            return myDB;
        }


    }
}
