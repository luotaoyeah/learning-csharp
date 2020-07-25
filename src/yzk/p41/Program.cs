using Microsoft.Extensions.Configuration;

namespace P41;

public class Program
{
    /// <summary>
    /// dotnet 命令行如何传参数, 多级参数使用 : 分隔
    ///   dotnet run Person:Name=luotao Person:Age=19
    ///
    /// </summary>
    /// <param name="args"></param>
    public static void Main(string[] args)
    {
        ConfigurationBuilder configurationBuilder = new ConfigurationBuilder();
        IConfigurationRoot configurationRoot = configurationBuilder
            .AddCommandLine(args)
            .AddEnvironmentVariables("LT_")
            .Build();

        Console.WriteLine(configurationRoot["Person:Name"]);
        Console.WriteLine(configurationRoot.GetSection("Person:Age").Value);
        Console.WriteLine(configurationRoot.GetSection("FOO").Value);
    }
}
