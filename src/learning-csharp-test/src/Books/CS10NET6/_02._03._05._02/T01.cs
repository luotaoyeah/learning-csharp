namespace Luotao.Test.Books.CS10NET6._02._03._05._02
{
    /// <summary>
    /// 2.3.5.2. comparing double and decimal types
    /// </summary>
    public class T01
    {
        private readonly ITestOutputHelper testOutputHelper;

        public T01(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        /// <summary>
        /// 浮点数使用了 IEEE-754 标准, 因此无法精确表示所有的浮点数, 比如 double 类型,
        /// 但是 decimal 类型可以精确表示浮点数, 因为 decimal 实际上存储的是整数, 然后记录了小数点需要左移或者右移的位数.
        /// </summary>
        [Fact]
        public void _01()
        {
            double d01 = 0.1D;
            double d02 = 0.2D;
            Assert.NotEqual(0.3, d01 + d02);

            decimal dec01 = 0.1M;
            decimal dec02 = 0.2M;
            Assert.Equal(0.3M, dec01 + dec02);
        }
    }
}
