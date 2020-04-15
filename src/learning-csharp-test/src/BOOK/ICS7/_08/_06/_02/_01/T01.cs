using LT.BOOK.ICS7._08._06._02._01;
using Xunit;

namespace LT.TEST.BOOK.ICS7._08._06._02._01
{
    /// <summary>
    /// 8.6.2.1 case 1: declaring print with override
    /// </summary>
    public class T01
    {
        [Fact]
        public void _01()
        {
            var secondDerived = new SecondDerived();
            MyBaseClass myBaseClass = secondDerived;
            MyDerivedClass myDerivedClass = secondDerived;

            Assert.Equal(3, myBaseClass.Print());
            Assert.Equal(3, myDerivedClass.Print());
        }
    }
}
