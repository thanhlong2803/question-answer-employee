using be.Data;

namespace be.Services
{
    public interface IQuestionRepository
    {
        List<Question> GetQuestions();
        List<Question> QuestionRandoms(int numberRamdom);
    }
}
