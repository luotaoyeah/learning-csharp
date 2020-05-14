using Xunit;

namespace LT.TEST.BOOK.ICS7._07._16
{
    public class C0104
    {
        [Fact]
        public void _01()
        {
            var c0110 = new LIB.BOOK.ICS7._07._16.C0110();

            Assert.Equal(6, c0110[0]);
            Assert.Equal(8, c0110[0, 0]);
        }
    }
}
