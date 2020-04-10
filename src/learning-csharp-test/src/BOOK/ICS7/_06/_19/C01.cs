using Xunit;

namespace LT.TEST.BOOK.ICS7._06._19
{
    public class C01
    {
        [Fact]
        public void T01()
        {
            //----------------------------------------------------------------------------------------------------
            // 调用方法时，使用 positional parameter，根据参数位置一一对应，
            //----------------------------------------------------------------------------------------------------
            Assert.Equal(6, LT.BOOK.ICS7._06._19.C01.Fn01(1, 2, 3));

            //----------------------------------------------------------------------------------------------------
            // 调用方法时，使用 named parameter，根据参数名称一一对应，
            //----------------------------------------------------------------------------------------------------
            Assert.Equal(6, LT.BOOK.ICS7._06._19.C01.Fn01(y: 2, x: 1, z: 3));

            //----------------------------------------------------------------------------------------------------
            // 混合使用 positional parameter 和 named parameter，所有的 positional parameter 必须在前面
            //----------------------------------------------------------------------------------------------------
            Assert.Equal(6, LT.BOOK.ICS7._06._19.C01.Fn01(1, z: 3, y: 2));
        }
    }
}
