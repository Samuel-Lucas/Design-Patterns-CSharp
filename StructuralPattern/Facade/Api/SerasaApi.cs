namespace Facade.Api;

public class SerasaApi
{
    public int Score(string cpf)
    {
        Random random = new Random();
        return random.Next(0, 1000);
    }
}