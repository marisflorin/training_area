using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.OOPShoppingBasket
{
    public class Item
    {
        public Item(string name, decimal price)
        {
            this.name = name;
            this.price = price;
        }
        public string name { set; get; }
        public decimal price { set; get; }
    }
   

}
