
using be.Services;

namespace Infrastructure
{
    public class Test_Question_MappingRepository : ITest_Question_MappingRepository
    {
        private SettingDbcontext _dbcontext;
        public Test_Question_MappingRepository(SettingDbcontext dbcontext)
        {
            _dbcontext = dbcontext;
        }

    }
}
