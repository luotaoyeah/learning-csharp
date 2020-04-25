using LT.BOOK.ICS7._08._04;
using Xunit;

namespace LT.TEST.BOOK.ICS7._08._04
{
    public class C01
    {
        [Fact]
        public void _01()
        {
            var c02 = new C02();
            Assert.Equal("8", C02.I01);
            Assert.Equal(3, c02.Fn01(1));
        }
    }
}
