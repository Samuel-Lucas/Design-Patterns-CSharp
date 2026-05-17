using TemplateMethod.Entity;
using TemplateMethod.Sorters;
using TemplateMethod.Template;

Movie movie1 = new(1, "Titanic", 1997, 4.9);
Movie movie2 = new(2, "Click", 2006, 3.7);
Movie movie3 = new(3, "A new hope", 1977, 4.8);
Movie movie4 = new(4, "Living daylights", 1987, 3.5);
Movie movie5 = new(5, "The housemaid", 2026, 1.0);

List<Movie> movieList = new()
{
    movie1,
    movie2,
    movie3,
    movie4,
    movie5
};

SorterTemplate sorterTemplate;

sorterTemplate = new TitleSorter();
var stock = sorterTemplate.OrderMovie(movieList);

foreach (var item in stock)
{
    Console.WriteLine($"{item.Id} - {item.Title} - {item.Year} - {item.Rating}");
}

Console.WriteLine("*****************************************");

sorterTemplate = new RatingSorter();
var stock2 = sorterTemplate.OrderMovie(movieList);

foreach (var item in stock)
{
    Console.WriteLine($"{item.Id} - {item.Title} - {item.Year} - {item.Rating}");
}