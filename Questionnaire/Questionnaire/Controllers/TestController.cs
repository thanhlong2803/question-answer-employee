using be.Data;
using be.Data.Model;
using be.Services;
using Microsoft.AspNetCore.Mvc;

namespace Questionnaire.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        private readonly ITestService _testService;
        public TestController(ITestService testService)
        {
            _testService = testService;
        }

        #region Get test and Create test

        [HttpGet("")]
        public ActionResult<List<Test>> GetTests()
        {
            return _testService.GetTests();
        }

        [HttpPost]
        public ActionResult<bool> CreateTest(Test test)
        {
            return _testService.CreateTest(test);
        }

        [HttpGet("TestQuestions")]
        public ActionResult<List<TestQuestionVo>> TestQuestion(long testId)
        {
            return Ok(_testService.GetTestQuestions(testId));
        }

        [HttpPost("CreateTestQuestion")]
        public ActionResult<bool> CreateTestQuestion(long testId, List<QuestionVo> questionVos)
        {
            return _testService.CreateTestQuestion(testId, questionVos);
        }

        #endregion
    }
}