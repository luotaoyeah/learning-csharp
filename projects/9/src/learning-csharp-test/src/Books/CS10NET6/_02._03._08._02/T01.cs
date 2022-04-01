using Luotao.Lib.Books.CS10NET6._02;

namespace Luotao.Test.Books.CS10NET6._02._03._08._02
{
    /// <summary>
    /// 2.3.9.3. using target-typed new to instantiate objects
    /// </summary>
    public class T01
    {
        private readonly ITestOutputHelper testOutputHelper;

        public T01(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        /// <summary>
        /// target-typed new 是 C# 9 中的一个新的语法,
        /// 使用 new 调用构造函数创建实例对象时, 如果可以推断类型, 则可以省略 new 后面的类名, 直接写作 new()
        /// </summary>
        [Fact]
        public void _01()
        {
            // 无法推断类型, 不能省略类名
            var xmlDocument01 = new XmlDocument();

            // 可以推断类型, 可以省略类名
            XmlDocument xmlDocument02 = new();
        }
    }
}
