using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementOverview
{
    class getinfo
    {
        public string Firstname { get; set; }
        
        public string Lastname { get; set; }
        public int UserId { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public double Balance { get; set; }
        public string Status { get; set; }
        public string Role { get; set; }


            public getinfo(string firstname, string lastname, int userId, string email, string address, double balance, string status, string role)
            {
                Firstname = firstname;
                Lastname = lastname;
                UserId = UserId;
            Email = email;
            Address = address;
            Balance = balance;
            Status = status;
            Role = role;


            }

        public override string ToString()
        {
            return Firstname + " " + Lastname + " " + UserId + " " + Email + " " + Address + " " + Balance + " " + Status + " " + Role;
        }
        
    }
}
