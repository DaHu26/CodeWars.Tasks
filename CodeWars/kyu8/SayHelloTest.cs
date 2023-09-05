using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace SayHelloTest
{
    public class Kata
    {
        public static string SayHello(string[] name, string city, string state)
        {
            return $"Hello, {string.Join(" ", name)}! Welcome to {city}, {state}!";
        }
    }

    [TestClass]
    public class SolutionTest
    {
        [TestMethod]
        public void SampleTest()
        {
            Assert.AreEqual("Hello, John Smith! Welcome to Phoenix, Arizona!", Kata.SayHello(new string[] { "John", "Smith" }, "Phoenix", "Arizona"));
        }
    }
}
