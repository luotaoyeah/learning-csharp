using Xunit;

namespace LuotaoYeah.Test.Books.ICS7._05._09
{
    public class C01
    {
        [Fact]
        public void _01()
        {
            var c01 = new Lib.Books.ICS7._05._09.C01();
            Assert.Equal(12, c01.Sum());
        }
    }
}
