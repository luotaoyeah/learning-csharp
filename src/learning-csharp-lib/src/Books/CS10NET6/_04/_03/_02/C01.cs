using System;
using System.Diagnostics;

namespace Luotao.Lib.Books.CS10NET6._04._03._02
{
    /// <summary>
    ///     4.3.2 writing to the default trace listener
    /// </summary>
    public class C01
    {
        /// <summary>
        ///     <see cref="Debug.WriteLine(string)" /> 和 <see cref="Trace.WriteLine(string)" /> 默认会输出到
        ///     <see cref="DefaultTraceListener" />,
        ///     也就是 rider 调试时的 "Debug Output" 窗口,
        ///     Debug 信息只会在 Debug 配置时输出,
        ///     Trace 信息会在 Debug/Release 配置时输出.
        /// </summary>
        public static void F01()
        {
            Console.WriteLine("CONSOLE...");
            Debug.WriteLine("DEBUG...");
            Trace.WriteLine("TRACE...");
        }
    }
}
