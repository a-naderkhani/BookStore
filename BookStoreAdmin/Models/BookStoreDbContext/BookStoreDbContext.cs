using BookStoreAdmin.Models.Entities.Book;
using Microsoft.EntityFrameworkCore;

namespace BookStoreAdmin.Models.BookStoreDbContext;

//public class BookStoreDbContext: DbContext
//{
//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//    {
//        optionsBuilder.UseSqlServer("Server=.;Database=BookStore;Integrated Security=True;MultipleActiveResultSets=True;TrustServerCertificate=True");
//        base.OnConfiguring(optionsBuilder);
//    }
//    public DbSet<Book> Books { get; set; }
//}

public class BookStoreDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=.\\MSSQLSERVER2019;Database=BookStoreDB;User Id=amiradmin;Password=A@mir16065;MultipleActiveResultSets=True;TrustServerCertificate=True");
        base.OnConfiguring(optionsBuilder);
    }
    public DbSet<Book> Books { get; set; }
}
