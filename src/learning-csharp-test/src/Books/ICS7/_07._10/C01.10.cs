using Xunit;

namespace LuotaoYeah.Test.Books.ICS7._07._10
{
    public class C0110
    {
        [Fact]
        public void _01()
        {
            Lib.Books.ICS7._07._10.C0110.P01 = 6;
            Assert.Equal(6, Lib.Books.ICS7._07._10.C0110.P01);
        }
    }
}
