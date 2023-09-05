using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace CodeWars.SolutionTest
{
    public class Kata
    {
        public static double Billboard(string name, double price = 30)
        {
            double fullPrice = 0;

            for (int i = 0; i < name.Count(); i++)
            {
                fullPrice += price;
            }
                
            return fullPrice;
        }
    }

    [TestClass]
    public class SolutionTest
    {
        [TestMethod]
        public void SampleTests()
        {
            Assertion(600, "Jeong-Ho Aristotelis");
            Assertion(40, "CODEWARS", 5);
        }

        private static void Assertion(double expected, string name, double price = -1) =>
          Assert.AreEqual(expected,price == -1 ? Kata.Billboard(name) : Kata.Billboard(name, price),

              0.000001,

              $"\n  Name: \"{name}\"\n" +
                $"  Price: {(price == -1 ? 30 : price)}\n\n"

          );
    }
}
