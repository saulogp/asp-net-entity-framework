using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FilmeLivroEntityFramework.Models
{
    public class Movie : MovieBook
    {
        public string Director { get; set; }
    }
}