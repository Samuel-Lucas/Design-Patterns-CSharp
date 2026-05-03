using Decorator.Interfaces;

namespace Decorator;

public sealed class Car : ICar
{
    public string GetCar()
    {
        var car = "this is a basic car";
        return car;
    }
}