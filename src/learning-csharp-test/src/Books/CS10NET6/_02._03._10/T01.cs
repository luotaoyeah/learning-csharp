namespace Luotao.Test.Books.CS10NET6._02._03._10
{
    /// <summary>
    /// 2.3.10. getting default values for types
    /// </summary>
    public class T01
    {
        private readonly ITestOutputHelper testOutputHelper;

        public T01(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        /// <summary>
        /// 使用 default() 这个 operator 获取某个类型的默认值.
        /// </summary>
        [Fact]
        public void _01()
        {
            Assert.Equal(0, default(int));
            Assert.Equal(0D, default(double));

            // bool 类型的默认值为 false.
            Assert.False(default(bool));

            // reference 类型的默认值都是 null
            Assert.Null(default(string));

            //----------------------------------------------------------------------------------------------------
            // DateTime 类型的默认值如下
            //----------------------------------------------------------------------------------------------------
            Assert.Equal("0001-01-01 00:00:00", default(DateTime).ToString("yyyy-MM-dd HH:mm:ss"));
        }

        /// <summary>
        /// 如果可以推断 default() 中的类型, 则可以省略类型, 直接写作 default.
        /// </summary>
        [Fact]
        public void _02()
        {
            Assert.Equal(0, default);
            Assert.Equal(0, default(int));

            Assert.False(default);
            Assert.False(default(bool));

            double d01 = 1D;
            Assert.Equal(1D, d01);
            d01 = default;
            Assert.Equal(0D, d01);
        }
    }
}
