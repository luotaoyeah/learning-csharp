using Xunit;

namespace LT.TEST.BOOK.ICS7.C03.C0302
{
    public class C0302Test
    {
        [Fact]
        public void Fn01()
        {
            string fn01 = LT.BOOK.ICS7._03._02.C0302.Fn01();
            Assert.Equal("FOOBARBAZ", fn01);
        }

        [Fact]
        public void Fn02()
        {
            string fn02 = LT.BOOK.ICS7._03._02.C0302.Fn02();
            Assert.Equal("FOOFOO", fn02);
        }
    }
}
