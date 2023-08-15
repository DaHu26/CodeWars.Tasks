namespace CodeWars.TwoArePositiveTest
{
    [TestClass]
    public class TwoArePositiveTest
    {
        [TestMethod]
        public void BasicTests()
        {
            Assert.AreEqual(true, Kata.TwoArePositive(2, 4, -3), "(2, 4, -3)");
            Assert.AreEqual(true, Kata.TwoArePositive(-4, 6, 8), "(-4, 6, 8)");
            Assert.AreEqual(true, Kata.TwoArePositive(4, -6, 9), "(4, -6, 9)");
            Assert.AreEqual(true, Kata.TwoArePositive(4, 6, 0), "(4, 6, 0)");
            Assert.AreEqual(false, Kata.TwoArePositive(-4, 6, 0), "(-4, 6, 0)");
            Assert.AreEqual(false, Kata.TwoArePositive(4, 6, 10), "(4, 6, 10)");
            Assert.AreEqual(false, Kata.TwoArePositive(-14, -3, -4), "(-14, -3, -4)");
        }
    }

    public static class Kata
    {
        public static bool TwoArePositive(int a, int b, int c)
        {
            int[] nums = { a, b, c };
            IEnumerable<int> positiveNums = nums.Where(x => x > 0);

            if (positiveNums.Count() == 2)
                return true;
            else
                return false;
        }

    }
}