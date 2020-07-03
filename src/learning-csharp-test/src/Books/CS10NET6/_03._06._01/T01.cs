namespace Luotao.Test.Books.CS10NET6._03._06._01
{
    /// <summary>
    /// 3.6.1 checking for overflow
    /// </summary>
    public class T01
    {
        private readonly ITestOutputHelper testOutputHelper;

        public T01(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        /// <summary>
        /// 发生溢出时, 默认不会抛出异常, 而是得到一个错误的结果,
        /// 可以使用 checked 包裹, 表示在溢出时抛出一个异常.
        /// </summary>
        [Fact]
        public void _01()
        {
            {
                var i01 = int.MaxValue - 1;
                i01++;
                i01++;

                Assert.Equal(-2147483648, i01);
            }

            Assert.Throws<OverflowException>(
                () =>
                {
                    checked
                    {
                        var i02 = int.MaxValue - 1;
                        i02++;
                        i02++;
                    }
                }
            );
        }
    }
}
