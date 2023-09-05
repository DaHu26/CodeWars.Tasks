using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.FindMissingLetterTest
{
    public class FindMissingLetterTest
    {
        public static char FindMissingLetter(char[] array)
        {
            var alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            var isUpper = char.IsUpper(array[0]);
            var stringArray = new string(array);
            var etalonArray = stringArray.ToLower().ToArray();
            var firstChar = alphabet.SkipWhile(x => x != etalonArray[0]).Take(etalonArray.Length + 1).ToArray();

            for (int i = 0; i < firstChar.Length; i++)
            {
                var comparedChar = firstChar[i];

                if (comparedChar != etalonArray[i])
                    return isUpper ? char.ToUpper(comparedChar) : comparedChar;
            }
            return ' ';
        }
    }

    [TestClass]
    public class KataTests
    {
        [TestMethod]
        public void ExampleTests()
        {
            Assert.AreEqual('e', FindMissingLetterTest.FindMissingLetter(new[] { 'a', 'b', 'c', 'd', 'f' }));
            Assert.AreEqual('P', FindMissingLetterTest.FindMissingLetter(new[] { 'O', 'Q', 'R', 'S' }));
        }
    }
}
