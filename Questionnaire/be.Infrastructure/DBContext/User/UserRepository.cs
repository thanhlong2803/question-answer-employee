
using be.Services;

namespace Infrastructure
{
    public class UserRepository
    {
        private SettingDbcontext _dbcontext;
        public UserRepository(SettingDbcontext dbcontext)
        {
            _dbcontext = dbcontext;
        }

    }
}
