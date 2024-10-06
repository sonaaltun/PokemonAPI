using PokemonAPI.Entities;

namespace PokemonAPI.Interfaces
{
    public interface IReviewerRepository
    {
        ICollection<Reviewer> GetReviewers();
        Reviewer GetReviewer(Guid reviewerId);
        ICollection<Review> GetReviewsByReviewer(Guid reviewerId);
        bool ReviewerExists(Guid reviewerId);
        bool CreateReviewer(Reviewer reviewer);
        bool UpdateReviewer(Reviewer reviewer);
        bool DeleteReviewer(Reviewer reviewer);
        bool Save();
    }
}
