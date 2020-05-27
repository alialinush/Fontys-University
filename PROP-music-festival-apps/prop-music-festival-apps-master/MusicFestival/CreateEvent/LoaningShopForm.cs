using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateEvent
{
    public partial class LoaningShopForm : Form
    {
        int eventid;
        DatabaseConnection db2 = new DatabaseConnection();
        public LoaningShopForm(int eventidFromEventForm)
        {
            InitializeComponent();
            eventid = eventidFromEventForm;

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoaningShopForm_Load(object sender, EventArgs e)
        {

        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            try
            {
                db2.Connect();
                db2.ExecuteReader("INSERT INTO device(DeviceId,Name_,Price,TotalAmount,LoanedAmount,LoaningShopId,EventId) VALUES ('" + tbDeviceId.Text + "','" + tbName.Text + "','" + tbPrice.Text + "','" + tbAmount.Text + "','" + tbLoanedAmount.Text + "','" + tbLoaningShop.Text + "','" + eventid + "' );");
                db2.Close();
                tbDeviceId.Text = "";
                tbName.Text = "";
                tbPrice.Text = "";
                tbAmount.Text = "";
                
                tbLoaningShop.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
