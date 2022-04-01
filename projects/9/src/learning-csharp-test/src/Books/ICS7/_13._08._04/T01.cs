namespace Luotao.Test.Books.ICS7._13._08._04
{
    /// <summary>
    ///     13.8.4 subarrays in jagged arrays
    /// </summary>
    public class T01
    {
        private readonly ITestOutputHelper testOutputHelper;

        public T01(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        /// <summary>
        ///     jagged array 的每一个 element 可以是不同的 rectangular array
        /// </summary>
        [Fact]
        public void _01()
        {
            int[][,] arr01 = new int[3][,];
            arr01[0] = new int[2, 2] { { 1, 2 }, { 3, 4 } };
            arr01[1] = new int [3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            Assert.Equal(3, arr01[0][1, 0]);
            Assert.Equal(8, arr01[1][2, 1]);

            Assert.Equal(1, arr01.Rank);
            Assert.Equal(3, arr01.Length);
        }
    }
}
