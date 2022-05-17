
using be.Data;
using be.Data.Model;
using be.Services;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class UserRepository : IUserRepository
    {
        private SettingDbcontext _dbcontext;

        public UserRepository(SettingDbcontext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public bool CreateUser(User user)
        {
            if (user == null)
                return false;
            _dbcontext.Add(user);
            _dbcontext.SaveChanges();

            return true;
        }

        public bool DeleteUser(long id)
        {
            var user = _dbcontext.User.Where(c => c.UserId == id).FirstOrDefault();
            if (user == null)
                return false;

            _dbcontext.Remove(user);
            _dbcontext.SaveChanges();

            return true;
        }

        public User GetById(long id)
        {
            return _dbcontext.User.Where(c => c.UserId == id).First();
        }

        public List<User> GetUsers()
        {
            return _dbcontext.User.ToList();
        }

        public bool UpdateUser(User user)
        {
            if (user == null)
                return false;

            var userEnity = _dbcontext.User.Where(c => c.UserId == user.UserId).FirstOrDefault();
            if (userEnity == null)
                return false;

            userEnity.UserId = user.UserId;
            userEnity.Firstname = user.Firstname;
            userEnity.LastName = user.LastName;

            _dbcontext.Update(userEnity);
            _dbcontext.SaveChanges();
            return true;
        }

        public bool ChoiceTestForUser(long userId, List<long> testIds)
        {
            if (testIds == null)
                return false;

            var userTests = new List<User_Test_Mapping>();

            foreach (var testId in testIds)
            {
                userTests.Add(new User_Test_Mapping { TestId = testId, UserId = userId });
            }

            _dbcontext.User_Test_Mapping.AddRange(userTests);
            _dbcontext.SaveChanges();

            return true;
        }

        public UserTestVo GetTestForUser(long userId)
        {
            var userTestVo = new UserTestVo();
            var userTest = _dbcontext.User_Test_Mapping
                .Include(xc => xc.User).Include(xc => xc.Test)
                .Where(xc => xc.Score != null && xc.UserId == userId).FirstOrDefault();

            if (userTest == null)
                return userTestVo;

            return userTestVo = new UserTestVo
            {
                UserId = userTest.UserId,
                Fistname = userTest.User.Firstname,
                Lastname = userTest.User.LastName,
                TestQuestionVos = GetTestQuestions(userTest.TestId)
            };
        }

        private List<TestQuestionVo> GetTestQuestions(long testId)
        {
            var testQuestions = new List<TestQuestionVo>();

            var testQuestionVos = _dbcontext.Test_Question_Mapping
                .Include(xc => xc.Test).Include(xc => xc.Question).ThenInclude(x => x.Opitions)
                .Where(xc => xc.TestId == testId).ToList();

            if (testQuestionVos == null)
                return testQuestions;

            foreach (var testQuestion in testQuestionVos)
            {
                var testQuestionVo = new TestQuestionVo()
                {
                    TestId = testQuestion.TestId,
                    Name = testQuestion.Test.Name,
                    Questions = new QuestionVo()
                    {
                        QuestionId = testQuestion.Question.QuestionId,
                        QuestionName = testQuestion.Question.QuestionName,
                        Opitions = testQuestion.Question.Opitions.Select(x => new OpitionVo
                        {
                            OpitionId = x.OpitionId,
                            OpitionName = x.OpitionName,
                            QuestionId = x.QuestionId,
                        }).ToList()
                    }
                };
                testQuestions.Add(testQuestionVo);
            }
            return testQuestions;
        }
    }
}