using System.Diagnostics;
using System.Net;

namespace Luotao.Test.Books.ICS7._21._01._01
{
    public class MyDownloadString
    {
        private readonly Stopwatch sw = new();

        /// <summary>
        /// 同步执行.
        /// </summary>
        public void DoRun()
        {
            const int largeNumber = 6_000_000;
            sw.Start();

            var t1 = CountCharacters(1, "http://www.microsoft.com");
            var t2 = CountCharacters(2, "http://www.illustratedcsharp.com");

            CountToALargeNumber(1, largeNumber);
            CountToALargeNumber(2, largeNumber);
            CountToALargeNumber(3, largeNumber);
            CountToALargeNumber(4, largeNumber);

            Console.WriteLine($"Chars in http://www.microsoft.com                : {t1,10:N0}");
            Console.WriteLine($"Chars in http://www.illustratedcsharp.com        : {t2,10:N0}");
        }

        private int CountCharacters(int id, string uriString)
        {
            WebClient webClient = new();
            Console.WriteLine($"Starting Call {id} :\t{sw.Elapsed.TotalMilliseconds,10:N0} ms");

            string result = webClient.DownloadString(uriString);
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
