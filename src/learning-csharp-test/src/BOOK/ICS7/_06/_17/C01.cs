using Xunit;

namespace LT.TEST.BOOK.ICS7._06._17
{
    public class C01
    {
        [Fact]
        public void T01()
        {
            //----------------------------------------------------------------------------------------------------
            // ref local 类似于 C++ 里面的 reference，是一个变量的别名，
            //----------------------------------------------------------------------------------------------------

            int i01 = 6;
            ref int ref01 = ref i01;
            Assert.Equal(6, i01);
            Assert.Equal(6, ref01);

            ref01 = 8;
            Assert.Equal(8, i01);
            Assert.Equal(8, ref01);

            i01 = 9;
            Assert.Equal(9, i01);
            Assert.Equal(9, ref01);
        }
    }
}
