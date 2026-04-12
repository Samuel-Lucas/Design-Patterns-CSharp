using FactoryMethod.Product;

namespace FactoryMethod.Creator;

public class ConcreteTelaSmartPhoneCreator :  TelaCreator
{
    public override Tela CriaTela()
    {
        return new TelaSmartPhone();
    }
}