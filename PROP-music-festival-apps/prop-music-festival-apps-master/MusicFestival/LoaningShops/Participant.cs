using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoaningShops
{
    class Participant
    {
        private int userid;
        private string firstname;
        private string lastname;
        private string address;
        private int bankaccid;
        private double balance;
        private string status;
        private string role;
        public List<Order> orders;


        //properties
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
            get
            {
                return firstname;
            }
            set
            {
                firstname = value;
            }
        }
        public string LastName
        {
            get
            {
                return lastname;
            }
            set
            {
                lastname = value;
            }
        }
        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }
        public int BankAccId
        {
            get
            {
                return bankaccid;
            }
            set
            {
                bankaccid = value;
            }

        }
        public double Balance
        {
            get
            {
                return balance;
            }
            set
            {
                balance = value;
            }
        }
        public string Status
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
            }
        }
        public string Role
        {
            get
            {
                return role;
            }
            set
            {
                role = value;
            }
        }





        //constructor
        public Participant()
        {
            orders = new List<Order>();


        }


        public Order GetOrder(int index)
        {
            return orders[index];
        }
    }
}
