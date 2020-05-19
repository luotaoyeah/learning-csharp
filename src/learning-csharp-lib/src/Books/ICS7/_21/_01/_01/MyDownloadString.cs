using System;
using System.Diagnostics;
using System.Net;

namespace Luotao.Lib.Books.ICS7._21._01._01
{
    public class MyDownloadString
    {
        private readonly Stopwatch sw = new();
        private readonly Action<string> WriteLine;

        public MyDownloadString(Action<string> writeLine)
        {
            WriteLine = writeLine;
        }

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

            WriteLine($"Chars in http://www.microsoft.com                : {t1}");
            WriteLine($"Chars in http://www.illustratedcsharp.com        : {t2}");
        }

        private int CountCharacters(int id, string uriString)
        {
            WebClient wc1 = new();
            WriteLine($"Starting Call {id}           :\t{sw.Elapsed.TotalMilliseconds,5:N0} ms");
            string result = wc1.DownloadString(uriString);
            WriteLine($"    Call {id} Completed      :\t{sw.Elapsed.TotalMilliseconds,5:N0} ms");
            return result.Length;
        }

        private void CountToALargeNumber(int id, int value)
        {
            for (var i = 0; i < value; i++)
            {
                // do nothing
            }

            WriteLine($"\tEnd Counting {id}        :\t{sw.Elapsed.TotalMilliseconds,5:N0} ms");
        }
    }
}
