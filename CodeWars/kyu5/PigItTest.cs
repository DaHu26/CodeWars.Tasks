using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.kyu5
{
    public class Kata
    {
        public static string PigIt(string str)
        {
            var stringArray = str.Split(' ');
            var list = new List<string>();
            foreach (var word in stringArray)
            {
                var i = word.First();
                if (word.Length != 1)
                {
                    var newWord = string.Concat(word.Skip(1));
                    newWord += i + "ay";
                    list.Add(newWord);
                }

                else
                    list.Add(word);
            }

            return string.Join(' ', list);
        }
    }

    [TestClass]
    public class KataTest
    {
        [TestMethod]
        public void KataTests()
        {
            Assert.AreEqual("igPay atinlay siay oolcay", Kata.PigIt("Pig latin is cool"));
            Assert.AreEqual("hisTay siay ymay tringsay", Kata.PigIt("This is my string"));
        }
    }
}
