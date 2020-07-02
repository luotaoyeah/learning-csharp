namespace Luotao.Test.Books.CS10NET6._03._04._01
{
    /// <summary>
    /// 3.4.1. casting numbers implicitly and explicitly
    /// </summary>
    public class T01
    {
        private readonly ITestOutputHelper testOutputHelper;

        public T01(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        /// <summary>
        ///
        /// </summary>
        [Fact]
        public void _01()
        {
            // 可以将 int 隐式转换为 double
            int i01 = 1;
            double d01 = i01;
            Assert.Equal(1D, d01);

            // 必须将 double 显式转换为 int, 因为转换之后可能会丢失数据
            double d02 = 1;
            int i02 = (int)d02;
            Assert.Equal(1, i02);
        }
    }
}
