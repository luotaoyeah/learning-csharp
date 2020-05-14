using Xunit;

namespace LT.TEST.BOOK.ICS7._07._18
{
    public class C01
    {
        [Fact]
        public void _01()
        {
            Assert.Equal(6, LT.LIB.BOOK.ICS7._07._18.C01.Fn01());
            Assert.Equal(8, LT.LIB.BOOK.ICS7._07._18.C01.Fn02());
        }
    }
}
