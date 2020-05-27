using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace CampingAuthorization
{
    public partial class LogInEmployeeCampingAuthorisation : Form
    {

        List<Event> events;
        int selectedeventId;



        string connectionstring = "server=studmysql01.fhict.local;" +
                                   "Uid=dbi401372;" +
                                   "Database=dbi401372;" +
                                   "Pwd=Xsy2X]XjdL;";
        public LogInEmployeeCampingAuthorisation()
        {
            InitializeComponent();

            events = new List<Event>();
            MySqlConnection conn = null;
            MySqlCommand command = null;


            conn = new MySqlConnection(this.connectionstring);

            command = new MySqlCommand("select EventId,UserId,Title,Description,StartDate,EndDate,TicketPrice,NrTickets,NrSpotsAvailable,CampingSpotPrice,Address from event_;", conn);

            conn.Open();
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
                int campingsportprice = Convert.ToInt32(reader["CampingSpotPrice"]);
                string location = Convert.ToString(reader["Address"]);

                Event eventi = new Event(eventid, userid, title, description, dtStart, dtEnd, ticketprice, nrtickets, nrspotsavail, campingsportprice, location);
                events.Add(eventi);

            }
            conn.Close();


            //choose an event
            foreach (Event e in events)
            {
                lbAvailableEvents.Items.Add(e.Title);
            }
        }

        private void btChooseEvent_Click(object sender, EventArgs e)
        {
            Event eventedSearched = SearchEvent(lbAvailableEvents.SelectedItem.ToString());

            selectedeventId = eventedSearched.EventId;

            Event SearchEvent(string title)
            {
                foreach (Event ev in events)
                {
                    if (ev.Title == title)
                    {
                        return ev;
                    }
                }
                return null;
            }
        }

        private void btLogIn_Click(object sender, EventArgs e)
        {
            MySqlConnection sqlconn = new MySqlConnection(("server=studmysql01.fhict.local;" +
                                  "Uid=dbi401372;" +
                                  "Database=dbi401372;" +
                                  "Pwd=Xsy2X]XjdL;"));


            string query = "SELECT * FROM user_ WHERE UserId= '" + tbEmployeeId.Text.Trim() + "' and Password_= '" + tbPassWord.Text.Trim() + "'";

            MySqlCommand command = new MySqlCommand(query, sqlconn);
            MySqlDataAdapter sda = new MySqlDataAdapter(query, sqlconn);
            DataTable dtb1 = new DataTable();
            sda.Fill(dtb1);
            if (dtb1.Rows.Count == 1)
            {
                CampingAuthorizationForm form = new CampingAuthorizationForm(selectedeventId);
                form.Show();
                this.Hide();
                MessageBox.Show("Welcome Employee");
            }
            else
            {
                MessageBox.Show("UserId or Password is incorrect");
            }
        }
    }
}
