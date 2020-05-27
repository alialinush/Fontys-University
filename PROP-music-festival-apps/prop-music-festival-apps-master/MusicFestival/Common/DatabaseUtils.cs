using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace Common
{
    public sealed class DatabaseUtils
    {
        private static string server = "studmysql01.fhict.local";
        private static string databaseName = "dbi401372";
        private static string userId = "dbi401372";
        private static string password = "Xsy2X]XjdL";
        private static MySqlConnection myDB;
        private static MySqlCommand myCMD;
        private static MySqlDataReader myReader;


        private static string Server => "Server=" + server + ";";
        private static string DatabaseName => "Database=" + databaseName + ";";
        private static string UserID => "Uid=" + userId + ";";
        private static string Password => "Pwd=" + password + ";";


        public static void Connect()
        {
            try
            {
                myDB = new MySqlConnection(GetConnectionString());
                myDB.Open();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public static string GetConnectionString()
        {
            return Server + UserID + DatabaseName + Password + "SslMode=none;";
        }

        public static void Close()
        {
            myDB.Close();
        }

        public static MySqlDataReader ExecuteReader(string sqlStatement)
        {

            Connect();
            myCMD = new MySqlCommand(sqlStatement, myDB);
            return myCMD.ExecuteReader();

        }

        public static List<string> ExecuteReader(string sqlStatement, int number_columns)
        {
            List<string> output = new List<string>();
            try
            {
                myReader = ExecuteReader(sqlStatement);
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

        public static MySqlConnection GetConnection()
        {
            return myDB;
        }

    }
}


