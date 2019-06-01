using LT.BOOK.ICS7.C03.C0307.C030705;
using Xunit;

namespace LT.TEST.BOOK.ICS7.C03.C0307.C030705
{
    public class C03070503Test
    {
        [Fact]
        public void Fn01()
        {
            Assert.Equal("500.00", C03070503.Fn01().Substring(1));
        }

        [Fact]
        public void Fn02()
        {
            Assert.Equal("099", C03070503.Fn02());
        }

        [Fact]
        public void Fn03()
        {
            Assert.Equal("3.14", C03070503.Fn03());
        }

        [Fact]
        public void Fn04()
        {
            Assert.Equal("99999", C03070503.Fn04());
        }

        [Fact]
        public void Fn05()
        {
            Assert.Equal("Aa", C03070503.Fn05());
        }

        [Fact]
        public void Fn06()
        {
            Assert.Equal("99,999.00", C03070503.Fn06());
        }

        [Fact]
        public void Fn07()
        {
            Assert.Contains(C03070503.Fn07(), new[] { "25.00%", "25.00 %" });
        }


        [Fact]
        public void Fn08()
        {
            Assert.Equal("1.23E+001", C03070503.Fn08());
        }
    }
}