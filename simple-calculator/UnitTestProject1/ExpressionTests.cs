using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionTests
{
    [TestClass]
    public class Parsing
    {
        [TestMethod]
        public void ExpressionTest1()
        {
            Parsing parser = new Parsing();
            string input = "1 + 2";
            string[] parsedOutput = parser.Parse(input);

            Assert.Equals("1", parsedOutput[0]);
            Assert.Equals("+", parsedOutput[1]);
            Assert.Equals("2", parsedOutput[2]);
        }
    }
}
