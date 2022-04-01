using System;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace P14;

public class Program
{
    public static async Task Main(string[] args)
    {
        Console.WriteLine($"1: {Thread.CurrentThread.ManagedThreadId}");

        await F01Async();

        Console.WriteLine($"2: {Thread.CurrentThread.ManagedThreadId}");
    }

    private static async Task F01Async()
    {
        StringBuilder stringBuilder = new StringBuilder();
        for (int i = 0; i < 1; i++)
        {
            stringBuilder.AppendLine("FOO");
        }

        Directory.CreateDirectory(@"D:/temp/p14");
        await File.WriteAllTextAsync(@"D:/temp/p14/000.txt", stringBuilder.ToString());
    }
}
