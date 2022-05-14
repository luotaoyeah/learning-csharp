using Microsoft.Extensions.Logging;

namespace Luotao.LearningCsharp.Test.Books.PROCN2021._16._02;

public class TestService
{
    private readonly ILogger<TestService> logger;

    public TestService(ILogger<TestService> logger)
    {
        this.logger = logger;
    }

    public void F01()
    {
        logger.LogInformation("[" + nameof(TestService) + "] " + "INFO");
        logger.LogDebug("[" + nameof(TestService) + "] " + "DEBUG");
        logger.LogWarning("[" + nameof(TestService) + "] " + "WARNING");
        logger.LogError("[" + nameof(TestService) + "] " + "ERROR");
        logger.LogCritical("[" + nameof(TestService) + "] " + "CRITICAL");
    }
}
