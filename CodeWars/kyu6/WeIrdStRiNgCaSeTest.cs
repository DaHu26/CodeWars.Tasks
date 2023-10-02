using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.WeIrdStRiNgCaSeTest
{
    public class WeIrdStRiNgCaSeTest
    {
        public static string ToWeirdCase(string s)
        {
            var listChar = new List<char>();
            var listString = new List<string>();
            string[] words = s.Split(' ');
            char newChar;

            foreach (var word in words)
            {
                var charArray = word.ToCharArray();

                for (int i = 0; i < charArray.Length; i++)
                {
                    if (i % 2 == 0)
                        newChar = char.ToUpper(charArray[i]);
                    else
                        newChar = char.ToLower(charArray[i]);

                    listChar.Add(newChar);
                }
                listString.Add(string.Join(string.Empty, listChar));
                listChar.Clear();
            }

            return string.Join(" ", listString);
        }
    }

    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void ShouldWorkForSomeExamples()
        {
            Assert.AreEqual("ThIs", WeIrdStRiNgCaSeTest.ToWeirdCase("This"));
            Assert.AreEqual("Is", WeIrdStRiNgCaSeTest.ToWeirdCase("is"));
            Assert.AreEqual("ThIs Is A TeSt", WeIrdStRiNgCaSeTest.ToWeirdCase("This is a test"));
        }
    }
}
