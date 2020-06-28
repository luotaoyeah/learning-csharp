using Luotao.Lib.Books.CS10NET6._02._03._08._02;
using Xunit;
using Xunit.Abstractions;

namespace Luotao.Test.Books.CS10NET6._02._03._08._02
{
    /// <summary>
    ///     2.3.8.2 using target-typed new to instantiate objects
    /// </summary>
    public class T01
    {
        private readonly ITestOutputHelper testOutputHelper;

        public T01(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        /// <summary>
        ///     target-typed new 是 C# 9 中的一个新的语法，
        ///     在使用 new 创建对象实例时，如果变量前面声明了类型，则可以省略 new 后面的类型，直接写作 new();
        /// </summary>
        [Fact]
        public void _01()
        {
            var xmlDocument01 = new XmlDocument();

            XmlDocument xmlDocument02 = new();
        }
    }
}
