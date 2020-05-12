using LT.LIB.BOOK.ICS7._06._12;
using Xunit;

namespace LT.TEST.BOOK.ICS7._06._12
{
    public class C01
    {
        [Fact]
        public void _01()
        {
            var person = new Person { Age = 18 };
            int x = 18;

            //----------------------------------------------------------------------------------------------------
            // reference parameter 在调用的时候也必须使用 ref 标记，
            //----------------------------------------------------------------------------------------------------
            LT.LIB.BOOK.ICS7._06._12.C01.Fn01(ref person, ref x);

            Assert.Equal(19, person.Age);
            Assert.Equal(19, x);
        }
    }
}
