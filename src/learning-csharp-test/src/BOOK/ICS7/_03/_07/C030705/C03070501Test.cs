using LT.BOOK.ICS7.C03.C0307.C030705;
using Xunit;

namespace LT.TEST.BOOK.ICS7.C03.C0307.C030705
{
    public class C03070501Test
    {
        [Fact]
        public void Fn01()
        {
            Assert.Equal("    9", C03070501.Fn01());
        }

        [Fact]
        public void Fn02()
        {
            Assert.Equal("9    ", C03070501.Fn02());
        }

        [Fact]
        public void Fn03()
        {
            Assert.Equal("999999", C03070501.Fn03());
        }
    }
}
