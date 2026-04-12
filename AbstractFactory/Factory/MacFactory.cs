using AbstractFactory.Factory.interfaces;
using AbstractFactory.Product;
using AbstractFactory.Product.Interfaces;

namespace AbstractFactory.Factory;

public class MacFactory : IGUIFactory
{
    public IButton createbutton()
    {
        return new MacButton();
    }

    public ICheckBox createCheckBox()
    {
        return new MacCheckBox();
    }
}