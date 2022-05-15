using Microsoft.AspNetCore.Mvc;
using be.Services;
using be.Data;

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

        #region Get all question and question random by numberRandom

        [HttpGet()]
        public ActionResult<List<Question>> GetQuestions()
        {
            return _questionService.GetQuestions();
        }

        [HttpGet("{numberRandom}")]
        public ActionResult<List<Question>> QuestionRandoms(int numberRandom)
        {
            return _questionService.QuestionRandoms(numberRandom);
        }

        #endregion
    }
}