using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace CodeWars.SquareSum
{
    public class Kata
    {
        public static int SquareSum(int[] numbers)
        {
            var squareNumbers = new List<int>();
            foreach (int number in numbers)
            {
                var newNumber = number * number;
                squareNumbers.Add(newNumber);
            }

            return squareNumbers.Sum();
        }
    }

    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void SquareSumTest()
        {
            var numbers = new int[] { 1, 2, 3 };
            var result = Kata.SquareSum(numbers);
            Assert.AreEqual(14, result);

            var numbers2 = new int[] { 5, 1, 6 };
            var result2 = Kata.SquareSum(numbers2);
            Assert.AreEqual(62, result2);
        }
    }
}
