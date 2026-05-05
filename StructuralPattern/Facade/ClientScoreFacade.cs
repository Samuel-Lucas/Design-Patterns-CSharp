using Facade.Api;

namespace Facade;

public class ClientScoreFacade
{
    DetranApi detran = new();
    SerasaApi serasa = new();
    ReceitaFederalApi receita = new();

    public decimal Score(string cpf, string cnh)
    {
        bool cnhValida = detran.ValidCNH(cnh);
        decimal scoreSerasa = serasa.Score(cpf);
        bool activecPF = receita.isCpfActive(cpf);

        decimal scoreSerasa20p100 = scoreSerasa * 0.2m;
        decimal scoreSerasa30p100 = scoreSerasa * 0.3m;
        decimal score = scoreSerasa;

        if (!cnhValida)
            score -= scoreSerasa20p100;

        if (!activecPF)
            score -= scoreSerasa30p100;
        
        return score;
    }
}