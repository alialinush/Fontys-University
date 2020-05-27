using System.Collections.Generic;
using System.Windows.Forms;
using Common.Forms.EmloyeeLogin;

namespace Common
{
    public partial class BaseEmployeeLoginForm : Form
    {

        private int selectedEventId;

        protected List<Event> GetAllCurrentEvents()
        {
            return DBManager.GetAllCurrentEvents();
        }
        protected void LoginEmployee(int employeeId, string password)
        {
            if (DBManager.LoginEmployee(employeeId, password))
            {
                ProceedToNext(selectedEventId);
                this.Hide();
                MessageBox.Show("Welcome Employee");
            }
            else
            {
                MessageBox.Show("UserId or Password is incorrect");
            }
        }

        protected void SetChosenEvent(Event chosenEvent) {
            selectedEventId = chosenEvent.EventId;
        }

        protected virtual void ProceedToNext(int eventId) { }

    }
}
