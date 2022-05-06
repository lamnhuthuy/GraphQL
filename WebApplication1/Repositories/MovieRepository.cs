using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Interfaces;
using WebApplication1.Model;

namespace WebApplication1.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private readonly ApplicationDbContext _appDbContext;
        public MovieRepository(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }


        public async Task<List<Movie>> GetAllMovies()
        {
            var tmp = _appDbContext.Movies.ToList();
            var movies= await  _appDbContext.Movies.Select(x => new Movie()
            {
                Id = x.Id,
                Title = x.Title,
                Description = x.Description,
                Instructor=x.Instructor

            }).ToListAsync();
           
            return movies;
        }
    }
}
