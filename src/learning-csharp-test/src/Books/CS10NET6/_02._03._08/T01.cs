using Microsoft.CSharp.RuntimeBinder;

namespace Luotao.Test.Books.CS10NET6._02._03._08
{
    /// <summary>
    /// 2.3.8. storing dynamic types
    /// </summary>
    public class T01
    {
        private readonly ITestOutputHelper testOutputHelper;

        public T01(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        /// <summary>
        /// dynamic 类似于 typescript 中的 any 类型, 不会在编译时检查类型, 而是在运行时检查类型,
        /// 如果运行时检查到类型有错误, 会抛出异常.
        /// </summary>
        [Fact]
        public void _01()
        {
            Assert.Throws<RuntimeBinderException>(
                () =>
                {
                    dynamic something = "luotao";
                    something = 9;
                    something = false;

                    testOutputHelper.WriteLine($"length is {something.Length}");
                }
            );
        }
    }
}
