
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
        
        public List<Test> ResultQuestion(Test test, List<Question> questions)
        {
            return null;
        }

    }
}
