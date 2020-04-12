using Xunit;

namespace LT.TEST.BOOK.ICS7._07._11
{
    public class C01
    {
        [Fact]
        public void T01()
        {
            var c01 = new LT.BOOK.ICS7._07._11.C01();
            Assert.NotNull(c01.time);
        }
    }
}
