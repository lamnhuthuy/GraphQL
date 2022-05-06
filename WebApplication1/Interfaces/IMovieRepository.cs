using WebApplication1.Model;

namespace WebApplication1.Interfaces
{
    public interface IMovieRepository
    {
       Task<List<Movie>> GetAllMovies();
    }
}
