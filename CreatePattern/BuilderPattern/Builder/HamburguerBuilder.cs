namespace BuilderPattern.Builder;

public class HamburguerBuilder
{
    private readonly Hamburguer _hamburguer;

    public HamburguerBuilder()
    {
        _hamburguer = new Hamburguer();
    }

    public HamburguerBuilder SetBreadType(string bread)
    {
        _hamburguer.BreadType = bread;
        return this;
    }

    public HamburguerBuilder SetMeatType(string meat)
    {
        _hamburguer.MeatType = meat;
        return this;
    }

    public HamburguerBuilder HasBacon()
    {
        _hamburguer.HasBacon = true;
        return this;
    }

    public HamburguerBuilder HasChips()
    {
        _hamburguer.HasChips = true;
        return this;
    }

    public HamburguerBuilder HasSalad()
    {
        _hamburguer.HasSalad = true;
        return this;
    }

    public Hamburguer Build() => _hamburguer;
}