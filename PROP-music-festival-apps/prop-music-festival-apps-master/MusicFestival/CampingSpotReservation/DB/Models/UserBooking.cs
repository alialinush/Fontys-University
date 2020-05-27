using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampingSpotReservation.DB
{
    class UserBooking
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int EvenId { get; set; }

        public UserBooking(int id, int userId, int evenId)
        {
            Id = id;
            UserId = userId;
            EvenId = evenId;
        }
    }
}
