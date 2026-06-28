using Observer.Observer;
using Observer.Subject;

ConcreteSubject subject = new ConcreteSubject();
ConcreteObserver observer1 = new ConcreteObserver("Observer 1");
ConcreteObserver observer2 = new ConcreteObserver("Observer 2");
ConcreteObserver observer3 = new ConcreteObserver("Observer 3");

subject.RegisterObserver(observer1);
subject.RegisterObserver(observer2);
subject.RegisterObserver(observer3);

subject.NotifyObservers(42);

subject.RemoveObserver(observer3);

subject.NotifyObservers(84);

Console.ReadLine();