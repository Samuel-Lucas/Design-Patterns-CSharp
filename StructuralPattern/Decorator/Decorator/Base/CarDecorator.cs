using Decorator.Interfaces;

namespace Decorator.Decorator.Base;

// Decorator (Base)
public class CarDecorator : ICar
{
    private readonly ICar _car;

    public CarDecorator(ICar car)
    {
        _car = car;
    }

    public virtual string GetCar()
    {
        return _car.GetCar();
    }
}