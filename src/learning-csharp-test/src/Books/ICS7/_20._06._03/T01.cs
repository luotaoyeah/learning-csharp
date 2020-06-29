namespace Luotao.Test.Books.ICS7._20._06._03
{
    /// <summary>
    ///     20.6.3 delegates as parameters
    /// </summary>
    public class T01
    {
        private readonly ITestOutputHelper testOutputHelper;

        public T01(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        /// <summary>
        ///     很多 standard query operators 支持额外的参数，通常是一个 delegate 类型的参数，
        /// </summary>
        [Fact]
        public void _01()
        {
            int[] arr01 = { 3, 4, 5, 6, 7, 9 };
            var count = arr01.Count(n => n % 2 == 1);
            Assert.Equal(4, count);
        }
    }
}
