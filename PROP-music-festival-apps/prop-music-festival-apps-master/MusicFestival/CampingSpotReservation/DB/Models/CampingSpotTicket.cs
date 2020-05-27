using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampingSpotReservation.DB
{
    class CampingSpotTicket
    {
        public int CampingSpotId { get; set; }
        public int TicketId { get; set; }
        public string TicketEmail { get; set; }

        public CampingSpotTicket(int campingSpotId, int ticketId, string ticketEmail)
        {
            CampingSpotId = campingSpotId;
            TicketId = ticketId;
            TicketEmail = ticketEmail;
        }

        public override string ToString()
        {
            return " Ticket № " + TicketId + ", Owner: " + TicketEmail;
        }
    }
}
