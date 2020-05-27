using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodAndDrinkShop
{
    class Item
    {

        private int eventid;
        private int itemid;
        private string name;
        private int price;
        private int amount;
        private int shopid;

        private string type;

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
        public int ItemId
        {
            get
            {
                return itemid;
            }
            set
            {
                itemid = value;
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
        public int Amount
        {
            get
            {
                return amount;
            }
            set
            {
                amount = value;
            }
        }
        public int ShopId
        {
            get
            {
                return shopid;
            }
            set
            {
                shopid = value;
            }
        }
        public Item(int eventid, int itemid, string name, int price, int amount, string type, int shopid)
        {
            this.ItemId = itemid;
            this.name = name;
            this.price = price;
            this.Amount = amount;
            this.type = type;
            this.ShopId = shopid;
            this.eventid = eventid;
        }

        //methods
        public string AsAString()
        {

            string s = "Id:" + this.ItemId + "," + "Name:" + this.Name + "," + "Price" + Price + Amount + type;
            return s;
        }
        public string ShortString()
        {
            string s = "Name" + this.Name;
            return s;
        }

        public bool CheckEnoughAmount()
        {
            if (Amount <= 0)
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
