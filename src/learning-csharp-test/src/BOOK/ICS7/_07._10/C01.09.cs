using Xunit;

namespace LT.TEST.BOOK.ICS7._07._10
{
    public class C0109
    {
        [Fact]
        public void _01()
        {
            var c0109 = new LIB.BOOK.ICS7._07._10.C0109();
            c0109.P01 = 6;
            Assert.Equal(6, c0109.P01);
        }
    }
}
