using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;

namespace P39;

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

    private static void F01()
    {
        ConfigurationBuilder configurationBuilder = new ConfigurationBuilder();
        IConfigurationRoot configurationRoot = configurationBuilder.AddJsonFile("config.json").Build();

        Console.WriteLine(configurationRoot["x"]);
        Console.WriteLine(configurationRoot["y:z"]);

        // 如果属性值是一个对象, 则通过索引取到的值为 null,
        // 也就是说, 通过索引只能取到叶子节点的值
        Console.WriteLine(configurationRoot["y"] == null);
    }

    /// <summary>
    /// IConfiguration.GetSection() 和索引的区别:
    ///   1. 如果是叶子节点, 索引返回值; 否则索引返回 null
    ///   2. GetSection() 返回元数据, 包括: Key, Value, Path
    ///      如果是叶子节点, Value 为值; 否则 Value 也为 null
    ///
    /// </summary>
    private static void F02()
    {
        ConfigurationBuilder configurationBuilder = new ConfigurationBuilder();
        IConfigurationRoot configurationRoot = configurationBuilder.AddJsonFile("config.json").Build();

        IConfigurationSection configurationSection01 = configurationRoot.GetSection("x");
        Console.WriteLine($"{configurationSection01.Key},{configurationSection01.Value},{configurationSection01.Path}");

        IConfigurationSection configurationSection02 = configurationRoot.GetSection("y:z");
        Console.WriteLine($"{configurationSection02.Key},{configurationSection02.Value},{configurationSection02.Path}");

        // 通过 GetSection() 取到不是叶子节点, 则 Value 为 null, 跟索引类似
        IConfigurationSection configurationSection03 = configurationRoot.GetSection("y");
        Console.WriteLine(configurationSection03.Value == null);
    }

    /// <summary>
    /// IConfiguration.GetChildren().
    /// </summary>
    private static void F03()
    {
        ConfigurationBuilder configurationBuilder = new ConfigurationBuilder();
        IConfigurationRoot configurationRoot = configurationBuilder.AddJsonFile("config.json").Build();

        // 如果是叶子节点, 则 GetChildren() 返回的是空列表
        IConfigurationSection configurationSection01 = configurationRoot.GetSection("x");
        IEnumerable<IConfigurationSection> configurationSections01 = configurationSection01.GetChildren();
        Console.WriteLine(configurationSections01.Count());

        IConfigurationSection configurationSection02 = configurationRoot.GetSection("y");
        IEnumerable<IConfigurationSection> configurationSections02 = configurationSection02.GetChildren();
        foreach (IConfigurationSection section in configurationSections02)
        {
            Console.WriteLine($"{section.Key},{section.Value},{section.Path}");
        }
    }

    /// <summary>
    /// Microsoft.Extensions.Configuration.Binder
    /// </summary>
    private static void F04()
    {
        ConfigurationBuilder configurationBuilder = new ConfigurationBuilder();
        IConfigurationRoot configurationRoot = configurationBuilder.AddJsonFile("config.json").Build();

        Config config = configurationRoot.Get<Config>();
        Console.WriteLine(config.X);

        ConfigY configY = configurationRoot.GetSection("y").Get<ConfigY>();
        Console.WriteLine(configY.Z);

        string x = configurationRoot.GetValue<string>("x");
        Console.WriteLine(x);

        // IConfiguration.GetValue() 根据路径获取叶子节点的值, 并转换到指定的类型
        // 如果不是叶子节点, 则返回 null
        Console.WriteLine(configurationRoot.GetValue<ConfigY>("y") == null);
        Console.WriteLine(configurationRoot.GetValue<int>("age") == 18);
        Console.WriteLine(configurationRoot["age"] == "18");
    }
}
