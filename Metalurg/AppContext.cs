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
        public DbSet<Production> Productions => Set<Production>();
        public DbSet<Product_Production> Product_Productions => Set<Product_Production>();
        public DbSet<Recept> Recepts => Set<Recept>();
        public DbSet<Recept_Product> recept_Products => Set<Recept_Product>();
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

            modelBuilder.Entity<Product_Production>().HasKey(u => new { u.ProductId, u.ProductionId });
            modelBuilder.Entity<Product_Production>().HasOne(u => u.Production)
                .WithMany(u => u.Product).HasForeignKey(u => u.ProductionId);
            modelBuilder.Entity<Product_Production>()
                .HasOne(u => u.Product).WithMany(u => u.Productions).HasForeignKey(u => u.ProductId);

            modelBuilder.Entity<Recept_Product>().HasKey(u => new { u.ProductId, u.ReceptId });
            modelBuilder.Entity<Recept_Product>().HasOne(u => u.Product)
                .WithMany(u => u.Recept_s).HasForeignKey(u => u.ProductId);
            modelBuilder.Entity<Recept_Product>().HasOne(u => u.Recept)
                .WithMany(u => u.Products).HasForeignKey(u => u.ReceptId);
        }

    }
}
