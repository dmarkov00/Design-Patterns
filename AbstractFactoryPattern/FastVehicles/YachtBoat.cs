using System;

namespace FastVehicles
{
    public class YachtBoat : IFastVehicle
    {
        public string GainSpeed()
        {
            return "The yacht boat streches its canvas, so it can use wind power and gain speed";
        }
        public string MoveFast()
        {
            return "The yacht boat is floating very fast";
        }
    }
}
