using Xunit;

namespace LuotaoYeah.Test.Books.ICS7._07._18
{
    public class C01
    {
        [Fact]
        public void _01()
        {
            Assert.Equal(6, Lib.Books.ICS7._07._18.C01.Fn01());
            Assert.Equal(8, Lib.Books.ICS7._07._18.C01.Fn02());
        }
    }
}
