using Xunit;

namespace LT.TEST.BOOK.ICS7._08._02
{
    public class C01
    {
        [Fact]
        public void T01()
        {
            var c02 = new LT.BOOK.ICS7._08._02.C02();

            //----------------------------------------------------------------------------------------------------
            // 正常访问继承来的 field 和 method
            //----------------------------------------------------------------------------------------------------
            Assert.Equal(1, c02.I01);
            Assert.Equal(2, c02.I02);
            Assert.Equal(1, c02.Fn01());
            Assert.Equal(4, c02.Fn02());
        }
    }
}
