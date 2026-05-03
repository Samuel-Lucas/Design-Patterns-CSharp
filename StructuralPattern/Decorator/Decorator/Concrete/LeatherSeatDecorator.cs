using Decorator.Decorator.Base;
using Decorator.Interfaces;

namespace Decorator.Decorator.Concrete;

public class LeatherSeatDecorator : CarDecorator
{
    public LeatherSeatDecorator(ICar car) : base(car) { }

    public override string GetCar()
    {
        return base.GetCar() + " with leather seat";
    }
}