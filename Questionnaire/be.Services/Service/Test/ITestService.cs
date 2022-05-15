using be.Data;

namespace be.Services
{
    public interface ITestService
    {
        List<Test> GetTests();
        bool CreateTest(Test test);
    }
}
