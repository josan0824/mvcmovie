using System;
using System.Data.Entity;

namespace mvcmovie.Models
{
    public class Movie
    {
        public int ID { get; set; }

        public string Title { get; set; }

        public DateTime ReleaseDate { set; get; }

        public string Genre { set; get; }

        public decimal Price { set; get; }
    }


    public class MovieDBContext : DbContext
    {
        public DbSet<Movie> Moives { get; set; }
    }
}