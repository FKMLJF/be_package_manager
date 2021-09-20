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
                .HasOne(p => p.Order)
                .WithMany(b => b.Products);

            modelBuilder.Entity<Order>()
              .HasOne(p => p.User)
              .WithMany(b => b.Orders);
        }
    }
}
