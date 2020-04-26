using LT.BOOK.ICS7._16._07;
using Xunit;
using Xunit.Abstractions;

namespace LT.TEST.BOOK.ICS7._16._07
{
    /// <summary>
    /// 16.7 implementing interfaces with duplicate members
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
