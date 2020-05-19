using Luotao.Lib.Books.ICS7._17._06._03;
using Xunit;
using Xunit.Abstractions;

namespace Luotao.Test.Books.ICS7._17._06._03
{
    /// <summary>
    ///     17.6.3 valid explicit reference conversions
    /// </summary>
    public class T01
    {
        private readonly ITestOutputHelper testOutputHelper;

        public T01(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        /// <summary>
        ///     如果父类变量为 null，则可以将他显式转换为子类，
        /// </summary>
        [Fact]
        public void _01()
        {
            A a = null;
            B b = (B) a;
        }

        /// <summary>
        ///     父类变量指向子类对象时，可以将该父类变量显式转换为子类，
        /// </summary>
        [Fact]
        public void _02()
        {
            B b01 = new();
            A a = b01;
            B b = (B) a;
        }
    }
}
