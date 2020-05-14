using Xunit;

namespace LT.TEST.BOOK.ICS7._03._07
{
    public class C0503
    {
        [Fact]
        public void Fn01()
        {
            Assert.Equal("500.00", LIB.BOOK.ICS7._03._07.C0503.Fn01().Substring(1));
        }

        [Fact]
        public void Fn02()
        {
            Assert.Equal("099", LIB.BOOK.ICS7._03._07.C0503.Fn02());
        }

        [Fact]
        public void Fn03()
        {
            Assert.Equal("3.14", LIB.BOOK.ICS7._03._07.C0503.Fn03());
        }

        [Fact]
        public void Fn04()
        {
            Assert.Equal("99999", LIB.BOOK.ICS7._03._07.C0503.Fn04());
        }

        [Fact]
        public void Fn05()
        {
            Assert.Equal("Aa", LIB.BOOK.ICS7._03._07.C0503.Fn05());
        }

        [Fact]
        public void Fn06()
        {
            Assert.Equal("99,999.00", LIB.BOOK.ICS7._03._07.C0503.Fn06());
        }

        [Fact]
        public void Fn07()
        {
            Assert.Contains(LIB.BOOK.ICS7._03._07.C0503.Fn07(), new[] { "25.00%", "25.00 %" });
        }

        [Fact]
        public void Fn08()
        {
            Assert.Equal("1.23E+001", LIB.BOOK.ICS7._03._07.C0503.Fn08());
        }
    }
}
