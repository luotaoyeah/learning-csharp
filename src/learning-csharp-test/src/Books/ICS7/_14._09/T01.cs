using LuotaoYeah.Lib.Books.ICS7._14._09;
using Xunit;
using Xunit.Abstractions;

namespace LuotaoYeah.Test.Books.ICS7._14._09
{
    /// <summary>
    ///     14.9 invoking a delegate
    /// </summary>
    public class T01
    {
        private readonly ITestOutputHelper testOutputHelper;

        public T01(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        private int F01(int x)
        {
            testOutputHelper.WriteLine(x.ToString());
            return x;
        }

        /// <summary>
        ///     可以直接像调用 method 一样调用一个 delegate，
        ///     或者使用 delegate 的 Invoke() 方法，
        /// </summary>
        [Fact]
        public void _01()
        {
            var delegate01 = new MyDelegate(F01);
            delegate01(1);

            delegate01?.Invoke(2);
        }
    }
}
