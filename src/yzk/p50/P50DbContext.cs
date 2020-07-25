using Microsoft.EntityFrameworkCore;

namespace P50;

public class P50DbContext : DbContext
{
    public DbSet<Book> Books { get; set; }
    public DbSet<Person> Persons { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);

        optionsBuilder.UseSqlServer("Server=127.0.0.1,6433;Database=Test;User Id=sa;Password=Pass@w0rd");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfiguration(new BookEntityTypeConfiguration());
    }
}
