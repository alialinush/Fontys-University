using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampingAuthorization
{
    public class Participant
    {
        private int userid;
        private string firstName;
        private string lastName;
        private string address;

        private double balance;
        private string status;
        private string role;


        public int Userid
        {
            get
            {
                return userid;
            }
            set
            {
                userid = value;
            }
        }

        public string FirstName
        {
            get { return firstName; }

            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }

            set { lastName = value; }
        }
        public string Address
        {
            get { return address; }

            set { address = value; }
        }



        public double Balance
        {
            get { return balance; }

            set { balance = value; }
        }

        public string Status
        {
            get { return status; }

            set { status = value; }
        }

        public string Role
        {
            get { return role; }

            set { role = value; }
        }

        public Participant(int userid, string firstName, string lastName, string address, double balance, string status, string role)
        {
            this.Userid = userid;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = address;
            this.Balance = balance;
            this.status = status;
            this.Role = role;
        }

        public Participant()
        {
        }
    }
}
