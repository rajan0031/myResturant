
using GraphQL;
using GraphQL.Types;
using GraphQLProject.Interfaces;
using GraphQLProject.Models;
using GraphQLProject.Type;

namespace GraphQLProject.Mutation
{


    public class ReviewMutation : ObjectGraphType
    {

        public ReviewMutation(IReviewRepository reviewRepository)
        {

            Field<ReviewType>("addreview").Arguments(new QueryArguments(new QueryArgument<ReviewInputType> { Name = "review" })).Resolve(context =>
            {

                var review = context.GetArgument<Review>("review");
                return reviewRepository.AddReview(review);


            });


            // adding a update mutation here , this api will works as updating the detail sof the review by its review id 

            Field<ReviewType>("updatereview").Arguments(new QueryArguments(new QueryArgument<ReviewInputType> { Name = "review" }, new QueryArgument<IntGraphType> { Name = "id" })).Resolve(context =>
            {
                var id = context.GetArgument<int>("id");
                var review = context.GetArgument<Review>("review");

                return reviewRepository.UpdateReview(review, id);
            });

        }


    }



}