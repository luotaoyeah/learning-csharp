using Microsoft.Extensions.Logging;

namespace P46;

public class TestService
{
    private readonly ILogger<TestService> logger;

    public TestService(ILogger<TestService> logger)
    {
        this.logger = logger;
    }

    public void Test()
    {
        logger.LogInformation("INFO...");
    }
}
