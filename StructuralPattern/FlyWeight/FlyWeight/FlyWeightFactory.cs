using FlyWeight.Entities;

namespace FlyWeight.FlyWeight;

public class FlyWeightFactory
{
    private List<Tuple<FlyWeightClass, string>> flyWeights = new List<Tuple<FlyWeightClass, string>>();


    public FlyWeightFactory(params Car[] args)
    {
        foreach (var elem in args)
        {
            this.flyWeights.Add(new Tuple<FlyWeightClass, string>(new FlyWeightClass(elem), this.getKey(elem)));
        }
    }
    // Returns a Flyweight's string hash for a given state.

    public string getKey(Car key)
    {
        List<string> elements = new List<string>();
        elements.Add(key.Model); elements.Add(key.Color);
        elements.Add (key. Company);

        if (key.Owner!= null && key.Number!= null)
        {
            elements. Add (key. Number); elements .Add(key.Owner);
        }

        elements.Sort();

        return string.Join("_", elements);
    }

    // Returns an existing Flyweight with a given state or creates a new one.

    public FlyWeightClass GetFlyweight(Car sharedState)
    {
        string key = this.getKey(sharedState);
        if (flyWeights.Where(t=> t.Item2== key).Count() == 0)
        {
            Console.WriteLine("FlyweightFactory: Can't find a flyweight, creating new one. "); 
            this.flyWeights.Add(new Tuple<FlyWeightClass, string>(new FlyWeightClass(sharedState), key));
        }
        else
        {
            Console.WriteLine("FlyweightFactory: Reusing existing flyweight.");
        }
        
        return flyWeights.FirstOrDefault(t => t.Item2 == key)!.Item1;
    }


    public void ListFlyweights()
    {
        var count = flyWeights.Count;
        Console.WriteLine($"\nFlyweightFactory: I have {count} flyweights:");

        foreach (var flyWeight in flyWeights)
        {
            Console.WriteLine(flyWeight.Item2);
        }
    }
}
