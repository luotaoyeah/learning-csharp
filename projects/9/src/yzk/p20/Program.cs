using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace P20;

public class Program
{
    public static async Task Main(string[] args)
    {
        await foreach (string s in F01Async())
        {
            Console.WriteLine(s);
        }
    }

    /// <summary>
    /// iterator 中使用 async 时, 返回类型需要使用 IAsyncEnumerator / IAsyncEnumerable,
    /// 同时在遍历时需要使用 await foreach.
    /// </summary>
    /// <returns></returns>
    private static async IAsyncEnumerable<string> F01Async()
    {
        Console.WriteLine("准备返回 A");
        yield return await F02Async("A");

        Console.WriteLine("准备返回 B");
        yield return await F02Async("B");

        Console.WriteLine("准备返回 C");
        yield return await F02Async("C");
    }

    private static async Task<string> F02Async(string s)
    {
        await Task.Delay(1000);
        return s;
    }
}
