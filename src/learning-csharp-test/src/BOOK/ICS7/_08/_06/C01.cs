using Xunit;

namespace LT.TEST.BOOK.ICS7._08._06
{
    public class C01
    {
        [Fact]
        public void T01()
        {
            LT.BOOK.ICS7._08._06.C02 c02 = new LT.BOOK.ICS7._08._06.C02();
            //----------------------------------------------------------------------------------------------------
            // 父类变量指向子类实例对象，通过该变量只能访问父类的 member
            //----------------------------------------------------------------------------------------------------
            LT.BOOK.ICS7._08._06.C01 c01 = c02;

            Assert.Equal(8, c02.I01);
            Assert.Equal(2, c02.I02);

            //----------------------------------------------------------------------------------------------------
            // 通过父类变量，访问被子类隐藏的父类的 member
            //----------------------------------------------------------------------------------------------------
            Assert.Equal(6, c01.I01);
        }
    }
}