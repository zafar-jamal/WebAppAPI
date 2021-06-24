using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppAPI.DomainLayer
{
    public class DomainFacade
    {
        public IEnumerable<Movie> GetAllmovies()
        {
            return GetInMemoryMovies();
        }

        public IEnumerable<Movie> GetMovieByGenre(Genre genre)
        {
            return GetInMemoryMovies().Where(m => m.Genre == genre);
        }

        private static IEnumerable<Movie> GetInMemoryMovies()
        {
            yield return new Movie("Star Wars Episode I: A new Hope", Genre.SciFi, 1977, "StarswarsEpisodeI.jpg");
            yield return new Movie("Star Wars Episode II: ReturnBack", Genre.SciFi, 1977, "StarswarsEpisodeI.jpg");
            yield return new Movie("Star Wars Episode III: The Phantom Menace", Genre.SciFi, 1977, "StarswarsEpisodeI.jpg");
            yield return new Movie("Star Wars Episode IV: Attack of the clones", Genre.SciFi, 1977, "StarswarsEpisodeI.jpg");
            yield return new Movie("Star Wars Episode V: Revenge of the Sith", Genre.SciFi, 1977, "StarswarsEpisodeI.jpg");
            yield return new Movie("Life of pi", Genre.Thriller, 2013, "LifeOfPi.jpg");
            yield return new Movie("The Call", Genre.Thriller, 2012, "StarswarsEpisodeI.jpg");
        }
    }
}
