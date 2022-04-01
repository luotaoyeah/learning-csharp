namespace Luotao.Test.Books.CS10NET6._03._04._02
{
    /// <summary>
    /// 3.4.2. converting with the System.Convert type
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
            // () 称为 casting operator
            // 使用 (type) 的方式显式转换类型, 会直接丢弃小数部分
            double d01 = 9.9;
            int i01 = (int)d01;
            Assert.Equal(9, i01);

            // 使用 System.Convert 中的方法来转换类型, 会进行四舍五入
            double d02 = 9.9;
            int i02 = Convert.ToInt32(d02);
            Assert.Equal(10, i02);
        }
    }
}
