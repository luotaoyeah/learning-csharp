using Xunit;

namespace LuotaoYeah.Test.Books.ICS7._05._04
{
    public class C0101
    {
        [Fact]
        public void _01()
        {
            Lib.Books.ICS7._05._04.C0101 c0101 = new();

            Assert.Equal(0, c0101.I01);
            Assert.Null(c0101.S01);
            Assert.True(c0101.B01);
            Assert.Equal(0.01, c0101.D01);
        }
    }
}
