using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.CreatePhoneNumberTest
{
    public class CreatePhoneNumberTest
    {
        public static string CreatePhoneNumber(int[] numbers)
        {
            string firstThree = string.Empty;
            string secondSeven = string.Empty;
            for (int i = 0; i < 3; i++)
            {
                firstThree += numbers[i];
            }
            firstThree = $"({firstThree})";

            for (int i = 3; i < 10; i++)
            {
                secondSeven += numbers[i];
                if (i == 5)
                {
                    secondSeven += "-";
                }
            }

            return string.Join(" ", firstThree, secondSeven);
        }
    }

    [TestClass]
    public class Tests
    {
        [TestMethod]
        [DataRow(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }, "(123) 456-7890")]
        [DataRow(new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, "(111) 111-1111")]
        public void FixedTest(int[] numbers, string expectedResult)
        {
            Assert.AreEqual(CreatePhoneNumberTest.CreatePhoneNumber(numbers), expectedResult);
        }
    }
}