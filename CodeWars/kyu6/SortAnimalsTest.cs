using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace CodeWars.kyu6
{
    public class Animal
    {
        public string Name { get; set; }
        public int NumberOfLegs { get; set; }
    }
    public class AnimalSorter
    {
        public List<Animal> Sort(List<Animal> input)
        {
            var OrderByLegs = input.OrderBy(x => x.NumberOfLegs).ToList<Animal>();
            for (int i = 0; i < OrderByLegs.Count - 1; i++)
            {
                if (OrderByLegs[i].NumberOfLegs == OrderByLegs[i + 1].NumberOfLegs)
                {
                    if (OrderByLegs[i].Name.First() > OrderByLegs[i + 1].Name.First())
                    {
                        var needToSwap = OrderByLegs[i + 1];
                        OrderByLegs.RemoveAt(i + 1);
                        OrderByLegs.Insert(i, needToSwap);
                    }
                }
            }
            return OrderByLegs;
        }
    }

    [TestClass]
    public class AnimalSorterTests
    {
        [TestMethod]
        public void SortTest()
        {
            var animals = new List<Animal>
      {
        new Animal {Name = "Cat", NumberOfLegs = 4},
        new Animal {Name = "Snake", NumberOfLegs = 0},
        new Animal {Name = "Dog", NumberOfLegs = 4},
        new Animal {Name = "Pig", NumberOfLegs = 4},
        new Animal {Name = "Human", NumberOfLegs = 2},
        new Animal {Name = "Bird", NumberOfLegs = 2}
      };
            var output = new AnimalSorter().Sort(animals);
            Assert.AreEqual(output[0].Name, "Snake");
            Assert.AreEqual(output[3].Name, "Cat");
        }
    }
}
