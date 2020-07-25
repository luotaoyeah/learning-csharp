using Microsoft.Extensions.DependencyInjection;
using Serilog;
using Serilog.Formatting.Json;

namespace P48;

public class Program
{
    public static void Main(string[] args)
    {
        ServiceCollection serviceCollection = new ServiceCollection();
        serviceCollection.AddScoped<TestService>();
        ServiceProvider buildServiceProvider = serviceCollection.BuildServiceProvider();
        TestService testService = buildServiceProvider.GetRequiredService<TestService>();

        Log.Logger = new LoggerConfiguration()
            .WriteTo.Console(new JsonFormatter())
            .MinimumLevel.Debug()
            .CreateLogger();

        Log.Information("INFO...{@Person}", new { Name = "luotao", Age = 18 });

        testService.Test();

        Log.CloseAndFlush();
    }
}
