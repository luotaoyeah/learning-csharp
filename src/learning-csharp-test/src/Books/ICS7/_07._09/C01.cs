using Xunit;

namespace Luotao.Test.Books.ICS7._07._09
{
    public class C01
    {
        [Fact]
        public void _01()
        {
            //----------------------------------------------------------------------------------------------------
            // 访问 constant member 跟访问 static member 一样，直接通过类名访问，
            //----------------------------------------------------------------------------------------------------
            Assert.Equal(3.14, Lib.Books.ICS7._07._08.C01.Pi);
        }
    }
}
