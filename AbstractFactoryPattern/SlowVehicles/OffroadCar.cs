using System;

namespace SlowVehicles
{
    public class OffroadCar : ISlowVehicle
    {
        public string DodgeObstacles()
        {
            return "The off-road car is dodging obstacles ";
        }
        public string MoveSlowly()
        {
            return "The off-road car is driving slowly through very narrow paths";
        }
    }
}
