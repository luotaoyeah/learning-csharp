using LT.BOOK.ICS7._06._15;
using Xunit;

namespace LT.TEST.BOOK.ICS7._06._15
{
    public class T01
    {
        [Fact]
        public void _01()
        {
            //----------------------------------------------------------------------------------------------------
            // 对于 parameter array，调用时不需要使用 params 标记，
            // 可以传任意多个参数，方法会使用这些参数构造一个 array，然后传给方法，
            //----------------------------------------------------------------------------------------------------
            Assert.Equal(1, C01.Fn01(1));
            Assert.Equal(3, C01.Fn01(1, 2));
            Assert.Equal(6, C01.Fn01(1, 2, 3));
        }

        [Fact]
        public void _02()
        {
            //----------------------------------------------------------------------------------------------------
            // 也可以直接传递一个 array 作为参数，
            //----------------------------------------------------------------------------------------------------
            int[] arr01 = { };
            Assert.Equal(1, C01.Fn01(1, arr01));

            int[] arr02 = { 2 };
            Assert.Equal(3, C01.Fn01(1, arr02));

            int[] arr03 = { 2, 3 };
            Assert.Equal(6, C01.Fn01(1, arr03));
        }
    }
}