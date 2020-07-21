using System;
using System.Threading;
using System.Threading.Tasks;

namespace P15;

public class Program
{
    public static async Task Main(string[] args)
    {
        Console.WriteLine($"0:{Thread.CurrentThread.ManagedThreadId}");

        // int result = await F01Async(10000);
        int result = await F02Async(10000);

        Console.WriteLine($"2:{Thread.CurrentThread.ManagedThreadId}");
    }

    /// <summary>
    /// Task.Run() 将任务添加到线程池的任务队列.
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    private static async Task<int> F01Async(int n)
    {
        return await Task.Run(
            () =>
            {
                int result = 0;
                for (int i = 0; i < n * n; i++)
                {
                    result += i;
                }

                Console.WriteLine($"1:{Thread.CurrentThread.ManagedThreadId}");

                return result;
            }
        );
    }

    /// <summary>
    /// Task.Factory.StartNew()
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    private static async Task<int> F02Async(int n)
    {
        return await Task.Factory.StartNew(
            () =>
            {
                int result = 0;
                for (int i = 0; i < n * n; i++)
                {
                    result += i;
                }

                Console.WriteLine($"1:{Thread.CurrentThread.ManagedThreadId}");

                return result;
            }
        );
    }
}
