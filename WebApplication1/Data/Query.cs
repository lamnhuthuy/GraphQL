using WebApplication1.Interfaces;
using WebApplication1.Model;

namespace WebApplication1.Data
{
    public class Query
    {
        private readonly IMovieRepository _movieRepository;
        public Query(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public async Task<List<Movie>> GetMovies()
        {
            var res= await _movieRepository.GetAllMovies();
            return res;

        }        
    }

    
}
