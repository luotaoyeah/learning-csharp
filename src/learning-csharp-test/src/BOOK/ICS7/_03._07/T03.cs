using LT.LIB.BOOK.ICS7._03._07;
using Xunit;

namespace LT.TEST.BOOK.ICS7._03._07
{
    public class T03
    {
        [Fact]
        public void _01()
        {
            C03.Fn01();
        }

        [Fact]
        public void _02()
        {
            Assert.Equal("1 + 2 = 3", C03.Fn02());
        }
    }
}
