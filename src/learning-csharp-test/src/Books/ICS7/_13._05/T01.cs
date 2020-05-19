using Xunit;
using Xunit.Abstractions;

namespace LuotaoYeah.Test.Books.ICS7._13._05
{
    /// <summary>
    ///     13.5 instantiating a one-dimensional or rectangular array
    /// </summary>
    public class T01
    {
        private readonly ITestOutputHelper testOutputHelper;

        public T01(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        [Fact]
        public void _01()
        {
            //----------------------------------------------------------------------------------------------------
            // 声明 array 的时候，类型中只指定了 rank/dimension，没有指定每一个 dimension 的 length，
            // dimension length 是在实例化 array 对象的时候指定的，
            // 使用 new 创建一个 array 实例对象，注意末尾没有圆括号，
            //----------------------------------------------------------------------------------------------------
            int[,,] arr01 = new int[2, 3, 4];
            Assert.Equal(3, arr01.Rank);
            Assert.Equal(2 * 3 * 4, arr01.Length);
        }
    }
}
