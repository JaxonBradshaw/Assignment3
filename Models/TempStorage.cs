using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment3.Models
{
    public class TempStorage
    {
        //creating new list
        private static List<MovieEntry> movies = new List<MovieEntry>();

        //passing info to movies
        public static IEnumerable<MovieEntry> Movies => movies;
        //adding whatever movie was passed
        public static void AddMovie(MovieEntry movie)
        {
            movies.Add(movie);
        }
    }
}
