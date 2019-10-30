using MovieDBApp.Models;
using MovieDBApp.NovaPasta2;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MovieDBApp.NovaPasta1
{
    interface IMovieDBService
    {
        
        Task<SearchResponse<Movie>> GetUpcomingMoviesAsync(int pageNumber = 1, string language = "en");
        Task<Movie> FindByIdAsync(int movieId, string language = "en");
    }
}

