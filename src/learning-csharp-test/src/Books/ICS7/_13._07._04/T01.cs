using Xunit;
using Xunit.Abstractions;

namespace Luotao.Test.Books.ICS7._13._07._04
{
    /// <summary>
    ///     13.7.4 shortcut syntax
    /// </summary>
    public class T01
    {
        private readonly ITestOutputHelper testOutputHelper;

        public T01(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        /// <summary>
        ///     省略 creation expression
        /// </summary>
        [Fact]
        public void _01()
        {
            int[,] arr01 = { { 1, 2 }, { 3, 4 } };
            int[,] arr02 = { { 1, 2 }, { 3, 4 } };

            Assert.Equal(arr01[0, 0], arr02[0, 0]);
            Assert.Equal(arr01[1, 1], arr02[1, 1]);
        }
    }
}
