using System.Linq;
using Xunit;
using Xunit.Abstractions;

namespace Luotao.Test.Books.ICS7._20._06._01
{
    /// <summary>
    ///     20.6.1 signatures of the standard query operators
    /// </summary>
    public class T01
    {
        private readonly ITestOutputHelper testOutputHelper;

        public T01(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        /// <summary>
        ///     standard query operators 都是一些 extension methods，
        ///     extension method 可以当初普通方法来调用，
        /// </summary>
        [Fact]
        public void _01()
        {
            int[] arr01 = { 2, 4, 6, 8 };

            var sum01 = arr01.Sum();
            Assert.Equal(20, sum01);

            var sum02 = arr01.Sum();
            Assert.Equal(20, sum02);
        }
    }
}
