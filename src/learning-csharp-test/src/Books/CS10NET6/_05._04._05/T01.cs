using Xunit;
using Xunit.Abstractions;

namespace Luotao.Test.Books.CS10NET6._05._04._05
{
    /// <summary>
    ///     5.4.5 passing optional parameters and naming arguments
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
            Assert.Equal("Run, 0, True", C01.OptionalParameters());

            //----------------------------------------------------------------------------------------------------
            // 调用函数时, 可以使用 positional parameter, 即按照形参顺序传参,
            // 也可以使用 named parameter, 即指定参数名称, 这样就可以不理会形参顺序.
            //
            // 使用 named parameter 可以省略中间某个 optional parameter 并且传递后面某个 optional parameter,
            // 使用 positional parameter 则不行.
            //
            // positional parameter 和 named parameter 可以混用,
            // 此时 named parameter 必须位于所有的 posotional parameter 后面.
            //----------------------------------------------------------------------------------------------------
            Assert.Equal("Fly, 0, False", C01.OptionalParameters("Fly", active: false));
        }
    }

    public class C01
    {
        /// <summary>
        ///     所有的 optional parameter 必须位于所有的 non-optional parameter 后面.
        /// </summary>
        /// <param name="command"></param>
        /// <param name="number"></param>
        /// <param name="active"></param>
        /// <returns></returns>
        public static string OptionalParameters(string command = "Run", double number = 0.0, bool active = true)
        {
            return $"{command}, {number}, {active}";
        }
    }
}
