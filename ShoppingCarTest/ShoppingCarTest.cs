using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ShoppingCar;

namespace ShoppingCarTest
{
    [TestClass]
    public class ShoppingCarTest
    {
        [TestMethod]
        public void 第一集買1本其他都沒買_價格應為100()
        {
            //arrange
            var target = new ShoppingList();
            var goods = GetGoods();
            var excepted = 100;

            //act
            var actual = target.GetTotalAmount(goods);

            //assert
            Assert.AreEqual(excepted, actual);
        }

        private object GetGoods()
        {
            throw new NotImplementedException();
        }
    }

    internal class ShoppingList
    {
        public ShoppingList()
        {
        }

        internal object GetTotalAmount(object goods)
        {
            throw new NotImplementedException();
        }
    }
}
