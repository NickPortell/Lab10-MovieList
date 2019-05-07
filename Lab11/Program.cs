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
            
            Movie movie1 = new Movie("Avengers Endgame", "Scifi");
            movies.Add(movie1);
            Movie movie2 = new Movie("Glass", "Scifi");
            movies.Add(movie2);
            Movie movie3 = new Movie("Miss Bala", "Drama");
            movies.Add(movie3);
            Movie movie4 = new Movie("The Lego Movie 2: The Second Part", "Animated");
            movies.Add(movie4);
            Movie movie5 = new Movie("Alita: Battle Angel", "Scifi");
            movies.Add(movie5);
            Movie movie6 = new Movie("Fighting with My Family", "Drama");
            movies.Add(movie6);
            Movie movie7 = new Movie("Happy Death day 2U", "Horror");
            movies.Add(movie7);
            Movie movie8 = new Movie("How to Train Your Dragon: The Hidden World", "Animated");
            movies.Add(movie8);
            Movie movie9 = new Movie("Us", "Horror");
            movies.Add(movie9);
            Movie movie10 = new Movie("Pet Sematary", "Horror");
            movies.Add(movie10);
            

            Console.WriteLine("Welcome to the Movie List Application!\n");
            Console.WriteLine($"There are {movies.Count} movies in this list.");


            Console.WriteLine("What category/ genre are you interested in?");

            Movie.ListMovies(movies);


            



        }
    }
}
