using WebApplication1.Data;
using WebApplication1.Interfaces;

namespace WebApplication1.Repositories
{
    public class SuperpowerRepository : ISuperpowerRepository
    {
        private readonly ApplicationDbContext _appDbContext;
        public SuperpowerRepository(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
    }
}
