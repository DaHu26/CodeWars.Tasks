using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using System.Globalization;

namespace CodeWars.JadenCaseTest
{
    public static class JadenCase
    {
        public static string ToJadenCase(this string phrase)
        {
            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
            string result = textInfo.ToTitleCase(phrase);
            return result;
        }
    }

    [TestClass]
    public class JadenCaseTest
    {
        [TestMethod]
        public void FixedTest()
        {
            Assert.AreEqual("How Can Mirrors Be Real If Our Eyes Aren't Real",
                            "How can mirrors be real if our eyes aren't real".ToJadenCase(),
                            "Strings didn't match.");
        }
    }
}
