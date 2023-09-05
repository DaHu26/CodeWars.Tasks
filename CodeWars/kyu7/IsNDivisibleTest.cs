using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.IsNDivisibleTest
{
    public static class IsNDivisibleTest
    {
        public static bool IsDivisible(int first, int second, int third)
        {
            return first % second == 0 && first % third == 0;
        }
    }

    [TestClass]
    public class SolutionTest
    {
        [TestMethod]
        public void BasicTest1()
        {
            Assert.AreEqual(false, IsNDivisibleTest.IsDivisible(3, 3, 4));
        }

        [TestMethod]
        public void BasicTest2()
        {
            Assert.AreEqual(true, IsNDivisibleTest.IsDivisible(12, 3, 4));
        }
    }
}