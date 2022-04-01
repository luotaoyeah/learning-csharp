using System;
using System.IO;
using System.Threading.Tasks;

namespace P16;

public class Program
{
    public static async Task Main(string[] args)
    {
        string text = await F02Async();
        Console.WriteLine(text);
    }

    private static async Task<string> F01Async()
    {
        return await File.ReadAllTextAsync("D:/temp/p16/000.txt");
    }

    /// <summary>
    /// 下面这种简单的场景, 不需要先 await 再 retrun, 直接返回 Task 对象即可.
    /// </summary>
    /// <returns></returns>
    private static Task<string> F02Async()
    {
        return File.ReadAllTextAsync("D:/temp/p16/000.txt");
    }
}
