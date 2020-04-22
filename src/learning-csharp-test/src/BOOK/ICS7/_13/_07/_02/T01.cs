using Xunit;
using Xunit.Abstractions;

namespace LT.TEST.BOOK.ICS7._13._07._02
{
    /// <summary>
    /// 13.7.2 explicit initialization of rectangular arrays
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
            //----------------------------------------------------------------------------------------------------
            // 使用 initialization list 初始化一个 rectangular array，
            //----------------------------------------------------------------------------------------------------
            int[,] arr01 = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };
            Assert.Equal(1, arr01[0, 0]);
            Assert.Equal(5, arr01[1, 1]);
        }
    }
}
