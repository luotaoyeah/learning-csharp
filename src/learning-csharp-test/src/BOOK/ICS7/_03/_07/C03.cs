using Xunit;

namespace LT.TEST.BOOK.ICS7._03._07
{
    public class C03
    {
        [Fact]
        public void _01()
        {
            LT.BOOK.ICS7._03._07.C03.Fn01();
        }

        [Fact]
        public void _02()
        {
            Assert.Equal("1 + 2 = 3", LT.BOOK.ICS7._03._07.C03.Fn02());
        }
    }
}
