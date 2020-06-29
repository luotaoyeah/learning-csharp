namespace Luotao.Test.Books.CS10NET6._02._03._03._04
{
    /// <summary>
    ///     2.3.3.4 comparing double and decimal types
    /// </summary>
    public class T01
    {
        private readonly ITestOutputHelper testOutputHelper;

        public T01(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        /// <summary>
        ///     浮点数使用了 IEEE-754 标准，因此无法精确表示所有的浮点数，比如 double 类型，
        ///     但是 decimal 类型可以精确表示浮点数，因为 decimal 实际上存储的是整数，以及小数点需要左移/右移的位数，
        /// </summary>
        [Fact]
        public void _01()
        {
            var d01 = 0.1;
            var d02 = 0.2;
            Assert.NotEqual(0.3, d01 + d02);

            var dec01 = 0.1M;
            var dec02 = 0.2M;
            Assert.Equal(0.3M, dec01 + dec02);
        }
    }
}
