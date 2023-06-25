using Microsoft.EntityFrameworkCore;
using Model;

namespace Metalurg
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users => Set<User>();
        public DbSet<Price> Prices => Set<Price>();
        public DbSet<TypePrice> TypePrices => Set<TypePrice>();
        public DbSet<Product> Products => Set<Product>();   
        public ApplicationContext() => Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Metalurg.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Price>().HasKey(u => new { u.Date, u.PriceTypeId, u.ProductId });

            modelBuilder.Entity<Price>().HasOne(u => u.Product)
                .WithMany(u => u.Prices).HasForeignKey(u=>u.ProductId);
            modelBuilder.Entity<Price>().HasOne(u => u.PriceType)
               .WithMany(u => u.Prices).HasForeignKey(u=>u.PriceTypeId);

            
        }

    }
}
