using System;

namespace FastVehicles
{
    public class F1Car : IFastVehicle
    {
        public string GainSpeed()
        {
            return "The F1 car shifts gears and gaining speed";
        }

        public string MoveFast()
        {
            return "The F1 car is moving very fast on the track";
        }
    }
}
