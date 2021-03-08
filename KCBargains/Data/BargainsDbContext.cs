using KCBargains.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

    namespace KCBargains.Data
    {
        public class BargainsDbContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Retailer> Retailers { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }

        public BargainsDbContext(DbContextOptions<BargainsDbContext> options)
                  : base(options)
            {
            }    
    }
  }