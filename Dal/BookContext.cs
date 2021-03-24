using FilmeLivroEntityFramework.Models;
using System.Data.Entity;

namespace FilmeLivroEntityFramework.Dal
{
    public class BookContext : DbContext
    {
        public BookContext() : base("ConexaoSQLServer") { }

        public DbSet<Book> Books { get; set; }
    }
}