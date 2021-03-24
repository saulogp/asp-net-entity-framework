using FilmeLivroEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FilmeLivroEntityFramework.Dal
{
    public class MovieContext : DbContext
    {
        public MovieContext() : base("ConexaoSQLServer") { }

        public DbSet<Movie> Movies { get; set; }
    }
}