using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;

namespace P33;

public class Program
{
    public static void Main(string[] args)
    {
        F01();
        Console.WriteLine("--------------------------------------------------");

        F02();
        Console.WriteLine("--------------------------------------------------");

        F03();
        Console.WriteLine("--------------------------------------------------");

        F04();
        Console.WriteLine("--------------------------------------------------");
    }

    /// <summary>
    /// AddTransient().
    /// </summary>
    private static void F01()
    {
        ServiceCollection serviceCollection = new ServiceCollection();
        serviceCollection.AddTransient<ITestService, TestService01>();

        ServiceProvider serviceProvider = serviceCollection.BuildServiceProvider();

        ITestService? service01 = serviceProvider.GetService<ITestService>();
        ITestService? service02 = serviceProvider.GetService<ITestService>();
        Console.WriteLine(ReferenceEquals(service01, service02));
    }

    /// <summary>
    /// AddSingleton().
    /// </summary>
    private static void F02()
    {
        ServiceCollection serviceCollection = new ServiceCollection();
        serviceCollection.AddSingleton<ITestService, TestService01>();

        ServiceProvider serviceProvider = serviceCollection.BuildServiceProvider();

        ITestService? service01 = serviceProvider.GetService<ITestService>();
        ITestService? service02 = serviceProvider.GetService<ITestService>();
        Console.WriteLine(ReferenceEquals(service01, service02));
    }

    /// <summary>
    /// AddScoped().
    /// </summary>
    private static void F03()
    {
        ServiceCollection serviceCollection = new ServiceCollection();
        serviceCollection.AddScoped<ITestService, TestService01>();

        ServiceProvider serviceProvider = serviceCollection.BuildServiceProvider();

        using IServiceScope scope01 = serviceProvider.CreateScope();
        var service01 = scope01.ServiceProvider.GetService<ITestService>();
        var service02 = scope01.ServiceProvider.GetService<ITestService>();
        Console.WriteLine(ReferenceEquals(service01, service02));

        using IServiceScope scope02 = serviceProvider.CreateScope();
        ITestService? service11 = scope02.ServiceProvider.GetService<ITestService>();
        ITestService? service12 = scope02.ServiceProvider.GetService<ITestService>();
        Console.WriteLine(ReferenceEquals(service11, service12));

        Console.WriteLine(ReferenceEquals(service01, service11));
    }

    /// <summary>
    /// ServiceProvider.GetServices().
    /// </summary>
    private static void F04()
    {
        ServiceCollection serviceCollection = new ServiceCollection();
        serviceCollection.AddScoped<ITestService, TestService02>();
        serviceCollection.AddScoped<ITestService, TestService01>();

        ServiceProvider serviceProvider = serviceCollection.BuildServiceProvider();

        ITestService service01 = serviceProvider.GetRequiredService<ITestService>();
        service01.Hi();

        IEnumerable<ITestService> services = serviceProvider.GetServices<ITestService>();
        foreach (ITestService service in services)
        {
            service.Hi();
        }
    }
}
