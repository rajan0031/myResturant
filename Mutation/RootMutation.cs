using GraphQL.Types;
using GraphQLProject.Migrations;
using GraphQLProject.Query;

namespace GraphQLProject.Mutation
{
    public class RootMutation : ObjectGraphType
    {
        public RootMutation()
        {
            Field<MenuMutation>("menuMutation").Resolve(context => new { });
            Field<CategoryMutation>("categoryMutation").Resolve(context => new { });
            Field<ReservationMutation>("reservationMutation").Resolve(context => new { });
            // added the mutations code for the review entity 
            Field<ReviewMutation>("reviewmutation").Resolve(context => new { });
            // added the mutations code for the User elements 
            Field<UserMutation>("usermutation").Resolve(context => new { });


        }
    }
}
