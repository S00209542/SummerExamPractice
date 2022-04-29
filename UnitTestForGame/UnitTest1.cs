using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SummerExamPractice;

namespace UnitTestForGame
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodDecreasePrice()
        {
            Game game1 = new Game() { Name = "Super Smash", Price = 60m};
            decimal expected = 50m;

            game1.DecreasePrice(10m);

            Assert.AreEqual(expected, game1.Price);

        }
    }
}
