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
    public partial class ItemsFoodForm : Form
    {
        int eventId;
        DatabaseConnection db1 = new DatabaseConnection();
        public ItemsFoodForm(int eventIdFromFormCreateEvent)
        {
            InitializeComponent();
            eventId = eventIdFromFormCreateEvent;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            try
            {
                db1.Connect();
                db1.ExecuteReader("INSERT INTO item(ItemId,Name_,Price, Amount, FoodShopId, Type,EventId) VALUES ('" + tbItemId.Text + "','" + tbName.Text + "','" + tbPrice.Text + "','" + tbAmount.Text + "','" + tbShopId.Text + "','" + tbType.Text + "','" + eventId + "' );");
                db1.Close();
                tbItemId.Text = "";
                tbName.Text = "";
                tbPrice.Text = "";
                tbShopId.Text = "";
                tbAmount.Text = "";
                tbType.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
