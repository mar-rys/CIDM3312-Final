using ColorGoGo.Models;
using Microsoft.EntityFrameworkCore;

namespace ColorGoGo.Models;
public class ColorGoGoContext : DbContext
{
public ColorGoGoContext(DbContextOptions<ColorGoGoContext> options)
: base(options)
{
}

    public DbSet<Artist> Artists { get; set; }
    public DbSet<ColoringBook> ColoringBooks { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Order> Orders { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Order>()
            .HasOne(o => o.Customer)
            .WithMany(c => c.Orders)
            .HasForeignKey(o => o.CustomerID)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Order>()
            .HasOne(o => o.ColoringBook)
            .WithMany(cb => cb.Orders)
            .HasForeignKey(o => o.ColoringBookID)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Artist>().HasData(SeedData.Artists);
        modelBuilder.Entity<ColoringBook>().HasData(SeedData.ColoringBooks);
        modelBuilder.Entity<Customer>().HasData(SeedData.Customers);
        modelBuilder.Entity<Order>().HasData(SeedData.Orders);
    }
}