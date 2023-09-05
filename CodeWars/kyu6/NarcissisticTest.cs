using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.NarcissisticTest
{
    public class NarcissisticTest
    {
        public static bool Narcissistic(int value)
        {
            var valueString = value.ToString();
            int[] values = valueString.Select(x => int.Parse(x.ToString())).ToArray();
            var list = new List<double>();

            for (int i = 0; i < values.Length; i++)
            {

                list.Add(Math.Pow(values[i], values.Length));
            }

            if (list.Sum() == value)
                return true;

            return false;
        }
    }

    [TestClass]
    public class Sample_Test
    {
        [TestMethod]
        [DataRow(1, true)]
        [DataRow(371, true)]
        [DataRow(297, false)]
        public void Test(int n, bool expectetResult)
        {
            Assert.AreEqual(expectetResult, NarcissisticTest.Narcissistic(n));
        }
    }
}