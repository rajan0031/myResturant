

using GraphQLProject.Models;



namespace GraphQLProject.Interfaces
{
    public interface IReviewRepository
    {

        List<Review> GetAllReview();

        Review GetReviewById(int id);
        Review AddReview(Review review);

    }
}