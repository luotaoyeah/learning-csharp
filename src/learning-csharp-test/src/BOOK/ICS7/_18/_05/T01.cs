using LT.LIB.BOOK.ICS7._18._05;
using Xunit;
using Xunit.Abstractions;

namespace LT.TEST.BOOK.ICS7._18._05
{
    /// <summary>
    /// 18.5 generic methods
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
            Assert.Equal(1, C01.F01<int>(1, 1));
            Assert.Equal(2.2, C01.F01<double>(1.1, 2.2));
        }
    }
}
