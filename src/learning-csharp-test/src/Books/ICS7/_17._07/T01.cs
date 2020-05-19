using Xunit;
using Xunit.Abstractions;

namespace Luotao.Test.Books.ICS7._17._07
{
    /// <summary>
    ///     17.7 boxing conversions
    /// </summary>
    public class T01
    {
        private readonly ITestOutputHelper testOutputHelper;

        public T01(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        /// <summary>
        ///     boxing（装箱）是将 value type 隐式转换为 reference type
        /// </summary>
        [Fact]
        public void _01()
        {
            var i01 = 10;

            // boxing
            object obj01 = i01;
            Assert.Equal(10, obj01);
        }
    }
}
