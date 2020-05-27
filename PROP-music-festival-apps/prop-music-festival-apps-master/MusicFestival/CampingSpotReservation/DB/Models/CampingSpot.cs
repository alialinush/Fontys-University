using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampingSpotReservation.DB
{
    class CampingSpot
    {
        public int Id { get; set; }
        public int EventId { get; set; }
        public int Capacity { get; set; }
        public string Availability { get; set; }
        public double Price { get; set; }

        public CampingSpot(int id, int eventId, int capacity, string availability, double price)
        {
            Id = id;
            EventId = eventId;
            Capacity = capacity;
            Availability = availability;
            Price = price;
        }

        public override string ToString()
        {
            return "CS № " + Id + ", Capacity: " + Capacity + ", Price: " + Price + " €";
        }
    }
}
