using Xunit;
//----------------------------------------------------------------------------------------------------
// 使用 using static <类> 将某个 class 中的所有 static member 引入，然后直接使用，
//----------------------------------------------------------------------------------------------------
using static LT.BOOK.ICS7._07._05.C01;

namespace LT.TEST.BOOK.ICS7._07._05
{
    public class C01
    {
        [Fact]
        public void _01()
        {
            Assert.Equal(6, I01);

            I01 = 8;
            Assert.Equal(8, I01);
        }
    }
}
