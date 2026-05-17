namespace TemplateMethod.Entity;

public class Movie
{
    public int Id { get; set; }
    public string Title { get; set; }
    public int Year { get; set; }
    public double Rating { get; set; }

    public Movie(int id, string title, int year, double rating)
    {
        Id = id;
        Title = title;
        Year = year;
        Rating = rating;
    }
}