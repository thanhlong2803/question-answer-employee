
using be.Services;
using be.Data;
using be.Data.Model;

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
        UserTestVo GetTestForUser(long userId);
    }
}
