using AbstractFactory.Product.Interfaces;

namespace AbstractFactory.Product;

public class MacCheckBox : ICheckBox
{
    public void Paint()
    {
        Console.WriteLine("Drawing checkbox in mac OS");
    }
}