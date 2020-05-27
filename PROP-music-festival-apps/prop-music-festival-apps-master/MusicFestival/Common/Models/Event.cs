using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Common
{
    public class Event
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
        private string address;

        public LineUp LineUp{ get; set; }
        public int EventId { get; set; }

        public Event(int eventid, int userid, string title, string description, DateTime startDate, DateTime endDate, int ticketPrice, int nrTickets, int nrSpotsAv, string address)
        {
            //   EventId=this.eventId+1;
            this.EventId = eventid;
            this.userId = userid;
            this.title = title;
            this.description = description;
            this.startDate = startDate;
            this.endDate = endDate;
            this.ticketPrice = ticketPrice;
            this.nrTickets = nrTickets;
            this.nrSpotsAvailable = nrSpotsAv;
            this.address = address;

            LineUp = new LineUp(eventId);
        }

        public override string ToString()
        {
            return title;
        }
    }
}
