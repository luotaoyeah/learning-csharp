using LuotaoYeah.Lib.Books.ICS7._12._02._01;
using Xunit;
using Xunit.Abstractions;

namespace LuotaoYeah.Test.Books.ICS7._12._02._01
{
    /// <summary>
    ///     12.2.1 the Flags attribute
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
            // [Flags] 不是非得添加, 但是添加之后会有额外的特性, 
            // 比如在转换为 string 类型时, 结果会不一样.
            //----------------------------------------------------------------------------------------------------
            Assert.Equal("3", (BitFlag01.A | BitFlag01.B).ToString());
            Assert.Equal("A, B", (BitFlag02.A | BitFlag02.B).ToString());
        }
    }
}
