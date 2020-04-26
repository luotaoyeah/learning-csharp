using LT.BOOK.ICS7._14._13._02._02;
using Xunit;
using Xunit.Abstractions;

namespace LT.TEST.BOOK.ICS7._14._13._02._02
{
    /// <summary>
    /// 14.13.2.2 parameters
    /// </summary>
    public class T01
    {
        private readonly ITestOutputHelper testOutputHelper;

        public T01(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }


        /// <summary>
        /// 如果没有 out parameter，并且 anonymous method 中没有使用任何一个 parameter，则 parameter list 可以省略，
        /// </summary>
        [Fact]
        public void _01()
        {
            SomeDel someDel = delegate { return 6; };
            Assert.Equal(6, someDel(0));
        }
    }
}
