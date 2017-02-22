using Cars;

namespace Accessories
{
    public class SportSeats : CarAccessory
    {
        public SportSeats(ICar car) : base(car)
        {
        }
        public override double CalculateCost()
        {
            return car.CalculateCost() + 1400 ;
        }
    }
}
