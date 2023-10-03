using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.MakeNegativeTets
{
    public static class Kata
    {
        public static int MakeNegative(int number)
        {
            return number <= 0 ? number : -number;
        }
    }

    [TestClass]
    public class Test
    {
        [TestMethod]
        [DataRow(5, -5)]
        [DataRow(0, 0)]
        [DataRow(-7, -7)]
        public void MakeNegativeTest(int number, int expectedResult)
        {
            var result = Kata.MakeNegative(number);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
