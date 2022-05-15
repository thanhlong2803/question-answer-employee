using be.Data;

namespace be.Services
{
    public interface ITestRepository
    {
        List<Test> GetTests();
        bool CreateTest(Test test);
    }
}
