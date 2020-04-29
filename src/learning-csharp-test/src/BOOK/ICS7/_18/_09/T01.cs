using LT.BOOK.ICS7._18._09;
using Xunit;
using Xunit.Abstractions;

namespace LT.TEST.BOOK.ICS7._18._09
{
    /// <summary>
    /// 18.9 generic interfaces
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
            var simple = new Simple<int, string>();
            Assert.Equal("0", simple.ReturnIt("0"));
        }
    }
}
