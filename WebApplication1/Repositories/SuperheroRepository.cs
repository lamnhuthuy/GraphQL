using WebApplication1.Data;
using WebApplication1.Interfaces;

namespace WebApplication1.Repositories
{
    public class SuperheroRepository: ISuperheroRepository
    {
        private readonly ApplicationDbContext _appDbContext;
        public SuperheroRepository(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
    }
}
