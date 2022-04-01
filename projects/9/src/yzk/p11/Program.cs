using System;
using System.IO;
using System.Threading.Tasks;

namespace P11;

public class Program
{
    public static async Task Main(string[] args)
    {
        // F01();

        await F02Async();
    }

    /// <summary>
    /// 同步方法.
    /// </summary>
    private static void F01()
    {
        Directory.CreateDirectory(@"D:/temp/p11/");
        string path = @"D:/temp/p11/000.txt";
        File.WriteAllText(path, "HELLO WORLD");
        string text = File.ReadAllText(path);
        Console.WriteLine(text);
        Console.Read();
    }

    /// <summary>
    /// 异步方法.
    /// </summary>
    private static async Task F02Async()
    {
        Directory.CreateDirectory(@"D:/temp/p11");
        string path = @"D:/temp/p11/000.txt";
        await File.WriteAllTextAsync(path, "HELLO WORLD");
        string text = await File.ReadAllTextAsync(path);
        Console.WriteLine(text);
        Console.Read();
    }
}
