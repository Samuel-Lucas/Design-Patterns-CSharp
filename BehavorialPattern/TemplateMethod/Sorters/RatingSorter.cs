using TemplateMethod.Entity;
using TemplateMethod.Template;

namespace TemplateMethod.Sorters;

public class RatingSorter : SorterTemplate
{
    public override bool IsFirst(Movie movie1, Movie movie2)
    {
        if (movie2.Rating < movie1.Rating)
            return true;
        
        return false;
    }
}