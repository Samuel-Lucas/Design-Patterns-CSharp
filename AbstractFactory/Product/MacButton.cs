using AbstractFactory.Product.Interfaces;

namespace AbstractFactory.Product;

public class MacButton : IButton
{
    public void Paint()
    {
        Console.WriteLine("Drawing Button in mac OS");
    }
}