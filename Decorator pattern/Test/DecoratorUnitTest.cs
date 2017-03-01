using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Accessories;
using Cars;
namespace Test
{
    [TestClass]
    public class DecoratorUnitTest
    {
        [TestMethod]
        public void Decorate_With_Bumber()
        {
            double expectedResult = 102500;
            ICar merc = new Mercedes(); // +100000
            merc = new Bumper(merc); // +2500
            Assert.AreEqual(expectedResult, merc.CalculateCost());
        }
        [TestMethod]
        public void Decorate_With_Spoiler()
        {
            double expectedResult = 101000;
            ICar merc = new Mercedes(); // +100000
            merc = new Spoiler(merc); // +1000
            Assert.AreEqual(expectedResult, merc.CalculateCost());
        }
        [TestMethod]
        public void Decorate_With_SportSeats()
        {
            double expectedResult = 101400;
            ICar merc = new Mercedes(); // +100000
            merc = new SportSeats(merc); // +1400
            Assert.AreEqual(expectedResult, merc.CalculateCost());
        }

        [TestMethod]
        public void AddDecorations_Multuple_Times()
        {
            double expectedResult = 207700;
            ICar ferrari = new Ferrari(); // +200000
            ferrari = new Bumper(ferrari); // +2500
            ferrari = new SportSeats(ferrari); // +1400
            ferrari = new SportSeats(ferrari); // +1400
            ferrari = new SportSeats(ferrari); // +1400
            ferrari = new Spoiler(ferrari); // +1000

            Assert.AreEqual(expectedResult, ferrari.CalculateCost());

        }
    }
}
