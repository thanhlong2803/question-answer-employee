
using be.Data;
using be.Services;

namespace Infrastructure
{
    public class UserRepository : IUserRepository
    {
        private SettingDbcontext _dbcontext;

        public UserRepository(SettingDbcontext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public bool CreateUser(User user)
        {
            if (user == null)
                return false;
            _dbcontext.Add(user);
            _dbcontext.SaveChanges();

            return true;
        }

        public bool DeleteUser(long id)
        {
            var user = _dbcontext.User.Where(c => c.UserId == id).FirstOrDefault();
            if (user == null)
                return false;

            _dbcontext.Remove(user);
            _dbcontext.SaveChanges();

            return true;
        }

        public User GetById(long id)
        {
            return _dbcontext.User.Where(c => c.UserId == id).First();
        }

        public List<User> GetUsers()
        {
            return _dbcontext.User.ToList();
        }

        public bool UpdateUser(User user)
        {
            if (user == null)
                return false;

            var userEnity = _dbcontext.User.Where(c => c.UserId == user.UserId).FirstOrDefault();
            if (userEnity == null)
                return false;

            userEnity.UserId = user.UserId;
            userEnity.Firstname = user.Firstname;
            userEnity.LastName = user.LastName;

            _dbcontext.Update(userEnity);
            _dbcontext.SaveChanges();
            return true;
        }

        public bool ChoiceTestForUser(long userId, List<long> testIds)
        {
            if (testIds == null)
                return false;

            var userTests = new List<User_Test_Mapping>();

            foreach (var testId in testIds)
            {
                userTests.Add(new User_Test_Mapping { TestId = testId, UserId = userId });
            }

            _dbcontext.User_Test_Mapping.AddRange(userTests);
            _dbcontext.SaveChanges();

            return true;
        }
    }
}
