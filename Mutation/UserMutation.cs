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


            Field<UserType>("updateuser").Arguments(new QueryArguments(new QueryArgument<UserInputType> { Name = "user" }, new QueryArgument<IntGraphType> { Name = "id" })).Resolve(context =>
              {
                  var user = context.GetArgument<User>("user");
                  var id = context.GetArgument<int>("id");
                  return userRepository.UpdateUserDetail(user, id);

              });


            // this is the mutations for the login a user to the database 
            Field<StringGraphType>("loginuser").Arguments(new QueryArguments(new QueryArgument<StringGraphType> { Name = "email" }, new QueryArgument<StringGraphType> { Name = "password" })).Resolve(context =>
              {
                  var email = context.GetArgument<string>("email");
                  var password = context.GetArgument<string>("password");
                  return userRepository.LoginUser(email, password);

              });




        }


    }


}