using Xunit;
using Xunit.Abstractions;

namespace LT.TEST.BOOK.ICS7._13._07._05
{
    /// <summary>
    /// 13.7.5 implicitly typed arrays
    /// </summary>
    public class T01
    {
        private readonly ITestOutputHelper testOutputHelper;

        public T01(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        /// <summary>
        /// 使用 var 声明一个 array，
        /// creation expression 中的 type 可以省略，但是 new 和 rank 不能省略，
        /// </summary>
        [Fact]
        public void _01()
        {
            var arr01 = new[,] { { 1, 2 }, { 3, 4 } };
        }
    }
}
