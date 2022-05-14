using Microsoft.AspNetCore.Mvc;
using be.Services;

namespace Questionnaire.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QuesitonController : ControllerBase
    {
        private readonly IQuestionService _questionService;
        public QuesitonController(IQuestionService questionService)
        {
            _questionService = questionService;
        }
    }
}