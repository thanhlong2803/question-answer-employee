
using be.Data;

namespace be.Services
{
    public class QuestionService : IQuestionService
    {
        private readonly IQuestionRepository _questionRepository;
        public QuestionService(IQuestionRepository questionRepository)
        {
            _questionRepository = questionRepository;
        }
        public List<Question> GetQuestions()
        {
            return _questionRepository.GetQuestions();
        }

        public List<Question> QuestionRandoms(int numberRamdom)
        {
           return _questionRepository.QuestionRandoms(numberRamdom);
        }
    }
}
