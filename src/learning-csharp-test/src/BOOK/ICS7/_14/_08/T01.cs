using LT.BOOK.ICS7._14._08;
using Xunit;
using Xunit.Abstractions;

namespace LT.TEST.BOOK.ICS7._14._08
{
    /// <summary>
    /// 14.8 removing methods from a delegate
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
        /// 使用 -= 从 delegate 对象中删除 method，
        /// 从 invocation list 的最后面开始删除，如果同一个方法存在多次，则每次只会删除一次，
        /// </summary>
        [Fact]
        public void _01()
        {
            var delegate01 = new MyDelegate(F01);
            delegate01 += F02;
            delegate01 += F01;
            delegate01();

            testOutputHelper.WriteLine("----------");

            delegate01 -= F01;
            delegate01();
        }
    }
}
