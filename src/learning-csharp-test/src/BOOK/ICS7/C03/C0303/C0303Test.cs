using Xunit;

namespace LT.TEST.BOOK.ICS7.C03.C0303
{
    public class C0303Test
    {
        [Fact]
        public void Fn01()
        {
            string fn01 = LT.BOOK.ICS7.C03.C0303.C0303.Fn01();
            Assert.Equal("FOO", fn01);
        }
    }
}