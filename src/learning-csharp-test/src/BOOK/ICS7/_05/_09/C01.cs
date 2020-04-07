using Xunit;

namespace LT.TEST.BOOK.ICS7._05._09
{
    public class C01
    {
        [Fact]
        public void T01()
        {
            var c01 = new LT.BOOK.ICS7._05._09.C01();
            Assert.Equal(12, c01.Sum());
        }
    }
}
