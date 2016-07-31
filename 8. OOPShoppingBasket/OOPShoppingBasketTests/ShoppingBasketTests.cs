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
        [TestMethod()]
        public void RemoveMostExpensiveTEst()
        {
            ShoppingBasket basket = AddItems();
            Item shugar = new Item("shugar", 6.0m);
            basket.Add(shugar);
            ShoppingBasket testBasket = new ShoppingBasket();
            Item beans = new Item("beans", 23.0m);
            testBasket.Add(beans);
            Item flowers = new Item("flowers", 5.99m);
            testBasket.Add(flowers);
            shugar = new Item("shugar", 6.0m);
            testBasket.Add(shugar);
            basket.RemoveMostExpensiveItem();
            
            Assert.AreEqual(testBasket.shoppingBasket[0].name, basket.shoppingBasket[0].name);
            Assert.AreEqual(testBasket.shoppingBasket[0].price, basket.shoppingBasket[0].price);
            Assert.AreEqual(testBasket.shoppingBasket[1].name, basket.shoppingBasket[1].name);
            Assert.AreEqual(testBasket.shoppingBasket[1].price, basket.shoppingBasket[1].price);
            Assert.AreEqual(testBasket.shoppingBasket[2].name, basket.shoppingBasket[2].name);
            Assert.AreEqual(testBasket.shoppingBasket[2].price, basket.shoppingBasket[2].price);
        }
        [TestMethod()]
        public void AddItemTEst()
        {
            ShoppingBasket basket = new ShoppingBasket();
            Item shugar = new Item("shugar", 6.0m);
            basket.Add(shugar);            
            Assert.AreEqual("shugar", basket.shoppingBasket[0].name);
            Assert.AreEqual(6.0m, basket.shoppingBasket[0].price);            
        }
    }
}
