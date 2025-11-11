using GraphQL.Types;

namespace GraphQLProject.Query
{
    public class RootQuery : ObjectGraphType
    {
        public RootQuery()
        {
            Field<MenuQuery>("menuQuery").Resolve(context => new { });
            Field<CategoryQuery>("categoryQuery").Resolve(context => new { });
            Field<ReservationQuery>("reservationQuery").Resolve(context => new { });
            Field<ReviewQuery>("reviewQuery").Resolve(context => new { });
            Field<UserQuery>("userquery").Resolve(context => new { });

        }
    }
}
