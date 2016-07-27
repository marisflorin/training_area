﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.OOPShoppingBasket
{
    public class ShoppingBasket
    {
        
        public List<Item> shoppingBasket;

        public ShoppingBasket()
        {
            this.shoppingBasket = new List<Item>();
        }

        public void Add(Item item)
        {
            this.shoppingBasket.Add(item);
        }
        
        public decimal GetTotalPrice()
        {
            decimal totalPrice = 0; 
            foreach( Item item in this.shoppingBasket)
            {
                totalPrice += item.price;
            }
            return totalPrice;
        }
        public Item GetCheapestItem()
        {
            Item cheapestItem = this.shoppingBasket[0];
            foreach (Item item in this.shoppingBasket)
            {
                if (item.price < cheapestItem.price) cheapestItem = item;
            }
            return cheapestItem;
        }
    }
}