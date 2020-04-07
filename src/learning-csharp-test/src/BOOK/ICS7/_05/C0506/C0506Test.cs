using Xunit;

namespace LT.TEST.BOOK.ICS7.C05.C0506
{
    public class C0506Test
    {
        [Fact]
        public void Fn01()
        {
            Assert.Equal(9, new LT.BOOK.ICS7.C05.C0506.C0506().Fn01());
        }

        [Fact]
        public void Fn02()
        {
            Assert.Equal(0, new LT.BOOK.ICS7.C05.C0506.C0506().Fn02());
        }
    }
}
