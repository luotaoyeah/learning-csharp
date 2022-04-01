using Luotao.Lib.Books.ICS7._06._11;

namespace Luotao.Test.Books.ICS7._06._11
{
    public class C01
    {
        [Fact]
        public void _01()
        {
            //----------------------------------------------------------------------------------------------------
            // 参数默认是值传递，会将实参复制给形参，
            // 如果参数是 reference 类型，则复制的是一个 reference，
            //----------------------------------------------------------------------------------------------------
            var person = new Person { Age = 18 };
            var x = 18;

            Lib.Books.ICS7._06._11.C01.Fn01(person, x);

            Assert.Equal(19, person.Age);
            Assert.Equal(18, x);
        }
    }
}
