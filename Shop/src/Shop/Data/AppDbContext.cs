using Microsoft.EntityFrameworkCore;
using Shop.Data.Models;

namespace Shop.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<AstronomicalObject> AstronomicalObjects { get; set; }

        public DbSet<Category> Categories { get; set; }
    }
}
