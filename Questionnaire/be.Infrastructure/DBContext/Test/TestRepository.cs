
using be.Services;

namespace Infrastructure
{
    public class TestRepository : ITest_Question_MappingRepository
    {
        private SettingDbcontext _dbcontext;
        public TestRepository(SettingDbcontext dbcontext)
        {
            _dbcontext = dbcontext;
        }

    }
}
