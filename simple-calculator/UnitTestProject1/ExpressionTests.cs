using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1;

namespace ExpressionTests
{
    [TestClass]
    public class ExpressionTest
    {
        [TestMethod]
        public void ParsingTest()
        {

            Expression parser = new Expression();
            string input = "1 + 2";
            parser.ParseInput(input);
            int term1 = parser.Term1;
            int term2 = parser.Term2;
            char op = parser.Op;

            Assert.AreEqual(1, term1);
            Assert.AreEqual(2, term2);
            Assert.AreEqual('+', op);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ParsingTestBadInputOne()
        {
            Expression parser = new Expression();
            string input = "$ + 1";
            parser.ParseInput(input);
            int term1 = parser.Term1;
            int term2 = parser.Term2;
            char op = parser.Op;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ParsingTestBadInputTwo()
        {
            Expression parser = new Expression();
            string input = "1 $ 1";
            parser.ParseInput(input);
            int term1 = parser.Term1;
            int term2 = parser.Term2;
            char op = parser.Op;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ParsingTestBadInputThree()
        {
            Expression parser = new Expression();
            string input = "1 + $";
            parser.ParseInput(input);
            int term1 = parser.Term1;
            int term2 = parser.Term2;
            char op = parser.Op;
        }
    }
}
