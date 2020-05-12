using Xunit;

namespace LT.TEST.BOOK.ICS7._08._09._04
{
    /// <summary>
    /// 8.9.4 protected member accessibility
    /// </summary>
    public class T01
    {
        [Fact]
        public void _01()
        {
            var myDerivedClass = new LT.LIB.BOOK.ICS7._08._09._04.MyDerivedClass();
            Assert.Equal(1, myDerivedClass.Fn01());
        }
    }
}
