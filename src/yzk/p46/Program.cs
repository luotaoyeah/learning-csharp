using Microsoft.Extensions.DependencyInjection;
using NLog.Extensions.Logging;

namespace P46;

public class Program
{
    public static void Main(string[] args)
    {
        var serviceCollection = new ServiceCollection();
        serviceCollection.AddScoped<TestService>();
        serviceCollection.AddLogging(
            (loggingBuilder) =>
            {
                loggingBuilder
                    .AddNLog();
            }
        );

        using ServiceProvider serviceProvider = serviceCollection.BuildServiceProvider();
        TestService testService = serviceProvider.GetRequiredService<TestService>();
        testService.Test();
    }
}
