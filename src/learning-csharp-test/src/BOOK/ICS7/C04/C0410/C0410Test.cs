using Microsoft.CSharp.RuntimeBinder;
using Xunit;

namespace LT.TEST.BOOK.ICS7.C04.C0410
{
    public class C0410Test
    {
        [Fact]
        public void Fn01()
        {
            RuntimeBinderException exception =
                Assert.Throws<RuntimeBinderException>(() => { LT.BOOK.ICS7.C04.C0410.C0410.Fn01(); });

            Assert.Equal("Cannot implicitly convert type 'string' to 'int'", exception.Message);
        }
    }
}