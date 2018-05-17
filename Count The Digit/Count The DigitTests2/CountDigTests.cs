using Microsoft.VisualStudio.TestTools.UnitTesting;
using Count_The_Digit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_The_Digit.Tests
{
    [TestClass()]
    public class CountDigTests
    {
        [TestMethod()]
        public void isAnArrayBuildedAndFilledUp()
        {
            CountDig count = new CountDig();
            count.NbDig(13, 0);
            var ExpectedLenght = 14;
            //Assert.AreEqual(count.ArrayLenght, ExpectedLenght);
        }


    }
}
