using System;
using System.Threading;
using System.Threading.Tasks;

namespace P18;

public class Program
{
    public static async Task Main(string[] args)
    {
        var cancellationTokenSource = new CancellationTokenSource();
        cancellationTokenSource.CancelAfter(5000);

        // await F01Async(cancellationTokenSource.Token);

        // await F02Async(cancellationTokenSource.Token);

        await F03Async(cancellationTokenSource.Token);
    }

    private static async Task F01Async(CancellationToken cancellationToken)
    {
        for (int i = 0; i < 10; i++)
        {
            if (cancellationToken.IsCancellationRequested)
            {
                Console.WriteLine("任务取消");
                return;
            }

            Console.WriteLine(i.ToString());
            await Task.Delay(1000);
        }
    }

    private static async Task F02Async(CancellationToken cancellationToken)
    {
        for (int i = 0; i < 10; i++)
        {
            cancellationToken.ThrowIfCancellationRequested();
            Console.WriteLine(i.ToString());
            await Task.Delay(1000);
        }
    }

    private static async Task F03Async(CancellationToken cancellationToken)
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i.ToString());
            await Task.Delay(1000, cancellationToken);
        }
    }
}
