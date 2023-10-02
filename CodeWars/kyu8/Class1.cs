using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.PositiveSum
{
    public class Kata
    {
        public static int PositiveSum(int[] arr)
        {
            return arr.Where(x => x > 0).Sum();
        }
    }


    [TestClass]
    public class Tests
    {
        [Test]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, ExpectedResult = 15)]
        [TestCase(new int[] { 1, -2, 3, 4, 5 }, ExpectedResult = 13)]
        [TestCase(new int[] { -1, 2, 3, 4, -5 }, ExpectedResult = 9)]
        [TestCase(new int[] { }, ExpectedResult = 0)]
        [TestCase(new int[] { -1, -2, -3, -4, -5 }, ExpectedResult = 0)]
        public static int ExampleTest(int[] arr)
        {
            return Kata.PositiveSum(arr);
        }
    }

}
