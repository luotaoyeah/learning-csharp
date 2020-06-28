using Xunit;
using Xunit.Abstractions;

namespace Luotao.Test.Books.CS10NET6._03._02._03
{
    /// <summary>
    ///     3.2.3 pattern matching with the if statement
    /// </summary>
    public class T01
    {
        private readonly ITestOutputHelper testOutputHelper;

        public T01(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        /// <summary>
        ///     if 的条件中可以使用模式匹配(pattern matching)
        /// </summary>
        [Fact]
        public void _01()
        {
            object i = 3;

            // 如果 i 可以转换为 int 类型, 则将转换结果存到变量 j 中
            if (i is int j)
                testOutputHelper.WriteLine("YES:{0}", j);
            else
                testOutputHelper.WriteLine("NO");
        }
    }
}
