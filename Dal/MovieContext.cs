using FilmeLivroEntityFramework.Models;
using System.Data.Entity;

namespace FilmeLivroEntityFramework.Dal
{
    public class MovieContext : DbContext
    {
        public MovieContext() : base("ConexaoSQLServer") { }

        public DbSet<Movie> Movies { get; set; }
    }
}