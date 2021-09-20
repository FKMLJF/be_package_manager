using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PackageManagerAPI.Models
{
    public class PackageManagerContext : DbContext
    {
        DbSet<User> Users { get;  set; }
        DbSet<Product> Products { get;  set; }
        DbSet<Order> Orders { get;  set; }

        public PackageManagerContext(DbContextOptions<PackageManagerContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
            .HasMany(p => p.Orders)
            .WithMany(p => p.Products)
            .UsingEntity(j => j.ToTable("ProductOrders"));

            modelBuilder.Entity<Order>()
              .HasOne(p => p.User)
              .WithMany(b => b.Orders);

            //modelBuilder.Entity<Product>().HasData(new Product { ProductId = 1,ProductName = "23423", ProductPrice = 1000, ProductQuantity = 1, ProductQuantityUnit = "Db" });
        }
    }
}
