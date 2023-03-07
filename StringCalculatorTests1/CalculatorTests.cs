using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void AddEmptyTest()
        {
            var calc = new Calculator();
            Assert.AreEqual(0, calc.Add(""));
        }

        [TestMethod()]
        public void AddOneNumberTest()
        {
            var calc = new Calculator();
            Assert.AreEqual(2, calc.Add("2"));
        }

        [TestMethod()]
        public void AddCommaDelimitedTest()
        {
            var calc = new Calculator();
            Assert.AreEqual(4, calc.Add("2,2"));
        }

        [TestMethod()]
        public void AddNewlineDelimitedTest()
        {
            var calc = new Calculator();
            Assert.AreEqual(4, calc.Add("2\n2"));
        }

        [TestMethod()]
        public void AddEitherWayDelimitedTest()
        {
            var calc = new Calculator();
            Assert.AreEqual(6, calc.Add("2\n2,2"));
        }

        [TestMethod()]
        public void AddNegativeExceptionTest()
        {
            var calc = new Calculator();
            Assert.ThrowsException<ArgumentException>(new Action(() => calc.Add("2\n2,-2")));
        }

        [TestMethod()]
        public void AddIgnoresGreaterThan1000Test()
        {
            var calc = new Calculator();
            Assert.AreEqual(4, calc.Add("1001\n2,2"));
        }

        [TestMethod()]
        public void AddCustomSeparatorTest()
        {
            var calc = new Calculator();
            Assert.AreEqual(4, calc.Add("//$1001\n2,2"));
        }
    }
}