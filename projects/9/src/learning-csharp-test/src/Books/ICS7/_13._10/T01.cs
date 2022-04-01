namespace Luotao.Test.Books.ICS7._13._10
{
    /// <summary>
    ///     13.10 the foreach statement
    /// </summary>
    public class T01
    {
        private readonly ITestOutputHelper testOutputHelper;

        public T01(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        /// <summary>
        ///     使用 foreach 语句来遍历一个 array 的所有 element
        /// </summary>
        [Fact]
        public void _01()
        {
            int[] arr01 = { 1, 2, 3 };

            foreach (var i in arr01) testOutputHelper.WriteLine($"{i}");
        }
    }
}
