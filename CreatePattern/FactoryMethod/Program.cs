using FactoryMethod.Creator;
using FactoryMethod.Product;

Tela tela1 = new ConcreteTelaWebCreator().CriaTela();
Tela tela2 = new ConcreteTelaSmartPhoneCreator().CriaTela();

Console.WriteLine($"TELA WEB => {tela1.GetMessage()}");
Console.WriteLine($"TELA SmartPhone => {tela2.GetMessage()}");