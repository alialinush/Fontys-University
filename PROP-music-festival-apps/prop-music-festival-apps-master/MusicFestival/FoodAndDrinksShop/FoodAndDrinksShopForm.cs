using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Common;
using MySql.Data.MySqlClient;

namespace FoodAndDrinkShop
{
    public partial class FoodAndDrinksShopForm : Form, RfidTagListener
    {

        string connectionstring = "server=studmysql01.fhict.local;" +
                                    "Uid=dbi401372;" +
                                    "Database=dbi401372;" +
                                    "Pwd=Xsy2X]XjdL;";
        int eventid;
        List<Item> items;
        Participant participant;
        DatabaseUtils db = new DatabaseUtils();
        DatabaseUtils db1 = new DatabaseUtils();
        MySqlConnection connection2 = null;
        MySqlConnection connection3 = null;
        MySqlConnection connectionG = null;
        //MySqlConnection connection4 = null;
        MySqlCommand command2 = null;
        MySqlCommand commandG = null;

        private bool rfidReaderEnabled;
        private string rfidNumber;

        public FoodAndDrinksShopForm(int eventIdFromLogIn)
        {
            InitializeComponent();

            participant = new Participant();
            eventid = eventIdFromLogIn;
            lbEvent.Text = eventid.ToString();
            items = new List<Item>();
            MySqlConnection connection = null;
            MySqlCommand command = null;

            OpenRfidConnection();

            try
            {
                connection = new MySqlConnection(this.connectionstring);
                command = new MySqlCommand("select EventId,ItemId,Name_,Price,Amount,FoodShopId,Type from item where EventId='" + lbEvent.Text + "'", connection);


                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {

                    int itemid = Convert.ToInt32(reader["ItemId"]);
                    string name = Convert.ToString(reader["Name_"]);
                    int price = Convert.ToInt32(reader["Price"]);
                    int amount = Convert.ToInt32(reader["Amount"]);
                    int foodshopid = Convert.ToInt32(reader["FoodShopId"]);
                    string type = Convert.ToString(reader["Type"]);
                    int eventid = Convert.ToInt32(reader["EventId"]);

                    Item item = new Item(eventid, itemid, name, price, amount, type, foodshopid);

                    items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //always close the connection
                if (connection != null) connection.Close();
            }

            foreach (Item i in items)
            {
                lbItems.Items.Add(i.Name);
            }
         
        }

        private void button_Click(object sender, EventArgs e)
        {
            Item itemselected = SearchItem(lbItems.SelectedItem.ToString());

            if (lbAmount.Text == "0")
            {
                lbAmount.Text = "";
            }
            Button b = (Button)sender;

            lbAmount.Text = lbAmount.Text + b.Text; //adding an amount

            if (itemselected.Amount <= Convert.ToInt32(lbAmount.Text))    //check if the amount given has crossed the limit
            {
                MessageBox.Show(itemselected.Name + " has crossed the limit");
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lbAmount.Text = "0";
        }

        private void gbItems_Enter(object sender, EventArgs e)
        {

        }

        private void lbItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            Item itemselected = SearchItem(lbItems.SelectedItem.ToString());

            lbAmount.Text = "0";

            if (!itemselected.CheckEnoughAmount())
            {
                MessageBox.Show(itemselected.Name + "doesn't have enough amount");
            }
            else
            {

                lbItemPrice.Text = itemselected.Price.ToString() + " €";


            } //if it has enough amount it will show its information

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Item itemselected = SearchItem(lbItems.SelectedItem.ToString());

            if (participant.orders.Count == 0)
            {
                Order order = new Order();
                participant.orders.Add(order);
                order.Add(itemselected, Convert.ToInt32(lbAmount.Text));

                lbOrder.Items.Add(itemselected.Name + " " + lbAmount.Text);
            }
            else if (participant.orders.Count == 1)
            {
                participant.orders[participant.orders.Count - 1].Add(itemselected, Convert.ToInt32(lbAmount.Text));
                lbOrder.Items.Add(itemselected.Name + "" + lbAmount.Text);
            }

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int index = lbOrder.SelectedIndex;

            if (index == -1)
            {
                lbOrder.Items.RemoveAt(index + 1);
                Order findOrder = participant.orders[participant.orders.Count - 1];
                findOrder.itemsOrdered.RemoveAt(index + 1);
                findOrder.prices.RemoveAt(index + 1);
                findOrder.quant.RemoveAt(index + 1);
            }
            else if (index == 0)
            {
                lbOrder.Items.RemoveAt(index);
                Order findOrder = participant.orders[participant.orders.Count - 1];
                findOrder.itemsOrdered.RemoveAt(index);
                findOrder.prices.RemoveAt(index);
                findOrder.quant.RemoveAt(index);
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (rfidNumber != "")
            {
                lbTotalPayment.Text = participant.orders[participant.orders.Count - 1].Total().ToString();

                connection2 = new MySqlConnection(this.connectionstring);

                command2 = new MySqlCommand("select UserId,FirstName,LastName,Address,BankAccId,Balance,Status_,Role from user_ WHERE UserId=@userid",connection2);
         
                command2.Parameters.AddWithValue("@userid", lbUserIdYes.Text);

                connection2.Open();
                MySqlDataReader reader = command2.ExecuteReader();
                while (reader.Read())
                {
                    int userid = Convert.ToInt32(reader["UserId"]);
                    string firstname = Convert.ToString(reader["FirstName"]);
                    string lastname = Convert.ToString(reader["LastName"]);
                    string address = Convert.ToString(reader["Address"]);
                    int bankAccId = 0; //Convert.ToInt32(reader["BankAccId"]);
                    int balance = Convert.ToInt32(reader["Balance"]);
                    string status = Convert.ToString(reader["Status_"]);
                    string role = Convert.ToString(reader["Role"]);

                    participant.Userid = userid;
                    participant.FirstName = firstname;
                    participant.LastName = lastname;
                    participant.Address = address;
                    participant.BankAccId = bankAccId;
                    participant.Balance = balance;
                    participant.Status = status;
                    participant.Role = role;

                }
                connection2.Close();

                //insert the order COMMAND1
                if (participant.Balance > participant.orders[participant.orders.Count - 1].Total())
                {

                    db.Connect();
                    MySqlCommand command1;

                    Order findOrdern = participant.orders[participant.orders.Count - 1];
                    for (int i = 0; i < findOrdern.itemsOrdered.Count; i++)
                    {
                        string insertstring = "INSERT INTO ORDER_ACTIVITY(EventId,ItemId,UserId,Quantity,Pay) VALUES ('" + eventid + "','" + participant.orders[participant.orders.Count - 1].itemsOrdered[i].ItemId + "','" + participant.Userid + "','" + participant.orders[participant.orders.Count - 1].quant[i] + "','" + participant.orders[participant.orders.Count - 1].prices[i] + "' );";
                        command1 = new MySqlCommand(insertstring, db.GetConnection());
                        command1.ExecuteNonQuery();
                    }
                    db.Close();

                    //CONNECTION3/COMMAND3
                    db.Connect();
                    MySqlCommand command3;

                    Order findOrdern2 = participant.orders[participant.orders.Count - 1];

                    for (int i = 0; i < findOrdern2.itemsOrdered.Count; i++)
                    {
                        
                        connection3 = new MySqlConnection(this.connectionstring);

                        command3 = new MySqlCommand("select Amount from item WHERE Name_= '" + participant.orders[participant.orders.Count - 1].itemsOrdered[i].Name + "'", connection3);


                        connection3.Open();
                        MySqlDataReader reader1 = command3.ExecuteReader();
                        while (reader1.Read())
                        {
                            MySqlCommand command4;

                            int amount = Convert.ToInt32(reader1["Amount"]);
                            amount = amount - participant.orders[participant.orders.Count - 1].quant[i];


                            string insertstring = "UPDATE item SET Amount=@am WHERE Name_ = @Name";
                            command4 = new MySqlCommand(insertstring, db.GetConnection());
                            command4.Parameters.AddWithValue("@am", amount);
                            command4.Parameters.AddWithValue("@Name", participant.orders[participant.orders.Count - 1].itemsOrdered[i].Name);
                            command4.ExecuteNonQuery();

                        }
                        connection3.Close();
                    }

                    db.Connect();
                    MySqlCommand command5;
                    participant.Balance = participant.Balance - participant.orders[participant.orders.Count - 1].Total();

                    string updatestring = "UPDATE user_ SET Balance=@ba WHERE UserID = @userId";
                    command5 = new MySqlCommand(updatestring, db.GetConnection());
                    command5.Parameters.AddWithValue("@ba", participant.Balance);
                    command5.Parameters.AddWithValue("@userId", participant.Userid);
                    command5.ExecuteNonQuery();
                    db.Close();


                    //  participant.Balance = participant.Balance - participant.orders[participant.orders.Count - 1].Total();


                    lbMessage.Text = "The purchase was successful";
                    lbBalance.Text = participant.Balance.ToString();
                }
                else
                {
                    lbMessage.Text = "The user doesn't have enough money";
                }


            }
            else
            {
                confirmForRFID();
            }

        } 

        private void btClearOrder_Click(object sender, EventArgs e)
        {
        }

        private void lbOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
             
            
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbSearch.Text != "")
                {
                    foreach (Item i in items)
                    {
                        if (i.Name.Contains(tbSearch.Text))
                        {
                            lbItems.Items.Clear();
                            lbItems.Items.Add(i.Name);
                        }
                    }
                }
                else
                {
                    lbItems.Items.Clear();
                    foreach (Item i in items)
                    {

                        lbItems.Items.Add(i.Name);
                    }

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            participant = new Participant();
            lbOrder.Items.Clear();
            lbAmount.Text = 0.ToString();
            lbItemPrice.Text = "";
            lbMessage.Text = "";
            lbTotalPayment.Text = "";


            lbBalance.Text = "";
            lbNameCustomer.Text = "";
            lbNameCustomer.Text = "";
            lbUserIdYes.Text = "";
            lbTicketNr.Text = "";

            lblSerialNo.Text = "Serial no:";
            lblDeviceStatus.Text = "Device Status:";

        }

        private Item SearchItem(string name)
        {
            foreach (Item i in items)
            {
                if (i.Name == name)
                {
                    return i;
                }
            }
            return null;
        }

        private void BtnOpenRFID_Click(object sender, EventArgs e)
        {
            
            if (rfidReaderEnabled) CloseRfidConnection(); else OpenRfidConnection();
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

        /**
         * Implementation of RfidTagListener interface
         */
        public void OnTagChange(string tagId)
        {                   
            Invoke(new Action(() => rfidNumber = tagId));
            Invoke(new Action(() => GetParticipantByRfid(rfidNumber)));
           // Invoke(new Action(() => confirmForRFID()));
        }

        private void getUserInformation()
        {
            // Select **** from user inner join ticket .... where ticket.rfidnumber = rfidNumber

            // update user data here

            btnConfirm.Visible = false; //make the btn confirm invisible
            GetParticipantByRfid(rfidNumber);

        }
        private  Participant GetParticipantByRfid (string rfidNumber)
        {
            connectionG = new MySqlConnection(connectionstring);

            connectionG.Open();

            //MySqlCommand command = new MySqlCommand("SELECT UserId,FirstName,LastName,Address,Balance,Status_,Role,Ticket.Id as TicketNumber FROM User_ " +
            //    "INNER JOIN Ticket ON User_.Email = Ticket.Email WHERE Ticket.RfidNumber= " + rfidNumber, connectionG);


            string query = "SELECT UserId,FirstName,LastName,Address,Balance,Status_,Role,Ticket.Id as TicketNumber FROM User_ INNER JOIN Ticket ON User_.Email=Ticket.Email WHERE Ticket.RfidNumber=@rfidnumber";
                
             MySqlCommand  commandx = new MySqlCommand(query, connectionG);
            commandx.Parameters.AddWithValue("@rfidnumber", rfidNumber);

            MySqlDataReader readerG = commandx.ExecuteReader();


            //command.ExecuteReader();
            //MySqlDataReader readerG = command.ExecuteReader();
           
            Participant visitor = null;
            while (readerG.Read())
            {
                int userid = Convert.ToInt32(readerG["UserId"]);
                string firstname = Convert.ToString(readerG["FirstName"]);
                string lastname = Convert.ToString(readerG["LastName"]);
                string address = Convert.ToString(readerG["Address"]);
                int balance = Convert.ToInt32(readerG["Balance"]);
                string status = Convert.ToString(readerG["Status_"]);
                int ticketnr = Convert.ToInt32(readerG["TicketNumber"]);
                string role = Convert.ToString(readerG["Role"]);

                lbNameCustomer.Text = firstname;
                lbTicketNr.Text = ticketnr.ToString();
                lbBalance.Text = balance.ToString();
                lbUserIdYes.Text = userid.ToString();

            }

            connectionG.Close();

            return visitor;
        }
        public void confirmForRFID()
        {

            lbTotalPayment.Text = participant.orders[participant.orders.Count - 1].Total().ToString();

            //Find our the user CONNECTION2-COMMAND2

            connection2 = new MySqlConnection(this.connectionstring);

            command2 = new MySqlCommand("select UserId,FirstName,LastName,Address,BankAccId,Balance,Status_,Role from user_ WHERE UserId= '" +lbUserIdYes.Text  + "'", connection2);

            connection2.Open();
            MySqlDataReader reader = command2.ExecuteReader();
            while (reader.Read())
            {
                int userid = Convert.ToInt32(reader["UserId"]);
                string firstname = Convert.ToString(reader["FirstName"]);
                string lastname = Convert.ToString(reader["LastName"]);
                string address = Convert.ToString(reader["Address"]);
                int bankAccId = Convert.ToInt32(reader["BankAccId"]);
                int balance = Convert.ToInt32(reader["Balance"]);
                string status = Convert.ToString(reader["Status_"]);
                string role = Convert.ToString(reader["Role"]);

                participant.Userid = userid;
                participant.FirstName = firstname;
                participant.LastName = lastname;
                participant.Address = address;
                participant.BankAccId = bankAccId;
                participant.Balance = balance;
                participant.Status = status;
                participant.Role = role;

            }
            connection2.Close();

            //insert the order COMMAND1
            if (participant.Balance > participant.orders[participant.orders.Count - 1].Total())
            {

                db.Connect();
                MySqlCommand command1;

                Order findOrdern = participant.orders[participant.orders.Count - 1];
                for (int i = 0; i < findOrdern.itemsOrdered.Count; i++)
                {
                    string insertstring = "INSERT INTO ORDER_ACTIVITY(EventId,ItemId,UserId,Quantity,Pay) VALUES ('" + eventid + "','" + participant.orders[participant.orders.Count - 1].itemsOrdered[i].ItemId + "','" + participant.Userid + "','" + participant.orders[participant.orders.Count - 1].quant[i] + "','" + participant.orders[participant.orders.Count - 1].prices[i] + "' );";
                    command1 = new MySqlCommand(insertstring, db.GetConnection());
                    command1.ExecuteNonQuery();
                }
                db.Close();

                //CONNECTION3/COMMAND3
                db.Connect();
                MySqlCommand command3;

                Order findOrdern2 = participant.orders[participant.orders.Count - 1];

                for (int i = 0; i < findOrdern2.itemsOrdered.Count; i++)
                {
                    //                    foreach(Item item in participant.orders[participant.orders.Count-1].itemsOrdered )
                    //                    { 
                    //}


                    connection3 = new MySqlConnection(this.connectionstring);

                    command3 = new MySqlCommand("select Amount from item WHERE Name_= '" + participant.orders[participant.orders.Count - 1].itemsOrdered[i].Name + "'", connection3);


                    connection3.Open();
                    MySqlDataReader reader1 = command3.ExecuteReader();
                    while (reader1.Read())
                    {
                        MySqlCommand command4;

                        int amount = Convert.ToInt32(reader1["Amount"]);
                        amount = amount - participant.orders[participant.orders.Count - 1].quant[i];


                        string insertstring = "UPDATE item SET Amount=@am WHERE Name_ = @Name";
                        command4 = new MySqlCommand(insertstring, db.GetConnection());
                        command4.Parameters.AddWithValue("@am", amount);
                        command4.Parameters.AddWithValue("@Name", participant.orders[participant.orders.Count - 1].itemsOrdered[i].Name);
                        command4.ExecuteNonQuery();

                    }
                    connection3.Close();
                }

                db.Connect();
                MySqlCommand command5;
                participant.Balance = participant.Balance - participant.orders[participant.orders.Count - 1].Total();

                string updatestring = "UPDATE user_ SET Balance=@ba WHERE UserID = @userId";
                command5 = new MySqlCommand(updatestring, db.GetConnection());
                command5.Parameters.AddWithValue("@ba", participant.Balance);
                command5.Parameters.AddWithValue("@userId", participant.Userid);
                command5.ExecuteNonQuery();
                db.Close();


                //  participant.Balance = participant.Balance - participant.orders[participant.orders.Count - 1].Total();


                lbMessage.Text = "The purchase was successful";

            }
            else
            {
                lbMessage.Text = "The user doesn't have enough money";
            }

        }
    }
}
