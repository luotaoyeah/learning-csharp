namespace Luotao.Test.Books.ICS7._20._06
{
    /// <summary>
    ///     20.6 the standard query operators
    /// </summary>
    public class T01
    {
        private readonly ITestOutputHelper testOutputHelper;

        public T01(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        /// <summary>
        ///     除了 query syntax 之外, 还可以使用 method syntax,
        ///     method syntax 就是调用一些列的方法, 这些方法称之为 standard query operators,
        /// </summary>
        [Fact]
        public void _01()
        {
            int[] arr01 = { 2, 4, 6, 8 };

            var sum = arr01.Sum();
            Assert.Equal(20, sum);

            var count = arr01.Count();
            Assert.Equal(4, count);
        }
    }
}
