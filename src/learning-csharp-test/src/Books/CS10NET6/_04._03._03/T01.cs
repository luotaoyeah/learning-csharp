using System.Diagnostics;

namespace Luotao.Test.Books.CS10NET6._04._03._03
{
    /// <summary>
    /// 4.3.3 configuring trace listeners
    /// </summary>
    public class T01
    {
        /// <summary>
        /// 除了默认的 <see cref="DefaultTraceListener" /> 之外, 还可以添加其他的 trace listener,
        /// 比如 <see cref="TextWriterTraceListener" /> 会将日志写到一个文件中.
        /// </summary>
        [Fact]
        public void _01()
        {
            // 移除默认的 DefaultTraceListener
            Trace.Listeners.RemoveAt(0);

            // 添加一个 TextWriterTraceListener
            Trace.Listeners.Add(new TextWriterTraceListener(File.CreateText("log.temp.txt")));
            Trace.AutoFlush = true;

            Console.WriteLine("CONSOLE...");
            Debug.WriteLine($"[{DateTime.Now}] DEBUG...");
            Trace.WriteLine($"[{DateTime.Now}] TRACE...");
        }
    }
}
