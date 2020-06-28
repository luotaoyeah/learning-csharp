using Xunit;
using Xunit.Abstractions;

namespace Luotao.Test.Books.CS10NET6._02._03._02._01
{
    /// <summary>
    ///     2.3.2.1 understanding verbatim strings
    /// </summary>
    public class T01
    {
        private readonly ITestOutputHelper testOutputHelper;

        public T01(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        /// <summary>
        ///     string literal 前面加上 @ 表示它是一个 verbatim string，
        ///     里面的转义字符不会转义，所有字符都会原样打印，
        /// </summary>
        [Fact]
        public void _01()
        {
            testOutputHelper.WriteLine("_\t_1_\\_2_\x0065_3_"); // _	_1_\_2_e_3_
            testOutputHelper.WriteLine(@"_\t_1_\\_2_\x0065_3_"); // _\t_1_\\_2_\x0065_3_
        }

        /// <summary>
        ///     例外1："" 会被解析为 "
        /// </summary>
        [Fact]
        public void _02()
        {
            testOutputHelper.WriteLine(@"_""_"); // _"_
        }

        /// <summary>
        ///     例外2：如果 verbatim string 又是一个 interpolated string，则 `{{` 会被解析为 `{`，`}}` 会被解析为 `}`，
        /// </summary>
        [Fact]
        public void _03()
        {
            testOutputHelper.WriteLine(@"_{1}_"); // _{1}_
        }
    }
}
