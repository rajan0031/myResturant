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


        // here i am createing a services for the getting all the reviews for the particular menuid

        public List<Review> GetAllReviewByMenuId(int menuId)
        {

            var review = dbContext.Reviews.Where(r => r.MenuId == menuId).ToList();
            if (review == null)
            {
                return null;
            }
            return review;

        }

        // this is the function which will update the review by usig the id unique identifer 

        public Review UpdateReview(Review review, int id)
        {

            var reviewResult = dbContext.Reviews.Find(id);

            if (reviewResult == null)
            {
                return null;
            }
            reviewResult.MenuId = review.MenuId;
            reviewResult.Description = review.Description;
            reviewResult.Ratting = review.Ratting;
            dbContext.SaveChanges();
            return reviewResult;
        }
    }


}