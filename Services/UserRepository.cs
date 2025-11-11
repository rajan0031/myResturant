using GraphQLProject.Models;
using GraphQLProject.Data;
using GraphQLProject.Interfaces;


namespace GraphQLParser.Services
{


    public class UserRepository : IUserRepository
    {

        private GraphQLDbContext dbContext; // this is reference to the database , its type is the GraphQLDbContext


        // constructor , i am going to define constructor here now 

        public UserRepository(GraphQLDbContext graphQLDbContext)
        {

            dbContext = graphQLDbContext;

        }

        // add a user all the logics will go here 
        public User AddUser(User user)
        {
            dbContext.Users.Add(user);
            dbContext.SaveChanges();
            return user;
        }



        // now define all the logic of the lal the funnctions from the Irepository 

        public List<User> GetAllUser()
        {

            return dbContext.Users.ToList();
        }

    }



}