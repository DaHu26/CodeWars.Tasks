using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.SquareDigitsTest
{
    public class Kata
    {
        public static int SquareDigits(int n)
        {
            var stringInt = n.ToString();
            char[] charInt = stringInt.ToCharArray();
            var listInt = new List<int>();

            foreach (char c in charInt) 
            {
                var number = c - '0';
                var square = number * number;
                listInt.Add(square);
            }

            var stringResult = string.Join("", listInt);
            var result = int.Parse(string.Join(string.Empty, stringResult));

            return result;
        }
    }

        [TestClass]
    public class KataTest
    {
        [TestMethod]
        public void SquareDigitsTest()
        {
            Assert.AreEqual(811181, Kata.SquareDigits(9119));
            Assert.AreEqual(0, Kata.SquareDigits(0));
        }
    }
}
