using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementOverview
{
    class UnReservedSpots
    {
        public string Availability { get; set; }
        public int Capacity { get; set; }
        public int Id { get; set; }
        public UnReservedSpots(int id)
        {
            //Availability = availability;
            //Capacity = capacity;
            Id = id;
        }
    }
}
