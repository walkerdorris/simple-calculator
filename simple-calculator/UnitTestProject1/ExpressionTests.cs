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

            Assert.Equals(1, term1);
            Assert.Equals(2, term2);
            Assert.Equals('+', op);
        }

        [TestMethod]
        public void MyTestMethod()
        {
            Expression parser = new Expression();
            string input = "1 + 2";
            parser.ParseInput(input);

            Evaluate eval = new Evaluate();
            decimal result = eval.Calculate(parser.Term1, parser.Op, parser.Term2);

            Assert.AreEqual(3, result);
        }



        [TestMethod]
        public void AddOperator()
        {
            Expression pickout = new Expression();
            string input = "1 + 2";
            char[] characters = input.ToCharArray();
            for (int i = 0; i < input.Length; i++)
            {
                if (characters[i].Equals ("+"))
                {
                    Assert.Equals('a', "+"); 
                }
            }
        }

        [TestMethod]
        public void Seperation()
        {
            var str = "3 + 2";
            string[] expression = str.Split('+');
            Assert.Equals(new[] { "3 ", " 2" }, expression);
        }

        [TestMethod]
        public void EliminateSpaces()
        {
            string equation = "1 + 1";
            equation = equation.Replace(" ", String.Empty);
            Assert.Equals("1+1", equation);
        }
    }
}
