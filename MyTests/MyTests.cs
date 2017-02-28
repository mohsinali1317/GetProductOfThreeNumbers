using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GetProductOfThreeNumbers;

namespace MyTests
{
    [TestClass]
    public class MyTests
    {
        [TestMethod]
        public void CheckProductForArray()
        {
            int[] iInput = { 1, 10, 2, 5, 6, 2 };

            ProductCalculator pc = new ProductCalculator();

            Assert.AreEqual(300, pc.CalculateProduct(iInput));
        }
    }
}
