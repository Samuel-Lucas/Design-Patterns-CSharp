using BuilderPattern.Builder;

HamburguerBuilder hamburguerBuilder = new();

// x-salad
var xSalad = hamburguerBuilder
    .SetBreadType("white")
    .SetMeatType("red")
    .HasSalad()
    .Build();

// x-bacon
hamburguerBuilder = new();
var xBacon = hamburguerBuilder
    .SetBreadType("black")
    .SetMeatType("red")
    .HasBacon()
    .Build();

// x-all
hamburguerBuilder = new();
var xAll = hamburguerBuilder
    .SetBreadType("white")
    .SetMeatType("red")
    .HasBacon()
    .HasChips()
    .HasSalad()
    .Build();

Console.WriteLine(xSalad.getDescription());
Console.WriteLine("**********************");
Console.WriteLine(xBacon.getDescription());
Console.WriteLine("**********************");
Console.WriteLine(xAll.getDescription());