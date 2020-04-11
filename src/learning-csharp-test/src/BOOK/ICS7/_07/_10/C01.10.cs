using Xunit;

namespace LT.TEST.BOOK.ICS7._07._10
{
    public class C0110
    {
        [Fact]
        public void T01()
        {
            LT.BOOK.ICS7._07._10.C0110.P01 = 6;
            Assert.Equal(6, LT.BOOK.ICS7._07._10.C0110.P01);
        }
    }
}
