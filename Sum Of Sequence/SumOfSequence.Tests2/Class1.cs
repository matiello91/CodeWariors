using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SumOfSequence;
using Sum_Of_Sequence;

namespace SumOfSequence.Tests2
{
    [TestFixture]
    public class Class1
    {
        [TestCase(2, 6, 2, 12)]
        [TestCase(1, 5, 1, 15)]
        [TestCase(1, 5, 3, 5)]
        [TestCase(0, 15, 3, 45)]
        [TestCase(16, 15, 3, 0)]
        [TestCase(2, 24, 22, 26)]
        public void BasicTest(int start, int end, int step, int result)
        {
            Assert.AreEqual(result, Kata.SequenceSum(start, end, step));

        }
        [Test]
        public void BasicTest()
        {
            Assert.AreEqual(12, Kata.SequenceSum(2, 6, 2));
            Assert.AreEqual(15, Kata.SequenceSum(1, 5, 1));
            Assert.AreEqual(5, Kata.SequenceSum(1, 5, 3));
            Assert.AreEqual(45, Kata.SequenceSum(0, 15, 3));
            Assert.AreEqual(0, Kata.SequenceSum(16, 15, 3));
            Assert.AreEqual(26, Kata.SequenceSum(2, 24, 22));
            Assert.AreEqual(2, Kata.SequenceSum(2, 2, 2));
            Assert.AreEqual(2, Kata.SequenceSum(2, 2, 1));
            Assert.AreEqual(35, Kata.SequenceSum(1, 15, 3));
            Assert.AreEqual(0, Kata.SequenceSum(15, 1, 3));
        }
    }


}
