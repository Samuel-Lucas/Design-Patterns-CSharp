namespace FactoryMethod.Product;

public class TelaWeb : Tela
{
    public int Tamanho { get; set; }

    public TelaWeb() : base("Ecrã", "Hello world ! Welcome to your screen") {}
}