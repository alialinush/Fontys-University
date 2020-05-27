using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ManagementOverview
{
    public partial class LogInEmployeeForm : BaseEmployeeLoginForm
    {
        public LogInEmployeeForm()
        {
            InitializeComponent();
            LoadEvents();
        }

        private void LoadEvents()
        {
            List<Event> events = GetAllCurrentEvents();

            for(int i = 0; i < events.Count; i++)
            {
                lbAvailableEvents.Items.Add(events[i]);
            }
        }

        private void btLogIn_Click(object sender, EventArgs e)
        {
            LoginEmployee(Convert.ToInt32(tbEmployeeId.Text), tbPassWord.Text);
        }

        private void btChooseEvent_Click(object sender, EventArgs e)
        {
            SetChosenEvent((Event) lbAvailableEvents.SelectedItem); 
        }

        protected override void ProceedToNext(int eventId)
        {
            ManagementOverviewForm form = new ManagementOverviewForm(eventId);
            form.Show();
        }
    }
}
