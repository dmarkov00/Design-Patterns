using Cars;

namespace Accessories
{
    public class Bumper : CarAccessory
    {
        public Bumper(ICar car) : base(car)
        {
        }
        public override double  CalculateCost()
        {
            return car.CalculateCost() + 2500;
        }
  
    }
}
