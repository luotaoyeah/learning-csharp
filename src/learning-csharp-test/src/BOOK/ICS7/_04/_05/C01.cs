using System;
using Xunit;

namespace LT.TEST.BOOK.ICS7._04._05
{
    public class C01
    {
        [Fact]
        public void _01()
        {
            int i01 = 6;
            Int32 i02 = 6;
            Assert.Equal(i01, i02);
        }
    }
}
