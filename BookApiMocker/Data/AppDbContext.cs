using Microsoft.EntityFrameworkCore;
using BookApiMocker.Models;

namespace BookApiMocker.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
        
    }
    public DbSet<Book> Books => Set<Book>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>().HasData(
            new Book { Id = 1, Title = "Clean Code", Author = "Robert C. Martin", ISBN = "978-0132350884", Price = 8990, PublishedYear = 2008, CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc) },
            new Book { Id = 2, Title = "The Pragmatic Programmer", Author = "David Thomas", ISBN = "978-0135957059", Price = 9990, PublishedYear = 2019, CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc) },
            new Book { Id = 3, Title = "Design Patterns", Author = "Gang of Four", ISBN = "978-0201633610", Price = 12990, PublishedYear = 1994, CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc) }
        );  
    }
}