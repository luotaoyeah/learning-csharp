using LT.BOOK.ICS7.C05.C0504;
using Xunit;

namespace LT.TEST.BOOK.ICS7._05._04
{
    public class C050402Test
    {
        [Fact]
        public void Fn01()
        {
            Assert.Equal(3, new C050402().Add(1, 2));
        }
    }
}
