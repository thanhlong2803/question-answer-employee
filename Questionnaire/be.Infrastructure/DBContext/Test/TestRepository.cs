
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

        public List<TestQuestionVo> GetTestQuestions(long testId)
        {
            var testQuestions = new List<TestQuestionVo>();

            var testQuestionVos = _dbcontext.Test_Question_Mapping
                .Include(xc => xc.Tests).Include(xc => xc.Questions)
                .ThenInclude(x => x.Opitions).Where(xc => xc.TestId == testId).ToList();

            if (testQuestionVos == null)
                return testQuestions;

            foreach (var testQuestion in testQuestionVos)
            {
                var testQuestionVo = new TestQuestionVo()
                {
                    TestId = testQuestion.TestId,
                    Name = testQuestion.Tests.First().Name,
                    Questions = testQuestion.Questions.Select(x => new QuestionVo
                    {
                        QuestionId = x.QuestionId,
                        QuestionName = x.QuestionName,
                        Opitions = x.Opitions.Select(x => new OpitionVo
                        {
                            OpitionId = x.OpitionId,
                            OpitionName = x.OpitionName,
                            QuestionId = x.QuestionId,
                        }).ToList()
                    }).ToList(),
                };
                testQuestions.Add(testQuestionVo);
            }

            return testQuestions;
        }
    }
}
