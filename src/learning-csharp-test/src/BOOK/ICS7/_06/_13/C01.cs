using LT.LIB.BOOK.ICS7._06._13;
using Xunit;

namespace LT.TEST.BOOK.ICS7._06._13
{
    public class C01
    {
        [Fact]
        public void _01()
        {
            var person01 = new Person();
            LT.LIB.BOOK.ICS7._06._13.C01.Fn01(person01);
            Assert.Equal(0, person01.Age);

            var person02 = new Person();
            LT.LIB.BOOK.ICS7._06._13.C01.Fn02(ref person02);
            Assert.Equal(18, person02.Age);
        }
    }
}
