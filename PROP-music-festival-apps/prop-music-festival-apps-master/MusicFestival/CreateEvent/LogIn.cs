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


namespace CreateEvent
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void btLogIn_Click(object sender, EventArgs e)
        {
            MySqlConnection sqlconn = new MySqlConnection(("server=studmysql01.fhict.local;" +
                                   "Uid=dbi401372;" +
                                   "Database=dbi401372;" +
                                   "Pwd=Xsy2X]XjdL;"));


            string query = "SELECT * FROM user_ WHERE UserId= '" + tbUserName.Text.Trim() + "' and Password_= '" + tbPassword.Text.Trim() + "'";

            MySqlCommand command = new MySqlCommand(query, sqlconn);
            MySqlDataAdapter sda = new MySqlDataAdapter(query, sqlconn);
            DataTable dtb = new DataTable();
            sda.Fill(dtb);
            if (dtb.Rows.Count == 1)
            {
                CreateEventForm createEvent = new CreateEventForm(Convert.ToInt32(tbUserName.Text));
                createEvent.Show();
                this.Hide();
                MessageBox.Show("Welcome Admin");
            }
            else
            {
                MessageBox.Show("UserId or Password is incorrect");
            }
        }
    }
}
