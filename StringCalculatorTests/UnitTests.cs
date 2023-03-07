using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace StringCalculatorTests
{
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
}
