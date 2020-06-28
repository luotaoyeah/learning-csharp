using System;
using Xunit;
using Xunit.Abstractions;

namespace Luotao.Test.Books.CS10NET6._03._04._08
{
    /// <summary>
    ///     3.4.8 checking for overflow
    /// </summary>
    public class T01
    {
        private readonly ITestOutputHelper testOutputHelper;

        public T01(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        /// <summary>
        ///     发生溢出时, 默认行为是得到一个错误的结果,
        ///     而 checked 表示在溢出时抛出一个异常.
        /// </summary>
        [Fact]
        public void _01()
        {
            var i01 = int.MaxValue - 1;
            i01++;
            i01++;

            Assert.Equal(-2147483648, i01);

            Assert.Throws<OverflowException>(F01);
        }

        private void F01()
        {
            checked
            {
                var i01 = int.MaxValue - 1;
                i01++;
                i01++;
            }
        }
    }
}
