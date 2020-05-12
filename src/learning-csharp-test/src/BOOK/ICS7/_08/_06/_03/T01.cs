using LT.LIB.BOOK.ICS7._08._06._03;
using Xunit;

namespace LT.TEST.BOOK.ICS7._08._06._03
{
    /// <summary>
    /// 8.6.3 overriding other member types
    /// </summary>
    public class T01
    {
        [Fact]
        public void _01()
        {
            var myDerivedClass = new MyDerivedClass();
            MyBaseClass myBaseClass = myDerivedClass;

            Assert.Equal(2, myBaseClass.P01);
            Assert.Equal(2, myBaseClass[0]);
        }
    }
}
