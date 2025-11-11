using GraphQLProject.Data;
using GraphQLProject.Interfaces;
using GraphQLProject.Models;



namespace GraphQLProject.Services
{



    public class ReviewRepository : IReviewRepository
    {


        private GraphQLDbContext dbContext;


        public ReviewRepository(GraphQLDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Review AddReview(Review review)
        {
            dbContext.Reviews.Add(review);
            dbContext.SaveChanges();
            return review;
        }

        public List<Review> GetAllReview()
        {
            var reviews = dbContext.Reviews.ToList();
            return reviews;
        }

        public Review GetReviewById(int id)
        {
            var review = dbContext.Reviews.Find(id);
            if (review == null)
            {
                return null;
            }
            return review;
        }
    }


}