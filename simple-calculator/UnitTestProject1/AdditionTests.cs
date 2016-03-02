using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    public class AdditionTests
    {
        [TestMethod]
        public void AddingTwoPositiveNumbers()
        {
            var add = new AdditionTests();
            var sum = add.Add(5, 10);
            Assert.Equals(15, sum);
        }

        [TestMethod]
        public void AddingNegativeAndPositveNumbers()
        {
            var add = new AdditionTests();
            var sum = add.Add(-2, 7);
            Assert.Equals(5, sum);
            
        }

        [TestMethod]
        public void AddingNegativeAndPositiveNumbers()
        {
            var add = new AdditionTests();
            var sum = add.Add(-3, -3);
            Assert.Equals(-6, sum);

        }

        [TestMethod]
        public void AddingZeroes()
        {
            var add = new AdditionTests();
            var sum = add.Add(0, 0);
            Assert.Equals(0, sum);

        }
    }
}
