using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace P45;

public class Program
{
    public static void Main(string[] args)
    {
        ServiceCollection serviceCollection = new ServiceCollection();
        serviceCollection.AddLogging(
            (loggingBuilder) =>
            {
                loggingBuilder
                    .AddConsole()
                    .SetMinimumLevel(LogLevel.Debug);
            }
        );
        serviceCollection.AddScoped<TestService>();

        using ServiceProvider serviceProvider = serviceCollection.BuildServiceProvider();
        TestService testService = serviceProvider.GetRequiredService<TestService>();
        testService.Test();

        ILogger<Program> logger = serviceProvider.GetRequiredService<ILogger<Program>>();
        logger.LogInformation("000");
    }
}
