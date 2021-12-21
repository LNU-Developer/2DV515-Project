namespace Backend.Models.Recommendation
{
    public class Similarity : ISimilarity
    {
        public int SelectedId { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public double SimilarityScore { get; set; }

    }
}