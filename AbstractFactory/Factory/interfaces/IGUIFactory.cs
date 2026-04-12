using AbstractFactory.Product.Interfaces;

namespace AbstractFactory.Factory.interfaces;

public interface IGUIFactory
{
    IButton createbutton();
    ICheckBox createCheckBox();
}