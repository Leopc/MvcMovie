using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcMovie.Models
{
    public class MovieModel
    {
        public int ID { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; }

        [Required]
        public string Genre { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:F1}")]
        public float Rating { get; set; }
    }

    public class MovieDbContext : DbContext
    {
        public DbSet<MovieModel> Movies { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }
    }
}