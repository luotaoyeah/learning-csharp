using LT.BOOK.ICS7._14._13._02._03;
using Xunit;
using Xunit.Abstractions;

namespace LT.TEST.BOOK.ICS7._14._13._02._03
{
    /// <summary>
    /// 14.13.2.3 the params parameters
    /// </summary>
    public class T01
    {
        private readonly ITestOutputHelper testOutputHelper;

        public T01(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }


        /// <summary>
        /// 如果 delegate 的类型声明中包含 params parameter，
        /// 则 anonymous method 的参数列表中，需要省略 params 关键字，直接将 params parameter 声明成一个 array 参数，
        /// </summary>
        [Fact]
        public void _01()
        {
            SomeDel someDel = delegate(int x, int[] y) { return x + y[0]; };
            Assert.Equal(3, someDel(1, 2));
        }
    }
}
