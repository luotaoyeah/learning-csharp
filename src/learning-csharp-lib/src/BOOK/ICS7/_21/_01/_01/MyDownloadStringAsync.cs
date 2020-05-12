using System;
using System.Diagnostics;
using System.Net;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace LT.LIB.BOOK.ICS7._21._01._01
{
    public class MyDownloadStringAsync
    {
        private Stopwatch sw = new Stopwatch();
        private Action<string> WriteLine;

        public MyDownloadStringAsync(Action<string> writeLine)
        {
            WriteLine = writeLine;
        }

        public void DoRun()
        {
            const int largeNumber = 6_000_000;
            sw.Start();

            Task<int> t1 = CountCharacters(1, "http://www.microsoft.com");
            Task<int> t2 = CountCharacters(2, "http://www.illustratedcsharp.com");

            CountToALargeNumber(1, largeNumber);
            CountToALargeNumber(2, largeNumber);
            CountToALargeNumber(3, largeNumber);
            CountToALargeNumber(4, largeNumber);

            WriteLine($"Chars in http://www.microsoft.com                : {t1.Result}");
            WriteLine($"Chars in http://www.illustratedcsharp.com        : {t2.Result}");
        }

        //----------------------------------------------------------------------------------------------------
        // Task 类似于 js 中的 Promise
        //----------------------------------------------------------------------------------------------------
        private async Task<int> CountCharacters(int id, string uriString)
        {
            WebClient wc1 = new WebClient();
            WriteLine($"Starting Call {id}           :\t{sw.Elapsed.TotalMilliseconds,5:N0} ms");
            string result = await wc1.DownloadStringTaskAsync(uriString);
            WriteLine($"    Call {id} Completed      :\t{sw.Elapsed.TotalMilliseconds,5:N0} ms");
            return result.Length;
        }

        private void CountToALargeNumber(int id, int value)
        {
            for (int i = 0; i < value; i++)
            {
                // do nothing
            }

            WriteLine($"\tEnd Counting {id}        :\t{sw.Elapsed.TotalMilliseconds,5:N0} ms");
        }
    }
}
