using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace LT.TEST.BOOK.C9N5._13._03._03
{
    /// <summary>
    ///     13.3.3 waiting for tasks
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

            var task01 = new Task(C01.F01);
            task01.Start();

            var task02 = Task.Factory.StartNew(C01.F02);
            var task03 = Task.Run(C01.F03);

            Task[] tasks = { task01, task02, task03 };
            Task.WaitAll(tasks);

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
