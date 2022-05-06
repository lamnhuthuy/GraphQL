using GraphQL.Types;
using WebApplication1.Interfaces;
using WebApplication1.Model;

namespace WebApplication1.Data
{
    public class MovieType: ObjectGraphType<Movie>
    {
        public MovieType()
        {
            Field(d=>d.Id).Description("Movie Id");
        }
    }
}
