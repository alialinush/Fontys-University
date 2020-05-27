using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoaningShops
{
    class BorrowActivity
    {
        private int borrowNr;
        private int deviceId;
        private int eventId;
        private int userId;
        private int quantity;
        private int pay;


        public int BorrowNr
        {
            get
            {
                return borrowNr;
            }
            set
            {
                borrowNr = value;
            }
            
        
        }
        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                quantity = value;
            }
        }


        public BorrowActivity(int borrowAc,int deviceId,int eventid,int userid,int quantity,int pay)
        {
            BorrowNr = borrowAc;
            this.deviceId = deviceId;
            this.eventId = eventid;
            this.userId = userid;
            this.Quantity = quantity;
            this.pay = pay;

        }

    }
}
