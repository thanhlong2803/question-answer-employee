
using be.Services;
using be.Data;
using Microsoft.EntityFrameworkCore;
using be.Data.Model;

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
        public bool CreateTestQuestion(long testId, List<QuestionVo> questionVos)
        {
            var testQuestion = new List<Test_Question_Mapping>();
            if (questionVos == null)
                return false;

            foreach (var questionVo in questionVos)
            {
                testQuestion.Add(new Test_Question_Mapping { QuestionId = questionVo.QuestionId, TestId = testId });
            }

            _dbcontext.Test_Question_Mapping.AddRange(testQuestion);
            _dbcontext.SaveChanges();

            return true;
        }
    }
}
