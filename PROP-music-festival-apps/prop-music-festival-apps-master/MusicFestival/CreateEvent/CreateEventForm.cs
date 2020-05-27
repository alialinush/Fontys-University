using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CreateEvent
{
    public partial class CreateEventForm : Form
    {
        DatabaseConnection db2 = new DatabaseConnection();
        DatabaseConnection db3 = new DatabaseConnection();
        private int a = 0;

        ItemsFoodForm itemsform;
        LoaningShopForm loaningform;
        int userIdFromLogIn;

        List<Event> events = new List<Event>();

        public CreateEventForm(int userId)
        {
            InitializeComponent();
            userIdFromLogIn = userId;
            tbUserId.Text = userIdFromLogIn.ToString();
        }

        private void CreateEventForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCreateEvent_Click(object sender, EventArgs e)
        {
            db3.Connect();
            db3.ExecuteReader("INSERT INTO event_(EventId,UserId,Title, Description, StartDate, EndDate, TicketPrice, NrTickets, NrSpotsAvailable, CampingSpotPrice, Address) VALUES ('" + tbEventId.Text + "','" + tbUserId.Text + "','" + tbName.Text + "','" + tbDescription.Text + "','" + datetimeSTART.Text + "','" + datetimeEND.Text + "','" + tbTicketPrice.Text + "','" + tbNrTicketsAvailable.Text + "','" + tbNrSpotsAvailable.Text + "','" + tbCampingSpotPrice.Text + "','" + tbLocation.Text + "' );");

            db3.Close();



            Event eventi = new Event(Convert.ToInt32(tbEventId.Text), Convert.ToInt32(tbUserId.Text), tbName.Text, tbDescription.Text, Convert.ToDateTime(datetimeSTART.Text), Convert.ToDateTime(datetimeEND.Text), Convert.ToInt32(tbTicketPrice.Text), Convert.ToInt32(tbNrTicketsAvailable.Text), Convert.ToInt32(tbNrSpotsAvailable.Text), Convert.ToInt32(tbCampingSpotPrice.Text), tbLocation.Text);
            events.Add(eventi);
            a++;
            lbCountEvents.Text = a.ToString();
            foreach (string artist in lbLineUp.Items)
            {
                eventi.Lineup.AddArtist(artist);
            }



            db2.Connect();
            for (int i = 0; i < lbLineUp.Items.Count; i++)
            {
                db2.ExecuteReader("INSERT INTO lineup(Artist,EventId) VALUES ('" + lbLineUp.Items[i] + "','" + eventi.EventId + "' );");

            }
            db2.Close();




        }

         private void tbuserId_TextChanged(object sender, EventArgs e)
         {

         }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lbLineUp.Items.Add(tbArtist.Text);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            lbLineUp.Items.RemoveAt(lbLineUp.SelectedIndex);
        }

        private void rbImportAliments_CheckedChanged(object sender, EventArgs e)
        {
            if (rbImportAliments.Checked == true)
            {
                try
                {
                    itemsform = new ItemsFoodForm(Convert.ToInt32(tbEventId.Text));
                    itemsform.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    rbImportAliments.Checked = false;
                }

            }
        }

        private void rbImportForLoaningShop_CheckedChanged(object sender, EventArgs e)
        {
            if (rbImportForLoaningShop.Checked == true)
            {
                try
                {
                    loaningform = new LoaningShopForm(Convert.ToInt32(tbEventId.Text));
                    loaningform.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    
                }

            }
        }
    }
    }


