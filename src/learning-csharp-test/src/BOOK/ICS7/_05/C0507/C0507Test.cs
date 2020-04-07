using Xunit;

namespace LT.TEST.BOOK.ICS7.C05.C0507
{
    public class C0507Test
    {
        [Fact]
        public void Fn01()
        {
            LT.BOOK.ICS7.C05.C0507.C0507 c0507A01 = new LT.BOOK.ICS7.C05.C0507.C0507("BAR");
            LT.BOOK.ICS7.C05.C0507.C0507 c0507A02 = new LT.BOOK.ICS7.C05.C0507.C0507("BAR");

            Assert.True(c0507A01.Bar == c0507A02.Bar);
            Assert.True(c0507A01.Bar.Equals(c0507A02.Bar));
        }

        [Fact]
        public void Fn02()
        {
            LT.BOOK.ICS7.C05.C0507.C0507 c0507A01 = new LT.BOOK.ICS7.C05.C0507.C0507("BAR");
            LT.BOOK.ICS7.C05.C0507.C0507 c0507A02 = new LT.BOOK.ICS7.C05.C0507.C0507("BAR");

            Assert.True(ReferenceEquals(c0507A01.Bar, c0507A02.Bar));
        }

        [Fact]
        public void Fn03()
        {
            Assert.Null(LT.BOOK.ICS7.C05.C0507.C0507.Foo);
        }
    }
}
