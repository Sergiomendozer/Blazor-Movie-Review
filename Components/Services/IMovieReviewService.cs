using MovieReview.Model;

namespace MovieReview.Services
{
    public interface IMovieReviewService
    {
        List<MovieModel>? GetMovies();
        MovieModel? GetMovieById(int id);
    }
}