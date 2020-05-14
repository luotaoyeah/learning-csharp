using Xunit;

namespace LT.TEST.BOOK.ICS7._07._16
{
    public class C0110
    {
        [Fact]
        public void _01()
        {
            var c0104 = new LIB.BOOK.ICS7._07._16.C0104();

            Assert.Equal(1, c0104.X);
            Assert.Equal(2, c0104.Y);
            Assert.Equal(3, c0104.Z);

            Assert.Equal(1, c0104[0]);
            Assert.Equal(2, c0104[1]);
            Assert.Equal(3, c0104[2]);
        }

        [Fact]
        public void _02()
        {
            //----------------------------------------------------------------------------------------------------
            // indexer 也可以使用 object initializer 的形式
            //----------------------------------------------------------------------------------------------------
            var c0104 = new LIB.BOOK.ICS7._07._16.C0104 { [1] = 6 };
            c0104[2] = 8;

            Assert.Equal(6, c0104[1]);
            Assert.Equal(8, c0104[2]);
        }
    }
}
