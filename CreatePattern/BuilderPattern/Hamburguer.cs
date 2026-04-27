namespace BuilderPattern;

public class Hamburguer
{
    public string? BreadType { get; set; }
    public string? MeatType { get; set; }
    public bool HasBacon { get; set; }
    public bool HasChips { get; set; }
    public bool HasSalad { get; set; }

    public string getDescription()
    {
        return $"Hamburguer with {BreadType} bread and {MeatType} meat. Bacon: {HasBacon}, Chips: {HasChips}, Salad: {HasSalad}";
    }
}