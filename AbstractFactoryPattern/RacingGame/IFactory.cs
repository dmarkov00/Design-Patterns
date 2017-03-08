using FastVehicles;
using SlowVehicles;
namespace RacingGame
{
    public interface IFactory
    {
        IFastVehicle CreateFastRacingVehicle();
        ISlowVehicle CreateSlowRacingVehicle();
    }
}
