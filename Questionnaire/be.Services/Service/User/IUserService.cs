using be.Data;

namespace be.Services
{
    public interface IUserService
    {
        List<User> GetUsers();
        User GetUserById(long userId);
        bool UpdateUser(User user);
        bool DeleteUser(long userId);
        bool CreateUser(User user);
        bool ChoiceTestForUser(long userId, List<long> testIds)
    }
}
