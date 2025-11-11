

using GraphQL;
using GraphQL.Types;
using GraphQLProject.Interfaces;
using GraphQLProject.Models;
using GraphQLProject.Type;


namespace GraphQLProject.Query
{


    public class ReviewQuery : ObjectGraphType
    {

        public ReviewQuery(IReviewRepository reviewRepository)
        {
            Field<ListGraphType<ReviewType>>("getallllreviews").Resolve(context =>
            {
                return reviewRepository.GetAllReview();
            });

            Field<ReviewType>("getreviewbyid").Arguments(new QueryArguments(new QueryArgument<IntGraphType> { Name = "id" })).Resolve(context =>
            {
                var id = context.GetArgument<int>("id");
                return reviewRepository.GetReviewById(id);
            });

            // here i am writting the query to get all the reviews for the particular menuId 

            Field<ListGraphType<ReviewType>>("getallreviewbymenuid").Arguments(new QueryArguments(new QueryArgument<IntGraphType> { Name = "menuId" })).Resolve(context =>
            {
                var menuId = context.GetArgument<int>("menuId");
                return reviewRepository.GetAllReviewByMenuId(menuId);
            });
        }

    }

}