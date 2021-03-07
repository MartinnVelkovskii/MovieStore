using MovieStore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStore.Services.interfaces
{
    public interface IMovieService
    {
        void Add(Movie movie);
        void Edit(Movie movie);
        void Delete(int movieId);

        Movie GetMovieById(int id);
        IEnumerable<Movie> GetAllMovies();
    }
}
