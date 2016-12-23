using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Brunner.Eval.Services;
using Brunner.Eval.Web.Tests.Mocks;
using Brunner.Eval.Constant;

namespace Brunner.Eval.Web.Tests
{
    [TestClass]
    public class ShoppingCartServiceTests
    {
        
        public ShoppingCartServiceTests()
        {

        }
        #region No Discount
        [TestMethod]
        public void GetTotalWithGivenPricesNoDiscounts()
        {
            ShoppingCartMockRepository mockRepo = new ShoppingCartMockRepository();
            NoDiscountMockRepository mockDiscount = new NoDiscountMockRepository();
            ShoppingCartService ser = new ShoppingCartService(mockRepo);
            Decimal expectedResult = 2.85M;

            var cart = ser.GetShoppingCartByID(new Guid("E5615A03-1E31-427C-857C-2011A5FAD6B7"));
            cart.CartItems.Add(new Data.Entity.CartItem() { CreatedDate = DateTime.Now, ID = 1, ProductName=Item.Apple , Quantity = 2, UnitPrice = .45M });
            cart.CartItems.Add(new Data.Entity.CartItem() { CreatedDate = DateTime.Now, ID = 2, ProductName = Item.Orange, Quantity = 3, UnitPrice = .65M });

            var result = ser.GetTotal(cart, mockDiscount);

            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void GetTotalWithGivenPricesNoDiscountsEmptyCart()
        {
            ShoppingCartMockRepository mockRepo = new ShoppingCartMockRepository();
            NoDiscountMockRepository mockDiscount = new NoDiscountMockRepository();
            ShoppingCartService ser = new ShoppingCartService(mockRepo);
            

            
            var result = ser.GetTotal(null, mockDiscount);

            
        }

        #endregion

        #region Discount
        [TestMethod]
        public void GetTotalWithGivenPricesDiscounts()
        {
            ShoppingCartMockRepository mockRepo = new ShoppingCartMockRepository();
            DiscountMockRepository mockDiscount =  new DiscountMockRepository();
            ShoppingCartService ser = new ShoppingCartService(mockRepo);
            Decimal expectedResult = 1.75M;

            var cart = ser.GetShoppingCartByID(new Guid("E5615A03-1E31-427C-857C-2011A5FAD6B7"));
            cart.CartItems.Add(new Data.Entity.CartItem() { CreatedDate = DateTime.Now, ID = 1, ProductName = Item.Apple, Quantity = 2, UnitPrice = .45M });
            cart.CartItems.Add(new Data.Entity.CartItem() { CreatedDate = DateTime.Now, ID = 2, ProductName = Item.Orange, Quantity = 3, UnitPrice = .65M });

           var  result=  ser.GetTotal(cart, mockDiscount);

           Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void GetTotalWithDifferentPrices()
        {
            ShoppingCartMockRepository mockRepo = new ShoppingCartMockRepository();
            DiscountMockRepository mockDiscount = new DiscountMockRepository();
            ShoppingCartService ser = new ShoppingCartService(mockRepo);
            Decimal expectedResult = 7M;

            var cart = ser.GetShoppingCartByID(new Guid("E5615A03-1E31-427C-857C-2011A5FAD6B7"));
            cart.CartItems.Add(new Data.Entity.CartItem() { CreatedDate = DateTime.Now, ID = 1, ProductName = Item.Apple, Quantity = 2, UnitPrice = 1M });
            cart.CartItems.Add(new Data.Entity.CartItem() { CreatedDate = DateTime.Now, ID = 2, ProductName = Item.Orange, Quantity = 3, UnitPrice = 3M });

            var result = ser.GetTotal(cart, mockDiscount);

            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void GetTotalWithUnitPriceZero()
        {
            ShoppingCartMockRepository mockRepo = new ShoppingCartMockRepository();
            DiscountMockRepository mockDiscount = new DiscountMockRepository();
            ShoppingCartService ser = new ShoppingCartService(mockRepo);
            Decimal expectedResult = 0M;

            var cart = ser.GetShoppingCartByID(new Guid("E5615A03-1E31-427C-857C-2011A5FAD6B7"));
            cart.CartItems.Add(new Data.Entity.CartItem() { CreatedDate = DateTime.Now, ID = 1, ProductName = Item.Apple, Quantity = 2, UnitPrice = 0M });
            cart.CartItems.Add(new Data.Entity.CartItem() { CreatedDate = DateTime.Now, ID = 2, ProductName = Item.Orange, Quantity = 3, UnitPrice = 0M });

            var result = ser.GetTotal(cart, mockDiscount);

            Assert.AreEqual(expectedResult, result);
        }
        #endregion

    }
}
