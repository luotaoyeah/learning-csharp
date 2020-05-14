using LT.LIB.BOOK.ICS7._18._09._01;
using Xunit;
using Xunit.Abstractions;

namespace LT.TEST.BOOK.ICS7._18._09._01
{
    /// <summary>
    /// 18.9.1 an example using generic interfaces
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
            var simple = new Simple();
            Assert.Equal(1, simple.ReturnIt(1));
            Assert.Equal("1", simple.ReturnIt("1"));
        }
    }
}
