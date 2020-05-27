using Common;
using System;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;

namespace Ticket_Service
{
    public partial class TicketServiceForm : Form, RfidTagListener
    {
        DatabaseUtils db;
        DatabaseUtils db2 = new DatabaseUtils();
        MySqlConnection connection10;
        MySqlCommand command10;
         int eventid;
        string connectionstring = "server=studmysql01.fhict.local;" +
                                    "Uid=dbi401372;" +
                                    "Database=dbi401372;" +
                                    "Pwd=Xsy2X]XjdL;";

        private bool rfidReaderEnabled;
        private string rfidNumber = "";
        public TicketServiceForm(int eventidFromLogin)
        {
            InitializeComponent();
            OpenRfidConnection();
            db = new DatabaseUtils();
            eventid = eventidFromLogin;
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void rbTicketExchange_CheckedChanged(object sender, EventArgs e)
        {
            if(rbTicketExchange.Checked)
            {
                gbVerifyAccount.Visible = true;
                gbCreateAccount.Visible = false;
            }
        }

        private void tbTicketSale_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTicketSale.Checked)
            {
                gbVerifyAccount.Visible = false;
                gbCreateAccount.Visible = true;
            }
        }

        private void OpenRfidConnection()
        {
            RfidUtils.Instance.OpenConnection();
            RfidUtils.Instance.SetTagListener(this);
            btnOpenRFID.Text = "Close connection";
            rfidReaderEnabled = true;
        }

        private void CloseRfidConnection()
        {
            RfidUtils.Instance.CloseConnection();
            btnOpenRFID.Text = "Open connection";
            rfidReaderEnabled = false;
        }

        public void OnTagChange(string tagId)
        {
           // RfidUtils.Instance.CloseConnection();
     
            
            Invoke(new Action(() => rfidNumber = tagId));
            Invoke(new Action(() => lblValidRFIDNo.Text = "Rfid number: " + tagId));
        }

        private void BtnOpenRFID_Click(object sender, EventArgs e)
        {
            if (rfidReaderEnabled) CloseRfidConnection(); else OpenRfidConnection();

        }

        private void BtnBindToAccount_Click(object sender, EventArgs e)
        {
            try
            {
                int ticketNumber = Convert.ToInt32(tbTicketNo.Text);
                if (rfidNumber != "" && ticketNumber != 0)
                {
                    // update db             //dam un rfid pt ticket
                    db.Connect();
                    MySqlCommand command;

                    string updatestring = "UPDATE ticket SET RfidNumber=@rfidnumber WHERE Id = @ticketNumber";
                    command = new MySqlCommand(updatestring, db.GetConnection());
                    command.Parameters.AddWithValue("@rfidnumber", rfidNumber);
                    command.Parameters.AddWithValue("@ticketNumber", ticketNumber.ToString());
                    command.ExecuteNonQuery();
                    db.Close();
                    lbMessage.Text = "Binding succesful";
                }
            }
            catch (Exception)
            {
                lbMessage.Text = "An error occured while binding";
            }
        }


        private void btnOpenRFID_Click_1(object sender, EventArgs e)
        {

        }

        private void TicketServiceForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if(rbTicketExchange.Checked==true)
            {
                MySqlConnection sqlconn = new MySqlConnection(("server=studmysql01.fhict.local;" +
                                   "Uid=dbi401372;" +
                                   "Database=dbi401372;" +
                                   "Pwd=Xsy2X]XjdL;"));


                string query = "SELECT * FROM ticket WHERE Id= '" + tbTicketNo.Text.Trim()  + "'";

                MySqlCommand command = new MySqlCommand(query, sqlconn);
                MySqlDataAdapter sda = new MySqlDataAdapter(query, sqlconn);
                DataTable dtb1 = new DataTable();
                sda.Fill(dtb1);
                if (dtb1.Rows.Count == 1)
                {
                    lbMessage.Text = "Checked, ready to bind";
                }
                else
                {
                    lbMessage.Text = "The ticket nr doesn't exist!";
                }
            }
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
         {   
            //before this button is pressed open the rfid
            try
            {
                int userid=0;
                db.Connect();
                
              
                db.ExecuteReader("INSERT INTO user_(Email,Password_,FirstName,LastName,Address,BankAccId,Status_,Role) VALUES ('" + tbEmail.Text+ "','" + tbPassWord.Text + "','" + tbFirstName.Text + "','" + tbLastName.Text+ "','" + tbAddress.Text + "','" + tbBankAccountId.Text + "','" + tbStatus.Text + "','"+"visitor" + "' );");



                connection10 = new MySqlConnection(this.connectionstring);

                command10 = new MySqlCommand("select UserId from user_ WHERE Email= '" + tbEmail.Text.Trim() + "'", connection10);

                connection10.Open();
                MySqlDataReader reader = command10.ExecuteReader();
                while (reader.Read())
                {
                     userid = Convert.ToInt32(reader["UserId"]);

                }
                connection10.Close();

                db2.Connect();
                db2.ExecuteReader("INSERT INTO UserBooking(UserId, EventId) VALUES('" + userid + "','" + eventid + "');");

                


                reader = db2.ExecuteReader("SELECT Id FROM UserBooking WHERE userid=" + userid + " AND EventId=" + eventid);
                
                int userBookingId=0;
                while (reader.Read())
                {
                    userBookingId = Convert.ToInt32(reader["Id"]);

                }
                


                db.ExecuteReader("INSERT INTO ticket(Email,UserBookingId,RfidNumber) VALUES ('" + tbEmail.Text + "','" + userBookingId + "','" + rfidNumber + "' );");

                db.Close();

                lbMessage.Text="Account created";
                db2.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

    }
}
