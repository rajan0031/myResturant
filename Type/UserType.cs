using GraphQL.Types;
using GraphQLProject.Models;

namespace GraphQLProject.Type
{


    public class UserType : ObjectGraphType<User>
    {


        public UserType()
        {

            Field(u => u.Id);
            Field(u => u.Name);
            Field(u => u.Email);
            Field(u => u.Password); // removed because of the security rson 
            Field(u => u.Role);

        }


    }

}