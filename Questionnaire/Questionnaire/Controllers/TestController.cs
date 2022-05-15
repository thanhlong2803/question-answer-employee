using be.Data;
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

        [HttpPost]
        public ActionResult<bool> TestQuestion(Test test, List<Question> questions)
        {
            return null;
        }

        #endregion
    }
}