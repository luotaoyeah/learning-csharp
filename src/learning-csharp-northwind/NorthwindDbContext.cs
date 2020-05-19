using System;
using System.IO;
using Microsoft.EntityFrameworkCore;

namespace LuotaoYeah.Northwind
{
    public class NorthwindDbContext : DbContext
    {
        public NorthwindDbContext()
        {
        }

        public NorthwindDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Category>? Categories { get; set; }
        public DbSet<Product>? Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "sqlite/northwind.db");
            Console.WriteLine($"path:{path}");
            optionsBuilder.UseSqlite($"Filename={path}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .Property(catetory => catetory.CategoryName)
                .IsRequired()
                .HasMaxLength(15);

            modelBuilder.Entity<Product>()
                .Property(product => product.Cost)
                .HasConversion<double>();
        }
    }
}
