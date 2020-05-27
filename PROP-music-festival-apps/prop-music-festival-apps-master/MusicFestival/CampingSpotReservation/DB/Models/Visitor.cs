using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampingSpotReservation.DB
{
    class Visitor
    {
        public int Userid { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public double Balance { get; set; }
        public string Status { get; set; }
        public string Role { get; set; }
        public int TicketNumber { get; set; }

        public Visitor(int userid, string firstName, string lastName, string address, double balance, string status, string role)
        {
            Userid = userid;
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            Balance = balance;
            Status = status;
            Role = role;
        }

        public Visitor(int userid, string firstName, string lastName, string address, double balance, string status, string role, int ticketNumber)
        {
            Userid = userid;
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            Balance = balance;
            Status = status;
            Role = role;
            TicketNumber = ticketNumber;
        }

        public Visitor()
        {
        }
    }
}
