using GraphQLProject.Models;

namespace GraphQLProject.Interfaces
{

    public interface IUserRepository
    {

        public List<User> GetAllUser();

        public User AddUser(User user);

        public User UpdateUserDetail(User user, int id);

        public String LoginUser(string email, string password);
    }

}