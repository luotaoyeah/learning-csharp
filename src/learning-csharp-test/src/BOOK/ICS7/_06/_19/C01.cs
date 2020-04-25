using Xunit;

namespace LT.TEST.BOOK.ICS7._06._19
{
    public class C01
    {
        [Fact]
        public void _01()
        {
            //----------------------------------------------------------------------------------------------------
            // 调用方法时，使用 positional parameter，根据参数位置一一对应，
            //----------------------------------------------------------------------------------------------------
            Assert.Equal(6, LT.BOOK.ICS7._06._19.C01.Fn01(1, 2, 3));

            //----------------------------------------------------------------------------------------------------
            // 调用方法时，也可以使用 named parameter，根据参数名称一一对应，
            // params parameter 也可以使用 named parameter 传递一个数组，
            //----------------------------------------------------------------------------------------------------
            int[] arr01 = { 1, 2, 3 };
            Assert.Equal(12, LT.BOOK.ICS7._06._19.C01.Fn01(y: 2, x: 1, arr: arr01, z: 3));

            //----------------------------------------------------------------------------------------------------
            // 混合使用 positional parameter 和 named parameter，所有的 positional parameter 必须在前面
            //----------------------------------------------------------------------------------------------------
            Assert.Equal(12, LT.BOOK.ICS7._06._19.C01.Fn01(1, z: 3, arr: arr01, y: 2));
        }
    }
}
