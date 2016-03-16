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
            Assert.AreEqual(3, answer);
        }

        [TestMethod]
        public void SubtractionTest()
        {
            Evaluate input = new Evaluate();
            int Term1 = 4;
            int Term2 = 2;
            char Oper = '-';

            int answer = input.Calculate(4, 2, '-');
            Assert.AreEqual(2, answer);
        }
        [TestMethod]
        public void MultiplicationTest()
        {
            Evaluate input = new Evaluate();
            int Term1 = 1;
            int Term2 = 2;
            char Oper = '*';

            int answer = input.Calculate(1, 2, '*');
            Assert.AreEqual(2, answer);
        }
        [TestMethod]
        public void DivisionTest()
        {
            Evaluate input = new Evaluate();
            int Term1 = 4;
            int Term2 = 2;
            char Oper = '/';

            int answer = input.Calculate(4, 2, '/');
            Assert.AreEqual(2, answer);
        }
        [TestMethod]
        public void ModulusTest()
        {
            Evaluate input = new Evaluate();
            int Term1 = 5;
            int Term2 = 2;
            char Oper = '%';

            int answer = input.Calculate(5, 2, '%');
            Assert.AreEqual(1, answer);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EvaluateExceptionTest()
        {
            Evaluate input = new Evaluate();
            int Term1 = 1;
            int Term2 = 2;
            char Oper = '7';

            int answer = input.Calculate(1, 2, '7');
        }
    }
}
