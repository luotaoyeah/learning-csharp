namespace Luotao.Test.Books.CS10NET6._02._03._03._01
{
    /// <summary>
    /// 2.3.3.1. understanding verbatim strings
    /// </summary>
    public class T01
    {
        private readonly ITestOutputHelper testOutputHelper;

        public T01(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        /// <summary>
        /// string literal 前面加上 @ 表示它是一个 verbatim string,
        /// verbatim string 中的转义字符不会被转义, 所有字符都会原样打印.
        /// </summary>
        [Fact]
        public void _01()
        {
            testOutputHelper.WriteLine("_\t_1_\\_2_\x0065_3_"); // _	_1_\_2_e_3_
            testOutputHelper.WriteLine(@"_\t_1_\\_2_\x0065_3_"); // _\t_1_\\_2_\x0065_3_
        }

        /// <summary>
        /// verbatim string 可以跨越多行.
        /// </summary>
        [Fact]
        public void _02()
        {
            testOutputHelper.WriteLine(
                @"
1
2
3
                "
            );
        }

        /// <summary>
        /// 例外1："" 会被解析为 "
        /// </summary>
        [Fact]
        public void _03()
        {
            testOutputHelper.WriteLine(@"_""_"); // _"_
        }
    }
}
