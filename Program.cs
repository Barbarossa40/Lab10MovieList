using System;
using System.Collections.Generic;
using System.Linq;

namespace MovieListLab
{
    class Program
    {
        static void Main(string[] args)
        {


            List<Movie> MovieList = new List<Movie>();

            MovieList.Add(new Movie("Jaws:            ", MovieGenre.Horror, "  'You'll never go in the water again'           ", 1975));
            MovieList.Add(new Movie("Alien:                                ", MovieGenre.SciFi, "  'In space, no one can hear you scream'           ", 1979));
            MovieList.Add(new Movie("The Thing:       ", MovieGenre.Horror, "  'Man is the warmest place to hide'             ", 1982));
            MovieList.Add(new Movie("Platoon:                   ", MovieGenre.Drama, "  'The first casualty of war is innocence'             ", 1986));
            MovieList.Add(new Movie("Chicken Run:       ", MovieGenre.Animated, "  'Escape or die frying'   ", 2000));
            MovieList.Add(new Movie("The Shawshank Redemption:  ", MovieGenre.Drama, "  'Fear can hold you prisoner. Hope can set you free'  ", 1994));
            MovieList.Add(new Movie("Jurassic Park:   ", MovieGenre.Horror, "  'An Adventure 65 Million Years in the Making'  ", 1993));
            MovieList.Add(new Movie("Star Wars episode IV: A New Hope:     ", MovieGenre.SciFi, "  'A long time ago in a galaxy far, far away....'  ", 1977));
            MovieList.Add(new Movie("The Jungle Book:   ", MovieGenre.Animated, "  'The jungle is JUMPIN'   ", 1967));
            MovieList.Add(new Movie("Close Encounters of the Third Kind:   ", MovieGenre.SciFi, "  'We are not alone'                               ", 1977));

            bool goAgain = true;

            Console.WriteLine("Howdy! Please select the genre of movie you'd like to see:");
            Console.WriteLine();
            Console.WriteLine("Press 1 to view our stable of Animated Film");
            Console.WriteLine("Press 2 to view our selection of Dramas");
            Console.WriteLine("Press 3 if you're looking for a scare from our Horror section");
            Console.WriteLine("Press 4 if you're more of a SciFi kinda guy or gal");

            string userSelection = Console.ReadLine();
            Console.WriteLine();

            while(InputIsValidNumber(userSelection) == false)
            {
                Console.WriteLine("Invalid input please try again");
                userSelection = Console.ReadLine();
                Console.WriteLine();
            }

            do
            {
                while (InputIsValidNumber(userSelection) == false)
                {
                    Console.WriteLine("Invalid input please try again");
                    userSelection = Console.ReadLine();
                    Console.WriteLine();
                }
                MovieGenre userInput = (MovieGenre)Enum.Parse(typeof(MovieGenre), userSelection);

                List<Movie> movieByCategory = MovieList.Where(x => x.Category == userInput).OrderBy(x => x.Title).ToList();

                foreach (Movie movie in movieByCategory)
                {
                    Console.WriteLine(movie.Title + movie.Category + movie.Tagline + movie.YearReleased);
                }
                Console.WriteLine();
                Console.WriteLine("Do you wish to look at a different genre? If so press the correspondiong number: 1 Animated, 2 Drama, 3 Horror, 4 SciFi");
                Console.WriteLine();
                Console.WriteLine("If you wish to exit the program please presss the number 5 and hit enter now");
                Console.WriteLine();

                userSelection = Console.ReadLine();

                if (int.TryParse(userSelection, out int userinput) == true && userinput == 5)
                {
                    goAgain = false;
                }
                else goAgain = true;


            } while (goAgain == true);

            Console.WriteLine("Arrivederci, Auf Wiedersehen, Goobye!!!");

        }

        public static bool InputIsValidNumber(string userSelection)
        {  
            try
            {
                int genreSelection = int.Parse(userSelection);
                if (genreSelection >= 1 && genreSelection <= 4)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (FormatException ez)
            {
                return false;
            }
        }

    }

}

