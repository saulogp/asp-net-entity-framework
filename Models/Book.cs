using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FilmeLivroEntityFramework.Models
{
    public class Book : MovieBook
    {
        public string Autor { get; set; }
    }
}