
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
                .Include(xc => xc.Test).Include(xc => xc.Question).ThenInclude(x => x.Opitions)
                .Where(xc => xc.TestId == testId).ToList();

            if (testQuestionVos == null)
                return testQuestions;

            foreach (var testQuestion in testQuestionVos)
            {
                var testQuestionVo = new TestQuestionVo()
                {
                    TestId = testQuestion.TestId,
                    Name = testQuestion.Test.Name,
                    Questions = new QuestionVo()
                    {
                        QuestionId = testQuestion.Question.QuestionId,
                        QuestionName = testQuestion.Question.QuestionName,
                        Opitions = testQuestion.Question.Opitions.Select(x => new OpitionVo
                        {
                            OpitionId = x.OpitionId,
                            OpitionName = x.OpitionName,
                            QuestionId = x.QuestionId,
                        }).ToList()
                    }
                };
                testQuestions.Add(testQuestionVo);
            }
            return testQuestions;
        }

        public double ScoreTestQuestionForUser(ScoreTestQuestionVo scoreTestQuestionVo)
        {
            double score = 0;
            var testQuestionVos = _dbcontext.Test_Question_Mapping
                .Include(xc => xc.Test).Include(xc => xc.Question).ThenInclude(x => x.Opitions)
                .Where(xc => xc.TestId == scoreTestQuestionVo.TestId).ToList();

            var optionForQuestions = testQuestionVos.SelectMany(c => c.Question.Opitions);
            if (testQuestionVos == null || scoreTestQuestionVo == null || optionForQuestions == null)
                return 0;

            foreach (var doQuestion in scoreTestQuestionVo.Questions.Opitions)
            {
                foreach (var checkQuestion in optionForQuestions)
                {
                    if (checkQuestion.IsCorrect == doQuestion.IsCorrect)
                    {
                        score++;
                    }
                }
            }

            var updateSore = _dbcontext.User_Test_Mapping
                .Where(x => x.UserId == scoreTestQuestionVo.UserId && x.TestId == scoreTestQuestionVo.TestId).FirstOrDefault();

            if (updateSore != null)
                updateSore.Score = score;
            _dbcontext.SaveChanges();

            return score;
        }
    }
}
