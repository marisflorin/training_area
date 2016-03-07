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
        public static int CheapestIndex(Item[] shoppingBasket)
        {
            int cheapestIndex = 0;
            int lowestPrice = shoppingBasket[0].price;
            for (int i = 0; i < shoppingBasket.Length; i++)
                if (lowestPrice > shoppingBasket[i].price)
                {
                    cheapestIndex = i;
                    lowestPrice = shoppingBasket[i].price;
                };
            return cheapestIndex ;
        }
        public static void EliminateMostExpensive(ref Item[] shoppingBasket)
        {
            int index= MostExpensiveIndex(shoppingBasket);
            ShiftToLeft(ref shoppingBasket, index);
        }
        public static void AddNewItem(Item newItem,ref Item[] shoppingBasket)
        {
            int length = shoppingBasket.Length + 1;
            Array.Resize(ref shoppingBasket, length);
            shoppingBasket[length-1] = newItem;

        }
        public static decimal GetMedianPrice(Item[] shoppingBasket)
        {
            decimal medianPrice = 0;
            medianPrice = TotalPrice(shoppingBasket) / shoppingBasket.Length;
            return medianPrice;
        }
        public static int MostExpensiveIndex(Item[] shoppingBasket)
        {
            int expensiveIndex = 0;
            int HighestPrice = shoppingBasket[0].price;
            for (int i = 0; i < shoppingBasket.Length; i++)
                if (HighestPrice < shoppingBasket[i].price)
                {
                    expensiveIndex = i;
                    HighestPrice = shoppingBasket[i].price;
                };
            return expensiveIndex;
        }
        public static void ShiftToLeft(ref Item[] itemArray, int startingPosition)
        {
            for (int i = startingPosition; i < itemArray.Length - 1; i++)
                itemArray[i] = itemArray[i + 1];
            Array.Resize(ref itemArray, itemArray.Length - 1);
        }
        public static bool CheckExistance(Item[] shoppingBasket, string searched)
        {
            bool existing = false;
            for (int i = 0; i < shoppingBasket.Length; i++)
                if (shoppingBasket[i].name == searched)
                {
                    existing = true;
                    break;
                }
            return existing;
        }
    }
}
