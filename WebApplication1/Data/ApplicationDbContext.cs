using Microsoft.EntityFrameworkCore;
using WebApplication1.Data.ContextConfigurations;
using WebApplication1.Model;

namespace WebApplication1.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Seed();
        }
        // Add the DbSets for each of our models we would like at our database
        public DbSet<Superhero> Superheroes { get; set; }
        public DbSet<Superpower> Superpowers { get; set; }
        public DbSet<Movie> Movies { get; set; }
    }
}
