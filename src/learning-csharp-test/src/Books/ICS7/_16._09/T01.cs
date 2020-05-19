using LuotaoYeah.Lib.Books.ICS7._16._09;
using Xunit;
using Xunit.Abstractions;

namespace LuotaoYeah.Test.Books.ICS7._16._09
{
    /// <summary>
    ///     16.9 an inherited member as an implementation
    /// </summary>
    public class T01
    {
        private readonly ITestOutputHelper testOutputHelper;

        public T01(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        /// <summary>
        /// </summary>
        [Fact]
        public void _01()
        {
            Assert.Equal(6, new MyClass().F01());
        }
    }
}
