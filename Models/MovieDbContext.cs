using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment3.Models
{
    //setting up context class to connect project to database   (hover over DbContext and it explains what it's doing)
    public class MovieDbContext : DbContext
    {
        //making constructor
        //finding out what options they've selected, inheriting from base options
        public MovieDbContext (DbContextOptions<MovieDbContext> options) : base(options)
        {

        }

        //building a movie DbSet
        public DbSet<Movie> Movies { get; set; }
    }
}
