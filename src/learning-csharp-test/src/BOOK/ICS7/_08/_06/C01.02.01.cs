using Xunit;

namespace LT.TEST.BOOK.ICS7._08._06
{
    public class C010201
    {
        [Fact]
        public void T01()
        {
            var secondDerived = new LT.BOOK.ICS7._08._06.SecondDerived();
            LT.BOOK.ICS7._08._06.MyBaseClass myBaseClass = secondDerived;
            LT.BOOK.ICS7._08._06.MyDerivedClass myDerivedClass = secondDerived;

            Assert.Equal(3, myBaseClass.Print());
            Assert.Equal(3, myDerivedClass.Print());
        }
    }
}
