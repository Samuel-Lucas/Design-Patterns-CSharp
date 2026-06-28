using Observer.Interfaces;

namespace Observer.Observer;

public class ConcreteObserver : IObserver
{
    private string _observerName;

    public ConcreteObserver(string observerName)
    {
        _observerName = observerName;
    }

    public void Update(int value)
    {
        Console.WriteLine($"Observer {_observerName} received update: {value}");
    }
}