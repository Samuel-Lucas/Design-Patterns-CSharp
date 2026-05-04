namespace Facade.Api;

public class ReceitaFederalApi
{
    public bool isCpfActive(string cpf)
    {
        Random random = new Random();
        return Boolean.Parse(random.Next(0, 1).ToString());
    }
}