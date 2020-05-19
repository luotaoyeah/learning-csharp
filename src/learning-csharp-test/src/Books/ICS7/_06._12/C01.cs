using LuotaoYeah.Lib.Books.ICS7._06._12;
using Xunit;

namespace LuotaoYeah.Test.Books.ICS7._06._12
{
    public class C01
    {
        [Fact]
        public void _01()
        {
            var person = new Person { Age = 18 };
            var x = 18;

            //----------------------------------------------------------------------------------------------------
            // reference parameter 在调用的时候也必须使用 ref 标记，
            //----------------------------------------------------------------------------------------------------
            Lib.Books.ICS7._06._12.C01.Fn01(ref person, ref x);

            Assert.Equal(19, person.Age);
            Assert.Equal(19, x);
        }
    }
}
