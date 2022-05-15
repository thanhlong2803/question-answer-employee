using be.Data;
using be.Services;

namespace Infrastructure
{
    public class QuestionRepository : IQuestionRepository
    {
        private SettingDbcontext _dbcontext;

        public QuestionRepository(SettingDbcontext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public List<Question> SelectQuesition()
        {
            var quesitionEntity = _dbcontext.Question.ToList();
            return quesitionEntity;
        }
        public List<Question> RadomQuestion(int numberRadom)
        {
            var radomQuestions = new List<Question>();
            var quesitionEntity = _dbcontext.Question.ToList();

            var newQuestions = quesitionEntity.Where(c => !c.Test_Question_Mappings.Select(c => c.QuestionId).Contains(c.QuestionId)).ToList();
            var oldQuestions = quesitionEntity.Where(c => c.Test_Question_Mappings.Select(c => c.QuestionId).Contains(c.QuestionId)).ToList();

            if (newQuestions.Count > 0)
                radomQuestions.AddRange(newQuestions);
            if (newQuestions.Count < numberRadom)
                radomQuestions.AddRange(oldQuestions);

            return radomQuestions;
        }
    }
}
