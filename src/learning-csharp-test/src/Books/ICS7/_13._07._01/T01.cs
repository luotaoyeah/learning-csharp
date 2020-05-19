using Xunit;
using Xunit.Abstractions;

namespace LuotaoYeah.Test.Books.ICS7._13._07._01
{
    /// <summary>
    ///     13.7.1 explicit initialization of one-dimensional arrays
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
            // 使用 initialization list 初始化一个 array，
            //----------------------------------------------------------------------------------------------------
            int[] arr01 = new int[3] { 1, 2, 3 };
            Assert.Equal(1, arr01[0]);
            Assert.Equal(2, arr01[1]);
            Assert.Equal(3, arr01[2]);
        }

        [Fact]
        public void _02()
        {
            //----------------------------------------------------------------------------------------------------
            // dimension length 可以省略，因为可以从 initialization list 中元素的个数来推断，
            //----------------------------------------------------------------------------------------------------
            int[] arr01 = { 1, 2, 3 };
            Assert.Equal(1, arr01[0]);
            Assert.Equal(2, arr01[1]);
            Assert.Equal(3, arr01[2]);
        }
    }
}
