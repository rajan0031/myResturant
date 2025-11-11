using GraphQL.Types;
using GraphQLProject.Interfaces;
using GraphQLProject.Models;
using GraphQLProject.Type;

namespace GraphQLProject.Query
{



    public class UserQuery : ObjectGraphType
    {


        public UserQuery(IUserRepository userRepository)
        {


            Field<ListGraphType<UserType>>("getalluser").Resolve(context =>
            {
                return userRepository.GetAllUser();
            });



        }



    }

}