using Cars;

namespace Accessories
{
    public class Spoiler : CarAccessory
    {
        public Spoiler(ICar car) : base(car)
        {
        }
        public override double CalculateCost()
        {
            return car.CalculateCost() + 1000;
        }
    
    }
}
