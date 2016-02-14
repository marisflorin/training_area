using _5._2_Shopping_Basket;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace _5._2_ShoppingBasketTests
{
    
    [TestClass]
    public class ShoppingBasketTests
    {
       
        [TestMethod]
        public void TestTotalSum()
        {
            Item[] shoppingBasket = new Item[] { new Item() { name ="Milk", price = 6 },
                                                 new Item() { name ="Eggs", price=12},
                                                 new Item() { name ="Bread", price=2}
                                               };

            Assert.AreEqual(20, ShoppingBasket.TotalPrice(shoppingBasket));
           

        }

    }
}
