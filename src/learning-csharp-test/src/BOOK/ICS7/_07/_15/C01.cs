using Xunit;

namespace LT.TEST.BOOK.ICS7._07._15
{
    public class C01
    {
        [Fact]
        public void _01()
        {
            var c01 = new LT.LIB.BOOK.ICS7._07._15.C01();
            Assert.Equal(8, c01.I01);

            var c02 = new LT.LIB.BOOK.ICS7._07._15.C01(7);
            Assert.Equal(7, c02.I01);

            Assert.Equal(5, LT.LIB.BOOK.ICS7._07._15.C01.I02);
        }
    }
}
