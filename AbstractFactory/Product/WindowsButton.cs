using AbstractFactory.Product.Interfaces;

namespace AbstractFactory.Product;

public class WindowsButton : IButton
{
    public void Paint()
    {
        Console.WriteLine("Drawing Button in windows");
    }
}