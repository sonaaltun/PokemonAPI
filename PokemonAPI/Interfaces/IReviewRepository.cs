using PokemonAPI.Entities;

namespace PokemonAPI.Interfaces
{
    public interface IReviewRepository
    {
        ICollection<Review> GetReviews();
        Review GetReview(Guid reviewId);
        ICollection<Review> GetReviewsOfAPokemon(Guid pokeId);
        bool ReviewExists(Guid reviewId);
        bool CreateReview(Review review);
        bool UpdateReview(Review review);
        bool DeleteReview(Review review);
        bool DeleteReviews(List<Review> reviews);
        bool Save();
    }
}
