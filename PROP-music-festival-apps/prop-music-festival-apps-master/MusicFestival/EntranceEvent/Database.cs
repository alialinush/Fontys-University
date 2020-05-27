using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Collections;
using System.Windows.Forms;



namespace BalanceTopUp
{

    public class DatabaseUtils
    {
        private MySqlConnection conn;

        //public Connection()
        //{
        //    String connInfo = "server=localhost;" +
        //                      "database=prop;" +
        //                      "user id=root;" +
        //                      "password=;" +
        //                      "connect timeout=10;";
        //    conn = new MySqlConnection(connInfo);
        //}

        public DatabaseUtils()
        {
            String connInfo = "server=studmysql01.fhict.local;" +
                                    "Uid=dbi401372;" +
                                    "Database=dbi401372;" +
                                    "Pwd=Xsy2X]XjdL;";
            conn = new MySqlConnection(connInfo);
        }
        public Account GetAcountByTag(string rfid)
        {
            try
            {
                string sqlQuery = "SELECT * FROM user_ WHERE UserId='" + rfid + "'";
                conn.Open();
                MySqlCommand command = new MySqlCommand(sqlQuery, conn);
                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    int tktnr = Convert.ToInt32(reader["UserId"]);
                    string mail = reader["Email"].ToString();
                    string fname = reader["FirstName"].ToString();
                    string lname = reader["LastName"].ToString();
                    string bank = reader["BankAccId"].ToString();
                    bool status = Convert.ToBoolean(reader["Status_"]);
                    double balance = Convert.ToDouble(reader["Balance"]);
                    Account a = new Account(tktnr, mail, fname, lname, bank, status, balance);
                    return a;
                }
                else
                {
                    conn.Close();
                    return null;
                }
            }
            catch (MySqlException)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
        }
        public bool GetBalanceByTkt(int tktnr, out double dbBalance)
        {
            try
            {
                bool result = false;
                string sqlQuery = "SELECT Balance FROM user_ WHERE UserId='" + tktnr + "'";
                conn.Open();
                MySqlCommand command1 = new MySqlCommand(sqlQuery, conn);
                MySqlDataReader reader = command1.ExecuteReader();
                dbBalance = 0;
                if (reader.Read())
                {
                    dbBalance = Convert.ToDouble(reader["Balance"]);
                    result = !result;
                }
                return result;
            }
            catch (MySqlException)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
        }
        public bool TopUpOnce(int tktnr, double dbBalance)
        {
            try
            {
                bool result = false;
                string sqlUpdate = "UPDATE user_ SET Balance = '" + dbBalance + "' WHERE UserId = '" + tktnr + "'; ";
                conn.Open();
                MySqlCommand command2 = new MySqlCommand(sqlUpdate, conn);
                if (command2.ExecuteNonQuery() != 1)
                {
                    result = !result;
                }
                return result;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
        }
        public bool TopUpAll(ArrayList arrlist)
        {
            bool result = true;
            foreach (string[] rec in arrlist)
            {
                int tktnr = int.Parse(rec[0]);
                double balance = Convert.ToDouble(rec[1]);
                double dbBalance;
                if (GetBalanceByTkt(tktnr, out dbBalance))
                {
                    dbBalance += balance;
                    if (TopUpOnce(tktnr, dbBalance))
                    {
                        result = !result;
                    }
                }
            }
            return result;
        }
        public bool GateCheckIn(Account acc)
        {
            try
            {
                bool result = false;
                string sqlUpdate = "UPDATE participant set Inpark= '1' WHERE ParticipantID='" + acc.tktnr + "'";
                conn.Open();
                MySqlCommand command = new MySqlCommand(sqlUpdate, conn);
                if (command.ExecuteNonQuery() == 1)
                {
                    result = !result;
                }
                return result;
            }
            catch (MySqlException)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
        }

    }
}
