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
        [TestMethod]
        public void TestCheepestProduct()
        {
            Item[] shoppingBasket = new Item[] { new Item() { name ="Milk", price = 6 },
                                                 new Item() { name ="Eggs", price=12},
                                                 new Item() { name ="Bread", price=2},
                                                 new Item() { name ="Ham", price=20},
                                                 new Item() { name ="Cheese", price=10}
                                               };
            int index = ShoppingBasket.CheapestIndex(shoppingBasket);
            Assert.AreEqual("Bread", shoppingBasket[index].name);

        }
        [TestMethod]
        public void TestEliminatedMostExpensive()
        {
            Item[] shoppingBasket = new Item[] { new Item() { name ="Milk", price = 6 },
                                                 new Item() { name ="Eggs", price=12},
                                                 new Item() { name ="Bread", price=2},
                                                 new Item() { name ="Ham", price=20},
                                                 new Item() { name ="Cheese", price=10}
                                               };
            ShoppingBasket.EliminateMostExpensive(ref shoppingBasket);
            bool eliminated = true;
            for (int i = 0; i < shoppingBasket.Length; i++)
                if (shoppingBasket[i].name == "Ham")
                {
                    eliminated = false;
                    break;
                }           
            Assert.AreEqual(true, eliminated);

        }
        [TestMethod]
        public void TestAddingProduct()
        {
            Item[] shoppingBasket = new Item[] { new Item() { name ="Milk", price = 6 },
                                                 new Item() { name ="Eggs", price=12},
                                                 new Item() { name ="Bread", price=2}
                                               };
            Item newItem = new Item { name = "Ham", price = 20 };
            ShoppingBasket.AddNewItem(newItem, ref shoppingBasket);

            Assert.AreEqual(newItem, shoppingBasket[shoppingBasket.Length-1]);

        }
        [TestMethod]
        public void TestMedianPrice()
        {
            Item[] shoppingBasket = new Item[] { new Item() { name ="Milk", price = 6 },
                                                 new Item() { name ="Eggs", price=12},
                                                 new Item() { name ="Bread", price=2},
                                                 new Item() { name ="Ham", price=20},
                                                 new Item() { name ="Cheese", price=10}
                                               };
            decimal medianPrice = ShoppingBasket.GetMedianPrice(shoppingBasket);           
            Assert.AreEqual(10, medianPrice);

        }
    }
}
