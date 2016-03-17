using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using simpleCalculator;

namespace UnitTestProject1
{
    [TestClass]
    public class CounterTests
    {
        [TestMethod]
        public void TestCounterWithUserInput()
        {
            Counter input = new Counter();
            int count = 0;
            string userinput = "Hello";
            int answer = input.ConsoleCounter(userinput, count);
            Assert.AreEqual(answer, 1);

        }
        [TestMethod]
        public void TestCounterWithoutUserInput()
        {
            Counter input = new Counter();
            int count = 0;
            string userinput = "";
            int answer = input.ConsoleCounter(userinput, count);
            Assert.AreEqual(count, 0);

        }
    }
}
