
using be.Data;
using Infrastructure;
using System.Linq;

namespace be.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public List<User> GetUsers()
        {
            return _userRepository.GetUsers();
        }

        public User GetUserById(long userId)
        {
            return _userRepository.GetById(userId);
        }

        public bool UpdateUser(User user)
        {
            return _userRepository.UpdateUser(user);
        }

        public bool CreateUser(User user)
        {
            return _userRepository.CreateUser(user);
        }

        public bool DeleteUser(long userId)
        {
            return _userRepository.DeleteUser(userId);
        }

        public bool ChoiceTestForUser(long userId, List<long> testIds)
        {
           return _userRepository.ChoiceTestForUser(userId, testIds);
        }
    }
}
