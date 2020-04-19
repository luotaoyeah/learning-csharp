using LT.BOOK.ICS7._11._04._01;
using Xunit;
using Xunit.Abstractions;

namespace LT.TEST.BOOK.ICS7._11._04._01
{
    /// <summary>
    /// 11.4.1 instance constructors
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
            var simple01 = new Simple();
            Assert.Equal(0, simple01.X);
            Assert.Equal(0, simple01.Y);

            var simple02 = new Simple(1, 2);
            Assert.Equal(1, simple02.X);
            Assert.Equal(2, simple02.Y);
        }
    }
}
