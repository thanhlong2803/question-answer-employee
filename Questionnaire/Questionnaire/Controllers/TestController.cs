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
    }
}