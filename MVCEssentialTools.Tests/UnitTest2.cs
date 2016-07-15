using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MVCEssentialTool.Models;
using Moq;

namespace MVCEssentialTools.Tests
{
    [TestClass]
    public class UnitTest2
    {
        private Product[] createProduct(decimal value)
        {
            return new[]{ new Product { Price = value }};
        }


        [TestMethod]
        public void TestMethod1()
        {
            Mock<IDiscountHelper> mock = new Mock<IDiscountHelper>();
            mock.Setup(m => m.ApplyDiscount(It.IsAny<decimal>())).Returns<decimal>(total => total);
            mock.Setup(m => m.ApplyDiscount(It.Is<decimal>(v=>v==0))).Throws<ArgumentOutOfRangeException>();
            mock.Setup(m => m.ApplyDiscount(It.Is<decimal>(v => v >100))).Returns<decimal>(total => (total*0.9m));
            mock.Setup(m => m.ApplyDiscount(It.IsInRange<decimal>(10,100,Range.Inclusive))).Returns<decimal>(total => total-5);
            var target = new LinqValueCalculator(mock.Object);

            decimal valueforlessthat10 = target.ValueProducts(createProduct(5));

            Assert.AreEqual(5, valueforlessthat10);
        }
    }
}
