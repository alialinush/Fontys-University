using System;
using System.Drawing;
using System.Windows.Forms;
using CampingAuthorization;
using Common;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace CampingAuthorization
{
    public partial class CampingAuthorizationForm : Form, RfidTagListener
    {
        private bool rfidReaderEnabled;
        private string rfidNumber;

        int eventid;
        Participant participant;

        public CampingAuthorizationForm(int eventIdFromLogIn)
        {
            InitializeComponent();
            OpenRfidConnection();
            eventid = eventIdFromLogIn;
            lbEventId.Text = eventid.ToString();
        }

        private void btnOpenConnection_Click(object sender, EventArgs e)
        {
            if (rfidReaderEnabled) CloseRfidConnection(); else OpenRfidConnection();
        }

        private void OpenRfidConnection()
        {
            RfidUtils.Instance.OpenConnection();
            RfidUtils.Instance.SetTagListener(this);
            lbRfidStatus.Text = "Running";
            lbRfidStatus.ForeColor = Color.Green;
            lbRfidStatus.Text = "Running";
            lbRfidStatus.ForeColor = Color.Green;
            btnOpenConnection.Text = "Stop bracelet scanning";
            rfidReaderEnabled = true;
        }

        private void CloseRfidConnection()
        {
            RfidUtils.Instance.CloseConnection();
            lbRfidStatus.Text = "Stopped";
            lbRfidStatus.ForeColor = Color.Red;
            lbRfidStatus.Text = "Stopped";
            lbRfidStatus.ForeColor = Color.Red;
            btnOpenConnection.Text = "Start bracelet scanning";
            rfidReaderEnabled = false;
        }

        public void OnTagChange(string tagId)
        {
            Invoke(new Action(() => rfidNumber = tagId));
            Invoke(new Action(() => showVisitorInformation()));
        }

        private void showVisitorInformation()
        {
            participant = DBManager.GetVisitorByRfid(rfidNumber);

            if (participant != null)
            {
                // visitor panel

                lbName.Text = participant.FirstName + " " + participant.LastName;
            }
            else
            {
                MessageBox.Show("User could not be found with this rfid number");
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            DatabaseUtils.Connect();
            MySqlCommand command;
            string campingTicket = "SELECT CampingSpotId FROM CampingSpotTicket INNER JOIN Ticket on CampingSpotTicket.TicketId = Ticket.Id WHERE Ticket.RfidNumber = @rfidNumber";
            command = new MySqlCommand(campingTicket, DatabaseUtils.GetConnection());
            command.Parameters.AddWithValue("@rfidNumber", rfidNumber);

            var dr = command.ExecuteReader();
            dr.Read();
            int camping_ticket = dr.GetInt32(0);
            dr.Close();
            DatabaseUtils.Close();

            if (camping_ticket != 0)
            {
                lbStatus.Text = "You have a camping spot!\n Now you can enter!";
                lbStatus.ForeColor = Color.Green;
            }
            else
            {
                lbStatus.Text = "You do not have a camping spot!";
                lbStatus.ForeColor = Color.Red;
            }
        }
    }
}
