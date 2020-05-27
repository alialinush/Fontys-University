using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalanceTopUp
{
    public class Account
    {
        public int tktnr { get; set; }

        public string mail { get; set; }

        public string fname { get; set; }

        public string lname { get; set; }

        public DateTime dob { get; set; }

        public bool gender { get; set; }

        public string bank { get; set; }

        public string rfid { get; set; }

        public int campnr { get; set; }

        public bool inpark { get; set; }

        public bool incamp { get; set; }

        public double balance { get; set; }

        //public List<Rental> rentals { get; }

        public Account(int tktnr, string mail, string fname, string lname, string bank, bool status, double balance)
        {
            this.tktnr = tktnr;
            this.mail = mail;
            this.fname = fname;
            this.lname = lname;
            //this.dob = dob;
            //this.gender = gender;
            this.bank = bank;
            //this.rfid = rfid;
            //this.campnr = campnr;
            this.inpark = inpark;
            //this.incamp = incamp;
            this.balance = balance;
            //rentals = new List<Rental>();
        }

        //public void AddRental(Rental r)
        //{
        //    rentals.Add(r);
        //}

        public override string ToString()
        {
            string info = "No.: " + this.tktnr + ",  Balance: €" + this.balance;
            return info;
        }
    }
}


