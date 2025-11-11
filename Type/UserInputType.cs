using GraphQL.Types;
using GraphQLProject.Type;


namespace GraphQLProject.Type
{

    public class UserInputType : InputObjectGraphType
    {

        public UserInputType()
        {

            Field<IntGraphType>("id");
            Field<StringGraphType>("name");
            Field<StringGraphType>("email");
            Field<StringGraphType>("password");
            Field<IntGraphType>("role");

        }
    }

}