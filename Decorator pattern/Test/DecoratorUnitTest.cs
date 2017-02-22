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
