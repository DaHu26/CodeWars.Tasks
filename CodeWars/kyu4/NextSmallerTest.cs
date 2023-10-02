using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace CodeWars.NextSmaller
{
    public class Kata
    {
        public static long NextSmaller(long n)
        {
            var listNumbers = new List<long>();
            var listResult = new List<long>();
            var longToString = n.ToString();

            for (int i = 0; i < longToString.Length; i++)
            {
                listNumbers.Add(longToString[i] - '0');
            }

            for (int i = 0; i < listNumbers.Count; i++)
            {
                int number = (int)listNumbers[i];
                for (int y = 0; y < listNumbers.Count; y++)
                {
                    var changeList = listNumbers.ToList();
                    changeList.RemoveAt(i);
                    changeList.Insert(y, number);
                    var listToString = string.Empty;

                    foreach (var listNumber in changeList)
                        listToString += listNumber.ToString();

                    var newNumber = long.Parse(listToString);

                    if (changeList[0] == 0)
                        continue;

                    if (newNumber < n)
                        listResult.Add(newNumber);
                }
            }

            if (listResult.Count == 0)
                return -1;

            return listResult.Max();
        }

        [TestClass]
        public class Tests
        {
            [TestMethod]
            [DataRow(1234567908, 1234567890)]
            [DataRow(2071, 2017)]
            public void FixedTests(long numbers, long expectedResult)
            {
                var result = Kata.NextSmaller(numbers);
                Assert.AreEqual(expectedResult, result);
            }
        }
    }
}
