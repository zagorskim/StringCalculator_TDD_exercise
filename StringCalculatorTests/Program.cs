// See https://aka.ms/new-console-template for more information
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringCalculatorTests;


    [TestClass]
    internal class UnitTests
    {
        [TestMethod]
        public void Test1()
        {
            var calc = new StringCalculator.Calculator();
            Assert.AreEqual(54, calc.Add("2 2 50"));
        }
    }
