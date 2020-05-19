using LuotaoYeah.Lib.Books.ICS7._08._07._01;
using Xunit;

namespace LuotaoYeah.Test.Books.ICS7._08._07._01
{
    /// <summary>
    ///     8.7.1 constructor initializers
    /// </summary>
    public class T01
    {
        [Fact]
        public void _01()
        {
            var myDerivedClass = new MyDerivedClass(1, 2);
            Assert.Equal(2, myDerivedClass.A);
            Assert.Equal(1, myDerivedClass.X);

            var myDerivedClass02 = new MyDerivedClass(1);
            Assert.Equal(2, myDerivedClass02.A);
            Assert.Equal(1, myDerivedClass02.X);
        }
    }
}
