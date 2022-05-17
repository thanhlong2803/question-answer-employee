using be.Data;
using be.Data.Model;

namespace be.Services
{
    public interface ITestRepository
    {
        List<Test> GetTests();
        bool CreateTest(Test test);
        bool CreateTestQuestion(long testId, List<QuestionVo> questionVos);
        List<TestQuestionVo> GetTestQuestions(long testId);       
    }
}
