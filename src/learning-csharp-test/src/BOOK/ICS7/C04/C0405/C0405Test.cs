using Xunit;

namespace LT.TEST.BOOK.ICS7.C04.C0405
{
    public class C0405Test
    {
        [Fact]
        public void Fn01()
        {
            Assert.Equal("9,0.01,0.01,0.01", LT.BOOK.ICS7.C04.C0405.C0405.Fn01());
        }
    }
}