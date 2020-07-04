using System.Diagnostics;

namespace Luotao.Test.Books.CS10NET6._04._03._02._01
{
    /// <summary>
    /// 4.3.2.1. writing to the default trace listener
    /// </summary>
    public class T01
    {
        private readonly ITestOutputHelper testOutputHelper;

        public T01(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        /// <summary>
        /// Debug.WriteLine() 和 Trace.WriteLine() 默认会输出到 DefaultTraceListener.
        /// </summary>
        [Fact]
        public void _01()
        {
            // 会在 Debug 配置时输出到 "Console" 窗口
            Console.WriteLine("CONSOLE");

            // 会在 Debug 配置时输出到 "Debug Output" 窗口
            Debug.WriteLine("DEBUG");

            // 会在 Debug/Release 配置时输出到 "Debug Output" 窗口
            Trace.WriteLine("TRACE");
        }
    }
}
