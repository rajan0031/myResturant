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

        // this is the function which will show a simple login functionality here 

        public string LoginUser(string email, string password)
        {

            var userDetail = dbContext.Users.FirstOrDefault(data => data.Email == email);
            if (userDetail == null)
            {
                return "Email does not exist, check Your email";
            }
            var userResult = dbContext.Users.FirstOrDefault(data => data.Email == email && data.Password == password);
            if (userResult == null)
            {
                return "Password is incorrect";
            }
            return "Login SuccessFull";
        }

        // this is the UserRepo for the updating the details of the user 
        public User UpdateUserDetail(User user, int id)
        {

            var userResult = dbContext.Users.Find(id);

            if (userResult == null)
            {
                return null;
            }

            userResult.Name = user.Name;
            userResult.Email = user.Email;
            userResult.Role = user.Role;
            dbContext.SaveChanges();
            return user;
        }
    }



}