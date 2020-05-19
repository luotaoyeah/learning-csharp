using System;
using System.Diagnostics;
using System.Net;
using System.Threading.Tasks;

namespace Luotao.Lib.Books.ICS7._21._03._03
{
    public class MyDownloadString
    {
        private readonly Action<string> writeLine;

        public MyDownloadString(Action<string> writeLine)
        {
            this.writeLine = writeLine;
        }

        public void DoRun()
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            Task<int> task = CountCharactersAsync("http://www.illustratedcsharp.com");
            //----------------------------------------------------------------------------------------------------
            // 调用 Wait() 方法，等待异步任务执行完毕
            //----------------------------------------------------------------------------------------------------
            task.Wait();

            writeLine($"{stopwatch.ElapsedMilliseconds}ms: {task.Result}");
        }

        private async Task<int> CountCharactersAsync(string site)
        {
            string result = await new WebClient().DownloadStringTaskAsync(new Uri(site));
            return result.Length;
        }
    }
}
