using LT.BOOK.ICS7.C03.C0306;
using Xunit;

namespace LT.TEST.BOOK.ICS7.C03.C0306
{
    public class C030601Test
    {
        [Fact]
        public void Fn01()
        {
            string fn01 = C030601.Fn01();
            Assert.Equal("999", fn01);
        }
    }
}
