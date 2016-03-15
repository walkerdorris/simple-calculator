using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using simpleCalculator;

namespace EvaluateTests
{
    [TestClass]
    public class EvaluateTest
    {
        [TestMethod]
        public void AdditionTest()
        {
            Evaluate input = new Evaluate();
            int Term1 = 1;
            int Term2 = 2;
            char Oper = '+';

            int answer = input.Calculate(1, 2, '+');
            Assert.Equals(3, answer);
        }
    }
}
