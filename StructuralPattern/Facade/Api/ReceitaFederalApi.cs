namespace Facade.Api;

public class ReceitaFederalApi
{
    public bool isCpfActive(string cpf)
    {
        return Random.Shared.Next(2) == 1;
    }
}