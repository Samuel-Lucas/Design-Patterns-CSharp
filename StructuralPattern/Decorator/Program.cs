using Decorator;
using Decorator.Decorator.Concrete;
using Decorator.Interfaces;

ICar car = new Car();
ICar carWithAirConditioner = new AirConditionerDecorator(car);
ICar carWithLeatherSeat = new AirConditionerDecorator(carWithAirConditioner);

var result = carWithLeatherSeat.GetCar();

Console.WriteLine(result);