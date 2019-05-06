using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Movie> movies = new List<Movie>();
            movies.Sort();
            //movies.Add(Avengers_Endgame);
            //Avengers_Endgame.title = "Avengers Endgame";
            //Avengers_Endgame.category = "Scifi";


            Console.WriteLine("Welcome to the Movie List Application!\n");

            Console.WriteLine($"There are {movies.Count} movies in this list.");


            Console.WriteLine("What category/ genre are you interested in?");

            Movie.ListMovies(movies);


            



        }
    }
}
