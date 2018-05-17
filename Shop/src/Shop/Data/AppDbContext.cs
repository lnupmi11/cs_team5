using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Shop.Data.Models;

namespace Shop.Data
{
    public class AppDbContext : IdentityDbContext<IdentityUser> 
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<AstronomicalObject> AstronomicalObjects { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        
        public DbSet<Order> Orders { get; set; }
        
        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}
