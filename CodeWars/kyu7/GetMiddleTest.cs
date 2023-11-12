namespace CodeWars.kyu7
{
    public class GetMiddle
    {
        public static string GetMiddleString(string s)
        {
            int lenth = s.Length;
            if (lenth % 2 == 0)
            {
                return s[lenth / 2 - 1] + s[lenth / 2].ToString();
            }
            else
            {
                return s[lenth / 2].ToString();
            }
        }
    }
    [TestClass]
    public class GetMiddleTests
    {
        [TestMethod]
        public void GetMiddleTest()
        {
            var expectedResult = "sN";
            Assert.AreEqual(expectedResult, GetMiddle.GetMiddleString("expectedIsNotWorking"));
            var expectedResult2 = "b";
            Assert.AreEqual(expectedResult2, GetMiddle.GetMiddleString("aba"));
            var expectedResult3 = "b";
            Assert.AreEqual(expectedResult3, GetMiddle.GetMiddleString("aaaabaaaa"));
        }
    }
}
