using TemplateMethod.Entity;

namespace TemplateMethod.Template;

public abstract class SorterTemplate
{
    public abstract bool IsFirst(Movie movie1, Movie movie2);

    public List<Movie> OrderMovie(List<Movie> movieList)
    {
        for (int i = 0; i < movieList.Count; i++)
        {
            for (int j = i + 1; i < movieList.Count; j++)
            {
                if (!IsFirst(movieList[i], movieList[j]))
                {
                    Movie temp = movieList[j];
                    movieList[j] = movieList[i];
                    movieList[i] = temp;
                }
            }
        }

        return movieList;
    }
}