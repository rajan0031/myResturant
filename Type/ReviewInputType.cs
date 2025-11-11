using GraphQL.Types;

namespace GraphQLProject.Type
{
    public class ReviewInputType : InputObjectGraphType
    {
        public ReviewInputType()
        {
            Field<IntGraphType>("id");
            Field<IntGraphType>("menuId");
            Field<StringGraphType>("description");
            Field<IntGraphType>("ratting");
        }
    }
}
