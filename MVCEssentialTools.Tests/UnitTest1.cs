using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MVCEssentialTool.Models;

namespace MVCEssentialTools.Tests
{
    [TestClass]
    public class UnitTest1
    {
        private IDiscountHelper getTestObject()
        {
            return new MinimumDiscountHelper();
        }

        [TestMethod]
        public void Discount_Above_100()
        {
            IDiscountHelper target = getTestObject();
            var total = 200;

            var discountTotal = target.ApplyDiscount(total);

            Assert.AreEqual(total * 0.9m, discountTotal);
        }

        [TestMethod]
        public void Discount_Between_10_And_100()
        {
            IDiscountHelper target = getTestObject();
            decimal TenDollarDiscount = target.ApplyDiscount(10);
            decimal HundredDollarDiscount = target.ApplyDiscount(100);
            decimal FiftyDollarDiscount = target.ApplyDiscount(50);

            Assert.AreEqual(5, TenDollarDiscount, "$10 discount iswrong");
            Assert.AreEqual(95, HundredDollarDiscount, "$100 discount is wrong");
            Assert.AreEqual(45, FiftyDollarDiscount, "$50 discount is wrong");
        }

        [TestMethod]
        public void Discount_Below_10()
        {
            IDiscountHelper target = getTestObject();

            decimal discount5 = target.ApplyDiscount(5);
            decimal discount0 = target.ApplyDiscount(0);
            
            Assert.AreEqual(5, discount5);
            Assert.AreEqual(0, discount0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Discount_Negative_Total()
        {            
            IDiscountHelper target = getTestObject();
         
            target.ApplyDiscount(-1);
        }
    }
}
