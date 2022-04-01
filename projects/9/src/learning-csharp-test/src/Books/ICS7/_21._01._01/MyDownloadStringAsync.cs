using System.Diagnostics;
using System.Net;
using System.Threading.Tasks;

namespace Luotao.Test.Books.ICS7._21._01._01
{
    public class MyDownloadStringAsync
    {
        private readonly Stopwatch sw = new();

        /// <summary>
        /// 异步执行.
        /// </summary>
        public void DoRun()
        {
            const int largeNumber = 6_000_000;
            sw.Start();

            Task<int> t1 = CountCharactersAsync(1, "http://www.microsoft.com");
            Task<int> t2 = CountCharactersAsync(2, "http://www.illustratedcsharp.com");

            CountToALargeNumber(1, largeNumber);
            CountToALargeNumber(2, largeNumber);
            CountToALargeNumber(3, largeNumber);
            CountToALargeNumber(4, largeNumber);

            Console.WriteLine($"Chars in http://www.microsoft.com                : {t1.Result,10:N0}");
            Console.WriteLine($"Chars in http://www.illustratedcsharp.com        : {t2.Result,10:N0}");
        }

        /// <summary>
        /// <see cref="Task{T}"/> 类似于 js 中的 Promise.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="uriString"></param>
        /// <returns></returns>
        private async Task<int> CountCharactersAsync(int id, string uriString)
        {
            WebClient webClient = new();
            Console.WriteLine($"Starting Call {id} :\t{sw.Elapsed.TotalMilliseconds,10:N0} ms");

            string result = await webClient.DownloadStringTaskAsync(uriString);
            Console.WriteLine($"Complete Call {id} :\t{sw.Elapsed.TotalMilliseconds,10:N0} ms");

            return result.Length;
        }

        private void CountToALargeNumber(int id, int value)
        {
            for (var i = 0; i < value; i++)
            {
                // do nothing
            }

            Console.WriteLine($"Complete Counting {id} :\t{sw.Elapsed.TotalMilliseconds,10:N0} ms");
        }
    }
}
