using Decorator.Decorator.Base;
using Decorator.Interfaces;

namespace Decorator.Decorator.Concrete;

public class AirConditionerDecorator : CarDecorator
{
    public AirConditionerDecorator(ICar car) : base(car) { }

    public override string GetCar()
    {
        return base.GetCar() + " with air conditioner";
    }
}