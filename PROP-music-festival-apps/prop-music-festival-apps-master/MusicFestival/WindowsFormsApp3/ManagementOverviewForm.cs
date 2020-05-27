using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace ManagementOverview
{
    public partial class ManagementOverviewForm : Form
    {
        string selecteditem;
        int amountcheckedin;
        private string firstname;
        private string lastname;
        private int eventid;
        private int id;
        private int lookforid;
        public ManagementOverviewForm(int eventid)
        {
            this.eventid = eventid;
            
            InitializeComponent();
            //cbProduct.Items = select Name_ from item
            lblCheckedInNr.Text = DBManager.GetTotalCheckedIn(eventid).ToString();
            lblNotCheckedInNr.Text = DBManager.GetTotalNotCheckedIn(eventid).ToString();
            List<peoplecheckedin> peopleCheckedin = DBManager.GetPeopleCheckedIn(eventid, firstname, lastname);
            foreach (peoplecheckedin o in peopleCheckedin)
            {
                lbCheckedIn.Items.Add(o.Firstname + " " + o.Lastname);
            }
            List<peoplenotcheckedin> peopleNotCheckedin = DBManager.GetPeopleNotCheckedIn(eventid, firstname, lastname);
            foreach (peoplenotcheckedin g in peopleNotCheckedin)
            {

                lbNotCheckedIn.Items.Add(g.Firstname + " " + g.Lastname);
            }
            label28.Text = DBManager.GetTotalVisitors(eventid).ToString();
            lblDeposit.Text = DBManager.GetTotalDepositMoney(eventid).ToString();
            lblProductRev.Text = DBManager.GetTotalFoodRevenue(eventid).ToString();
            camptickets.Text = DBManager.GetTotalCampers(eventid).ToString();
            totalrevtickets.Text = DBManager.GetTotalRevTickets(eventid).ToString();
            lblTotalCampingNr.Text = DBManager.GetTotalCampersCheckedornot(eventid).ToString();
            lblReservedNr.Text = DBManager.GetTotalCampers(eventid).ToString();
            List<ReservedSpots> reservedSpots = DBManager.GetReservedSpots(eventid, id);
            foreach (ReservedSpots f in reservedSpots)
            {
                lbReservedSpots.Items.Add(f.Id);
            }
            List<UnReservedSpots> unReservedSpots = DBManager.GetUnReservedSpots(eventid, id);
            foreach (UnReservedSpots x in unReservedSpots)
            {
                lbUnreservedSpots.Items.Add(x.Id);
            }
            lblNotReservedNr.Text = DBManager.GetCountUnreservedSpots(eventid).ToString();
            
        }
                
        private void btnSearch_Click(object sender, EventArgs e)
        {
            lookforid = Convert.ToInt32(tbSearch.Text);
            id = Convert.ToInt32(tbSearch.Text);
            tbPersonSelected.Text = Convert.ToString(DBManager.GetInfo(id));
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbCheckedIn_SelectedIndexChanged(object sender, EventArgs e)
        {
            //select LastName where status=yes
        }

        private void lblNotCheckedInNr_Click(object sender, EventArgs e)
        {
            //count userid where status=no
        }

        private void lblCheckedInNr_Click(object sender, EventArgs e)
        {
            //select count userid where status=yes
        }

        private void lbNotCheckedIn_SelectedIndexChanged(object sender, EventArgs e)
        {
            //select LastName where status=no
        }

        private void label28_Click(object sender, EventArgs e)
        {
            //select count userId
        }

        private void cbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            //selecteditem=cbProduct.SelectedItem.ToString();

        }

        private void lblDeposit_Click(object sender, EventArgs e)
        {

        }

        private void lblProductRev_Click(object sender, EventArgs e)
        {

        }

        private void camptickets_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalCampingNr_Click(object sender, EventArgs e)
        {

        }

        private void lblReservedNr_Click(object sender, EventArgs e)
        {

        }
    }
}
