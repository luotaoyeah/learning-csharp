using Xunit;

namespace LT.TEST.BOOK.ICS7._07._10
{
    public class C0105
    {
        [Fact]
        public void _01()
        {
            var c0105 = new LIB.BOOK.ICS7._07._10.C0105();

            c0105.I01 = 6;
            Assert.Equal(6, c0105.I01);

            c0105.I01 = 18;
            Assert.Equal(9, c0105.I01);
        }
    }
}
