using LT.LIB.BOOK.ICS7._08._06._02._02;
using Xunit;

namespace LT.TEST.BOOK.ICS7._08._06._02._02
{
    /// <summary>
    /// 8.6.2.2 case 2: declaring print with new
    /// </summary>
    public class T01
    {
        [Fact]
        public void _01()
        {
            var secondDerived = new SecondDerived();
            MyBaseClass myBaseClass = secondDerived;
            MyDerivedClass myDerivedClass = secondDerived;

            Assert.Equal(2, myBaseClass.Print());
            Assert.Equal(2, myDerivedClass.Print());
            Assert.Equal(3, secondDerived.Print());
        }
    }
}
