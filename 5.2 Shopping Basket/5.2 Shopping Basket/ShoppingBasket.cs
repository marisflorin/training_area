using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _5._2_Shopping_Basket
{
    /*Cumpărături
Ai un coș plin de produse. Dacă cunoști prețul fiecărui produs în parte:

1.Calculează care e totalul de plată pentru un coșul cu cumpărături
2.Găsește și care e cel mai ieftin produs din coș
3.Elimină cel mai scump produs din coș
4.Adaugă un nou produs în coș
5.Calculează prețul mediu */
    public struct Item
    {
        public string name;
        public int price;
    }

   public class ShoppingBasket
    {
                static void Main(string[] args)
        {
        }
               public Item[] shoppingBasket = new Item[10];      
       public static int TotalPrice(Item[] shoppingBasket)
        {
            int totalPrice = 0;
            for (int i = 0; i < shoppingBasket.Length; i++)
                totalPrice += shoppingBasket[i].price;
            return totalPrice;
                
                
        }
    }
}
