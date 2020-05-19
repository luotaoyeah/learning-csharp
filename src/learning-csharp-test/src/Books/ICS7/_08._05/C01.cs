using Luotao.Lib.Books.ICS7._08._05;
using Xunit;

namespace Luotao.Test.Books.ICS7._08._05
{
    public class C01
    {
        [Fact]
        public void _01()
        {
            var c02 = new C02();

            Assert.Equal(1, c02.Fn01());
            Assert.Equal(2, c02.Fn02());
        }
    }
}
