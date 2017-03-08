using FastVehicles;
using SlowVehicles;

namespace RacingGame
{
    public class RacecarFactory : IFactory
    {
        public IFastVehicle CreateFastRacingVehicle()
        {
            return new F1Car();
        }
        public ISlowVehicle CreateSlowRacingVehicle()
        {
            return new OffroadCar();
        }
    }
}
