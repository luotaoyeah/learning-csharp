using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace P19;

public class Program
{
    public static async Task Main(string[] args)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        // await F01Async();

        await F02Async();

        Console.WriteLine(stopwatch.Elapsed.Seconds);
    }

    private static Task F01Async()
    {
        return Task.WhenAll(Task.Delay(1000), Task.Delay(2000), Task.Delay(3000));
    }

    private static Task F02Async()
    {
        return Task.WhenAny(Task.Delay(1000), Task.Delay(2000), Task.Delay(3000));
    }
}
