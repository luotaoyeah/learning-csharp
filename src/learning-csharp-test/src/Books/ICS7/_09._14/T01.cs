using Luotao.Lib.Books.ICS7._09._14;
using Xunit;

namespace Luotao.Test.Books.ICS7._09._14
{
    /// <summary>
    ///     9.14 user-defined type conversions
    /// </summary>
    public class T01
    {
        [Fact]
        public void _01()
        {
            LimitedInt limitedInt = 500;
            Assert.Equal(100, limitedInt.TheValue);

            int i01 = limitedInt;
            Assert.Equal(100, i01);
        }
    }
}
