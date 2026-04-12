using AbstractFactory.Factory.interfaces;
using AbstractFactory.Product;
using AbstractFactory.Product.Interfaces;

namespace AbstractFactory.Factory;

public class WindowsFactory : IGUIFactory
{
    public IButton createbutton()
    {
        return new WindowsButton();
    }

    public ICheckBox createCheckBox()
    {
        return new WindowsCheckBox();
    }
}