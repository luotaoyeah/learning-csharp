using System;
using System.Diagnostics;
using System.Threading;
using Xunit;
using Xunit.Abstractions;

namespace LuotaoYeah.Test.Books.C9N5._13._03._01
{
    /// <summary>
    ///     13.3.1 running multiple actions synchronously
    /// </summary>
    public class T01
    {
        private readonly ITestOutputHelper testOutputHelper;

        public T01(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        [Fact]
        public void _01()
        {
            var stopwatch = Stopwatch.StartNew();
            C01.F01();
            C01.F02();
            C01.F03();
            Console.WriteLine($"TIME: {stopwatch.ElapsedMilliseconds}ms");
        }
    }

    public class C01
    {
        public static void F01()
        {
            Console.WriteLine("starting F01");
            Thread.Sleep(3000);
            Console.WriteLine("finished F01");
        }

        public static void F02()
        {
            Console.WriteLine("starting F02");
            Thread.Sleep(2000);
            Console.WriteLine("finished F02");
        }

        public static void F03()
        {
            Console.WriteLine("starting F03");
            Thread.Sleep(1000);
            Console.WriteLine("finished F03");
        }
    }
}
