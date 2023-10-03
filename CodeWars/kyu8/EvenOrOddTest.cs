using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.EvenOrOddTest
{
    public class EvenOrOddClass
    {
        public static string EvenOrOdd(int number)
        {
            return number % 2 == 0 ? "Even" : "Odd";
        }
    }

    [TestClass]
    public class TestClass
    {
        [TestMethod]
        [DataRow(12, "Even")]
        [DataRow(11, "Odd")]
        [DataRow(101, "Odd")]
        public void EvenOrOddTest(int number, string expectedResult)
        {
            var result = EvenOrOddClass.EvenOrOdd(number);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
