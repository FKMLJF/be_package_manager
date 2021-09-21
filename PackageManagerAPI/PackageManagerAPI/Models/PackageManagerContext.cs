using Microsoft.EntityFrameworkCore;
using PackageManagerAPI.Helpers;
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

            // SEED Data from the arukereso.hu page
            List<Product> products = Task.Run(async () => {
                Crawler crawler = new Crawler();
                await crawler.ContentLoad();
                return crawler.Products;
            }).Result;

            products.ForEach(product => 
                modelBuilder
                .Entity<Product>()
                .HasData(
                    new Product { 
                        ProductId = product.ProductId,
                        ProductName = product.ProductName,
                        ProductPrice = product.ProductPrice }));
          
        }
    }
}
