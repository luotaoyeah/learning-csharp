using Microsoft.Extensions.Logging;

namespace P45;

public class TestService
{
    private readonly ILogger<TestService> logger;

    public TestService(ILogger<TestService> logger)
    {
        this.logger = logger;
    }

    public void Test()
    {
        logger.LogTrace("TRACE...");
        logger.LogDebug("DEBUG...");
        logger.LogInformation("INFO...");
        logger.LogWarning("WARNING...");
        logger.LogError("ERROR...");
        logger.LogCritical("CRITICAL...");
    }
}
