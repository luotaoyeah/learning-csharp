using Xunit;

namespace LT.TEST.BOOK.ICS7._05._10
{
    public class C01
    {
        [Fact]
        public void _01()
        {
            var c01 = new LT.BOOK.ICS7._05._10.C01();
            Assert.Equal(6, c01.X);

            c01.X = 8;
            Assert.Equal(8, c01.X);
        }
    }
}
