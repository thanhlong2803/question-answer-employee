
using be.Services;
using be.Data;
namespace Infrastructure
{
    public interface IUserRepository
    {
        List<User> GetUsers();
        User GetById(long id);
        bool CreateUser(User user);
        bool UpdateUser(User user);
        bool DeleteUser(long id);
        bool ChoiceTestForUser(long userId, List<long> testIds);
    }
}
