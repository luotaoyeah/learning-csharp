using Xunit;
using Xunit.Abstractions;

namespace Luotao.Test.Books.ICS7._13._10._02
{
    /// <summary>
    ///     13.10.2 the foreach statement with multidimensional arrays
    /// </summary>
    public class T01
    {
        private readonly ITestOutputHelper testOutputHelper;

        public T01(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        /// <summary>
        ///     使用 foreach 遍历 rectangular array，
        ///     先遍历第一行的所有列，再遍历第二行的所有列，
        /// </summary>
        [Fact]
        public void _01()
        {
            int[,] arr01 = { { 1, 2, 3 }, { 4, 5, 6 } };

            foreach (var i in arr01) testOutputHelper.WriteLine($"{i}");
        }

        /// <summary>
        ///     使用 foreach 遍历 jagged array，
        ///     遍历的只是第一维的（最外层的） array，内层的 array 需要再次使用 foreach 进行遍历，
        /// </summary>
        [Fact]
        public void _02()
        {
            int[][] arr01 = new int[2][];
            arr01[0] = new int[3] { 1, 2, 3 };
            arr01[1] = new int[3] { 4, 5, 6 };

            foreach (int[] ints in arr01)
            foreach (var i in ints)
                testOutputHelper.WriteLine($"{i}");
        }
    }
}
