using Xunit;

namespace LT.TEST.BOOK.ICS7._08._13
{
    /// <summary>
    /// 8.13 static classes
    /// </summary>
    public class T01
    {
        [Fact]
        public void _01()
        {
            Assert.Equal(3.14f, LT.LIB.BOOK.ICS7._08._13.MyMath.PI);
        }
    }
}
