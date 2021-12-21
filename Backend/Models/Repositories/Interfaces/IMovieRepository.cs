using Backend.Models.Database;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace Backend.Models.Repositories
{
    public interface IMovieRepository : IRepository<Movie>
    {
        Task<Movie> GetMovieById(int movieId);
        Task<List<Movie>> GetAllMovies(int numberOfRatings);
        Task<List<Movie>> GetAllSeenMoviesByUserId(int userId);
        Task<List<Movie>> GetAllMoviesDataExceptSelected(Movie selectedMovie);

    }

}
