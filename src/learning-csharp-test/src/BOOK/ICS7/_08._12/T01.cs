using Xunit;

namespace LT.TEST.BOOK.ICS7._08._12
{
    /// <summary>
    /// 8.12 sealed classes
    /// </summary>
    public class T01
    {
        [Fact]
        public void _01()
        {
            var myClass = new LT.LIB.BOOK.ICS7._08._12.MyClass();
            Assert.Equal(6, myClass.Fn01());
        }
    }
}
