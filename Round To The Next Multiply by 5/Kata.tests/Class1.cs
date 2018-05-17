using NUnit.Framework;
using Round_To_The_Next_Multiply_by_5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.tests
{
    [TestFixture]
    public class Class1
    {
        [TestCase(0, 0)]
        [TestCase(1, 5)]
        [TestCase(3, 5)]
        [TestCase(5, 5)]
        [TestCase(7, 10)]
        [TestCase(39, 40)]
        public void checkIsRoundingProperly(int x, int expectedResult)
        {
            var tester = new Kata2();
            var result = tester.RoundToNext5(x);
            Assert.AreEqual(result, expectedResult);
        }
    }
}
