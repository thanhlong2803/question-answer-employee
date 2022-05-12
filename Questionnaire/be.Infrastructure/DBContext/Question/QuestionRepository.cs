using be.Services;

namespace Infrastructure
{
    public class QuestionRepository :IQuestionRepository
    {
        private SettingDbcontext _dbcontext;

        public QuestionRepository(SettingDbcontext dbcontext)
        {
            _dbcontext = dbcontext;
        }
    }
}
