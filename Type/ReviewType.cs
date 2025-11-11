using GraphQL.Types;
using GraphQLProject.Models;


namespace GraphQLProject.Type
{

    public class ReviewType : ObjectGraphType<Review>
    {


        public ReviewType()
        {


            Field(x => x.Id);
            Field(x => x.MenuId);
            Field(x => x.Description);
            Field(x => x.Ratting);



        }

    }

}