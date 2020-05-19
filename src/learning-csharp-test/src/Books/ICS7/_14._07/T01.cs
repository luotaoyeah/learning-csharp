using Luotao.Lib.Books.ICS7._14._07;
using Xunit;
using Xunit.Abstractions;

namespace Luotao.Test.Books.ICS7._14._07
{
    /// <summary>
    ///     14.7 adding methods to delegates
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
        ///     使用 += 往 delegate 对象中添加新的 method，同一个 method 可以被添加多次，
        /// </summary>
        [Fact]
        public void _01()
        {
            var delegate01 = new MyDelegate(F01);
            delegate01 += F02;
            delegate01 += F01;

            delegate01();
        }
    }
}
