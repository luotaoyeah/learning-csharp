using LT.LIB.BOOK.ICS7._14._13;
using Xunit;
using Xunit.Abstractions;

namespace LT.TEST.BOOK.ICS7._14._13
{
    /// <summary>
    /// 14.13 anonymous methods
    /// </summary>
    public class T01
    {
        private readonly ITestOutputHelper testOutputHelper;

        public T01(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        /// <summary>
        /// delegate 的 invocation list 中的 method 可以是 anonymous method
        /// </summary>
        [Fact]
        public void _01()
        {
            OtherDel delegate01 = delegate(int x) { return x + 20; };
            Assert.Equal(25, delegate01(5));

            delegate01 += delegate(int i) { return i * 2; };
            Assert.Equal(10, delegate01(5));
        }
    }
}
