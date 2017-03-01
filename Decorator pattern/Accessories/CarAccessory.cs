using System;
using Cars;
namespace Accessories
{
    /// <summary>
    /// The decorator class used to be be inherited from the concrete decorators
    /// for bigger flexability
    /// </summary>
    public abstract class CarAccessory : ICar
    {
        public CarAccessory(ICar car)
        {
            this.car = car;
        }
        protected ICar car;
        public abstract double CalculateCost();
        

    }
}
