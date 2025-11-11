using GraphQLProject.Models;

namespace GraphQLProject.Interfaces
{

    public interface IUserRepository
    {

        public List<User> GetAllUser();
    }

}