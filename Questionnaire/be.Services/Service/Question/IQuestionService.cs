using be.Data;

namespace be.Services
{
    public interface IQuestionService
    {
        List<Question> GetQuestions();
        List<Question> QuestionRandoms(int numberRamdom);
    }
}
