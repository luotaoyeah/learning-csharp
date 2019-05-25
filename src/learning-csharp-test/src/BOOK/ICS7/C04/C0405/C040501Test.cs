using LT.BOOK.ICS7.C04.C0405;
using Xunit;

namespace LT.TEST.BOOK.ICS7.C04.C0405
{
    public class C040501Test
    {
        [Fact]
        public void Fn01()
        {
            Assert.True(C040501.Fn01());
        }

        [Fact]
        public void Fn02()
        {
            Assert.Equal("FOOBAR", C040501.Fn02());
        }
    }
}