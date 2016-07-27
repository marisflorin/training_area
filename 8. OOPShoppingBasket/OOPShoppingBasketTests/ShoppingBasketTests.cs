using _8.OOPShoppingBasket;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _8.OOPShoppingBasket.Tests
{
    [TestClass()]
    public class UnitTest1
    {
        /*Cumpărături
Ai un coș plin de produse. Dacă cunoști prețul fiecărui produs în parte:
1.Calculează care e totalul de plată pentru un coșul cu cumpărături
2.Găsește și care e cel mai ieftin produs din coș
3.Elimină cel mai scump produs din coș
4.Adaugă un nou produs în coș
5.Calculează prețul mediu */
        private static ShoppingBasket AddItems()
        {
            ShoppingBasket basket = new ShoppingBasket();
            Item beans = new Item("beans", 23.0m);
            basket.Add(beans);
            Item flowers = new Item("flowers", 5.99m);
            basket.Add(flowers);
            Item books = new Item("books", 27.0m);
            basket.Add(books);
            return basket;
        }
        [TestMethod()]
        public void TotalPriceTest()
        {
            ShoppingBasket basket = AddItems();
            Assert.AreEqual(55.99m, basket.GetTotalPrice());
        }
        [TestMethod()]
        public void EmptyBasketTest()
        {
            ShoppingBasket basket = new ShoppingBasket();
            Assert.AreEqual(0m, basket.GetTotalPrice());
        }
        [TestMethod()]
        public void GetChaepestItemTest()
        {
            ShoppingBasket basket = AddItems();
            Item flowers = new Item("flowers", 5.99m);
            Assert.AreEqual(flowers.name, basket.GetCheapestItem().name);
            Assert.AreEqual(flowers.price, basket.GetCheapestItem().price);
        }
    }
}
