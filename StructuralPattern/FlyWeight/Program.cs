using FlyWeight.Entities;
using FlyWeight.FlyWeight;

// The client code usually creates a bunch of pre-populated
// flyweights in the initialization stage of the application. 
var factory = new FlyWeightFactory(
    new Car { Company = "Chevrolet", Model = "Camaro2018", Color = "pink" },
    new Car { Company = "Mercedes Benz", Model = "C300", Color = "black" },
    new Car { Company = "BMW", Model = "X6", Color = "white" },
    new Car { Company = "BMW", Model = "M5", Color = "red" }
);

factory.ListFlyweights();

addCarToPoliceDatabase(factory, new Car
{
    Number = "CL234IR",
    Owner = "James Doe",
    Company = "BMW",
    Model = "M5",
    Color = "red"
});

addCarToPoliceDatabase(factory, new Car
{
    Number = "CL234IR",
    Owner = "James Doe",
    Company = "BMW",
    Model = "X1",
    Color = "black"
});

factory.ListFlyweights();

static void addCarToPoliceDatabase(FlyWeightFactory factory, Car car)
{
    Console.WriteLine("InClient: Adding a car to database.");

    var flyWeight = factory.GetFlyweight(new Car 
    {
        Color = car.Color,
        Model = car.Model,
        Company = car. Company
    });

    // The client code either stores or calculates extrinsic state and
    // passes it to the flyweight's methods.
    flyWeight.Operation(car);
}