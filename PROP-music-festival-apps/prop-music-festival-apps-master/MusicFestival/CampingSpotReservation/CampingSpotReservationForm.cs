using CampingSpotReservation.DB;
using Common;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CampingSpotReservation
{
    public partial class CampingSpotReservationForm : Form, RfidTagListener
    {
        private bool rfidReaderEnabled;
        private string rfidNumber;
        private Visitor visitor;
        private CampingSpot bookedCampingSpot;
        private int eventId;

        public CampingSpotReservationForm(int eventId)
        {
            this.eventId = eventId;
            InitializeComponent();
            LoadAvailableCampingSpots();
            OpenRfidConnection();
        }

        private void LoadAvailableCampingSpots()
        {
            List<CampingSpot> campingSpots = DBManager.GetAvailableCampingSpots(eventId);
            foreach (CampingSpot campingSpot in campingSpots)
            {
                listBoxAvailableSpots.Items.Add(campingSpot);
            }
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
            lbRfidStatus2.Text = "Running";
            lbRfidStatus2.ForeColor = Color.Green;
            btnOpenConnection.Text = "Stop bracelet scanning";
            rfidReaderEnabled = true;
        }

        private void CloseRfidConnection()
        {
            RfidUtils.Instance.CloseConnection();
            lbRfidStatus.Text = "Stopped";
            lbRfidStatus.ForeColor = Color.Red;
            lbRfidStatus2.Text = "Stopped";
            lbRfidStatus2.ForeColor = Color.Red;
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
            visitor = DBManager.GetVisitorByRfid(rfidNumber);

            if (visitor != null)
            {
                // Booking panel
                lbTicketNumber.Text = visitor.TicketNumber.ToString();
                lbName.Text = GetCapitalizedString(visitor.FirstName) + " " + GetCapitalizedString(visitor.LastName);
                lbBalance.Text = visitor.Balance.ToString() + " €";

                // Add users to CS panel
                lbTicketNumber2.Text = visitor.TicketNumber.ToString();
                lbName2.Text = GetCapitalizedString(visitor.FirstName) + " " + GetCapitalizedString(visitor.LastName);

                showCampingSpotForBooking();
            }
            else
            {
                MessageBox.Show("User could not be found with this rfid number");
            }
        }

        private void showCampingSpotForBooking()
        {
            if (visitor != null)
            {
                bookedCampingSpot = DBManager.GetCampingSpotForBooking(visitor.Userid, eventId);

                if (bookedCampingSpot != null)
                {
                    gbBookCampingSpot.Enabled = false;
                    lbCampingSpots.Text = bookedCampingSpot.Id.ToString();

                    lbCampingSpotId.Text = bookedCampingSpot.Id.ToString();
                    lbCampingSpotCapacity.Text = bookedCampingSpot.Capacity.ToString();
                    lbCampingSpotPrice.Text = bookedCampingSpot.Price.ToString() + " €";

                    showAssigneesToCampingSpot();
                }
                else
                {
                    gbBookCampingSpot.Enabled = true;
                }
            }
        }

        private void showAssigneesToCampingSpot()
        {
            listboxCSAssignees.Items.Clear();
            List<CampingSpotTicket> campingSpotTickets = DBManager.GetAllCampingSpotAssigneesForBooking(visitor.Userid, eventId);

            for (int i = 0; i < campingSpotTickets.Count; i++)
            {
                listboxCSAssignees.Items.Add(campingSpotTickets[i]);
            }

            if (campingSpotTickets.Count < bookedCampingSpot.Capacity)
            {
                btnAddCSAssignee.Enabled = true;
            }
            else
            {
                btnAddCSAssignee.Enabled = false;
            }
        }

        private string GetCapitalizedString(string input)
        {
            return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(input.ToLower());
        }

        private void ListBoxAvailableSpots_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            btnRemove.Enabled = false;
        }

        private void ListBoxBookedSpots_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            btnRemove.Enabled = true;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if(listBoxBookedSpots.Items.Count > 0)
            {
                MessageBox.Show("You can book only 1 camping spot per user");
            } else
            {
                CampingSpot selectedCampingSpot = (CampingSpot)listBoxAvailableSpots.SelectedItem;
                listBoxAvailableSpots.Items.Remove(selectedCampingSpot);
                listBoxBookedSpots.Items.Add(selectedCampingSpot);
                SetTotalPrice();
            }
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            CampingSpot selectedCampingSpot = (CampingSpot)listBoxBookedSpots.SelectedItem;
            listBoxBookedSpots.Items.Remove(selectedCampingSpot);
            listBoxAvailableSpots.Items.Add(selectedCampingSpot);
            SetTotalPrice();
        }

        /**
         * Sets total price of camping spot booking
         */
        private void SetTotalPrice()
        {
            double totalPrice = 0;
            // Itterate through all items of the list and add them to total price
            for (int i = 0; i < listBoxBookedSpots.Items.Count; i++)
            {
                totalPrice += ((CampingSpot)listBoxBookedSpots.Items[i]).Price;
            }
            lbTotalPrice.Text = totalPrice.ToString();
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            double totalPrice = Convert.ToDouble(lbTotalPrice.Text);

            if (rfidNumber == null)
            {
                MessageBox.Show("Please scan a valid visitor's bracelet");
                return;
            }

            if (visitor.Balance < totalPrice)
            {
                MessageBox.Show("Unsufficient visitor balance");
                return;
            }

            if (listBoxBookedSpots.Items.Count > 0)
            {
                CampingSpot selectedCampingSpot = (CampingSpot)listBoxBookedSpots.Items[0];
                DBManager.BookCampingSpot(visitor.Userid, eventId, selectedCampingSpot.Id, visitor.TicketNumber);
                DBManager.UpdateVisitorBalance(visitor.Userid, visitor.Balance - totalPrice);

                listBoxBookedSpots.Items.Clear();
                listBoxAvailableSpots.Items.Clear();
                lbTotalPrice.Text = "0";
                showVisitorInformation();
                LoadAvailableCampingSpots();
            }
        }

        private void BtnAddCSAssignee_Click(object sender, EventArgs e)
        {
            int ticketNumber;

            try
            {
                ticketNumber = Convert.ToInt32(tbTicketNumber.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Enter a valid ticket number");
                return;
            }

            if (bookedCampingSpot.Capacity <= listboxCSAssignees.Items.Count + 1)
            {
                DBManager.BookCampingSpot(visitor.Userid, eventId, bookedCampingSpot.Id, ticketNumber);
                showAssigneesToCampingSpot();
                MessageBox.Show("Ticket is successfully assigned to camping spot № " + bookedCampingSpot.Id);
            }
            else
            {
                MessageBox.Show("Camping spot has reached its maximum capacity");
            }
        }
    }
}
