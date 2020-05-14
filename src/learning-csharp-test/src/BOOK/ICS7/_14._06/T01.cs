using LT.LIB.BOOK.ICS7._14._06;
using Xunit;
using Xunit.Abstractions;

namespace LT.TEST.BOOK.ICS7._14._06
{
    /// <summary>
    /// 14.6 combining delegates
    /// </summary>
    public class T01
    {
        private readonly ITestOutputHelper testOutputHelper;

        public T01(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        private void F01()
        {
            testOutputHelper.WriteLine("01");
        }

        private void F02()
        {
            testOutputHelper.WriteLine("02");
        }

        /// <summary>
        /// 两个 delegate 相加的效果是：
        ///   新建一个新的 delegate，这个新的 delegate 的 invocation list 包含这两个 delegate 的 invocation list 中的所有方法，
        /// </summary>
        [Fact]
        public void _01()
        {
            var delegate01 = new MyDelegate(F01);
            var delegate02 = new MyDelegate(F02);
            var delegate03 = delegate01 + delegate02;
            delegate03();
        }
    }
}
