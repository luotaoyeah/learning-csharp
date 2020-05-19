using LuotaoYeah.Lib.Books.ICS7._14._11;
using Xunit;
using Xunit.Abstractions;

namespace LuotaoYeah.Test.Books.ICS7._14._11
{
    /// <summary>
    ///     14.11 invoking delegates with return values
    /// </summary>
    public class T01
    {
        private readonly ITestOutputHelper testOutputHelper;

        public T01(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        private int F01()
        {
            return 1;
        }

        private int F02()
        {
            return 2;
        }

        /// <summary>
        ///     如果 delegate 的 return type 不是 void，则它的返回值为 invocation list 中最后一个 method 的返回值，
        ///     其他的 method 的返回值被忽略了，
        /// </summary>
        [Fact]
        public void _01()
        {
            var delegate01 = new MyDelegate(F01);
            delegate01 += F02;

            Assert.Equal(2, delegate01.Invoke());
        }
    }
}
