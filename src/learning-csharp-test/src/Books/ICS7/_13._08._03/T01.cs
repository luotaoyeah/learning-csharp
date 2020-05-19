using Xunit;
using Xunit.Abstractions;

namespace Luotao.Test.Books.ICS7._13._08._03
{
    /// <summary>
    ///     13.8.3 instantiating a jagged array
    /// </summary>
    public class T01
    {
        private readonly ITestOutputHelper testOutputHelper;

        public T01(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        /// <summary>
        ///     jagged array 中每一个 element 是长度不同的 array，
        ///     可以把 jagged array 当成是 array of array
        /// </summary>
        [Fact]
        public void _01()
        {
            int[][] arr01 = new int[2][];

            arr01[0] = new int[3];
            arr01[1] = new int[4];

            //----------------------------------------------------------------------------------------------------
            // 在计算 jagged array 的 rank/length 时，只计算第一维的 rank/length
            //----------------------------------------------------------------------------------------------------
            Assert.Equal(1, arr01.Rank);
            Assert.Equal(2, arr01.Length);
        }
    }
}
