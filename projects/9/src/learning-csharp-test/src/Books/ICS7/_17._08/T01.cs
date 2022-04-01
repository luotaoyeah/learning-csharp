namespace Luotao.Test.Books.ICS7._17._08
{
    /// <summary>
    ///     17.8 unboxing conversions
    /// </summary>
    public class T01
    {
        private readonly ITestOutputHelper testOutputHelper;

        public T01(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        /// <summary>
        ///     unboxing（拆箱）是将 reference 显式转换为 value type
        /// </summary>
        [Fact]
        public void _01()
        {
            var i01 = 10;

            // boxing
            object obj01 = i01;
            Assert.Equal(10, obj01);

            // unboxing
            var i02 = (int)obj01;
            Assert.Equal(10, i02);
        }
    }
}
