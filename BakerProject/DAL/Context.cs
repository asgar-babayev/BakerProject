using BakerProject.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BakerProject.DAL
{
    public class Context:IdentityDbContext<AppUser>
    {
        public Context(DbContextOptions<Context> options):base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShopBag> ShopBags { get; set; }
        public DbSet<HomeProduct> HomeProducts { get; set; }
    }
}
