using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoaningShops
{
    class Device
    {
        private int deviceId;
        private string name;
        private int price;
        private int totalAmount;
        private int loanedAmount;
        private int loaningShopId;
        private int eventId;

        public int DeviceId
        {
            get
            {
                return deviceId;
            }
            set
            {
                deviceId = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }

        }
        public int Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
        public int TotalAmount
        {
            get
            {
                return totalAmount;
            }
            set
            {
                totalAmount = value;
            }
        }
        public int LoanedAmount
        {
            get
            {
                return loanedAmount;
            }
            set
            {
                loanedAmount = value;
            }
        }
        public int LoaningShopId
        {
            get
            {
                return loaningShopId;
            }
            set
            {
                loaningShopId = value;
            }
            
        }
        public int EventId
        {
            get
            {
                return eventId;
            }
            set
            {
                eventId = value;
            }

        }



        public Device(int deviceid,string name,int price,int totalAmount,int loanedAmount,int loaningShopId,int eventId)
        {
            this.DeviceId = deviceid;
            this.Name = name;
            this.Price = price;
            this.TotalAmount = totalAmount;
            this.LoanedAmount = loanedAmount;
            this.LoaningShopId = loaningShopId;
            this.EventId = eventId;
        }



        //methods
        public string AsAString()
        {

            string s = "Id:" + this.DeviceId + "," + "Name:" + this.Name + "," + "Price" + Price + totalAmount;
            return s;
        }
        public string ShortString()
        {
            string s = this.Name + " amount: " + TotalAmount;
            return s;
        }

        public bool CheckEnoughAmount()
        {
            if (TotalAmount <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
