using FastVehicles;
using SlowVehicles;

namespace RacingGame
{
    public class RaceboatFactory : IFactory
    {
        public IFastVehicle CreateFastRacingVehicle()
        {
            return new YachtBoat();
        }
        public ISlowVehicle CreateSlowRacingVehicle()
        {
            return new KayakBoat();
        }
    }
}
