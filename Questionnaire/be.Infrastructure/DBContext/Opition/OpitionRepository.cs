
using be.Services;

namespace Infrastructure
{
    public class OpitionRepository : IOpitionRepository
    {
        private SettingDbcontext _dbcontext;

        public OpitionRepository(SettingDbcontext dbcontext)
        {
            _dbcontext = dbcontext;
        }

    }
}
