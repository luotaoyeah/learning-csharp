using Xunit;
using Xunit.Abstractions;

namespace LuotaoYeah.Test.Books.ICS7._17._10
{
    /// <summary>
    ///     17.10 the is operator
    /// </summary>
    public class T01
    {
        private readonly ITestOutputHelper testOutputHelper;

        public T01(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        /// <summary>
        ///     <code>x is T</code> 返回 true/false，表示判断 x 是否可以成功转换为类型 T，
        ///     允许的转换方式包括 reference conversion，boxing，unboxing
        /// </summary>
        [Fact]
        public void _01()
        {
        }
    }
}
