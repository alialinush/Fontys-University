using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Forms.EmloyeeLogin
{
    class DBManager
    {
        private static MySqlConnection connection = new MySqlConnection(DatabaseUtils.GetConnectionString());

        public static List<Event> GetAllCurrentEvents()
        {
            List<Event> events = new List<Event>();

            MySqlCommand command = new MySqlCommand("select EventId,UserId,Title,Description,StartDate,EndDate,TicketPrice,NrTickets,NrSpotsAvailable,Address from event_;", connection);

            connection.Open();
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int eventid = Convert.ToInt32(reader["EventId"]);
                int userid = Convert.ToInt32(reader["UserId"]);
                string title = Convert.ToString(reader["Title"]);
                string description = Convert.ToString(reader["Description"]);
                DateTime dtStart = Convert.ToDateTime(reader["StartDate"]);
                DateTime dtEnd = Convert.ToDateTime(reader["EndDate"]);
                int ticketprice = Convert.ToInt32(reader["TicketPrice"]);
                int nrtickets = Convert.ToInt32(reader["NrTickets"]);
                int nrspotsavail = Convert.ToInt32(reader["NrSpotsAvailable"]);
                string location = Convert.ToString(reader["Address"]);

                if (dtStart < DateTime.Now && DateTime.Now < dtEnd)
                {
                    events.Add(new Event(eventid, userid, title, description, dtStart, dtEnd, ticketprice, nrtickets, nrspotsavail, location));
                }
            }
            connection.Close();

            return events;
        }

        public static bool LoginEmployee(int employeeId, string employeePassword)
        {
            string query = "SELECT * FROM user_ WHERE UserId= '" + employeeId.ToString() + "' and Password_= '" + employeePassword + "'";

            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataAdapter sda = new MySqlDataAdapter(query, connection);
            DataTable dtb1 = new DataTable();
            sda.Fill(dtb1);
            if (dtb1.Rows.Count == 1)
            {
                return true;
            }
            return false;
        }
    }
}
