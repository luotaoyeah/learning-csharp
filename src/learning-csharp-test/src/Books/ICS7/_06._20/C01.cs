using Xunit;

namespace LuotaoYeah.Test.Books.ICS7._06._20
{
    public class C01
    {
        [Fact]
        public void _01()
        {
            Assert.Equal(4, Lib.Books.ICS7._06._20.C01.Fn01(1, 3));
            Assert.Equal(13, Lib.Books.ICS7._06._20.C01.Fn01(1, 3, 4, 5));

            Assert.Equal(3, Lib.Books.ICS7._06._20.C01.Fn01(1));
            int[] arr01 = { 4, 5 };
            Assert.Equal(12, Lib.Books.ICS7._06._20.C01.Fn01(1, arr: arr01));
        }

        [Fact]
        public void _02()
        {
            //----------------------------------------------------------------------------------------------------
            // 如果使用 positional parameter 的形式，
            // 则如果某个 optional parameter 使用了默认值，则它后面所有的 optional parameter 也必须使用默认值，
            //
            // 如果使用 named parameter 的形式，则可以随意让某个 optional parameter 使用默认值，
            //----------------------------------------------------------------------------------------------------
            Assert.Equal(5, Lib.Books.ICS7._06._20.C01.Fn02(y: 4));
        }
    }
}
