
using be.Services;
using be.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class TestRepository : ITestRepository
    {
        private SettingDbcontext _dbcontext;
        public TestRepository(SettingDbcontext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public List<Test> GetTests()
        {
            return _dbcontext.Test.ToList();
        }
        public bool CreateTest(Test test)
        {
            if (test == null)
                return false;

            _dbcontext.Test.Add(test);
            _dbcontext.SaveChanges();

            return true;
        }
    }
}
