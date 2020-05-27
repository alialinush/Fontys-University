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
using Common;

namespace LoaningShops
{
    public partial class FormLoaningShop : Form, RfidTagListener
    {

        string connectionstring = "server=studmysql01.fhict.local;" +
                                    "Uid=dbi401372;" +
                                    "Database=dbi401372;" +
                                    "Pwd=Xsy2X]XjdL;";
        MySqlCommand commandG = null;
        MySqlConnection connectionG;
        int eventid;
        List<Device> devices;
        Participant participant;

        DatabaseUtils db = new DatabaseUtils();
        DatabaseUtils db2 = new DatabaseUtils();
        DatabaseUtils db3 = new DatabaseUtils();
        MySqlConnection connection2;
        MySqlConnection connection3;
        MySqlConnection connection4;
        MySqlConnection connectionA;
        MySqlConnection connectionL;
        MySqlCommand command2;


        private bool rfidReaderEnabled;
        private string rfidNumber;


        public FormLoaningShop(int eventIdFromLogIn)
        {
            InitializeComponent();

            eventid = eventIdFromLogIn;
            lbEvent.Text = "Event:" + eventid.ToString();



            participant = new Participant();

            devices = new List<Device>();

            MySqlConnection connection = null;
            MySqlCommand command = null;

            OpenRfidConnection();

            try
            {
                connection = new MySqlConnection(this.connectionstring);
                command = new MySqlCommand("select DeviceId,Name_,Price,TotalAmount,LoanedAmount,LoaningShopId,EventId from device where EventId='" + eventid + "'", connection);


                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {

                    int deviceid = Convert.ToInt32(reader["DeviceId"]);
                    string name = Convert.ToString(reader["Name_"]);
                    int price = Convert.ToInt32(reader["Price"]);
                    int totalamount = Convert.ToInt32(reader["TotalAmount"]);
                    int loanedamount = Convert.ToInt32(reader["LoanedAmount"]);
                    int loaningshopid = Convert.ToInt32(reader["LoaningShopId"]);

                    int eventid = Convert.ToInt32(reader["EventId"]);

                    Device device = new Device(deviceid, name, price, totalamount, loanedamount, loaningshopid, eventid);

                    devices.Add(device);
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

            foreach (Device d in devices)
            {
                lbItems.Items.Add(d.Name);
            }
            // ShowInfoBorrowActivity();

            //I added the devices for the specific event in the listbox
            if (tbSearchUser.Text == "")
            {
                lbBorrowActivity.Items.Clear();

            }

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void FormLoaningShop_Load(object sender, EventArgs e)
        {


        }


        private void BtnOpenRFID_Click(object sender, EventArgs e)
        {

            if (rfidReaderEnabled) CloseRfidConnection(); else OpenRfidConnection();
        }

        private void OpenRfidConnection()
        {
            RfidUtils.Instance.OpenConnection();
            RfidUtils.Instance.SetTagListener(this);
            btRFIDReader.Text = "Close connection";
            rfidReaderEnabled = true;
        }

        private void CloseRfidConnection()
        {
            RfidUtils.Instance.CloseConnection();
            btRFIDReader.Text = "Open connection";
            rfidReaderEnabled = false;
        }

        /**
         * Implementation of RfidTagListener interface
         */
        public void OnTagChange(string tagId)
        {
            Invoke(new Action(() => rfidNumber = tagId));
            Invoke(new Action(() => GetParticipantByRfid(rfidNumber)));
      
        }

        private Participant GetParticipantByRfid(string rfidNumber)
        {
            connectionG = new MySqlConnection(connectionstring);

            connectionG.Open();


            string query = "SELECT UserId,FirstName,LastName,Address,Balance,Status_,Role,Ticket.Id as TicketNumber FROM User_ INNER JOIN Ticket ON User_.Email=Ticket.Email WHERE Ticket.RfidNumber=@rfidnumber";

            MySqlCommand commandx = new MySqlCommand(query, connectionG);
            commandx.Parameters.AddWithValue("@rfidnumber", rfidNumber);

            MySqlDataReader readerG = commandx.ExecuteReader();

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

                lbName.Text = firstname;
                lbTicketNo.Text = ticketnr.ToString();
                lbBalanace.Text = balance.ToString();
                lbUserIfFromRFID.Text = userid.ToString();


                lbParticipants.Items.Add("Name:" + firstname + " " + lastname + " userid:" + userid);

            }

            connectionG.Close();

            return visitor;
        }
         
        private Device SearchDevice(string name)
        {
            foreach (Device d in devices)
            {
                if (d.Name == name)
                {
                    return d;
                }
            }
            return null;
        }

        private void lbItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            Device deviceSelected = SearchDevice(lbItems.SelectedItem.ToString());

            lbAmountP.Text = "0";


            if (!deviceSelected.CheckEnoughAmount())
            {
                MessageBox.Show(deviceSelected.Name + "doesn't have enough amount");
            }
            else
            {

                lbDevicePrice.Text = deviceSelected.Price.ToString() + " euro";


            }//if it has enough amount it will show its information
        }

        private void button_click(object sender, EventArgs e)
        {
            Device deviceSelected = SearchDevice(lbItems.SelectedItem.ToString());

            if (lbAmountP.Text == "0")
            {
                lbAmountP.Text = "";
            }

            Button b = (Button)sender;

            lbAmountP.Text = lbAmountP.Text + b.Text; //adding an amount

            if (deviceSelected.TotalAmount <= Convert.ToInt32(lbAmountP.Text))    //check if the amount given has crossed the limit
            {
                MessageBox.Show(deviceSelected.Name + " has crossed the limit");
            }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            lbAmountP.Text = "0";
        }

        private void LoanPage_Click(object sender, EventArgs e)
        {

        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            Device deviceSelected = SearchDevice(lbItems.SelectedItem.ToString());


            if (participant.orders.Count == 0)
            {
                Order order = new Order();
                participant.orders.Add(order);
                order.Add(deviceSelected, Convert.ToInt32(lbAmountP.Text));

                lbOrder.Items.Add(deviceSelected.Name + " " + lbAmountP.Text);
            }
            else if (participant.orders.Count == 1)
            {
                participant.orders[participant.orders.Count - 1].Add(deviceSelected, Convert.ToInt32(lbAmountP.Text));
                lbOrder.Items.Add(deviceSelected.Name + "" + lbAmountP.Text);
            }
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            int index = lbOrder.SelectedIndex;

            if (index == -1)
            {
                lbOrder.Items.RemoveAt(index + 1);
                Order findOrder = participant.orders[participant.orders.Count - 1];
                findOrder.devicesOrdered.RemoveAt(index + 1);
                findOrder.prices.RemoveAt(index + 1);
                findOrder.quant.RemoveAt(index + 1);
            }
            else if (index == 0)
            {
                lbOrder.Items.RemoveAt(index);
                Order findOrder = participant.orders[participant.orders.Count - 1];
                findOrder.devicesOrdered.RemoveAt(index);
                findOrder.prices.RemoveAt(index);
                findOrder.quant.RemoveAt(index);
            }
        }

        private void btLoan_Click(object sender, EventArgs e)
        {

            if (rfidNumber != "")
            {
                lbPayment.Text = participant.orders[participant.orders.Count - 1].Total().ToString();
               

                //Find the user-connection2.command2

                connection2 = new MySqlConnection(this.connectionstring);
                command2 = new MySqlCommand("select UserId,FirstName,LastName,Address,BankAccId,Balance,Status_,Role from user_ WHERE UserId=@userid",connection2);
                command2.Parameters.AddWithValue("@userid", lbUserIfFromRFID.Text);

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

                //participantul cu care lucram este pus in lista participants si acum ii completam valorile
                //deci participantul asta cu care lucram are un userid,in lista acest participant o sa aiba un user id

                //INSERT INTO BORROW ACTIVITY-db,command1

                if (participant.Balance > participant.orders[participant.orders.Count - 1].Total())
                {

                    db.Connect();
                    MySqlCommand command1;

                    Order findOrdern = participant.orders[participant.orders.Count - 1];
                    for (int i = 0; i < findOrdern.devicesOrdered.Count; i++)
                    {
                        string insertstring = "INSERT INTO borrow_activity(DeviceId,EventId,UserId,Quantity,Pay) VALUES ('" + participant.orders[participant.orders.Count - 1].devicesOrdered[i].DeviceId + "','" + eventid + "','" + lbUserIfFromRFID.Text + "','" + participant.orders[participant.orders.Count - 1].quant[i] + "','" + participant.orders[participant.orders.Count - 1].prices[i] + "' );";
                        command1 = new MySqlCommand(insertstring, db.GetConnection());
                        command1.ExecuteNonQuery();
                    }
                    db.Close();



                    //Update TOTAL AMOUNT OF DEVICES-connection3,command3,commandx
                    db.Connect();
                    MySqlCommand command3;

                    Order findOrdern2 = participant.orders[participant.orders.Count - 1];

                    for (int i = 0; i < findOrdern2.devicesOrdered.Count; i++)
                    {
                        //                    foreach(Item item in participant.orders[participant.orders.Count-1].itemsOrdered )
                        //                    { 
                        //}


                        connection3 = new MySqlConnection(this.connectionstring);

                        command3 = new MySqlCommand("select TotalAmount from device WHERE Name_= '" + participant.orders[participant.orders.Count - 1].devicesOrdered[i].Name + "'", connection3);


                        connection3.Open();
                        MySqlDataReader reader1 = command3.ExecuteReader();
                        while (reader1.Read())
                        {
                            MySqlCommand commandx;

                            int totalamount = Convert.ToInt32(reader1["TotalAmount"]);
                            totalamount = totalamount - participant.orders[participant.orders.Count - 1].quant[i];


                            string insertstring = "UPDATE device SET TotalAmount=@am WHERE Name_ = @Name";
                            commandx = new MySqlCommand(insertstring, db.GetConnection());
                            commandx.Parameters.AddWithValue("@am", totalamount);
                            commandx.Parameters.AddWithValue("@Name", participant.orders[participant.orders.Count - 1].devicesOrdered[i].Name);
                            commandx.ExecuteNonQuery();

                        }
                        connection3.Close();
                    }


                    //UPDATE AmounedLoaned


                    db.Connect();
                    MySqlCommand command4;

                    Order findOrdersmth = participant.orders[participant.orders.Count - 1];

                    for (int i = 0; i < findOrdersmth.devicesOrdered.Count; i++)
                    {
                        //                    foreach(Item item in participant.orders[participant.orders.Count-1].itemsOrdered )
                        //                    { 
                        //}


                        connection4 = new MySqlConnection(this.connectionstring);

                        command4 = new MySqlCommand("select LoanedAmount from device WHERE Name_= '" + participant.orders[participant.orders.Count - 1].devicesOrdered[i].Name + "'", connection4);


                        connection4.Open();
                        MySqlDataReader reader1 = command4.ExecuteReader();
                        while (reader1.Read())
                        {
                            MySqlCommand command5;

                            int loanedamount = Convert.ToInt32(reader1["LoanedAmount"]);
                            loanedamount = loanedamount + participant.orders[participant.orders.Count - 1].quant[i];


                            string insertstring = "UPDATE device SET LoanedAmount=@aml WHERE Name_ = @Name";
                            command5 = new MySqlCommand(insertstring, db.GetConnection());
                            command5.Parameters.AddWithValue("@aml", loanedamount);
                            command5.Parameters.AddWithValue("@Name", participant.orders[participant.orders.Count - 1].devicesOrdered[i].Name);
                            command5.ExecuteNonQuery();

                        }
                        connection4.Close();

                    }


                    //UPDATE THE BALANCE OF THE USER

                    db.Connect();
                    MySqlCommand command6;
                    participant.Balance = participant.Balance - participant.orders[participant.orders.Count - 1].Total();

                    string updatestring = "UPDATE user_ SET Balance=@ba WHERE UserID = @userId";
                    command6 = new MySqlCommand(updatestring, db.GetConnection());
                    command6.Parameters.AddWithValue("@ba", participant.Balance);
                    command6.Parameters.AddWithValue("@userId", participant.Userid);
                    command6.ExecuteNonQuery();
                    db.Close();

                    lbMessage.Text = "The loaning was successful";

                }

                else
                {
                    lbMessage.Text = "The user doesn't have enough money";
                }
            }
            else
            {
                ConfirmForRfid();
            }
        }

        public void ConfirmForRfid()
        {

            lbPayment.Text = participant.orders[participant.orders.Count - 1].Total().ToString();


            //Find the user-connection2.command2

            connection2 = new MySqlConnection(this.connectionstring);
            command2 = new MySqlCommand("select UserId,FirstName,LastName,Address,BankAccId,Balance,Status_,Role from user_ WHERE UserId= '" + tbUserId.Text.Trim() + "'", connection2);

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


            //INSERT INTO BORROW ACTIVITY-db,command1

            if (participant.Balance > participant.orders[participant.orders.Count - 1].Total())
            {

                db.Connect();
                MySqlCommand command1;

                Order findOrdern = participant.orders[participant.orders.Count - 1];
                for (int i = 0; i < findOrdern.devicesOrdered.Count; i++)
                {
                    string insertstring = "INSERT INTO borrow_activity(DeviceId,EventId,UserId,Quantity,Pay) VALUES ('" + participant.orders[participant.orders.Count - 1].devicesOrdered[i].DeviceId + "','" + eventid + "','" + tbUserId.Text + "','" + participant.orders[participant.orders.Count - 1].quant[i] + "','" + participant.orders[participant.orders.Count - 1].prices[i] + "' );";
                    command1 = new MySqlCommand(insertstring, db.GetConnection());
                    command1.ExecuteNonQuery();
                }
                db.Close();



                //Update TOTAL AMOUNT OF DEVICES-connection3,command3,commandx
                db.Connect();
                MySqlCommand command3;

                Order findOrdern2 = participant.orders[participant.orders.Count - 1];

                for (int i = 0; i < findOrdern2.devicesOrdered.Count; i++)
                {
                    //                    foreach(Item item in participant.orders[participant.orders.Count-1].itemsOrdered )
                    //                    { 
                    //}


                    connection3 = new MySqlConnection(this.connectionstring);

                    command3 = new MySqlCommand("select TotalAmount from device WHERE Name_= '" + participant.orders[participant.orders.Count - 1].devicesOrdered[i].Name + "'", connection3);


                    connection3.Open();
                    MySqlDataReader reader1 = command3.ExecuteReader();
                    while (reader1.Read())
                    {
                        MySqlCommand commandx;

                        int totalamount = Convert.ToInt32(reader1["TotalAmount"]);
                        totalamount = totalamount - participant.orders[participant.orders.Count - 1].quant[i];


                        string insertstring = "UPDATE device SET TotalAmount=@am WHERE Name_ = @Name";
                        commandx = new MySqlCommand(insertstring, db.GetConnection());
                        commandx.Parameters.AddWithValue("@am", totalamount);
                        commandx.Parameters.AddWithValue("@Name", participant.orders[participant.orders.Count - 1].devicesOrdered[i].Name);
                        commandx.ExecuteNonQuery();

                    }
                    connection3.Close();
                }




                //UPDATE AmounedLoaned


                db.Connect();
                MySqlCommand command4;

                Order findOrdersmth = participant.orders[participant.orders.Count - 1];

                for (int i = 0; i < findOrdersmth.devicesOrdered.Count; i++)
                {
                    //                    foreach(Item item in participant.orders[participant.orders.Count-1].itemsOrdered )
                    //                    { 
                    //}


                    connection4 = new MySqlConnection(this.connectionstring);

                    command4 = new MySqlCommand("select LoanedAmount from device WHERE Name_= '" + participant.orders[participant.orders.Count - 1].devicesOrdered[i].Name + "'", connection4);


                    connection4.Open();
                    MySqlDataReader reader1 = command4.ExecuteReader();
                    while (reader1.Read())
                    {
                        MySqlCommand command5;

                        int loanedamount = Convert.ToInt32(reader1["LoanedAmount"]);
                        loanedamount = loanedamount + participant.orders[participant.orders.Count - 1].quant[i];


                        string insertstring = "UPDATE device SET LoanedAmount=@aml WHERE Name_ = @Name";
                        command5 = new MySqlCommand(insertstring, db.GetConnection());
                        command5.Parameters.AddWithValue("@aml", loanedamount);
                        command5.Parameters.AddWithValue("@Name", participant.orders[participant.orders.Count - 1].devicesOrdered[i].Name);
                        command5.ExecuteNonQuery();

                    }
                    connection4.Close();



                    //UPDATE THE BALANCE OF THE USER

                    db.Connect();
                    MySqlCommand command6;
                    participant.Balance = participant.Balance - participant.orders[participant.orders.Count - 1].Total();

                    string updatestring = "UPDATE user_ SET Balance=@ba WHERE UserID = @userId";
                    command6 = new MySqlCommand(updatestring, db.GetConnection());
                    command6.Parameters.AddWithValue("@ba", participant.Balance);
                    command6.Parameters.AddWithValue("@userId", participant.Userid);
                    command6.ExecuteNonQuery();
                    db.Close();



                    lbMessage.Text = "The loaning was successful";

                }
            }
            else
            {
                lbMessage.Text = "The loaning was not successful";
            }
        }
        private void ReturnPage_Click(object sender, EventArgs e)
        {

        }

        private void lbBorrowActivity_SelectedIndexChanged(object sender, EventArgs e)
        {


            string nameDevice = lbBorrowActivity.SelectedItem.ToString();

            //MySqlConnection connectionM;
            MySqlCommand commandM;
            int userid = Convert.ToInt32(tbSearchUser.Text);

            try
            {
                // connectionM = new MySqlConnection(this.connectionstring);
                db.Connect();
                commandM = new MySqlCommand("select borrow_activity.BorrowNr,borrow_activity.DeviceId,borrow_activity.EventId,UserId,Quantity,Pay from borrow_activity  INNER JOIN device   on borrow_activity.DeviceId=device.DeviceId where UserId=@USERID AND device.Name_=@NAMED", db.GetConnection());
                commandM.Parameters.AddWithValue("@USERID", userid);
                commandM.Parameters.AddWithValue("@NAMED", nameDevice);

                // connectionM.Open();
                MySqlDataReader reader = commandM.ExecuteReader();
                while (reader.Read())
                {
                    int borrownr = Convert.ToInt32(reader["BorrowNr"]);
                    int deviceid = Convert.ToInt32(reader["DeviceId"]);
                    int eventid = Convert.ToInt32(reader["EventId"]);
                    int useridd = Convert.ToInt32(reader["UserId"]);
                    int quantity = Convert.ToInt32(reader["Quantity"]);
                    int pay = Convert.ToInt32(reader["Pay"]);
                    //string name= Convert.ToString(reader["Name_"]);



                    Device searchedDevice = SearchDevice(deviceid);
                    if (searchedDevice.Name == nameDevice)
                    {
                        // lbQuantity.Text = quantity.ToString();
                        BorrowActivity brAc = new BorrowActivity(borrownr, deviceid, eventid, useridd, quantity, pay);
                        lbQuantity.Text = brAc.Quantity.ToString();
                        lbBorrowNr.Text = brAc.BorrowNr.ToString();
                    }

                }
                db.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        public void ShowInfoBorrowActivity()
        {

        }
        private Device SearchDevice(int deviceid)
        {
            foreach (Device d in devices)
            {
                if (d.DeviceId == deviceid)
                {
                    return d;
                }
            }
            return null;
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            participant = new Participant();
            lbOrder.Items.Clear();
            lbAmountP.Text = 0.ToString();
            lbDevicePrice.Text = "";
            lbMessage.Text = "";

            lbUserIfFromRFID.Text = "";
            lbName.Text = "";
            lbTicketNo.Text = "";
            lbBalanace.Text = "";
        }

        private void btShowBCustomer_Click(object sender, EventArgs e)
        {

        }

        private void ShowBorrowAcitivityForUser()
        {

        }
        public void ShowInfoBorrowActivityUser(int userid)
        {

        }

        private void tbSearchUser_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void btRefresh_Click(object sender, EventArgs e)
        {

        }

        public void ShowInfoPerUser(int userid)
        {
            MySqlConnection connection = null;
            MySqlCommand command = null;

            try
            {
                connection = new MySqlConnection(this.connectionstring);
                command = new MySqlCommand("select DeviceId,EventId,UserId,Quantity,Pay from borrow_activity where UserId='" + userid + "'", connection);


                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {

                    int deviceid = Convert.ToInt32(reader["DeviceId"]);
                    int eventid = Convert.ToInt32(reader["EventId"]);
                    int useridd = Convert.ToInt32(reader["UserId"]);
                    int quantity = Convert.ToInt32(reader["Quantity"]);
                    int pay = Convert.ToInt32(reader["Pay"]);

                    Device searchedDevice = SearchDevice(deviceid);
                    participant.Userid = userid;

                    string s = searchedDevice.Name;
                    lbBorrowActivity.Items.Add(s);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void btReturn_Click(object sender, EventArgs e)
        {
            string nameDevice = lbBorrowActivity.SelectedItem.ToString();

            //Scad Cantitatea din borrow acitvity

            MySqlCommand commandA;
            MySqlCommand commandx3;//

            MySqlCommand commandx2;

            connectionA = new MySqlConnection(this.connectionstring);
            commandA = new MySqlCommand("select Quantity from borrow_activity WHERE BorrowNr=@borrownr AND UserId=@userid", connectionA);
            commandA.Parameters.AddWithValue("@borrownr", lbBorrowNr.Text);
            commandA.Parameters.AddWithValue("@userid", tbSearchUser.Text);

            
            connectionA.Open();
            MySqlDataReader reader1 = commandA.ExecuteReader();
            MySqlCommand commandx;
            int quantity = 0;
            while (reader1.Read())
            {
                
                db.Connect();

                 quantity = Convert.ToInt32(reader1["Quantity"]); //cantitatea pe care o avem pt un anumit user si borrownr
                lbQuantity.Text = (quantity - 1).ToString();
                quantity = quantity - 1;
                

                int quantity2 = Convert.ToInt32(reader1["Quantity"]);
                quantity2 = quantity2 + 1;

            }

                string insertstring = "UPDATE borrow_activity SET Quantity=@qu WHERE BorrowNr=@borrownr AND UserId=@userid";

                commandx = new MySqlCommand(insertstring, db.GetConnection());

                commandx.Parameters.AddWithValue("@qu", quantity);
                commandx.Parameters.AddWithValue("@borrownr", lbBorrowNr.Text);
                commandx.Parameters.AddWithValue("@userid", tbSearchUser.Text);

                commandx.ExecuteNonQuery();

                connectionA.Close();
                db.Close();
            
             MySqlConnection connectionZ = new MySqlConnection(this.connectionstring);
                 connectionZ.Open();
                commandx3 = new MySqlCommand("select TotalAmount from device WHERE DeviceId=@deviceid", connectionZ);//
            commandx3.Parameters.AddWithValue("@deviceid", SearchDevice(nameDevice).DeviceId); //
            int totalquantity = 0;
                MySqlDataReader reader2 = commandx3.ExecuteReader();
                while(reader2.Read())
                {
                     totalquantity = Convert.ToInt32(reader2["TotalAmount"]);//
                    totalquantity = totalquantity + 1; //

                }
            connectionZ.Close();

                db2.Connect();
                string insertstring2 = "UPDATE device SET TotalAmount=@totalamount WHERE DeviceId=@deviceid";
                commandx2 = new MySqlCommand(insertstring2, db2.GetConnection());
                commandx2.Parameters.AddWithValue("@totalamount", totalquantity); //instead of quantity2 totalamount

                commandx2.Parameters.AddWithValue("@deviceid", SearchDevice(nameDevice).DeviceId);
                commandx2.ExecuteNonQuery();

                db2.Close();

            MySqlCommand commandx4;
            MySqlConnection connectionQ = new MySqlConnection(this.connectionstring);
            connectionQ.Open();
            commandx4 = new MySqlCommand("select LoanedAmount from device WHERE DeviceId=@deviceid", connectionQ);//
            commandx4.Parameters.AddWithValue("@deviceid", SearchDevice(nameDevice).DeviceId); //
            int loanedamount = 0;
            MySqlDataReader reader3 = commandx4.ExecuteReader();
            while (reader3.Read())
            {


                loanedamount = Convert.ToInt32(reader3["LoanedAmount"]);//
                loanedamount = loanedamount-1; //

            }
            connectionQ.Close();


            db3.Connect();
            MySqlCommand commandx5;
            string insertstring3 = "UPDATE device SET LoanedAmount=@loanedamount WHERE DeviceId=@deviceid";
            commandx5 = new MySqlCommand(insertstring3, db3.GetConnection());
            commandx5.Parameters.AddWithValue("@loanedamount", loanedamount); //instead of quantity2 totalamount

            commandx5.Parameters.AddWithValue("@deviceid", SearchDevice(nameDevice).DeviceId);
            commandx5.ExecuteNonQuery();

            db3.Close();
        
           
        }

        private void btRFIDReader_Click(object sender, EventArgs e)
        {

        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            if (tbSearchUser.Text != "")
            {
                ShowInfoPerUser(Convert.ToInt32(tbSearchUser.Text));
            }
            if (tbSearchUser.Text == "")
            {
                lbBorrowActivity.Items.Clear();
            }
        }
    }
}
