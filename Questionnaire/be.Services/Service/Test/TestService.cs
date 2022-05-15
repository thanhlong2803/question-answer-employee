
using be.Data;

namespace be.Services
{
    public class TestService : ITestService
    {
        private readonly ITestRepository _testRepository;
        public TestService(ITestRepository testRepository)
        {
            _testRepository = testRepository;
        }

        public List<Test> GetTests()
        {
            return _testRepository.GetTests();
        }
        public bool CreateTest(Test test)
        {
            return _testRepository.CreateTest(test);
        }
    }
}
