using Xunit;
using Xunit.Abstractions;

namespace Luotao.Test.Books.C9N5._04._01._05
{
    /// <summary>
    ///     4.1.5 using lambdas in function implementations
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
            for (var i = 1; i < 10; i++) testOutputHelper.WriteLine(Fibonacci01(i).ToString());
        }

        [Fact]
        public void _02()
        {
            for (var i = 1; i < 10; i++) testOutputHelper.WriteLine(Fibonacci02(i).ToString());
        }

        /// <summary>
        ///     使用 lambda 的形式定义一个 function.
        /// </summary>
        /// <param name="value">数值.</param>
        /// <returns></returns>
        private static int Fibonacci01(int value)
        {
            return value switch
            {
                1 => 0,
                2 => 1,
                _ => Fibonacci01(value - 1) + Fibonacci01(value - 2)
            };
        }

        private static int Fibonacci02(int value)
        {
            return value switch
            {
                1 => 0,
                2 => 1,
                _ => Fibonacci02(value - 1) + Fibonacci02(value - 2)
            };
        }
    }
}
