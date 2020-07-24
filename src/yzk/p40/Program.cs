using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace P40;

public class Program
{
    public static void Main(string[] args)
    {
        ConfigurationBuilder configurationBuilder = new ConfigurationBuilder();
        IConfigurationRoot configurationRoot = configurationBuilder.AddJsonFile("config.json").Build();

        ServiceCollection serviceCollection = new ServiceCollection();
        serviceCollection.AddScoped<TestService>();
        serviceCollection.AddOptions()
            .Configure<Config>(i => configurationRoot.Bind(i))
            .Configure<Proxy>(i => configurationRoot.GetSection("Proxy").Bind(i));

        ServiceProvider serviceProvider = serviceCollection.BuildServiceProvider();

        TestService testService = serviceProvider.GetRequiredService<TestService>();

        Console.WriteLine($"Name:{testService.GetConfig().Name}");
        Console.WriteLine($"Proxy.Port:{testService.GetProxy().Port}");
    }
}
