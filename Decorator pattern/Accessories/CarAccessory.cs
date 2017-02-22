using System;
using Cars;
namespace Accessories
{

    public abstract class CarAccessory : ICar
    {
        public CarAccessory(ICar car)
        {
            this.car = car;
        }
        protected ICar car;
        public virtual double CalculateCost()
        {
            return car.CalculateCost();
        }

    }
}
