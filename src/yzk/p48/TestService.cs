using Serilog;

namespace P48;

public class TestService
{
    public void Test()
    {
        Log.Information($"{nameof(TestService)}.{nameof(Test)}()");
    }
}
