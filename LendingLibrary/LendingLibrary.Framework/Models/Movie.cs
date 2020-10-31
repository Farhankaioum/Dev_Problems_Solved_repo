using System;
using System.Collections.Generic;
using System.Text;

namespace LendingLibrary.Framework.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Language { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int AvailableItem { get; set; }
        public int PendingPerson { get; set; }

        public List<Movie> Movies { get; set; }

        public Movie()
        {
            Movies = new List<Movie>
            {
                new Movie{ Id = 1, Name = "3 Idios", Language="Hindi", ReleaseDate = DateTime.Now, AvailableItem = 2 , PendingPerson=0 },
                new Movie{ Id = 2, Name = "The boy in the striped pajamas", Language="English", ReleaseDate = DateTime.Now , AvailableItem = 2, PendingPerson=0 },
                new Movie{ Id = 3, Name = "Taqdeer", Language="Tamil", ReleaseDate = DateTime.Now , AvailableItem = 2, PendingPerson=0 },
                new Movie{ Id = 4, Name = "Green mile", Language="English", ReleaseDate = DateTime.Now , AvailableItem = 2, PendingPerson=0 },
                new Movie{ Id = 5, Name = "Purani Jeans", Language="Hindi", ReleaseDate = DateTime.Now , AvailableItem = 2, PendingPerson=0 },
            };
        }

        public void AddMovie(Movie movie)
        {
            var id = Movies.Count + 1;
            movie.Id = id;

            Movies.Add(movie);
        }

    }
}
