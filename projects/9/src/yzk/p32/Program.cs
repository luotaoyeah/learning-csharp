using Microsoft.Extensions.DependencyInjection;
using p32;

namespace P32;

public class Program
{
    public static void Main(string[] args)
    {
        ServiceCollection serviceCollection = new ServiceCollection();
        serviceCollection.AddTransient<ITestService, TestService02>();

        using ServiceProvider serviceProvider = serviceCollection.BuildServiceProvider();
        ITestService? testService = serviceProvider.GetService<ITestService>();
        testService?.Hi();
    }
}
