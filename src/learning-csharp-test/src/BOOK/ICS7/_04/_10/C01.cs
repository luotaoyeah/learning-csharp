using LT.BOOK.ICS7._04._10;
using Microsoft.CSharp.RuntimeBinder;
using Xunit;

namespace LT.TEST.BOOK.ICS7._04._10
{
    public class C01
    {
        [Fact]
        public void _01()
        {
            RuntimeBinderException exception = Assert.Throws<RuntimeBinderException>(() => { C10.Fn01(); });
            Assert.Equal("Cannot implicitly convert type 'string' to 'int'", exception.Message);
        }
    }
}
