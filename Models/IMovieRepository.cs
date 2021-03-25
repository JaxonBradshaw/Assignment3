using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment3.Models
{
    //setting up interface  (built to be inheritted)
    public interface IMovieRepository
    {
        IQueryable<Movie> Movies { get; }
    }
}
