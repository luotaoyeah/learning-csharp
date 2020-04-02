using LT.BOOK.ICS7.C03.C0307;
using Xunit;

namespace LT.TEST.BOOK.ICS7.C03.C0307
{
    public class C030703Test
    {
        [Fact]
        public void Fn01()
        {
            C030703.Fn01();
        }

        [Fact]
        public void Fn02()
        {
            Assert.Equal("1 + 2 = 3", C030703.Fn02());
        }
    }
}
