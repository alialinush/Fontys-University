using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodAndDrinkShop
{
    class Order
    {
        public List<Item> itemsOrdered;
        //  private Participant participant;
        public List<int> quant;
        public List<int> prices;




        //properties
        //public Participant Participant
        //{
        //    get
        //    {
        //        return participant;
        //    }
        //    set
        //    {
        //        participant = value;
        //    }
        //}

        public Order()
        {
            itemsOrdered = new List<Item>();
            quant = new List<int>();
            prices = new List<int>();
        }


        //methods

        public void Add(Item item, int quanti)
        {
            if (item != null && quanti > 0)
            {
                if (itemsOrdered.Contains(item))
                {
                    int index = itemsOrdered.IndexOf(item);
                    quant[index] = quant[index] + quanti;
                    prices[index] = item.Price * quant[index];
                }
                else
                {
                    itemsOrdered.Add(item);
                    quant.Add(quanti);
                    prices.Add(item.Price * quanti);
                }
            }
        }


        public void Remove(int _index)
        {
            itemsOrdered.RemoveAt(_index);
            quant.RemoveAt(_index);
            prices.RemoveAt(_index);
        }

        public void Remove(int _index, int _qty)
        {
            quant[_index] -= _qty;
            if (quant[_index] <= 0)
            {
                Remove(_index);
            }
        }
        //public List<string> AsAstring()
        //{
        //    List<string> output = new List<string>();
        //    UpdateSQLStatement = new List<string>();
        //    int amount = itemsOrdered.Count;
        //    for (int i = 0; i < amount; i++)
        //    {
        //        output.Add(itemsOrdered[i].ShortString() + "X" + quant[i] + "=" + prices[i]);
        //        string sqlStatement = $"insert into ORDER_ACTIVITY(UserId,ItemId,Quantity,Pay) values('{Participant.Userid}','{items[i].ItemId}','{quant[i]}','{prices[i]}');";
        //        UpdateSQLStatement.Add(sqlStatement);
        //    }
        //    output.Add($"TOTAL: {Total()} euro");
        //    return output;

        //}
        public double Total()
        {
            double output = 0;
            foreach (double p in prices)
            {
                output += p;
            }
            return output;
        }
    }
}
