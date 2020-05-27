using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_Service
{
    class Event
    {
        private int eventId;
        private int userId;
        private string title;
        private string description;
        private DateTime startDate;
        private DateTime endDate;
        private int ticketPrice;
        private int nrTickets;
        private int nrSpotsAvailable;
        private int campingspotPrice;
        private string address;


        public int EventId
        {
            get
            {
                return eventId;
            }
            set
            {
                eventId = value;
            }
        }
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }

        public Event(int eventid, int userid, string title, string description, DateTime startDate, DateTime endDate, int ticketPrice, int nrTickets, int nrSpotsAv, int campingspotPrice, string address)
        {

            this.EventId = eventid;
            this.userId = userid;
            this.Title = title;
            this.description = description;
            this.startDate = startDate;
            this.endDate = endDate;
            this.ticketPrice = ticketPrice;
            this.nrTickets = nrTickets;
            this.nrSpotsAvailable = nrSpotsAv;
            this.campingspotPrice = campingspotPrice;
            this.address = address;

        }
    }
}
