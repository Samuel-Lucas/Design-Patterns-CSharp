namespace FactoryMethod.Product;

public abstract class Tela
{
    private readonly string Nome;
    protected string Message { get; }

    public Tela(string nome, string msg)
    {
        Nome = nome;
        Message = msg;
    }

    public string GetMessage()
        => Message;
}