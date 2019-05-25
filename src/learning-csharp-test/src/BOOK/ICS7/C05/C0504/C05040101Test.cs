using LT.BOOK.ICS7.C05.C0504;
using Xunit;

namespace LT.TEST.BOOK.ICS7.C05.C0504
{
    public class C05040101Test
    {
        [Fact]
        public void Fn01()
        {
            C05040101 c05040101 = new C05040101();

            Assert.Equal(0, c05040101.I01);
            Assert.Null(c05040101.S01);
            Assert.True(c05040101.B01);
            Assert.Equal(0.01, c05040101.D01);
        }
    }
}