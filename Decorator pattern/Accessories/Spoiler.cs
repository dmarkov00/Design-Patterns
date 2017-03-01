using Cars;

namespace Accessories
{
    public class Spoiler : CarAccessory
    {
        public Spoiler(ICar car) : base(car)
        {
        }
        // adding 1000 for a spoiler
        public override double CalculateCost()
        {
            return car.CalculateCost() + 1000;
        }
    
    }
}
