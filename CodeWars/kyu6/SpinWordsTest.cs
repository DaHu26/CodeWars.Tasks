using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.SpinWordsTest
{
    public class Kata
    {
        public static string SpinWords(string sentence)
        {
            string[] words = sentence.Split(' ');
            char[] charWord;
            var listWords = new List<string>();

            foreach(string word in words) 
            {
                charWord = word.ToCharArray();
                if (charWord.Length > 4 )
                    Array.Reverse(charWord);

                var result = new string(charWord);
                listWords.Add(result);
            }

            var i = String.Join(" ", listWords);

            return i;
        }
    }

    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void Test1()
        {
            Assert.AreEqual("emocleW", Kata.SpinWords("Welcome"));
        }

        [TestMethod]
        public void Test2()
        {
            Assert.AreEqual("Hey wollef sroirraw", Kata.SpinWords("Hey fellow warriors"));
        }

        [TestMethod]
        public void Test3()
        {
            Assert.AreEqual("This is a test", Kata.SpinWords("This is a test"));
        }

        [TestMethod]
        public void Test4()
        {
            Assert.AreEqual("This is rehtona test", Kata.SpinWords("This is another test"));
        }

        [TestMethod]
        public void Test5()
        {
            Assert.AreEqual("You are tsomla to the last test", Kata.SpinWords("You are almost to the last test"));
        }

        [TestMethod]
        public void Test6()
        {
            Assert.AreEqual("Just gniddik ereht is llits one more", Kata.SpinWords("Just kidding there is still one more"));
        }
    }
}
