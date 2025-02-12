using Microsoft.EntityFrameworkCore;
using Entity.Models;

namespace Entity.Data;

public class ApplicationDbContext : DbContext
{
    // Konstruktor
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }

    //Tabellerna
    public DbSet<Author> Authors { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<Loan> Loans { get; set; }
}