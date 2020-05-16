using System;
using Xunit;
using Xunit.Abstractions;

namespace LT.TEST.BOOK.C9N5._06._04._04
{
    /// <summary>
    ///     6.4.4 defining interfaces with default implementations
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
            var boy = new Boy();
            boy.Run();

            var girl = new Girl();
            girl.Run();
            girl.Sing();
        }
    }

    public interface IPerson
    {
        void Run();

        /// <summary>
        ///     接口中的方法可以定义默认的实现,
        ///     这样一来, 实现该接口的类就可以不用实现该方法,
        ///     但是实现该接口的类也就不能访问该方法.
        /// </summary>
        void Sing()
        {
            Console.WriteLine("singing");
        }
    }

    public class Boy : IPerson
    {
        public void Run()
        {
            Console.WriteLine("boy running");
        }
    }

    public class Girl : IPerson
    {
        public void Sing()
        {
            Console.WriteLine("girl singing");
        }

        public void Run()
        {
            Console.WriteLine("girl running");
        }
    }
}
