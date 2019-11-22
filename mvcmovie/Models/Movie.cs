using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace mvcmovie.Models
{
    public class Movie
    {
        public int ID { get; set; }

        public string Title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:yyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { set; get; }

        public string Genre { set; get; }

        public decimal Price { set; get; }
    }


    public class MovieDBContext : DbContext
    {
        public DbSet<Movie> Moives { get; set; }
    }
}