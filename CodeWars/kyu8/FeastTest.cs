namespace CodeWars.kyu8.FeastTest
{
    public class Feast
    {
        public static bool FeastMethod(string beast, string dish)
        {
            var firstAnimal = beast.First();
            var lastAnimal = beast.Last();

            var firstDish = dish.First();
            var lastDish = dish.Last();

            if (firstAnimal == firstDish && lastAnimal == lastDish)
                return true;

            return false;
        }
    }

    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void Test()
        {
            var animal = "wolf";
            var food = "waraf";

            var result = Feast.FeastMethod(animal, food);

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestFalse()
        {
            var animal = "bear";
            var food = "honey";

            var result = Feast.FeastMethod(animal, food); 

            Assert.AreEqual(false, result);
        }
    }
}
