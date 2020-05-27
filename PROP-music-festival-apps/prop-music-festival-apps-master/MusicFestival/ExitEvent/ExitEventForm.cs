using System;
using System.Drawing;
using System.Windows.Forms;
using Common;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ExitEvent
{
    public partial class ExitEventForm : Form, RfidTagListener

    {
        private bool rfidReaderEnabled;
        private string rfidNumber;


        string connectionstring = "server=studmysql01.fhict.local;" +
                                   "Uid=dbi401372;" +
                                   "Database=dbi401372;" +
                                   "Pwd=Xsy2X]XjdL;";
        int eventid;
        Participant participant;
        DatabaseUtils db = new DatabaseUtils();
        MySqlConnection connection;
        MySqlCommand command;
        MySqlConnection connection1;
        MySqlCommand command1;

        public ExitEventForm(int eventIdFromLogIn)
        {
            InitializeComponent();
            OpenRfidConnection();
            eventid = eventIdFromLogIn;
        }

        private void ExitEventForm_Load(object sender, System.EventArgs e)
        {

        }

        private void btnExitAndReturnMoney_Click(object sender, System.EventArgs e)
        {
            //UPDATE THE BALANCE OF THE USER

            db.Connect();
            MySqlCommand command2;

            string updateBalance = "UPDATE user_ SET Balance=@ba WHERE UserID = @userId";
            command2 = new MySqlCommand(updateBalance, db.GetConnection());
            command2.Parameters.AddWithValue("@ba", 0);
            command2.Parameters.AddWithValue("@userId", participant.Userid);
            command2.ExecuteNonQuery();


            MySqlCommand command3;           
            string currentStatus = "SELECT Status_ FROM user_ WHERE UserID = @userId";
            command3 = new MySqlCommand(currentStatus, db.GetConnection());
            command3.Parameters.AddWithValue("@userId", participant.Userid);

            var dr = command3.ExecuteReader();
            dr.Read();
            string status_ = Convert.ToString(dr["Status_"]);
            dr.Close();
            db.Close();
            db.Connect();

            MySqlCommand command4;
            if (status_ == "Yes")
            {
                string updateStatus = "UPDATE user_ SET Status_=@st WHERE UserID = @userId";
                command4 = new MySqlCommand(updateStatus, db.GetConnection());
                command4.Parameters.AddWithValue("@st", "No");
                command4.Parameters.AddWithValue("@userId", participant.Userid);
                command4.ExecuteNonQuery();
                db.Close();
                lbBalance.Text = "0 €";
                MessageBox.Show("Current Balance is 0 and You can exit the event!");
            }
            else
            {
                MessageBox.Show("You have already exit the event!");
            }

        }

        private void btnExitWithoutReturning_Click(object sender, EventArgs e)
        {

            db.Connect();
            MySqlCommand command3;
            string currentStatus = "SELECT Status_ FROM user_ WHERE UserId = @userId";
            command3 = new MySqlCommand(currentStatus, db.GetConnection());
            command3.Parameters.AddWithValue("@userId", participant.Userid);

            var dr = command3.ExecuteReader();
            dr.Read();
            string status_ = Convert.ToString(dr["Status_"]);
            dr.Close();
            db.Close();

            db.Connect();
            MySqlCommand command4;
            if (status_ == "Yes")
            {
                string updateStatus = "UPDATE user_ SET Status_=@st WHERE UserId = @userId";
                command4 = new MySqlCommand(updateStatus, db.GetConnection());
                command4.Parameters.AddWithValue("@st", "No");
                command4.Parameters.AddWithValue("@userId", participant.Userid);
                command4.ExecuteNonQuery();
                db.Close();
                MessageBox.Show("You can exit the event!");
            }
            else
            {
                MessageBox.Show("You have already exit the event!");
            }

        }

        private void btnCheckReturning_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            connection = new MySqlConnection(this.connectionstring);
            command = new MySqlCommand("UPDATE borrow_activity SET Quantity = 0 WHERE UserId= '" + participant.Userid + "';", connection);
            connection.Open();
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                command.Parameters.AddWithValue("Quantity", 0);
            }
            connection.Close();
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close(); 
            connection1 = new MySqlConnection(this.connectionstring);
            command1 = new MySqlCommand("SELECT d.Name_ , b.Quantity FROM device d JOIN borrow_activity b ON d.DeviceId = b.DeviceId WHERE b.UserId= '" + participant.Userid + "';", connection1);

            connection1.Open();
            MySqlDataReader reader1 = command1.ExecuteReader();
            while (reader1.Read())
            {
                listBox1.Items.Add(reader1["Name_"] + "      " + reader1["Quantity"]);
            }
            connection1.Close();
            btnCheckReturning.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            connection1 = new MySqlConnection(this.connectionstring);
            command1 = new MySqlCommand("SELECT d.Name_ , b.Quantity FROM device d JOIN borrow_activity b ON d.DeviceId = b.DeviceId WHERE b.UserId= '" + participant.Userid + "';", connection1);

            connection1.Open();
            MySqlDataReader reader = command1.ExecuteReader();
            while(reader.Read())
            {
                listBox1.Items.Add(reader["Name_"] + "      " + reader["Quantity"]);
            }
            connection1.Close();
            btnCheckReturning.Enabled = true;
        }

        private void BtnOpenConnection_Click(object sender, EventArgs e)
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
                lbBalance.Text = participant.Balance.ToString() + " €";
            }
            else
            {
                MessageBox.Show("User could not be found with this rfid number");
            }
        }
    }
}
