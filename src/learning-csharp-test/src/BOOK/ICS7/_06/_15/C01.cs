using Xunit;

namespace LT.TEST.BOOK.ICS7._06._15
{
    public class C01
    {
        [Fact]
        public void T01()
        {
            //----------------------------------------------------------------------------------------------------
            // 对于 parameter array，调用时不用使用 params 标记，
            // 可以传任意多个参数，
            //----------------------------------------------------------------------------------------------------
            Assert.Equal(1, LT.BOOK.ICS7._06._15.C01.Fn01(1));
            Assert.Equal(3, LT.BOOK.ICS7._06._15.C01.Fn01(1, 2));
            Assert.Equal(6, LT.BOOK.ICS7._06._15.C01.Fn01(1, 2, 3));
        }
    }
}
