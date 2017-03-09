using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RacingGame;
using FastVehicles;
using SlowVehicles;

namespace Tests
{
    [TestClass]
    public class FactoryPatternTests
    {
        IFactory f;

        [TestMethod]
        public void Correct_Type_From_RaceboatFactory_CreateFastRacingVehicle()
        {
            f = new RaceboatFactory();
            // YachtBoat is expected to be the type 
            var expectedYachBoat = f.CreateFastRacingVehicle();

            Assert.IsInstanceOfType(expectedYachBoat, typeof(YachtBoat));
        }
        [TestMethod]
        public void Correct_Type_From_RaceboatFactory_CreateSlowRacingVehicle()
        {
            f = new RaceboatFactory();
            // KayakBoat is expected to be the type 
            var expectedKayakBoat = f.CreateSlowRacingVehicle();

            Assert.IsInstanceOfType(expectedKayakBoat, typeof(KayakBoat));
        }
        [TestMethod]
        public void Correct_Type_From_RacecarFactory_CreateFastRacingVehicle()
        {
            f = new RacecarFactory();

            // F1Car is the expected type
            var expectedF1Car = f.CreateFastRacingVehicle();

            Assert.IsInstanceOfType(expectedF1Car, typeof(F1Car));
        }
        [TestMethod]
        public void Correct_Type_From_RacecarFactory_CreateSlowRacingVehicle()
        {
            f = new RacecarFactory();

            // OffroadCar is the expected type
            var expectedOffroadCar = f.CreateSlowRacingVehicle();

            Assert.IsInstanceOfType(expectedOffroadCar, typeof(OffroadCar));
        }        
    }
}
