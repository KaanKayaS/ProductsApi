using System.Reflection.Emit;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ProductsAPI.Models
{
    public class ProductsContext : IdentityDbContext< AppUser,AppRole, int>
    {

        public ProductsContext(DbContextOptions<ProductsContext> options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(new Product() { ProductId = 1, ProductName = "IPhone13", Price = 60000, IsActive = true });
            modelBuilder.Entity<Product>().HasData(new Product() { ProductId = 2, ProductName = "IPhone14", Price = 70000, IsActive = true });
            modelBuilder.Entity<Product>().HasData(new Product() { ProductId = 3, ProductName = "IPhone15", Price = 80000, IsActive = true });
            modelBuilder.Entity<Product>().HasData(new Product() { ProductId = 4, ProductName = "IPhone16", Price = 90000, IsActive = true });
            modelBuilder.Entity<Product>().HasData(new Product() { ProductId = 5, ProductName = "IPhone17", Price = 100000, IsActive = true });


            modelBuilder.Entity<Product>()
              .Property(p => p.Price)
              .HasColumnType("decimal(18,2)");

            base.OnModelCreating(modelBuilder);
        }
    }
}