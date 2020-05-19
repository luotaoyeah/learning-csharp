using LuotaoYeah.Lib.Books.ICS7._08._12;
using Xunit;

namespace LuotaoYeah.Test.Books.ICS7._08._12
{
    /// <summary>
    ///     8.12 sealed classes
    /// </summary>
    public class T01
    {
        [Fact]
        public void _01()
        {
            var myClass = new MyClass();
            Assert.Equal(6, myClass.Fn01());
        }
    }
}
