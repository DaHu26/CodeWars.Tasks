using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.CountPositivesSumNegatives
{
    public class Kata
    {
        public static int[] CountPositivesSumNegatives(int[] input)
        {
            if (input == null)
                return new int[0];

            if (input.Length == 0)
                return new int[0];

            var positiveNumbers = 0;
            var negativeNumbers = 0;

            foreach (int i in input)
            {
                if (i > 0)
                    positiveNumbers++;
                else
                    negativeNumbers += i;
            }
            int[] result = new int[] { positiveNumbers, negativeNumbers };
            return result;
        }
    }

    [TestClass]
    public class TestClass
    {
        [TestMethod]
        [DataRow(new[] { 1, 2, 3, 4, -5, -15 }, new[] { 4, -20 })]
        [DataRow(new[] { 0, 4, -1, -2, 3}, new[] {2, -3})]
        public void CountPositivesSumNegativesTest(int[] numbers, int[] expectedResult)
        {
            var result = Kata.CountPositivesSumNegatives(numbers);
            for (int i = 0; i < result.Length; i++)
            {
                Assert.AreEqual(expectedResult[i], result[i]);
            }
        }
    }
}
