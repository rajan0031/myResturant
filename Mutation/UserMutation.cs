using GraphQL;
using GraphQL.Types;
using GraphQLProject.Interfaces;
using GraphQLProject.Type;
using GraphQLProject.Models;

namespace GraphQLProject.Migrations
{


    public class UserMutation : ObjectGraphType
    {


        // constructor bnawo and inject the values , of the  INterface repository here 

        public UserMutation(IUserRepository userRepository)
        {


            Field<UserType>("adduser").Arguments(new QueryArguments(new QueryArgument<UserInputType> { Name = "user" })).Resolve(context =>
            {
                var user = context.GetArgument<User>("user");

                return userRepository.AddUser(user);

            });




        }


    }


}