using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Phidget22;
using Phidget22.Events;
using System.IO;
using MySql.Data.MySqlClient;
using BalanceTopUp;

namespace EntranceEvent
{
    public partial class Form1 : Form
    {
        private RFID rfidReader;
        private DatabaseUtils conn;
        private Account acc;

        public Form1()
        {
            InitializeComponent();
            InitializeDisplay();
            conn = new DatabaseUtils();
            try
            {
                rfidReader = new RFID();
                rfidReader.Attach += new AttachEventHandler(RfidDevAtt);
                rfidReader.Detach += new DetachEventHandler(RfidDevDet);
                rfidReader.Tag += new RFIDTagEventHandler(RfidTagScan);
                rfidReader.Open();
            }
            catch (PhidgetException)
            {
                lblDevStatus.ForeColor = Color.FromArgb(231, 76, 60);
                lblDevStatus.Text = "SHIT HAPPENS";
            }
        }
        private void InitializeDisplay()
        {
            pbxSign.Image = null;
            lblTktnr.Text = "";
        }
        private void RfidDevAtt(object sender, AttachEventArgs e)
        {
            lblDevStatus.ForeColor = Color.FromArgb(22, 160, 133);
            lblDevStatus.Text = "DEVICE ATTACHED";
            InitializeDisplay();
        }

        private void RfidDevDet(object sender, DetachEventArgs e)
        {
            lblDevStatus.ForeColor = Color.FromArgb(231, 76, 60);
            lblDevStatus.Text = "DEVICE DETACHED";
            InitializeDisplay();
        }

        private void RfidTagScan(object sender, RFIDTagEventArgs e)
        {
            string rfid = e.Tag.ToString();
            acc = conn.GetAcountByTag(rfid);
            InitializeDisplay();
            if (acc is null)
            {
                lblDevStatus.ForeColor = Color.FromArgb(231, 76, 60);
                lblDevStatus.Text = "TAG INVALID";
                pbxSign.Image = ilstSign.Images[0];
            }
            else
            {
                if (acc.inpark)
                {
                    lblDevStatus.ForeColor = Color.FromArgb(231, 76, 60);
                    lblDevStatus.Text = "TAG ALREADY CHECKED";
                    lblTktnr.Text = acc.tktnr.ToString();
                    pbxSign.Image = ilstSign.Images[0];
                }
                else
                {
                    if (conn.GateCheckIn(acc))
                    {
                        lblDevStatus.ForeColor = Color.FromArgb(22, 160, 133);
                        lblDevStatus.Text = "WELCOME";
                        lblTktnr.Text = acc.tktnr.ToString();
                        pbxSign.Image = ilstSign.Images[1];
                    }
                }
            }
        }
    

    private void pbLogo_Click(object sender, EventArgs e)
        {

        }
    }
}
