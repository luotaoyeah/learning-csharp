using LT.BOOK.ICS7.C05.C0504;
using Xunit;

namespace LT.TEST.BOOK.ICS7.C05.C0504
{
    public class C050401Test
    {
        [Fact]
        public void Fn01()
        {
            // ReSharper disable once SuggestVarOrType_SimpleTypes
            C050401 c050401 = new C050401("foo");
            Assert.Equal("foo", c050401.Name);
        }
    }
}