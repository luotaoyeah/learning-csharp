using LuotaoYeah.Lib.Books.ICS7._09._15._01;
using Xunit;

namespace LuotaoYeah.Test.Books.ICS7._09._15._01
{
    /// <summary>
    ///     9.15.1 example of operator overloading
    /// </summary>
    public class T01
    {
        [Fact]
        public void _01()
        {
            var limitedInt01 = new LimitedInt { TheValue = 100 };
            Assert.Equal(100, limitedInt01.TheValue);

            var limitedInt02 = -limitedInt01;
            Assert.Equal(0, limitedInt02.TheValue);
        }

        [Fact]
        public void _02()
        {
            var limitedInt01 = new LimitedInt { TheValue = 20 };
            var limitedInt02 = new LimitedInt { TheValue = 10 };
            var limitedInt03 = limitedInt01 - limitedInt02;
            Assert.Equal(10, limitedInt03.TheValue);
        }

        [Fact]
        public void _03()
        {
            var limitedInt01 = new LimitedInt { TheValue = 10 };
            var limitedInt02 = limitedInt01 + 10;
            Assert.Equal(20, limitedInt02.TheValue);
        }
    }
}
