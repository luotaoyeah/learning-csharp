using Xunit;
using Xunit.Abstractions;

namespace LuotaoYeah.Test.Books.C9N5._05._04._02
{
    /// <summary>
    ///     5.4.2 combining multiple returned values using tuples
    /// </summary>
    public class T01
    {
        private readonly ITestOutputHelper testOutputHelper;

        public T01(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        /// <summary>
        ///     使用 Item1, Item2, ... 访问 tuple 的各个元素/字段.
        /// </summary>
        [Fact]
        public void _01()
        {
            var fruit = C01.GetFruit();
            Assert.Equal("Apples", fruit.Item1);
            Assert.Equal(5, fruit.Item2);
        }
    }

    public class C01
    {
        /// <summary>
        ///     使用 tuple 类型, 让方法返回多个数据.
        /// </summary>
        /// <returns></returns>
        public static (string, int) GetFruit()
        {
            return ("Apples", 5);
        }
    }
}
