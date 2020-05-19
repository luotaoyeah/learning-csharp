using LuotaoYeah.Lib.Books.ICS7._08._06;
using Xunit;

namespace LuotaoYeah.Test.Books.ICS7._08._06
{
    public class C0101
    {
        [Fact]
        public void _01()
        {
            var c0101A = new C0101A();
            Lib.Books.ICS7._08._06.C0101 c0101 = c0101A;

            //----------------------------------------------------------------------------------------------------
            // 父类变量指向子类对象，此时通过它访问被 override 的方法，访问的是子类中的方法，
            //----------------------------------------------------------------------------------------------------
            Assert.Equal(2, c0101A.Fn01());
            Assert.Equal(2, c0101.Fn01());
        }

        [Fact]
        public void _02()
        {
            var c0101 = new C0101A();
            Assert.Equal(1, c0101.Fn02());
        }

        [Fact]
        public void _03()
        {
            var c0101 = new Lib.Books.ICS7._08._06.C0101();
            Assert.Equal(1, c0101.Fn01());
        }
    }
}
