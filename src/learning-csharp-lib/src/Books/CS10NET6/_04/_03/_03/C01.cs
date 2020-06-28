using System;
using System.Diagnostics;

namespace Luotao.Lib.Books.CS10NET6._04._03._03
{
    /// <summary>
    ///     4.3.3 configuring trace listeners
    /// </summary>
    public class C01
    {
        /// <summary>
        ///     除了默认的 <see cref="DefaultTraceListener" /> 之外, 还可以添加其他的 trace listener,
        ///     比如 <see cref="TextWriterTraceListener" /> 会将日志写到一个文件中.
        /// </summary>
        public static void F01()
        {
            // 移除默认的 trace listener
            Trace.Listeners.RemoveAt(0);

            Trace.Listeners.Add(new TextWriterTraceListener("log.txt"));
            Trace.AutoFlush = true;

            Console.WriteLine("CONSOLE...");
            Debug.WriteLine("DEBUG...");
            Trace.WriteLine("TRACE...");
        }
    }
}
