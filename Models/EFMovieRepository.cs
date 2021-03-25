using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment3.Models
{
    //inheritting from the IMovieRepository interface that I made
    public class EFMovieRepository : IMovieRepository
    {
        private MovieDbContext _context;

        //Constructor
        public EFMovieRepository (MovieDbContext context)
        {
            _context = context;
        }

        //movies will always be set to whatever is in  _context.Movies
        public IQueryable<Movie> Movies => _context.Movies;

        


    }
}
