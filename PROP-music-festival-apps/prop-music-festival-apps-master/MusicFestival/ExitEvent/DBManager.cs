using System;
using MySql.Data.MySqlClient;

namespace ExitEvent
{
    class DBManager
    {
        private static MySqlConnection connection = new MySqlConnection(Common.DatabaseUtils.GetConnectionString());
        /**
         * Returns a visitor based on his/her rfid number
         */
        public static Participant GetVisitorByRfid(string rfidNumber)
        {
            connection.Open();

            MySqlCommand command = new MySqlCommand("SELECT UserId,FirstName,LastName,Address,Balance,Status_,Role,Ticket.Id as TicketNumber FROM User_ " +
                "INNER JOIN Ticket ON User_.Email = Ticket.Email WHERE Ticket.RfidNumber = " + rfidNumber, connection);

            MySqlDataReader reader = null;
            try
            {
                reader = command.ExecuteReader();
            }
            catch (Exception) { }

            Participant participant = null;
            if (reader != null)
            {
                while (reader.Read())
                {
                    int userid = Convert.ToInt32(reader["UserId"]);
                    string firstname = Convert.ToString(reader["FirstName"]);
                    string lastname = Convert.ToString(reader["LastName"]);
                    string address = Convert.ToString(reader["Address"]);
                    double balance = Convert.ToDouble(reader["Balance"]);
                    string status = Convert.ToString(reader["Status_"]);
                    string role = Convert.ToString(reader["Role"]);
                    //int ticketNumber = Convert.ToInt32(reader["TicketNumber"]);

                    participant = new Participant(userid, firstname, lastname, address, balance, status, role);

                }
            }

            connection.Close();

            return participant;
        }
    }
}
