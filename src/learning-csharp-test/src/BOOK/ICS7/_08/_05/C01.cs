using Xunit;

namespace LT.TEST.BOOK.ICS7._08._05
{
    public class C01
    {
        [Fact]
        public void T01()
        {
            var c02 = new LT.BOOK.ICS7._08._05.C02();

            Assert.Equal(1, c02.Fn01());
            Assert.Equal(2, c02.Fn02());
        }
    }
}
