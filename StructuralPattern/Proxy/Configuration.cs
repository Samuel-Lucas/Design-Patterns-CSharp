using Proxy.Interfaces;

namespace Proxy;

public class Configuration : IConfiguration
{
    public string GetConfig(string key)
    {
        Random rnd = new();
        return $"Configuration value of key {key} is {rnd.Next(0,100)}";
    }

    public void Init()
    {
        Console.WriteLine("Initialized");
    }

    public void SetConfig(string key, string value)
    {
        Console.WriteLine($"key {key}:{value} setted succesfully");
    }

    public void Update()
    {
        Console.WriteLine("Configurations updated");
    }
}