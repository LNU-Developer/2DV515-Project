namespace Backend.Models.Recommendation
{
    public interface IMovieRecommendation
    {
        int MovieId { get; set; }
        string MovieTitle { get; set; }
        double AverageWeightedRating { get; set; }
    }
}