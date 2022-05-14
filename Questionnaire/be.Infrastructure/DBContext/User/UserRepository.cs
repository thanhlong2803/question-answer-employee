
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

    }
}
