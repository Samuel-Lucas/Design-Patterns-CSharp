using AbstractFactory.Product.Interfaces;

namespace AbstractFactory.Product;

public class WindowsCheckBox : ICheckBox
{
    public void Paint()
    {
        Console.WriteLine("Drawing checkcbox for windows");
    }
}