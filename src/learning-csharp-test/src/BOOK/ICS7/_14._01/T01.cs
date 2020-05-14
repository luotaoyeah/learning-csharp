using LT.LIB.BOOK.ICS7._14._01;
using Xunit;
using Xunit.Abstractions;

namespace LT.TEST.BOOK.ICS7._14._01
{
    /// <summary>
    /// 14.1 what is a delegate?
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
            MyDel printDelegate = C01.PrintDelegate(49);
            Assert.Equal("LOW", printDelegate());

            printDelegate = C01.PrintDelegate(51);
            Assert.Equal("HIGH", printDelegate());
        }
    }
}
