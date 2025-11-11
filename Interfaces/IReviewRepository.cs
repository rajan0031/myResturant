

using GraphQLProject.Models;



namespace GraphQLProject.Interfaces
{
    public interface IReviewRepository
    {

        List<Review> GetAllReview();

        Review GetReviewById(int id);

        List<Review> GetAllReviewByMenuId(int menuId);
        Review AddReview(Review review);

        // declaring a function  which will take care of my update review 

        Review UpdateReview(Review review, int id);

    }
}